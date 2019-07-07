using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoWebCadastro.Models;

namespace ProjetoWebCadastro.Models
{
    public class cadastrofornecedor
    {
        [Key]
        public int Id { get; set; }






        [StringLength(30, ErrorMessage = "O CNPJ não pode exceder{1} caracteres.")]
        [validadorCNPJ]
        [Display(Name = "CNPJ")]
        [Required]
        public string CNPJ { get; set; }


        
        [Display(Name = "RazaoSocial")]
        public string RazaoSocial { get; set; }





        [StringLength(100, ErrorMessage = "O Nome Fantasia não pode exceder{1} caracteres.")]
        [Display(Name = "Nome Fantasia")]
        public string NomeFantasia { get; set; }





        [StringLength(100, ErrorMessage = "O Email não pode exceder{1} caracteres.")]
        [EmailAddress(ErrorMessage = "O endereço de Email não é Validade")]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }



        [StringLength(100, ErrorMessage = "Endereço não pode exceder{1} caracteres.")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }


        [StringLength(100, ErrorMessage = "A Cidade não pode exceder{1} caracteres.")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }


        [StringLength(100, ErrorMessage = "O Estado não pode exceder{1} caracteres.")]
        [Display(Name = "Estado")]
        public string Estado { get; set; }


        [TelefoneSuperMercado]
        [StringLength(30, ErrorMessage = "O Telefone não pode exceder{1} caracteres.")]
        [Phone(ErrorMessage = "O número de Telefone não é valido")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }


       
        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.DateTime)]
        public DateTime? DataDeCadastro { get; set; }





        public categoriafornecedor Categoria { get; set; }

        [Display(Name = "Categoria")]
        public int? CategoriaId { get; set; }



        [Display(Name = "Status- Ativo")]
        public bool Status { get; set; }



        [StringLength(20, ErrorMessage = "A Agencia não pode exceder{1} caracteres.")]
        [Display(Name = "Agencia")]
        public string Agencia { get; set; }


        [StringLength(20, ErrorMessage = "A Conta Corrente não pode exceder{1} caracteres.")]
        [Display(Name = "Conta Corrente")]
        public string ContaCorrente { get; set; }

    }
}