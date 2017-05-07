using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrayApp
{
    internal class TrayAppApplicationContext : ApplicationContext
    {
        private readonly ConfigWindow _configWindow = new ConfigWindow();
        private readonly NotifyIcon _notifyIcon = new NotifyIcon();

        internal TrayAppApplicationContext()
        {
            var configMenuItem = new MenuItem("Configuration", new EventHandler(ShowConfig));
            var exitMenuItem = new MenuItem("Exit", new EventHandler(Exit));

            
            _notifyIcon.Icon = TrayApp.Properties.Resources.AppIcon;
            _notifyIcon.ContextMenu = new ContextMenu(new MenuItem[]
                { configMenuItem, exitMenuItem });
            _notifyIcon.Visible = true;
        }

        private void ShowConfig(object sender, EventArgs e)
        {
            // If we are already showing the window, merely focus it.
            if (_configWindow.Visible)
            {
                _configWindow.Activate();
            }
            else
            {
                _configWindow.ShowDialog();
            }
        }

        private void Exit(object sender, EventArgs e)
        {
            // We must manually tidy up and remove the icon before we exit.
            // Otherwise it will be left behind until the user mouses over.
            _notifyIcon.Visible = false;
            Application.Exit();
        }
    }
}
