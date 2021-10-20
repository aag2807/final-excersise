using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Entity
{
    [Table("T_Htransferencia")]
    public class HistoricoTransferencia
    {
        public int Id { get; set; }
        public string No_transferencia { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string No_cuentaEmisor { get; set; }
        public string No_CuentaReceptor { get; set; }
        public int Id_Cuenta { get; set; }
        public Cuenta Cuenta { get; set; }
    }
}
