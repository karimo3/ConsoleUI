using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterSheet.Models;
using CharacterSheet.ViewModels;
using CharacterSheet.Services;

namespace CharacterSheet.Controllers
{
    public class HomeController : Controller
    {

        private readonly IMailService _mailService;
        
        public HomeController(IMailService mailService)
        {
            _mailService = mailService;
        }
        public IActionResult Index()
        {
            var model = new Characters();
            model.Name = "Hux";
            return View(model);
        }


        /// <summary>
        /// ///////////
        /// </summary>
        /// <returns></returns>
        public IActionResult About()
        {
            return View();
        }

        /// <summary>
        /// ///////////////
        /// </summary>
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }


        public IActionResult Create(string characterName)
        {
            return View();
        }




        /// <summary>
        /// ///////////
        /// </summary>
        /// <returns></returns>
        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel contactViewModel)
        {
            if (ModelState.IsValid)
            {
                _mailService.SendMessage("kokarim@msn.com", contactViewModel.Subject, $"From: {contactViewModel.Name} - {contactViewModel.Email}, Message: {contactViewModel.Message}");
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            }
            else
            {
                //show errors
            }
            return View();
        }

        /// <summary>
        /// ////////////
        /// </summary>
        /// <returns></returns>
        //Manage Program Flow
        public IActionResult ImplementMultithreading()
        {
            return View();
        }

        public IActionResult ManageMultithreading()
        {
            return View();
        }

        public IActionResult ProgramFlow()
        {
            return View();
        }

        public IActionResult EventsAndCallbacks()
        {
            return View();
        }

        public IActionResult ExceptionHandling()
        {
            return View();
        }

        /// <summary>
        /// ////////////
        /// </summary>
        /// <returns></returns>
        //Create and Use Types
        public IActionResult CreateTypes()
        {
            return View();
        }

        public IActionResult ConsumeTypes()
        {
            return View();
        }

        public IActionResult EnforceEncapsulation()
        {
            return View();
        }

        public IActionResult CreateAndImplementClassHierarchy()
        {
            return View();
        }

        public IActionResult Reflection()
        {
            return View();
        }

        public IActionResult ManageObjectLifeCycle()
        {
            return View();
        }

        public IActionResult ManipulateStrings()
        {
            return View();
        }


        /// <summary>
        /// ////////////////
        /// </summary>
        /// <returns></returns>
        //Debug Applications and Implement Security
        public IActionResult ValidateAppInput()
        {
            return View();
        }

        public IActionResult SymmetricEncryption()
        {
            return View();
        }

        public IActionResult ManageAssemblies()
        {
            return View();
        }

        public IActionResult DebugApplication()
        {
            return View();
        }

        public IActionResult ImplementDiagnostics()
        {
            return View();
        }

        /// <summary>
        /// ////////////////
        /// </summary>
        /// <returns></returns>
        //Implement Data Access section
        public IActionResult IOOperations()
        {
            return View();
        }

        public IActionResult ConsumeData()
        {
            return View();
        }

        public IActionResult LINQData()
        {
            return View();
        }

        public IActionResult SerializeData()
        {
            return View();
        }

        public IActionResult StoreRetrieveData()
        {
            return View();
        }

    }
}
