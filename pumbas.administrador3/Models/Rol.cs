using System.ComponentModel.DataAnnotations;

namespace pumbas.administrador3.Models
{
    public class Rol
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }
    }
}
