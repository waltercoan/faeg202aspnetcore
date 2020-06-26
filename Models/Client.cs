using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace faegtodo.Models
{
    public class Client{
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name="Nome")]
        [Required(ErrorMessage="O campo {0} é obrigatório")]
        public string Name { get; set; }
        [Display(Name="Endereço")]
        [Required(ErrorMessage="O campo {0} é obrigatório")]
        public string Address { get; set; }
        [Display(Name="Data de Nascimento")]
        public DateTime Birthday { get; set; }
    }
}