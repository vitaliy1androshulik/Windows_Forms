using Timer = System.Windows.Forms.Timer;

namespace _6_ProgressBarTrackBar
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer(); public Form1()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            UpdateColor();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = progressBar1.Minimum;
            }
            else
            {
                progressBar1.Value++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void TopBtn_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Minimum;

            decimal max = (numericUpDown1.Value > progressBar1.Maximum ?
                progressBar1.Maximum : numericUpDown1.Value);
            while (progressBar1.Value < max)
            {
                progressBar1.Value++;
                progressBar1.Update();
                Thread.Sleep(50);
            }
            progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;//��������� �� ��������
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            UpdateColor();
        }
        private void UpdateColor()
        {
            Color color = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            this.BackColor = color;

        }

        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = trackBar4.Value / 100.0;
        }
    }
}