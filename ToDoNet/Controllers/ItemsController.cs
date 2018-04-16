using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ToDoNet.Models;


namespace ToDoNet.Controllers
{
    public class ItemsController : Controller
    {
        private ToDoNetContext db = new ToDoNetContext();
        public IActionResult Index()
        {
            List<Item> model = db.Items.ToList();
            return View(model);
        }
    }
}
