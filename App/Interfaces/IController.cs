using KinecticFramework.App.Handlers;
using KinecticFramework.App.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinecticFramework.App.Interfaces
{
    public abstract class IController
    {
        protected WindowProvider WindowProvider;
        protected BrowserHandler BrowserHandler { get => WindowProvider.BrowserHandler; }
        protected ViewHandler ViewHandler { get => WindowProvider.ViewHandler; }
        public abstract string Name { get; }

        protected IController(WindowProvider windowProvider)
        {
            WindowProvider = windowProvider;
        }

        public abstract void Start();
    }
}
