using KinecticFramework.App.Handlers;
using KinecticFramework.App.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinecticFramework.App.Interfaces
{
    internal interface IDynamicWindow
    {
        public void SetupWindow(WindowProvider windowProvider);
    }
}
