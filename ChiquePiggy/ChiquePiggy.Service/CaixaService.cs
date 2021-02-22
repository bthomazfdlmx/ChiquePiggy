using ChiquePiggy.Caching;
using ChiquePiggy.Helpers.Constantes;
using ChiquePiggy.Models;
using ChiquePiggy.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiquePiggy.Services
{
    public class CaixaService : ICaixaService
    {    
        public SaldoClienteViewModel ConsultarSaldoPontos(int id)
        {            
            return new SaldoClienteViewModel(0);
        }
    }
}
