using KinecticFramework.App.Interfaces;
using KinecticFramework.App.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinecticFramework.Windows
{
    public partial class MainWindow : Form, IDynamicWindow
    {
        private WindowProvider WindowProvider;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void SetupWindow(WindowProvider windowProvider)
        {
            WindowProvider = windowProvider;
            WindowProvider.BrowserHandler.FrameVisible += OnFrameVisible;
        }

        private void OnFrameVisible(object? sender, EventArgs args)
        {
            if (InvokeRequired)
                Invoke((Delegate)(() =>
                {
                    LoadingIcon.Hide();
                }));
            else
                LoadingIcon.Hide();
        }
    }
}