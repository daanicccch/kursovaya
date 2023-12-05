using System.Runtime.ExceptionServices;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Курсач
{
    public partial class Form1 : Form
    {
        private int[] array;
        private int target;
        private int currentIndex = -1;
        private PictureBox[] arrayElementPictureBoxes;
        string line;
        public Form1()
        {
            InitializeComponent();
            InitializePanels();
            InitializePictureBoxes();
            //label1
            label1.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(62, 39, 61);

            //label2
            label2.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(62, 39, 61);
            label4.BackColor = Color.FromArgb(163, 132, 160);

            //label3
            label3.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(62, 39, 61);
            label3.BackColor = Color.FromArgb(163, 132, 160);

            //label4
            label4.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(62, 39, 61);

            //button1
            // this.BackColor = Color.FromArgb(166, 149, 168);
            button1.BringToFront();
            button1.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            button1.BackColor = Color.FromArgb(129, 106, 133); // Цвет фона
            button1.ForeColor = Color.FromArgb(62, 39, 61);
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 10, 10));

            button1.MouseEnter += (sender, e) =>
            {
                button1.ForeColor = Color.FromArgb(247, 169, 221);
                button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 78, 97);
                pictureBox2.Visible = true;
            };
            button1.MouseLeave += (sender, e) =>
            {
                button1.ForeColor = Color.FromArgb(62, 39, 61);
                pictureBox2.Visible = false;
            };

            //button2
            this.BackColor = Color.FromArgb(166, 149, 168);
            button2.BringToFront();
            button2.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            button2.BackColor = Color.FromArgb(129, 106, 133); // Цвет фона
            button2.ForeColor = Color.FromArgb(62, 39, 61);
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 10, 10));

            button2.MouseEnter += (sender, e) =>
            {
                button2.ForeColor = Color.FromArgb(247, 169, 221);
                button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 78, 97);
                pictureBox5.Visible = true;
            };
            button2.MouseLeave += (sender, e) =>
            {
                button2.ForeColor = Color.FromArgb(62, 39, 61);
                pictureBox5.Visible = false;
            };

            //button3
            this.BackColor = Color.FromArgb(166, 149, 168);
            button3.BringToFront();
            button3.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            button3.BackColor = Color.FromArgb(129, 106, 133); // Цвет фона
            button3.ForeColor = Color.FromArgb(62, 39, 61);
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 10, 10));

            button3.MouseEnter += (sender, e) =>
            {
                button3.ForeColor = Color.FromArgb(247, 169, 221);
                button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 78, 97);
                pictureBox4.Visible = true;
            };
            button3.MouseLeave += (sender, e) =>
            {
                button3.ForeColor = Color.FromArgb(62, 39, 61);
                pictureBox4.Visible = false;
            };

            //button4
            this.BackColor = Color.FromArgb(166, 149, 168);
            button4.BringToFront();
            button4.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            button4.BackColor = Color.FromArgb(129, 106, 133); // Цвет фона
            button4.ForeColor = Color.FromArgb(62, 39, 61);
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            button4.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width, button4.Height, 10, 10));

            button4.MouseEnter += (sender, e) =>
            {
                button4.ForeColor = Color.FromArgb(247, 169, 221);
                button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 78, 97);
                pictureBox3.Visible = true;
            };
            button4.MouseLeave += (sender, e) =>
            {
                button4.ForeColor = Color.FromArgb(62, 39, 61);
                pictureBox3.Visible = false;
            };

            //textbox1
            textBox1.BackColor = Color.FromArgb(129, 106, 133);
            textBox1.ForeColor = Color.FromArgb(247, 169, 221);
            textBox1.BringToFront();
            textBox1.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox1.Width, textBox1.Height, 10, 10));
            textBox1.MouseEnter +=(sender, e) =>
            {
                textBox1.BackColor = Color.FromArgb(95, 78, 97);
                pictureBox6.Visible = true;
            };
            textBox1.MouseLeave +=(sender, e) =>
            {
                textBox1.BackColor = Color.FromArgb(129, 106, 133);
                pictureBox6.Visible = false;
            };
            //textbox2
            textBox2.BackColor = Color.FromArgb(129, 106, 133);
            textBox2.ForeColor = Color.FromArgb(247, 169, 221);
            textBox2.BringToFront();
            textBox2.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox2.Width, textBox2.Height, 10, 10));
            textBox2.MouseEnter +=(sender, e) =>
            {
                textBox2.BackColor = Color.FromArgb(95, 78, 97);
                pictureBox7.Visible = true;
            };
            textBox2.MouseLeave +=(sender, e) =>
            {
                textBox2.BackColor = Color.FromArgb(129, 106, 133);
                pictureBox7.Visible = false;
            };

            //textbox3
            textBox3.BackColor = Color.FromArgb(129, 106, 133);
            textBox3.ForeColor = Color.FromArgb(247, 169, 221);
            textBox3.BringToFront();
            textBox3.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox3.Width, textBox3.Height, 10, 10));
            textBox3.MouseEnter +=(sender, e) =>
            {
                textBox3.BackColor = Color.FromArgb(95, 78, 97);
                pictureBox8.Visible = true;
            };
            textBox3.MouseLeave +=(sender, e) =>
            {
                textBox3.BackColor = Color.FromArgb(129, 106, 133);
                pictureBox8.Visible = false;
            };

            //pictureBox2
            pictureBox2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox2.Width, pictureBox2.Height, 10, 10));

            //pictureBox3
            pictureBox3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox3.Width, pictureBox3.Height, 10, 10));

            //pictureBox4
            pictureBox4.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox4.Width, pictureBox4.Height, 10, 10));

            //pictureBox5
            pictureBox5.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox5.Width, pictureBox5.Height, 10, 10));

            //pictureBox6
            pictureBox6.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox6.Width, pictureBox6.Height, 10, 10));

            //pictureBox7
            pictureBox7.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox7.Width, pictureBox7.Height, 10, 10));

            //pictureBox8
            pictureBox8.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox8.Width, pictureBox8.Height, 10, 10));

        }
        private Panel leftPanel;
        private Panel rightPanel;
        private void InitializePanels()
        {
            // левая
            leftPanel = new Panel();
            leftPanel.BackColor = Color.FromArgb(166, 149, 168);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Width = this.Width / 2;

            // правая
            rightPanel = new Panel();
            rightPanel.BackColor = Color.FromArgb(163, 132, 160);
            rightPanel.Dock = DockStyle.Right;
            rightPanel.Width = this.Width / 2;

            this.Controls.Add(leftPanel);
            this.Controls.Add(rightPanel);

            this.Resize += MainForm_Resize;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            leftPanel.Width = this.Width / 2;
            rightPanel.Width = this.Width / 2;
        }
        private void TextBox1_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        int arrPic = 0;
        private void InitializePictureBoxes()
        {
            int elementWidth = 40;
            int elementHeight = 40;

            arrayElementPictureBoxes = new PictureBox[arrPic];

            for (int i = 0; i < arrPic; i++)
            {
                arrayElementPictureBoxes[i] = new PictureBox
                {
                    Location = new Point(50 + i * (elementWidth + 10), 330),
                    Size = new Size(elementWidth, elementHeight),
                    BackColor = Color.Pink,
                    BorderStyle = BorderStyle.FixedSingle,
                };
                Label label1 = new Label()
                {
                    Text = array[i].ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                };
                arrayElementPictureBoxes[i].Controls.Add(label1);
                this.Controls.Add(arrayElementPictureBoxes[i]);
                arrayElementPictureBoxes[i].BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (arrayElementPictureBoxes != null)
            {
                foreach (PictureBox pictureBox in arrayElementPictureBoxes)
                {
                    this.Controls.Remove(pictureBox);
                }
            }
            if (ParseInput())
            {
                currentIndex = 0;
                if (arrayElementPictureBoxes.Length > 14 && arrayElementPictureBoxes.Length > 0)
                {

                    foreach (PictureBox pictureBox in arrayElementPictureBoxes)
                    {
                        this.Controls.Remove(pictureBox);
                    }
                    MessageBox.Show("Введите меньше 14 чисел");
                    return;
                }
                InitializePictureBoxes();
                UpdatePictureBoxes();
                VisualizeSearchh();
            }
        }

        private bool ParseInput()
        {
            string[] inputArray = textBox1.Text.Split(',');
            arrPic= inputArray.Length;
            if (inputArray.Length == 0)
            {
                CustomMessageBox msg = new CustomMessageBox("Ошибка ввода чисел. Пожалуйста, введите числа через запятую.");
                msg.ShowDialog();
                return false;
            }

            array = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (!int.TryParse(inputArray[i], out array[i]))
                {
                    CustomMessageBox msg = new CustomMessageBox("Ошибка ввода чисел. Пожалуйста, введите числа через запятую.");
                    msg.ShowDialog();
                    return false;
                }
            }

            if (int.TryParse(textBox2.Text, out var parsedTarget))
            {
                target = parsedTarget;
                return true;
            }
            else
            {
                CustomMessageBox msg = new CustomMessageBox("Ошибка ввода данных для поиска. Пожалуйста, введите корректное число.");
                msg.ShowDialog();
                return false;
            }
        }

        private void VisualizeSearch()
        {
            if (currentIndex >= 0 && currentIndex < array.Length)
            {

                if (array[currentIndex] == target)
                {
                    arrayElementPictureBoxes[currentIndex].BackColor = Color.Red;
                    CustomMessageBox msg = new CustomMessageBox($"Элемент {target} найден в позиции {currentIndex}.");
                    msg.ShowDialog();

                }
                else
                {
                    arrayElementPictureBoxes[currentIndex].BackColor = Color.Pink;
                    currentIndex++;
                    VisualizeSearch();
                }
            }
            else
            {
                CustomMessageBox msg = new CustomMessageBox($"Элемент {target} не найден.");
                msg.ShowDialog();
            }
        }
        private async void VisualizeSearchh()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    arrayElementPictureBoxes[i].BackColor = Color.FromArgb(189, 171, 211);//цвет совпадения
                    ((Label)arrayElementPictureBoxes[i].Controls[0]).Text = array[i].ToString();
                    await Task.Delay(300);
                    CustomMessageBox msg = new CustomMessageBox($"Элемент {target} найден в позиции {i}.");
                    msg.ShowDialog();
                    return;
                }
                else
                {
                    arrayElementPictureBoxes[i].BackColor = Color.FromArgb(255, 204, 236);//цвет несовпадения 
                    ((Label)arrayElementPictureBoxes[i].Controls[0]).Text = array[i].ToString();
                    await Task.Delay(300);
                }
            }
            CustomMessageBox msgg = new CustomMessageBox($"Элемент {target} не найден.");
            msgg.ShowDialog();
        }
        private void UpdatePictureBoxes()
        {
            for (int i = 0; i < arrPic; i++)
            {
                arrayElementPictureBoxes[i].BackColor = Color.White;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.InitialDirectory = "D:\\ЯП 3ий сем\\САОД\\Курсач";
            openFileDialog1.Title = "Выберите файл";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                //"D:\\ЯП 3ий сем\\Разработка приложений в визуальных средах\\лаб 6\\file.txt"
                using (System.IO.StreamReader sr = new System.IO.StreamReader(selectedFilePath))
                {
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string wordToFind = textBox3.Text.ToString();
            if (wordToFind == "")
            {
                label3.Text = "Выберите файл для поиска";
                return;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                label3.Text = "Введите слово для поиска";
                return;
            }
            int pos = 0;
            bool wordFound = false;
            while ((pos = line.IndexOf(wordToFind, pos)) != -1)
            {
                label3.Text = $"Слово найдено на позиции {pos}";
                wordFound = true; // слово было найдено
                pos += wordToFind.Length;
            }
            if (!wordFound)
            {
                label3.Text = "Слово не найдено";
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (PictureBox pictureBox in arrayElementPictureBoxes)
                {
                    this.Controls.Remove(pictureBox);
                }
                // UpdatePictureBoxes();
            }
            catch (IndexOutOfRangeException ex)
            {
                CustomMessageBox msg = new CustomMessageBox("Ошибка ввода чисел. Пожалуйста, введите числа через запятую.");
                msg.ShowDialog();
            }
            catch (Exception ex)
            {
                CustomMessageBox msg = new CustomMessageBox("Ошибка ввода чисел. Пожалуйста, введите числа через запятую.");
                msg.ShowDialog();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
