using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Entity
{
    public class HistoricoTransferencia
    {
        public int Id_HistoricoTranf { get; set; }
        public string No_transferencia { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string No_cuentaEmisor { get; set; }
        public string No_CuentaReceptor { get; set; }
        public int Id_Cuenta { get; set; }
        public Cuenta Cuenta { get; set; }
    }
}
