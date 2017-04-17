using System;
using System.Linq;
using System.Web.Mvc;
using MyTasks.Web.Models;
using MyTasks.Web.Services;

namespace MyTasks.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var service = new TaskService();
            var tasks = service.GetTasks().ToList();

            return View(tasks);
        }

        [HttpPost]
        public ActionResult NewTask(string title)
        {
            var service = new TaskService();
            service.AddTask(title);
            var tasks = service.GetTasks().ToList();

            return View("Index", tasks);
        }

        public ActionResult Complete(Guid id)
        {
            var service = new TaskService();

            service.CompleteTask(id);

            var tasks = service.GetTasks().ToList();

            return View("Index", tasks);
        }

    }
}