using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primera_Aplicacion
{
    public class BankAccount
    {
        public Guid ID { get; set; }
        public string Nombre { get; set; }

        public decimal Saldo { get; set; }

        //Constructor
        public BankAccount(string nombre ) 
        {
            Nombre = nombre;            
            ID = Guid.NewGuid();
            Saldo = 0;
        }
    }
}
