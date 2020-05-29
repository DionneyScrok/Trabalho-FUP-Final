using ForeignKey_Email;
using Remake_FUP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO_FUP_Brasil.Models
{
    public class Chefia
    {
        public int ChefiaId { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string NomeChefia { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Setor { get; set; }

        [InverseProperty("Chefia")]
        public int FuncionarioId { get; set; }
        [ForeignKey("Funcionario")]
        public virtual List<Funcionario> Funcionarios { get; set; }

        [InverseProperty("Chefia")]
        public virtual Email Email { get; set; }

        [InverseProperty("Chefia")]
        public virtual Telefone Telefone { get; set; }

    }
}
