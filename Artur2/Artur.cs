using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Xml;

class Trax : Form {
    TableLayoutPanel panel;
    Button button;

    public static void image() {
        // Bitmap imgsp = new Bitmap ("sp.jpg");
        Bitmap image1 = new Bitmap ("1.jpg"); // У тебя есть 10 секунд...
        Bitmap image2 = new Bitmap ("2.jpg"); // Романтичный
        Bitmap image3 = new Bitmap ("3.jpg"); // Квадратный
        Bitmap image4 = new Bitmap ("4.jpg"); // 2D
        Bitmap image5 = new Bitmap ("5.jpg"); // Решает вопросы
        Bitmap image6 = new Bitmap ("6.jpg"); // Внепланетный
        Bitmap image7 = new Bitmap ("7.jpg"); // С активистом
        Bitmap image8 = new Bitmap ("8.jpg"); // Гей
        Bitmap image9 = new Bitmap ("9.jpg"); // Спящий
        Bitmap image10 = new Bitmap ("10.jpg"); // В цветах
        Bitmap image11 = new Bitmap ("11.jpg"); // С пацанами
        Bitmap image12 = new Bitmap ("12.jpg"); // Wide
        Bitmap image13 = new Bitmap ("13.jpg"); // На солнце
        Bitmap image14 = new Bitmap ("14.jpg"); // С кисами
        Bitmap image15 = new Bitmap ("15.jpg"); // Игривый
        Bitmap image16 = new Bitmap ("16.jpg"); // В теплой постели
        Bitmap image17 = new Bitmap ("17.jpg"); // Без Артура
        Bitmap image18 = new Bitmap ("18.jpg");
        Bitmap image18_2 = new Bitmap ("18-2.jpg");
        Bitmap image19 = new Bitmap ("19.jpg"); // Лисичка
        Bitmap image20 = new Bitmap ("20.jpg"); // Сильный
        Bitmap image21 = new Bitmap ("21.jpg"); // ...
        Bitmap image22 = new Bitmap ("22.jpg"); // После душа
        Bitmap image23 = new Bitmap ("23.jpg"); // Серьезный
        Bitmap image24 = new Bitmap ("24.jpg"); // Опасный
        Bitmap image25 = new Bitmap ("25.jpg"); // Горилла
        Bitmap image26 = new Bitmap ("26.jpg"); // Природе
    }
    
    // Метод-конструктор нашего класса
    public Trax() {
        // Указываем заголовок окна
        this.Text = "Artur";
        this.Height = 700; this.Width = 950;

        // Добавляем панель для размещения остальных элементов управления
		panel = new TableLayoutPanel ();
		panel.AutoScroll = true;
		panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		panel.ColumnCount = 5;
		panel.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 20F));
		panel.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 10F));
		panel.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 40F));
		panel.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 10F));
		panel.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 20F));
		panel.Dock = DockStyle.Fill;
		panel.RowCount = 5;
		panel.RowStyles.Add (new RowStyle (SizeType.Percent, 10F));
		panel.RowStyles.Add (new RowStyle (SizeType.Percent, 40F));
		panel.RowStyles.Add (new RowStyle (SizeType.Percent, 25F));
		panel.RowStyles.Add (new RowStyle (SizeType.Percent, 20F));
		panel.RowStyles.Add (new RowStyle (SizeType.Percent, 5F));
		panel.TabIndex = 0;
        panel.BackColor = Color.FromArgb(247, 240, 190);
		this.Controls.Add(panel);

        // Добавляем кнопку в коллекцию элементов управления формы
        // Хотя на кнопке написано: "Нажми меня!",
        // пока при нажатии ничего не происходит!
        button = new Button();
		button.Dock = DockStyle.Fill;
        button.Font = new Font("Arial", button.Width/2);
        button.Text = "Начать!";
        button.BackColor = Color.Green;
        button.ForeColor = Color.White;
        panel.Controls.Add(button, 2, 2);

        // Создадим элемент PictureBox, поместим в него изображение,
        // добавим его на форму
        PictureBox sp = new PictureBox();
        sp.SizeMode = PictureBoxSizeMode.StretchImage;
        Bitmap imgsp = new Bitmap ("img/sp.jpg");
		sp.Dock = DockStyle.Top;
        sp.Height = this.Width*3/5;
        sp.Image = (Image)imgsp;
        panel.Controls.Add(sp, 1, 1);
        this.panel.SetColumnSpan(sp, 3);

        // Добавляем на панель метку
        Label label = new Label();
		label.Dock = DockStyle.Top;
        label.BorderStyle = BorderStyle.FixedSingle;
        label.Height = this.Height/25;
        label.Text = "Made by isabelle. (tap here)";
        label.Font = new Font("Times New Roman", 10);
        label.Click += new EventHandler(label_Click);
        // label.BackColor = Color.FromArgb(207, 60, 60);
        label.BackColor = Color.FromArgb(247, 240, 190);
        label.ForeColor = Color.Black;
        panel.Controls.Add(label, 4, 4);

    }
    void label_Click(object sender, System.EventArgs e) {
        MessageBox.Show ("https://github.com/isabellbelle");
    }
    static void Main() {
        // Создаем и запускаем форму
        Application.Run(new Trax());
    }
}
