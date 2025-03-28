namespace ProdutosLibrary.Data;
public interface IProdutosService
{
    Task<List<Produto>>? LoadProdutosAsync();
}
