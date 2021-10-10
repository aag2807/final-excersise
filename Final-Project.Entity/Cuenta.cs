using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Entity
{
    [Table("T_cuenta")]
    public class Cuenta
    {
        [Key]
        public int Id_cuenta { get; set; }
        public string Tipo_Cuenta { get; set; }
        public decimal No_Cuenta { get; set; }
        public decimal Balance { get; set; }
        public int Id_usuario { get; set; }
        [ForeignKey("Id_usuario")]
        public virtual Usuario Usuario { get; set; }
        public int Id_historico { get; set; }
    }
}
