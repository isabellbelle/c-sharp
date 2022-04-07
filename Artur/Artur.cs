using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Xml;

class Trax : Form {
    Panel panel;
    Button button1;
    // Метод-конструктор нашего класса
    public Trax() {
        // Указываем заголовок окна
        this.Text = "Artur";
        this.Height = 700; this.Width = 950;

        // Добавляем панель для размещения остальных элементов управления
        panel = new Panel();
        panel.Dock = DockStyle.Right;
        panel.BorderStyle = BorderStyle.Fixed3D;
        panel.Height = this.Height - 10;
        panel.Width = this.Width - 10;
        panel.Top = -10;
        panel.Left = -10;
        this.Controls.Add(panel);
        
        // Добавляем кнопку в коллекцию элементов управления формы
        // Хотя на кнопке написано: "Нажми меня!",
        // пока при нажатии ничего не происходит!
        button1 = new Button();
        button1.Font = new Font("Arial", 18);
        button1.Text = "Трахнуть!";
        button1.Top = 125;
        button1.Left = 387;
        button1.Height = 100;
        button1.Width = 225;
        // button1.BackColor = Color.Red;
        // button1.BackColor = Color.FromArgb(207, 169, 97);
        button1.BackColor = Color.FromArgb(207, 60, 60);
        button1.ForeColor = Color.White;
        panel.Controls.Add(button1);

        // Создадим элемент PictureBox, поместим в него изображение,
        // добавим его на форму
        PictureBox Artur = new PictureBox();
        Artur.SizeMode = PictureBoxSizeMode.StretchImage;
        Bitmap image1 = new Bitmap ("Artur.jpg");
        Artur.ClientSize = new Size(320, 240);
        Artur.Top = 400;
        Artur.Left = 481;
        Artur.Image = (Image)image1;
        panel.Controls.Add(Artur);

        // Создадим элемент PictureBox, поместим в него изображение,
        // добавим его на форму
        PictureBox Artur_p = new PictureBox();
        Artur_p.SizeMode = PictureBoxSizeMode.StretchImage;
        Bitmap image2 = new Bitmap ("Artur-p.jpg");
        Artur_p.ClientSize = new Size(180, 240);
        Artur_p.Top = 50;
        Artur_p.Left = 750;
        Artur_p.Image = (Image)image2;
        panel.Controls.Add(Artur_p);

        // Создадим элемент PictureBox, поместим в него изображение,
        // добавим его на форму
        PictureBox Artur_p2 = new PictureBox();
        Artur_p2.SizeMode = PictureBoxSizeMode.StretchImage;
        Bitmap image3 = new Bitmap ("Artur-p2.jpg");
        Artur_p2.ClientSize = new Size(360, 480);
        Artur_p2.Top = 18;
        Artur_p2.Left = 10;
        Artur_p2.Image = (Image)image3;
        panel.Controls.Add(Artur_p2);

        button1.Click += new EventHandler(button1_Click);
    }
    void button1_Click(object sender, EventArgs e) {
        panel.Controls.Clear();

        // Создадим элемент PictureBox, поместим в него изображение,
        // добавим его на форму
        PictureBox s = new PictureBox();
        s.SizeMode = PictureBoxSizeMode.StretchImage;
        Bitmap image5 = new Bitmap ("s.jpg");
        s.ClientSize = new Size(230, 150);
        s.Top = 475;
        s.Left = 10;
        s.Image = (Image)image5;
        panel.Controls.Add(s);

        // Создадим элемент PictureBox, поместим в него изображение,
        // добавим его на форму
        PictureBox s_2 = new PictureBox();
        s_2.SizeMode = PictureBoxSizeMode.StretchImage;
        Bitmap image6 = new Bitmap ("s-2.jpg");
        s_2.ClientSize = new Size(230, 140);
        s_2.Top = 400;
        s_2.Left = 700;
        s_2.Image = (Image)image6;
        panel.Controls.Add(s_2);
            
        // Добавляем на панель метку
        Label label1 = new Label();
        label1.Text = "Вы трахнули Артура!";
        label1.Font = new Font("Times New Roman", 38);
        
        label1.Location = new Point(225, 400);
        label1.Width = 520;
        label1.Height = 60;
        // label1.Click += new EventHandler(label1_Click);
        // label1.BackColor = Color.FromArgb(207, 60, 60);
        label1.BackColor = Color.White;
        label1.ForeColor = Color.Green;
        panel.Controls.Add(label1);
        
        // Создадим элемент PictureBox, поместим в него изображение,
        // добавим его на форму
        PictureBox Cngt = new PictureBox();
        Cngt.SizeMode = PictureBoxSizeMode.StretchImage;
        Bitmap image4 = new Bitmap ("Cngt.jpg");
        Cngt.ClientSize = new Size(this.Width, this.Height);
        Cngt.Top = 0;
        Cngt.Left = 0;
        Cngt.Image = (Image)image4;
        panel.Controls.Add(Cngt);

        }
    static void Main() {
        // Создаем и запускаем форму
        Application.Run(new Trax());
    }
}
