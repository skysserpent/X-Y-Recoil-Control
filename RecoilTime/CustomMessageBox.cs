using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace YourNameSpace
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox(string message, string title)
        {
            InitializeComponent();
            this.Text = title;
            this.labelMessage.Text = message;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            int borderRadius = 8;
            int width = this.Width;
            int height = this.Height;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 150);
            path.AddArc(width - borderRadius - 1, 0, borderRadius, borderRadius, 270, 150);
            path.AddArc(width - borderRadius - 1, height - borderRadius - 1, borderRadius, borderRadius, 0, 150);
            path.AddArc(0, height - borderRadius - 1, borderRadius, borderRadius, 150, 150);
            path.CloseAllFigures();
            this.Region = new Region(path);
            this.BackColor = Color.FromArgb(27, 27, 27);
        }

        public static void Show(string message, string title = "Message")
        {
            CustomMessageBox msgBox = new CustomMessageBox(message, title);
            msgBox.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {

        }

        private void labelMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
