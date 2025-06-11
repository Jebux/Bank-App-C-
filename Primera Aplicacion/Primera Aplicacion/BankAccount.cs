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

        public decimal Saldo { get; private set; }

        //Constructor
        public BankAccount(string nombre ) 
        {
            Nombre = nombre;            
            ID = Guid.NewGuid();
            Saldo = 0;
        }

        public void Depositar(decimal saldo = 0)
        {
            if (saldo != 0)
            {
                Saldo += saldo;
            }
        }

        public void Retirar(decimal saldo = 0)
        {
            if (Saldo >= saldo)
            {
                Saldo -= saldo;
            }
            else
            {
                MessageBox.Show("Sin saldo suficiente");
            }
        }

    }
}
