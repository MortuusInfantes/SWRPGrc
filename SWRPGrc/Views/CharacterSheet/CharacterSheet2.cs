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
    public partial class CharacterSheet2 : UserControl
    {
        public CharacterSheet2()
        {
            InitializeComponent();
        }

        private void CharacterSheet2_Load(object sender, EventArgs e)
        {
            TreeNode outer = new TreeNode("A");
            outer.Nodes.Add("1");
            outer.Nodes.Add("2");
            outer.Nodes.Add("3");

            a.Nodes.Add(outer);

            outer = new TreeNode("B");
            a.Nodes.Add(outer);
            outer.Nodes.Add("1");
            outer.Nodes.Add("2");
            outer.Nodes.Add("3");
            a.Nodes.Add(new TreeNode("C", new TreeNode[3] { new TreeNode("1"), new TreeNode("2"), new TreeNode("3") }));
                        
        }
    }
}
