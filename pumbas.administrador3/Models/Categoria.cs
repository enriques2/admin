using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace pumbas.administrador3.Models
{
    public class Categoria
    {
      
          
            public int Id { get; set; }

       
            [Required(ErrorMessage = "Producto es obligatorio")]
          
            public int IdProducto { get; set; }

            [Required(ErrorMessage = "Nombre es obligatorio")]
  
            public string Nombre { get; set; }

            [Required(ErrorMessage = "Imagen es obligatorio")]

            public string Imagen { get; set; }



        }
}
