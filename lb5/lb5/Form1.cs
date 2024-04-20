using System;

namespace lb5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Draw();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Коваль Ангеліна Варіант 10 КН21");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(405, 240);
            Graphics graph = Graphics.FromImage(bmp);

            Point[] points1 =
            {
            new Point(200, 140),
            new Point(295, 40),
            new Point(235, 190)
            };
            graph.FillPolygon(Brushes.Red, points1);

            Point[] points2 =
            {
            new Point(135, 190),
            new Point(185, 40),
            new Point(235, 190)
            };
            graph.FillPolygon(Brushes.Yellow, points2);

            Point[] points3 =
            {
            new Point(155, 130),
            new Point(95, 40),
            new Point(135, 190)
            };
            graph.FillPolygon(Brushes.Green, points3);

            graph.FillEllipse(Brushes.Red, new Rectangle(280, 15, 30, 30));
            graph.FillEllipse(Brushes.Yellow, new Rectangle(170, 15, 30, 30));
            graph.FillEllipse(Brushes.Green, new Rectangle(80, 15, 30, 30));

            pictureBox1.Image = bmp;
        }
    }
}