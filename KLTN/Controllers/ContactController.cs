using Microsoft.AspNetCore.Mvc;
using ProjectKLTN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectKLTN.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ContactController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateContact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.Contacts.Add(contact);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contact);
        }
    }
}
