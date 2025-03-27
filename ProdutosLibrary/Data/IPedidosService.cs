namespace ProdutosLibrary.Data;

public interface IPedidosService
{
    Task<List<Pedido>>? LoadPedidosAsync();
}
