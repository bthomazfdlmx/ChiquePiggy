using ChiquePiggy.Helpers.Views;
using ChiquePiggy.Models;
using ChiquePiggy.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChiquePiggy.MVC.Controllers
{
    public class CaixaController : Controller
    {        
        private readonly ICaixaService _caixaService;

        public CaixaController(ICaixaService caixaService)
        {
            _caixaService = caixaService;
        }

        public ActionResult Inicio(int id = 0)
        {
            //Exemplo básico de chamada aos serviços e fluxo do sistema         
            SaldoClienteViewModel saldoModel = _caixaService.ConsultarSaldoPontos(id);            
            return View(CaixaViews.Inicio);
        }
    }
}