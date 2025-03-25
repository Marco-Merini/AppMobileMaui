using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosLibrary.Data;

public class Produto
{
    public string? Codigo_Produto { get; set; }
    public string? Descricao { get; set; }
    public string? Valor_Unitario { get; set; }
    public string? Quantidade { get; set; }
    public string? Valor_Total { get; set; }
}
