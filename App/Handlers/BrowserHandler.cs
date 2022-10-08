using CefSharp.WinForms;
using CefSharp;
using KinecticFramework.App.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using KinecticFramework.App.Interfaces;
using System.Diagnostics;

namespace KinecticFramework.App.Handlers
{
    public class BrowserHandler
    {
        private WindowProvider WindowProvider;
        private ChromiumWebBrowser Browser;

        // Eventos
        public event EventHandler FrameVisible;
        public event EventHandler FrameReady;
        public IController? Controller;

        public BrowserHandler(WindowProvider windowProvider)
        {
            WindowProvider = windowProvider;
        }

        public void Start()
        {
            CefSettings settings = new CefSettings();
            settings.CefCommandLineArgs.Add("allow-file-access-from-files");
            settings.CefCommandLineArgs.Add("universal-access-from-file-urls");
            Cef.Initialize(settings);

            Browser = new ChromiumWebBrowser();
            WindowProvider.Window.Controls.Add(Browser);
            Browser.Dock = DockStyle.Fill;
            Browser.Hide();
            Browser.FrameLoadStart += OnFrameVisible;
            Browser.FrameLoadEnd += OnFrameReady;
        }

        public void Stop()
        {
            Cef.Shutdown();
        }

        public void LoadUrl(String url)
        {
            Browser.LoadUrl(url);
        }

        public void PrepareController(IController? controller)
        {
            if(controller == null)
                return;
            Controller = controller;
            Controller?.Start();
            Browser.JavascriptObjectRepository.Register("Controller", Controller, BindingOptions.DefaultBinder);
        }

        #region Event Subscribers
        private void OnFrameVisible(object? sender, FrameLoadStartEventArgs args)
        {
            if (Browser.InvokeRequired)
                Browser.Invoke(() =>
                {
                    Browser.Show();
                    Browser.ShowDevTools();
                });
            else
            {
                Browser.Show();
                Browser.ShowDevTools();
            }
            FrameVisible?.Invoke(this, EventArgs.Empty);
        }

        private void OnFrameReady(object? sender, FrameLoadEndEventArgs args)
        {
            FrameReady?.Invoke(this, EventArgs.Empty);
        }
        #endregion
    }
}
