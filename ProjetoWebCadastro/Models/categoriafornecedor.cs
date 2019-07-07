using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoWebCadastro.Models
{
    public class categoriafornecedor
    {
        public int Id { get; set; }

        [Required]
        [nomeunico]
        public string Nome { get; set; }

    }
}