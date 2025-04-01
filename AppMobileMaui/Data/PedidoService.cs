using ProdutosLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMobileMaui.Data;

public class PedidoService : IPedidosService
{
    public async Task<List<Pedido>> LoadPedidosAsync()
    {
        await Task.Delay(1000);
        var pedidos = new[]
        {
        new Pedido() {Numero_Pedido = "7891000248768", Nome_Cliente = "Eduardo Vargas", Data_Pedido = "12/10/2001"},
        new Pedido() {Numero_Pedido = "7897947612907", Nome_Cliente = "Silvio Santos", Data_Pedido = "21/10/2023"},
        new Pedido() {Numero_Pedido = "1520277195852", Nome_Cliente = "Neymar Jr", Data_Pedido = "28/07/2008"},
        new Pedido() {Numero_Pedido = "2565972751651", Nome_Cliente = "Roberto Dinamite", Data_Pedido = "05/10/1977"},
        new Pedido() {Numero_Pedido = "4723843078320", Nome_Cliente = "Paulo da Silva", Data_Pedido = "03/11/2000"},
        };
        return pedidos.ToList();
    }
}
