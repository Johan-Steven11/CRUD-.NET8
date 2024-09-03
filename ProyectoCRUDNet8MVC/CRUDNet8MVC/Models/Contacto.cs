using System.ComponentModel.DataAnnotations;

namespace CRUDNet8MVC.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }
        [Required (ErrorMessage = "El campo nombre es oblogatorio")]
        public string Name { get; set; }
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El campo celular es oblogatorio")]
        public string Celular { get; set; }
        [Required(ErrorMessage = "El campo email es oblogatorio")]
        public string Email { get; set; }
        public DateTime FechaCreacion { get; set; }

    }
}
