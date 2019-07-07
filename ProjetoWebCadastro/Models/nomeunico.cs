using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoWebCadastro.Models
{
    public class nomeunico : ValidationAttribute
    {
        private ApplicationDbContext _context;

        public nomeunico()
        {
            _context = new ApplicationDbContext();
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var categoria = (categoriafornecedor)validationContext.ObjectInstance;
            var validaUnico = _context.Categorias
                .FirstOrDefault(c => c.Nome == categoria.Nome
                && c.Id != categoria.Id);

            if (validaUnico == null)
                return ValidationResult.Success;
            return new ValidationResult("Nome já utilizado.");

        }
    }
    
    }
