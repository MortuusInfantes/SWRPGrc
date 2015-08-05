using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SWRPGrc.Classes;

namespace SWRPGrc.Views
{
    public partial class Mapper : UserControl
    {
        private bool gridVisible = true;
        private int gridSpacing = 100;
        private Color gridColor = Color.White;
        private Graphics g;
        private Bitmap bmp;
        private bool hasMap = false;
        public Map map;

        private Form1 parent;

        public Mapper(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        public Mapper(Form1 parent, bool hasMap)
        {
            this.parent = parent;
            this.hasMap = hasMap;
            InitializeComponent();
        }

        private void Mapper_Load(object sender, EventArgs e)
        {
            InitializePbx();
            RenderMap();
        }

        private void InitializePbx()
        {
            if (hasMap)
            {
                bmp = map.GetBmp();
                g = Graphics.FromImage(bmp);
            }
            else
            {
                bmp = new Bitmap(1000, 1000);
                g = Graphics.FromImage(bmp);
                g.FillRectangle(new SolidBrush(Color.Black), 0, 0, 1000, 1000);
            }
            pictureBox1.Image = bmp;
        }

        private void RenderMap()
        {
            if (gridVisible)
            {
                DrawGrid();
            }
        }

        private void DrawGrid()
        {
            //draw border
            Pen p = new Pen(gridColor);
            g.DrawLine(p, 0, 0, 0, 1000);
            g.DrawLine(p, 0, 1000, 1000, 1000);
            g.DrawLine(p, 1000, 1000, 1000, 0);
            g.DrawLine(p, 1000, 0, 0, 0);

            //draw grid
            for (int x = 0; x < bmp.Width; x += gridSpacing)
            {
                g.DrawLine(p, x, 0, x, bmp.Height);
            }

            for (int y = 0; y < bmp.Height; y += gridSpacing)
            {
                g.DrawLine(p, 0, y, bmp.Width, y);
            }
        }
    }
}
