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

        public SaldoClienteViewModel(int saldo)
        {
            Saldo = saldo;
        }

        public int Saldo { get; private set; }
    }
}
