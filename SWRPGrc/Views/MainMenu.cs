using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SWRPGrc.Views
{
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BtnChar_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(new SWRPGrc.Views.CharcterMain.CharacterMain());
        }

        private void BtnCamp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Campaign stuff");
        }

        private void BtnPlan_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Play stuff");
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(new SWRPGrc.Views.HomeMain.HomeMain());

        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("settings stuff");
        }

        
    }
}
