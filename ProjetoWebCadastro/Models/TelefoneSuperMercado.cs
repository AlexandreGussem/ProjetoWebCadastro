using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoWebCadastro.Models
{
    public class TelefoneSuperMercado : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var fornecedor = (cadastrofornecedor)validationContext.ObjectInstance;
            if (fornecedor.Categoria == null || String.IsNullOrWhiteSpace(fornecedor.Categoria.Nome))
                return ValidationResult.Success;
            if (fornecedor.Categoria.Nome.ToLower() != "supermercado")
                return ValidationResult.Success;
            if (fornecedor.Telefone == null)
                return new ValidationResult("Telefone obrigatorio para supermercados");
            return ValidationResult.Success;
        }
    }
}