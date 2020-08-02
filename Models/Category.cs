using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleEstoque.Models
{
    [Table("Categoria")]
    public class Category
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Titulo")]
        [Column("Titulo")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(100, ErrorMessage ="Máximo de 100 caracteres")]
        public String Titulo { get; set; }
        [Display(Name = "Produtos")]
        [Column("Produtos")]
        public string Produtos { get; set; }
    }
}
