using ProdutosLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMobileMaui.Data;

public class ProdutoService : IProdutosService
{
    public async Task<List<Produto>> LoadProdutosAsync()
    {
        await Task.Delay(1000);
        var produtos = new[]
        {
        new Produto() {Codigo_Produto = "43821", Descricao = "Camisa polo masculina azul", Valor_Unitario = "79.90", Quantidade = "2", Valor_Total = "159.80"},
        new Produto() {Codigo_Produto = "92734", Descricao = "Tênis esportivo branco", Valor_Unitario = "199.90", Quantidade = "1", Valor_Total = "199.90"},
        new Produto() {Codigo_Produto = "10562", Descricao = "Mochila resistente para notebook", Valor_Unitario = "149.90", Quantidade = "1", Valor_Total = "149.90"},
        new Produto() {Codigo_Produto = "59248", Descricao = "Relógio digital à prova d'água", Valor_Unitario = "89.90", Quantidade = "3", Valor_Total = "269.70"},
        new Produto() {Codigo_Produto = "38107", Descricao = "Óculos de sol com proteção UV", Valor_Unitario = "120.00", Quantidade = "1", Valor_Total = "120.00"},
        };
        return produtos.ToList();
    }
}
