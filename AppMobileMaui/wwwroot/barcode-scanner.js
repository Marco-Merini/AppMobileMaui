window.startBarcodeScanner = function () {
    return new Promise((resolve, reject) => {
        if (!navigator.mediaDevices || !navigator.mediaDevices.getUserMedia) {
            alert("Seu navegador não suporta leitura de código de barras.");
            reject("Navegador não suportado");
            return;
        }

        const constraints = {
            video: { facingMode: 'environment' } // Câmera traseira
        };

        // Criar modal
        const modal = document.createElement('div');
        modal.id = "scanner-modal";
        modal.innerHTML = `
            <div style="position: fixed; top: 0; left: 0; width: 100%; height: 100%; background: rgba(0,0,0,0.8); z-index: 1000; display: flex; align-items: center; justify-content: center;">
                <video id="scanner-video" autoplay playsinline style="width: 100%; height: auto; max-height: 100vh; background: black;"></video>
            </div>
        `;
        document.body.appendChild(modal);

        const video = document.getElementById("scanner-video");

        navigator.mediaDevices.getUserMedia(constraints)
            .then(stream => {
                video.srcObject = stream;

                video.onloadedmetadata = () => {
                    video.play();
                    iniciarQuagga(video);
                };
            })
            .catch(error => {
                console.error("Erro ao acessar a câmera:", error);
                reject(error);
            });

        function iniciarQuagga(video) {
            Quagga.init({
                inputStream: {
                    name: "Live",
                    type: "LiveStream",
                    target: video
                },
                decoder: {
                    readers: ["ean_reader", "code_128_reader", "code_39_reader", "codabar_reader"]
                }
            }, err => {
                if (err) {
                    console.error("Erro ao iniciar QuaggaJS:", err);
                    reject(err);
                    return;
                }
                Quagga.start();
            });

            Quagga.onDetected(result => {
                const code = result.codeResult.code;
                console.log("Código detectado:", code);
                pararScanner(video, modal);
                resolve(code);
            });
        }

        function pararScanner(video, modal) {
            if (video.srcObject) {
                video.srcObject.getTracks().forEach(track => track.stop());
            }
            Quagga.stop();
            document.body.removeChild(modal);
        }
    });
};
