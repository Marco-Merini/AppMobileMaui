using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosLibrary.Data;
public interface IProdutosService
{
    Task<List<Produto>>? LoadProdutosAsync();
}
