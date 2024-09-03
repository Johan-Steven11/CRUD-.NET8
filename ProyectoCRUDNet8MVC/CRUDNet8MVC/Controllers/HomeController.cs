using CRUDNet8MVC.Datos;
using CRUDNet8MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;

namespace CRUDNet8MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AplicationDbContext _context;

        public HomeController(AplicationDbContext context)
        {
           _context = context;
        }
        [HttpGet]
        public async Task <IActionResult> Index()
        {
            return View(await _context.Contacto.ToListAsync());
        }
        [HttpGet]
        public IActionResult Crear() 
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear(Contacto contacto)
        {
            if (ModelState.IsValid)
            {
                //Fecha & Hora

                contacto.FechaCreacion = DateTime.Now;
                _context.Contacto.Add(contacto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        [HttpGet]
        public IActionResult Editar(int? id) 
        {
            if (id == null) { return NotFound(); }
            var contacto = _context.Contacto.Find(id);
            if (contacto == null) { return NotFound();}
            return View(contacto);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(Contacto contacto)
        {
            if (ModelState.IsValid)
            {
                
                _context.Update(contacto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        public IActionResult Detalle(int? id)
        {
            if (id == null) { return NotFound(); }
            var contacto = _context.Contacto.Find(id);
            if (contacto == null) { return NotFound(); }
            return View(contacto);
        }

        [HttpGet]
        public IActionResult Eliminar(int? id)
        {
            if (id == null) { return NotFound(); }
            var contacto = _context.Contacto.Find(id);
            if (contacto == null) { return NotFound(); }
            return View(contacto);
        }


        [HttpPost, ActionName("Borrar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Borrar(int? id)
        {
            var contacto = await _context.Contacto.FindAsync(id);
            if(contacto == null) {  return View(); }
            //Borrado

            _context.Contacto.Remove(contacto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
            
        
        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
