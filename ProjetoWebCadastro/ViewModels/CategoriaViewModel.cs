using ProjetoWebCadastro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoWebCadastro.ViewModels
{
    public class CategoriaViewModel
    {
        public IEnumerable<categoriafornecedor> Categorias { get; set; }
    }
}