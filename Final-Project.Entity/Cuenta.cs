﻿using System;
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
        public int Id { get; set; }
        public string Tipo_Cuenta { get; set; }
        public string No_Cuenta { get; set; }
        public double Balance { get; set; }
        public int Id_usuario { get; set; }
        public Usuario Usuario { get; set; }
        public int Id_historico { get; set; }
    }
}
