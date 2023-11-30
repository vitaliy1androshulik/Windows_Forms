namespace _2_MoveButtonHomeWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Ви перемогли!";
            button1.Enabled = false;
            Thread.Sleep(4000);
            button1.Enabled = true;
            button1.Text = "Злови мене!";
        }

        private void button1_MouseMove_1(object sender, MouseEventArgs e)
        {
            //Random rndx = new Random();
            //Random rndy = new Random();
            //Point pt = new Point(rndx.Next(800), rndy.Next(400));
            //
            //if (Cursor.Position.X == button1.Left + 10 || e.X == button1.Right + 10 || e.Y == button1.Top - 10 || e.Y == button1.Bottom + 10)
            //{
            //    button1.Location = pt;
            //}
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Mose Position {e.X}:{e.Y}";
            Point mouse = e.Location;
            Random random = new Random();
            if (mouse.X >= button1.Left - 5 && (mouse.X <= button1.Right + button1.Width + 1))
            {
                if (mouse.X >= button1.Left + (button1.Width / 2))
                {
                    button1.Left = button1.Left - 4;
                }
                else
                {
                    button1.Left = button1.Left + 4;
                }
            }
            if (button1.Left < 0 || button1.Right > this.ClientSize.Width)
            {
                button1.Location = new Point(random.Next(this.Width - button1.Width), random.Next(this.Height - button1.Height));
            }

            if (mouse.Y >= button1.Top - 5 && (mouse.Y <= button1.Bottom + button1.Height + 1))
            {
                if (mouse.Y >= button1.Top + (button1.Height / 2))
                {
                    button1.Top = button1.Top - 4;
                }
                else
                {
                    button1.Top = button1.Top + 4;
                }
            }
            if (button1.Top < 0 || button1.Bottom > this.ClientSize.Height)
            {
                button1.Location = new Point(random.Next(this.Height - button1.Height), random.Next(this.Width - button1.Width));
            }

        }
    }
}