using System.Drawing;
using System.Windows.Forms;

namespace _20_PaintHomeWork
{
    public partial class Form1 : Form
    {
        Point startLocation;
        int CursorX;
        int CursorY;
        List<MyShape> shapes;
        Boolean cursorMoving = false;
        Pen cursorPen;
        List<Point> points;
        Color c;
        int size;
        Graphics g;
        enum ShapeTypesEnum
        {
            Pencil,Rectangle, Line, Ellipse, Curve, Dot
        };
        public Form1()
        {
            InitializeComponent();
            //this.CreateGraphics().FillRectangle();
            shapes = new List<MyShape>();
            foreach (var item in Enum.GetValues(typeof(ShapeTypesEnum)))
            {
                ShapeType.Items.Add(item);
            }
            ShapeType.SelectedIndex = 0;
            LineType.SelectedIndex = 0;
            points = new List<Point>();
            c = Color.Green;
            g = this.CreateGraphics();

            cursorPen = new Pen(c, size);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            cursorPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            cursorPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            size = (int)numericUpDown1.Value;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
            startLocation = e.Location;
            var type = (ShapeTypesEnum)ShapeType.SelectedItem;
            if (type==ShapeTypesEnum.Pencil)
            {
                cursorMoving = true;
                CursorX = e.X; CursorY = e.Y;
                cursorPen.Color = c;
                cursorPen.Width = size;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Point cursorLocation = e.Location;
            Point endLocation = e.Location;

            MyShape shape = null;
            string style = LineType.SelectedItem.ToString();
            Pen penLine = new Pen(Brushes.Black);
            penLine.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            var type = (ShapeTypesEnum)ShapeType.SelectedItem;
            if (type != ShapeTypesEnum.Pencil)
            {
                if (type == ShapeTypesEnum.Rectangle || type == ShapeTypesEnum.Ellipse)
                {
                    Rectangle rect = new Rectangle();
                    rect.X = startLocation.X < endLocation.X ? startLocation.X : endLocation.X;
                    rect.Y = startLocation.Y < endLocation.Y ? startLocation.Y : endLocation.Y;

                    rect.Width = Math.Abs(endLocation.X - startLocation.X);
                    rect.Height = Math.Abs(endLocation.Y - startLocation.Y);

                    if (type == ShapeTypesEnum.Rectangle)
                    {
                        shape = new MyRectangle(c, rect);
                    }
                    else if (type == ShapeTypesEnum.Ellipse)
                    {
                        shape = new MyEllipse(c, rect);
                    }
                    //SolidBrush brush = new SolidBrush(c);
                    //g.FillRectangle(brush, rect);

                    //shape = new MyRectangle(c, rect);
                    //shape.Draw(g);

                    //shapes.Add(new MyRectangle(c, rect));
                }

                else if (type == ShapeTypesEnum.Line)
                {
                    shape = new MyLine(c, startLocation, endLocation, size, style);
                    //shape.Draw(g);
                    //shapes.Add(shape);
                }
                else if (type == ShapeTypesEnum.Dot)
                {
                    shape = new MyDot(c, cursorLocation, size);
                }
                else if (type == ShapeTypesEnum.Curve)
                {
                    shape = new MyCurve(c, points, size, style);
                }
                shape.Draw(g);
                shapes.Add(shape);
                cursorMoving = false;
                CursorX = -1; CursorY = -1;
            }
            else if(type == ShapeTypesEnum.Pencil)
            {
                cursorMoving = false;
                CursorX = -1; CursorY = -1;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (MyShape item in shapes)
            {
                //g.FillRectangle(new SolidBrush(item.Color), item.Rects) ;

                item.Draw(g);

            }
        }

        private void UndoBtn_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            points.Add(e.Location);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            points.Clear();
            this.CreateGraphics().FillRectangle(Brushes.White, 0, 0, 10000, 10000);
        }

        private void ColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                c = color.Color;
            }
        }

        private void PencilBtn_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (CursorX != -1 && CursorY != -1 && cursorMoving == true)
            {
                g.DrawLine(cursorPen, new Point(CursorX, CursorY),e.Location);
                CursorX = e.X;
                CursorY = e.Y;
            }
        }
    }


    internal abstract class MyShape
    {
        public abstract void Draw(Graphics g);
    }
    class MyRectangle : MyShape
    {
        public Color Color { get; set; }
        public Rectangle Rects { get; set; }

        public MyRectangle()
        {

        }
        public MyRectangle(Color c, Rectangle r)
        {
            Color = c;
            Rects = r;
        }
        public override void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color), Rects);
        }
    }
    class MyLine : MyShape
    {
        public Pen Pen { get; set; }
        public Point Start { get; set; }
        public Point End { get; set; }

        public override void Draw(Graphics g)
        {
            g.DrawLine(Pen, Start, End);
        }
        public MyLine()
        {

        }
        public MyLine(Color c, Point s, Point e, int size, string style)
        {
            Pen = new Pen(c, size);
            Start = s;
            End = e;
            if (style == "Dot")
            {
                Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            }
            else if (style == "Line Dot")
            {
                Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            }
            else if (style == "Line Dot Dot")
            {
                Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            }
            else if (style == "Dash")
            {
                Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            }
        }
    }
    class MyEllipse : MyRectangle
    {
        public MyEllipse() { }
        public MyEllipse(Color color, Rectangle rect) : base(color, rect) { }
        public override void Draw(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color), Rects);
        }

    }
    class MyDot : MyRectangle
    {
        public Point Point { get; set; }
        public int Size { get; set; }
        public MyDot() { }
        public MyDot(Color color, Point p, int size)
        {
            Color = color;
            Point = p;
            Size = size;
        }
        public override void Draw(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color), Point.X - 5, Point.Y - 5, Size, Size);
        }
    }
    class MyCurve : MyShape
    {
        public Pen Pen { get; set; }
        public Color Color { get; set; }
        List<Point> Points;

        public MyCurve()
        {

        }

        public MyCurve(Color c, List<Point> p, int size, string style)
        {

            Pen = new Pen(c, size);
            Points = p;
            if (style == "Dot")
            {
                Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            }
            else if (style == "Line Dot")
            {
                Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            }
            else if (style == "Line Dot Dot")
            {
                Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            }
            else if (style == "Dash")
            {
                Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            }
        }

        public override void Draw(Graphics g)
        {
            if (Points.Count < 2)
            {
                return;
            }
            g.DrawCurve(Pen, Points.ToArray());
        }
    }


}