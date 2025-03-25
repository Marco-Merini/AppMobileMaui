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
        new Pedido() {Numero_Pedido = "058956", Nome_Cliente = "Eduardo Vargas", Data_Pedido = "79.90"},
        new Pedido() {Numero_Pedido = "453875", Nome_Cliente = "Silvio Santos", Data_Pedido = "199.90"},
        new Pedido() {Numero_Pedido = "924875", Nome_Cliente = "Neymar Jr", Data_Pedido = "149.90"},
        new Pedido() {Numero_Pedido = "152348", Nome_Cliente = "Roberto Dinamite", Data_Pedido = "89.90"},
        new Pedido() {Numero_Pedido = "810254", Nome_Cliente = "Paulo da Silva", Data_Pedido = "120.00"},
        };
        return pedidos.ToList();
    }
}
