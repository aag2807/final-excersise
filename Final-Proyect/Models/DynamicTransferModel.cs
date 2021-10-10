namespace Final_Proyect.Models
{
    public class DynamicTransferModel
    {
        public int Id { get; set; }
        public string No_transferencia { get; set; }
        public double Monto { get; set; }
        public string Fecha { get; set; }
        public string No_cuentaEmisor { get; set; }
        public string No_CuentaReceptor { get; set; }
        public int Id_Cuenta { get; set; }
    }
}