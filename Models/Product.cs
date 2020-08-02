using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ControleEstoque.Models
{
    [Table("Produtos")]
    public class Product
    {
        [Display(Name ="Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Titulo")]
        [Column("Titulo")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(100, ErrorMessage = "Limitado a 100 caracters")]
        public string Titulo { get; set; }
        
        [Display(Name = "Descricao")]
        [Column("Descricao")]
        public string Descricao { get; set; } //Caracters Ilimitados

        [Display(Name = "Medida")]
        [Column("Medida")]
        public int Medida { get; set; }
        
        [Display(Name = "Peso")]
        [Column("Peso")]
        public int  Peso { get; set; }

        [Display(Name = "CodigoDeBarras")]
        [Column("CodigoDeBarras")]
        public decimal CodigoDeBarras { get; set; }

        [Display(Name = "Categoria")]
        [Column("Categoria")]
        [Required(ErrorMessage ="Este campo é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage ="Categoria Inválida")]
        public int CategoryId { get; set; }
        public Category Categorias { get; set; }

        [Display(Name = "Valor")]
        [Column("Valor")]
        [Required(ErrorMessage ="Este campo é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage ="O preço deve ser maior que zero")]
        public string Valor { get; set; }

        [Display(Name = "DataAquisicao")]
        [Column("DataAquisicao")]
        public  DateTime DataAquisicao { get; set; }

        [Display(Name = "Imagem")]
        [Column("Imagem")]
        public ImageFileMachine Imagem { get; set; }

    }
}
