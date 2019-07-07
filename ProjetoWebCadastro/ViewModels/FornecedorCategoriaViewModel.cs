using ProjetoWebCadastro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoWebCadastro.ViewModels
{
    public class FornecedorCategoriaViewModel
    {
        public cadastrofornecedor Fornecedores { get; set; }

        public List<categoriafornecedor> Categorias { get; set; }


        public static List<string> TransformarEmString(List<categoriafornecedor> categorias)
        {
            var listaStringCategorias = new List<string>();
            foreach (var categoria in categorias)
            {
                listaStringCategorias.Add(categoria.Nome);
            }
            return listaStringCategorias;
        }
    }
}