using ChiquePiggy.Caching;
using ChiquePiggy.Helpers.Constantes;
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
        public int ConsultarSaldoPontos(int id)
        {
            if(id == 0) return 0;
            //TODO: Consultar o saldo de pontos atual do cliente            
            return 0;
        }
    }
}
