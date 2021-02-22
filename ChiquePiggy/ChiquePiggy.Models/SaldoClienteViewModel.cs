using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiquePiggy.Models
{
    public class SaldoClienteViewModel
    {
        public SaldoClienteViewModel()
        {

        }

        public SaldoClienteViewModel(int saldo, bool existente)
        {
            Saldo = saldo;
            Existente = existente;
        }

        public int Saldo { get; set; }

        public bool Existente { get; set; }

    }
}
