using KinecticFramework.App.Handlers;
using KinecticFramework.App.Interfaces;
using KinecticFramework.App.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinecticFramework.App.Controllers
{
    internal class HomeController : IController
    {
        public override string Name => "Home";

        public HomeController(WindowProvider window) : base(window)
        {

        }
        public override void Start()
        {
            ViewHandler.ChangeView("home.index");
        }

        public string GetName()
        {
            return this.Name;
        }
    }
}
