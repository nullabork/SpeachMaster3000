using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace speechmaster
{
    public partial class SettingsForm : Form
    {
        public SettingsForm(UserControl userControl)
        {
            InitializeComponent();
            EmbedUserControl(userControl);
        }

        private void EmbedUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            this.Controls.Add(userControl);
        }
    }
}
