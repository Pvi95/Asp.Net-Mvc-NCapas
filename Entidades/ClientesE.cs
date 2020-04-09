using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class ClientesE
    {
        [Display(Name = "ID")]
        public int id_cli { get; set; }
        [Display(Name = "Nombre")]
        public string nombre_cli { get; set; }
        [Display(Name = "Apellido")]
        public string apellido_cli { get; set; }
        [Display(Name = "Alias")]
        public string alias_cli { get; set; }
        [Display(Name = "Contraseña")]
        public string contrasenia_cli { get; set; }

    }
}
