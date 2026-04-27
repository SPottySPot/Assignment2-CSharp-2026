using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class TaskAForm : Form
    {
        public TaskAForm()
        {
            InitializeComponent();
            this.Width = 400;
            this.Height = 400;
        }

        private void TaskAForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // House base
            g.FillRectangle(Brushes.LightBlue, 100, 150, 200, 150);

            // Roof (triangle)
            Point[] roofPoints = {
            new Point(100, 150),
            new Point(200, 80),
            new Point(300, 150)};

            g.FillPolygon(Brushes.DarkRed, roofPoints);

            // Door
            g.FillRectangle(Brushes.Brown, 180, 220, 40, 80);

            // Windows
            g.FillRectangle(Brushes.White, 120, 170, 40, 40);
            g.FillRectangle(Brushes.White, 240, 170, 40, 40);
        }
    }
}
