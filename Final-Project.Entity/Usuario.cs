using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Entity
{
    public class Usuario
    {
        public int ID_Usuario { get; set; }
        public string Username { get; set; }
        [Required(ErrorMessage = "La contraseña es requerida")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        [Required(ErrorMessage = "El email es requerido")]
        [EmailAddress(ErrorMessage = "Email invalido")]
        public string Email { get; set; }

    }
}
