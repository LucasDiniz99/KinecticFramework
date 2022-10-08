using KinecticFramework.App.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinecticFramework.App.Handlers
{
    public class ViewHandler
    {
        private WindowProvider WindowProvider;
        private BrowserHandler Browser { get => WindowProvider.BrowserHandler; }

        public ViewHandler(WindowProvider windowProvider)
        {
            WindowProvider = windowProvider;
        }

        public void Start()
        {

        }

        public void ChangeView(String view)
        {
            var path = "";
            var aux = view.Split('.');
            if(aux.Length > 1)
            {
                for(int i = 0; i < aux.Length; i++)
                {
                    path += '\\' + aux[i];
                }
            } else
            {
                path = aux[0];
            }
            path = string.Format(@"{0}\Resources\Views{1}.html", Application.StartupPath, path);
            if (!File.Exists(path))
            {
                throw new Exception("File does not exist!");
            }
            Browser.LoadUrl(path);
        }
    }
}
