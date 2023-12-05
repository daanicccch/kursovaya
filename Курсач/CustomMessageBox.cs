using System.Runtime.ExceptionServices;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Курсач
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox(string message)
        {
            InitializeComponent();
            messageLabel.Text = message;
            messageLabel.Anchor = AnchorStyles.None;
            messageLabel.Location = new Point((this.ClientSize.Width - messageLabel.Width) / 2,
                                         (this.ClientSize.Height - messageLabel.Height) / 2);
            this.Size = new Size(messageLabel.Size.Width + 140, messageLabel.Size.Height + 200);
            this.BackColor = Color.FromArgb(166, 149, 168);
            closeButton.Location = new Point(this.Size.Width - 135, this.Size.Height - 90);


            //messageLabel
            messageLabel.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            messageLabel.ForeColor = Color.FromArgb(62, 39, 61);

            //button2
            this.BackColor = Color.FromArgb(166, 149, 168);
            closeButton.BringToFront();
            closeButton.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            closeButton.BackColor = Color.FromArgb(129, 106, 133); // Цвет фона
            closeButton.ForeColor = Color.FromArgb(62, 39, 61);
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.FlatAppearance.BorderSize = 0; // Убираем границу, чтобы скругление было видно
            closeButton.Region = System.Drawing.Region.FromHrgn(Form1.CreateRoundRectRgn(0, 0, closeButton.Width, closeButton.Height, 10, 10));
            closeButton.MouseEnter += (sender, e) =>
            {
                closeButton.ForeColor = Color.FromArgb(247, 169, 221);
                closeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 78, 97);
                pictureBox1.Visible = true;
            };
            closeButton.MouseLeave += (sender, e) =>
            {
                closeButton.ForeColor = Color.FromArgb(62, 39, 61);
                pictureBox1.Visible = false;
            };

            //pictureBox1
            pictureBox1.Location = new Point(this.Size.Width - 137, this.Size.Height - 92);
            pictureBox1.Size= new Size(closeButton.Width +4, closeButton.Height +4);
            pictureBox1.Region = System.Drawing.Region.FromHrgn(Form1.CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 10, 10));
        }
        private void closeButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
