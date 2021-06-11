/*using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SpaceCat.Controllers
{
    public class NovostiAnketeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            var novosti = GetNovosti();
            var ankete = GetAnkete();
            NovostiAnketeModel model = new NovostiAnketeModel();
            model.Ankete=ankete;
            model.Novosti=novosti;
            return View(model);
        }

        private List<Novost> GetNovosti()
        {
            return new List<Novost>() { new Novost(){}};
        }
        private List<Anketa> GetAnkete()
        {
            return new List<Anketa>() { new Anketa(){}};
        }
    }
}*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SpaceCat;
using SpaceCat.Data;

namespace SpaceCat.Controllers
{
    public class NovostiAnketeController : Controller
    {
        private readonly SpaceCatContext _context;

        public NovostiAnketeController(SpaceCatContext context)
        {
            _context = context;
        }

       /* // GET: Novost
        public async Task<IActionResult> Index()
        {
            return View(await _context.NovostiAnketeModel.ToListAsync());
        }*/
    }
}