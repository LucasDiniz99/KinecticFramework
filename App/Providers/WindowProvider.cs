using KinecticFramework.App.Controllers;
using KinecticFramework.App.Handlers;
using KinecticFramework.App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KinecticFramework.App.Providers
{
    public class WindowProvider
    {
        public Form Window;
        public BrowserHandler BrowserHandler;
        public ViewHandler ViewHandler;
        public IController? CurrentController;
        public BackgroundProvider BackgroundProvider;

        private Type DefaultController = typeof(HomeController);

        public WindowProvider(Form browserWindow)
        {
            Window = browserWindow;
            BackgroundProvider = new BackgroundProvider();
            BrowserHandler = new BrowserHandler(this);
            ViewHandler = new ViewHandler(this);

            (Window as IDynamicWindow).SetupWindow(this);
            Window.Load += OnLoad;
            Window.FormClosing += OnClosing;

            Application.Run(browserWindow);
        }

        public void SetController(object? controller)
        {
            CurrentController = controller != null ? (IController)controller : null;
            BrowserHandler.PrepareController(CurrentController);
        }

        #region Event Subscribers
        private void OnLoad(object? observer, EventArgs args)
        {
            BrowserHandler.Start();
            ViewHandler.Start();
            // Starting default controller
            SetController(Activator.CreateInstance(DefaultController, new object[] { this }));
        }

        private void OnClosing(object? observer, EventArgs args)
        {
            BrowserHandler.Stop();
        }
        #endregion
    }
}
