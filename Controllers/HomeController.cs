using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using VintageStuff.Data;
using VintageStuff.Models;
using VintageStuff.Web.Models;
using VintageStuff.Web.ViewModels;

namespace VintageStuff.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public IActionResult Index()
        //{
          //  return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        private readonly ApplicationDbContext dbContext;
        private readonly IWebHostEnvironment webHostEnvironment;
        public HomeController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            dbContext = context;
            webHostEnvironment = hostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            var usuario = await dbContext.Usuarios.ToListAsync();
            return View(usuario);
        }

        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> New(UsuarioViewModel model)
        {
            if (ModelState.IsValid)
            {
                string unicoNombreArchivo = UploadedFile(model);
                Usuario usuario = new Usuario
                {
                    Nombre = model.Nombre,
                    Apellido = model.Apellido,
                    NombreCompleto = model.Nombre + " " + model.Apellido,
                    Telefono = model.Telefono,
                    Correo = model.Correo,
                    ImagenPerfil = unicoNombreArchivo,
                };
                dbContext.Add(usuario);
                await dbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }

        private string UploadedFile(UsuarioViewModel model)
        {
            string unicoArchivo = null;

            if (model.ImagenPerfil != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                unicoArchivo = Guid.NewGuid().ToString() + "_" + model.ImagenPerfil.FileName;
                string filePath = Path.Combine(uploadsFolder, unicoArchivo);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ImagenPerfil.CopyTo(fileStream);
                }
            }
            return unicoArchivo;
        }
    


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    }