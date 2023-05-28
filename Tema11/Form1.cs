using System.Windows.Forms;
using TemeGC;

namespace Tema11
{
    public partial class Form1 : Form
    {
        public static int width;
        public static int height;

        public static PictureBox pictureBox1 = new PictureBox();
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Size = new Size(flowLayoutPanel1.Width, flowLayoutPanel1.Height);
            flowLayoutPanel1.Controls.Add(pictureBox1);
            width = flowLayoutPanel1.Width;
            height = flowLayoutPanel1.Height;
            pictureBox1 = S11.P1(pictureBox1);
        }
    }
}