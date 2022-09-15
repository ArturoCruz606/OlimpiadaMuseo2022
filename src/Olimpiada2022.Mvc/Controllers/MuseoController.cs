using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OlimpiadaMuseo2022.Core;

namespace Olimpiada2022.Mvc.Controllers
{
    public class MuseoController : Controller
    {
        private readonly Contexto _contexto;

        public MuseoController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<IActionResult> Listado()
        {
            var museos = await _contexto.Museos.ToListAsync();
            return View(museos);
        }
        public async Task<IActionResult> Alta()
        {
            
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}