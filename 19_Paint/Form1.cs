using System.Drawing;

namespace _19_Paint
{
    public partial class Form1 : Form
    {
        int redraw_count;
        List<Point> points;
        public Form1()
        {
            InitializeComponent();
            redraw_count = 0;
            points =new List<Point>();
        }

        private void DrawBtn_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            int x = 25, y = 25, height = 500, width = 500;


            Rectangle rect = new Rectangle(x, y, height, width);
            g.FillEllipse(Brushes.Blue, rect);


            Point point = new Point(50, 50);
            Size size = new Size(125, 200);
            Rectangle rect1 = new Rectangle(point, size);
            Pen pen = new Pen(Brushes.Black, 10);
            g.DrawEllipse(pen, rect1);

            Point point1 = new Point(400, 50);
            Rectangle rect2 = new Rectangle(point1, size);
            Pen pen1 = new Pen(Brushes.Black, 10);
            g.DrawEllipse(pen1, rect2);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            this.Text = $"{redraw_count++}";
            Graphics g = e.Graphics;
            int x = 25, y = 25, height = 500, width = 500;


            Rectangle rect = new Rectangle(x, y, height, width);
            g.FillEllipse(Brushes.Blue, rect);


            Point point = new Point(50, 50);
            Size size = new Size(125, 200);
            Rectangle rect1 = new Rectangle(point, size);
            Pen pen = new Pen(Brushes.Black, 10);
            g.DrawEllipse(pen, rect1);

            Point point1 = new Point(400, 50);
            Rectangle rect2 = new Rectangle(point1, size);
            Pen pen1 = new Pen(Brushes.Red, 10);
            g.DrawEllipse(pen1, rect2);


            Pen penLine = new Pen(Brushes.Red, 6);
            penLine.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            penLine.EndCap = System.Drawing.Drawing2D.LineCap.Triangle;
            penLine.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            penLine.DashCap = System.Drawing.Drawing2D.DashCap.Round;

            g.DrawLine(penLine, 50, 150, 600, 200);

            printFigures(g);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void printFigures(Graphics g)
        {
            foreach (Point item in points)
            {
                g.FillEllipse(Brushes.Teal, item.X - 5, item.Y - 5, 10, 10);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = e.Location;
            points.Add(point);
            this.CreateGraphics().FillEllipse(Brushes.Teal, point.X-5,point.Y-5, 10,10 );
        }
    }
}