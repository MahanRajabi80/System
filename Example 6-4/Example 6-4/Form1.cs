using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example_6_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //---------------------------------------------------------------------
        private void btnRestart_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            switch (Convert.ToInt32(b.Tag))
            {
                case 1://hibernate
                    Application.SetSuspendState(PowerState.Hibernate, true, true);
                    break;
                case 2://stand by
                    Application.SetSuspendState(PowerState.Suspend, true, true);
                    break;
                case 3://shut down
                    System.Diagnostics.Process.Start("ShutDown", "/s");
                    break;
                case 4://log off
                    System.Diagnostics.Process.Start("ShutDown", "/l");
                    break;
                case 5://restart
                    System.Diagnostics.Process.Start("ShutDown", "/r");
                    break;
            }
        }
    }
}
