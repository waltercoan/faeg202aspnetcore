
using System.Threading.Tasks;
using faegtodo.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using faegtodo.Models;

namespace faegtodo.Controllers
{
    public class ClientController : Controller{

        private IClientService service = null;

        public ClientController(IClientService service){
            this.service = service;
        }
        [HttpGet]
        public async Task<IActionResult> Index(){
            var _listClient = await this.service.GetAll();
            return View(_listClient);

        }
        [HttpGet]
        public IActionResult Form(){
            Console.WriteLine("METODO GET");
            var client = new Client();
            return View(client);
        }
        [HttpPost]
        public IActionResult Form(Client client){
            
            Console.WriteLine("Metodo POST");
            if(ModelState.IsValid)
            {
                service.Save(client);
                return RedirectToAction("Index");
            }
            

            return View(client);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int Id){
            var client = await service.GetById(Id);
            return View("Form",client);
        }

        [HttpGet]
        public IActionResult Delete(int Id){
            service.Delete(Id);
            return RedirectToAction("Index");
        }

    }    
}