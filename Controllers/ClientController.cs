
using System.Threading.Tasks;
using faegtodo.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using faegtodo.Models;
using System.Collections.Generic;

namespace faegtodo.Controllers
{
    public class ClientController : Controller{

        private IClientService service = null;

        public ClientController(IClientService service){
            this.service = service;
        }
        [HttpGet]
        public async Task<IActionResult> Index(String search){
            var _listClient = await this.service.GetAll();
            return View(_listClient);

        }
        [HttpPost]
        public async Task<IActionResult> Search(String search){
            IList<Client> _listClient = null;
            if(search == null){
                _listClient = await this.service.GetAll();
            }else{
                _listClient = await this.service.GetAllByName(search);
            }
            return View("Index",_listClient);
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