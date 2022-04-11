using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Xml;

class Trax : Form {
    TableLayoutPanel panel; // на thispnl
    TableLayoutPanel paneltabl; // на thispnl
    TableLayoutPanel panelvr; // на paneltabl
    TableLayoutPanel panelimg; // на paneltabl
    TableLayoutPanel paneltxt; // на paneltabl
    TableLayoutPanel thispnl; // на this
    Button button;
    Button btn;
    Button buttonl;
    Button buttonc;
    Button buttonr;
    Int32 numch;
    string [] arraych;

    string [] image() {
        
        string [] arraych = {"18-2.jpg", "У тебя есть 10 секунд...", "Романтичный",
        "Квадратный", "2D", "Решает вопросы", "Внепланетарный", "С активистом",
        "Гей", "Спящий", "В цветах", "С пацанами (не геи)", "Wide", "На солнце", "С кисами",
        "Игривый", "После сна", "Без Артура", "18-2.jpg", "Лисичка", "За мир",
        "...", "После душа", "Серьезный", "Опасный", "Горилла", "Фото для мамы"};

/*
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
        Bitmap image16 = new Bitmap ("16.jpg"); // После сна
        Bitmap image17 = new Bitmap ("17.jpg"); // Без Артура
        Bitmap image18 = new Bitmap ("18.jpg");
        Bitmap image18_2 = new Bitmap ("18-2.jpg");
        Bitmap image19 = new Bitmap ("19.jpg"); // Лисичка
        Bitmap image20 = new Bitmap ("20.jpg"); // За мир
        Bitmap image21 = new Bitmap ("21.jpg"); // ...
        Bitmap image22 = new Bitmap ("22.jpg"); // После душа
        Bitmap image23 = new Bitmap ("23.jpg"); // Серьезный
        Bitmap image24 = new Bitmap ("24.jpg"); // Опасный
        Bitmap image25 = new Bitmap ("25.jpg"); // Горилла
        Bitmap image26 = new Bitmap ("26.jpg"); // Фото для мамы
*/
        return arraych;
    }
    
    // Метод-конструктор нашего класса
    public Trax() {
        // Указываем заголовок окна
        this.Text = "Artur";
        this.Height = 700; this.Width = 950;
        
		thispnl = new TableLayoutPanel ();
		thispnl.ColumnCount = 2;
		thispnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
		thispnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
		thispnl.Dock = DockStyle.Fill;
		thispnl.RowCount = 2;
		thispnl.RowStyles.Add(new RowStyle(SizeType.Percent, 95F));
		thispnl.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
        Controls.Add(thispnl);
        // Добавляем на панель метку
        label_inf();
        panel_bgn();
        this.thispnl.Controls.Add(panel, 0, 0);
        this.thispnl.SetColumnSpan(panel, 2);
        // Добавляем панель
        // panel_bgn();

    }

    void label_Click(object sender, System.EventArgs e) {
        MessageBox.Show ("https://github.com/isabellbelle");
    }

    void label_inf() {
        // Добавляем на панель метку
        Label label = new Label();
		label.Dock = DockStyle.Top;
        label.BorderStyle = BorderStyle.FixedSingle;
        label.Height = this.Height/25;
        label.Text = "Made by isabelle. (tap here)";
        label.Font = new Font("Times New Roman", 10);
        // label.BackColor = Color.FromArgb(207, 60, 60);
        // label.BackColor = Color.FromArgb(247, 240, 190);
        label.BackColor = Color.White;
        label.ForeColor = Color.Black;
        label.Click += new EventHandler(label_Click);
        
        // TableLayoutPanel panelx= new TableLayoutPanel();
        // panelx.Name = "panel";
        thispnl.Controls.Add(label, 1, 1);
    }

    void panel_bgn() { // thispnl на panel
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
		thispnl.Controls.Add(panel, 0, 0);

        // Добавляем кнопку в коллекцию элементов управления формы
        button = new Button();
		button.Dock = DockStyle.Fill;
        button.Font = new Font("Arial", button.Width/2);
        button.Text = "Начать!";
        button.BackColor = Color.Green;
        button.ForeColor = Color.White;
        panel.Controls.Add(button, 2, 2);
        button.Click += new EventHandler(button1_Click);

        // Создадим элемент PictureBox, поместим в него изображение,
        // добавим его на форму
        PictureBox sp = new PictureBox();
        sp.SizeMode = PictureBoxSizeMode.StretchImage;
        Bitmap imgsp = new Bitmap ("img/sp.jpg");
		sp.Dock = DockStyle.Top;
        sp.Height = this.Width*3/5;
        sp.Image = (Image)imgsp;
        panel.Controls.Add(sp, 1, 1);
        panel.SetColumnSpan(sp, 3);

     }

    void panel_tabl() { // paneltabl на thispanel
        // Добавляем панель для размещения остальных элементов управления
		paneltabl = new TableLayoutPanel ();
		paneltabl.AutoScroll = true;
		paneltabl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		paneltabl.ColumnCount = 1;
		paneltabl.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 100F));
		paneltabl.Dock = DockStyle.Fill;
		paneltabl.RowCount = 7;
		paneltabl.RowStyles.Add (new RowStyle (SizeType.Percent, 4F));
		paneltabl.RowStyles.Add (new RowStyle (SizeType.Percent, 11F));
		paneltabl.RowStyles.Add (new RowStyle (SizeType.Percent, 4F));
		paneltabl.RowStyles.Add (new RowStyle (SizeType.Percent, 60F));
		paneltabl.RowStyles.Add (new RowStyle (SizeType.Percent, 2F));
		paneltabl.RowStyles.Add (new RowStyle (SizeType.Percent, 15F));
		paneltabl.RowStyles.Add (new RowStyle (SizeType.Percent, 4F));
		paneltabl.TabIndex = 0;
        paneltabl.BackColor = Color.FromArgb(210,210,230);
		thispnl.Controls.Add(paneltabl);
        
        this.thispnl.Controls.Add(paneltabl, 0, 0);
        this.thispnl.SetColumnSpan(paneltabl, 2);
     }

    void panel_vr() { // панель с кнопками на paneltabl
        // Добавляем панель для размещения остальных элементов управления
		panelvr = new TableLayoutPanel ();
		panelvr.AutoScroll = true;
		panelvr.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		panelvr.ColumnCount = 7;
		panelvr.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 5F));
		panelvr.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 30F));
		panelvr.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 5F));
		panelvr.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 20F));
		panelvr.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 5F));
		panelvr.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 30F));
		panelvr.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 5F));
		panelvr.Dock = DockStyle.Fill;
		panelvr.RowCount = 1;
		panelvr.RowStyles.Add (new RowStyle (SizeType.Percent, 100F));
		panelvr.TabIndex = 0;
        panelvr.BackColor = Color.FromArgb(210 ,210, 230);
		paneltabl.Controls.Add(panelvr, 0, 5);

        buttonl = new Button();
		buttonl.Dock = DockStyle.Fill;
        buttonl.Font = new Font("Arial", buttonl.Width/2);
        buttonl.Text = "<-";
        buttonl.BackColor = Color.Blue;
        buttonl.ForeColor = Color.White;
        panelvr.Controls.Add(buttonl, 1, 0);
        buttonl.Click += new EventHandler(ClickL);

        buttonc = new Button();
		buttonc.Dock = DockStyle.Fill;
        buttonc.Font = new Font("Arial", buttonc.Width/2);
        buttonc.Text = "v";
        buttonc.BackColor = Color.Green;
        buttonc.ForeColor = Color.White;
        panelvr.Controls.Add(buttonc, 3, 0);
        buttonc.Click += new EventHandler(MakeChs);

        buttonr = new Button();
		buttonr.Dock = DockStyle.Fill;
        buttonr.Font = new Font("Arial", buttonr.Width/2);
        buttonr.Text = "->";
        buttonr.BackColor = Color.Blue;
        buttonr.ForeColor = Color.White;
        panelvr.Controls.Add(buttonr, 5, 0);
        buttonr.Click += new EventHandler(ClickR);
     }

    void panel_txt() { // панель с подписью
        // Добавляем панель для размещения остальных элементов управления
		paneltxt = new TableLayoutPanel ();
		paneltxt.AutoScroll = true;
		paneltxt.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		paneltxt.ColumnCount = 3;
		paneltxt.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 20F));
		paneltxt.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 60F));
		paneltxt.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 20F));
		paneltxt.Dock = DockStyle.Fill;
		paneltxt.RowCount = 1;
		paneltxt.RowStyles.Add (new RowStyle (SizeType.Percent, 100F));
		paneltxt.TabIndex = 0;
        paneltxt.BackColor = Color.FromArgb(210, 210, 230);
		paneltabl.Controls.Add(paneltxt, 0, 1);

        // // добавление метки
        // AddTxt(1);
    }
    void panel_img() { // панель с *.jpg
        // Добавляем панель для размещения остальных элементов управления
		panelimg = new TableLayoutPanel ();
		panelimg.AutoScroll = true;
		panelimg.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		panelimg.ColumnCount = 3;
		panelimg.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 30F));
		panelimg.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 40F));
		panelimg.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 30F));
		panelimg.Dock = DockStyle.Fill;
		panelimg.RowCount = 1;
		panelimg.RowStyles.Add (new RowStyle (SizeType.Percent, 100F));
		panelimg.TabIndex = 0;
        panelimg.BackColor = Color.FromArgb(210, 210, 230);
		paneltabl.Controls.Add(panelimg, 0, 3);

        // // Создадим элемент PictureBox, поместим в него изображение,
        // // добавим его на форму
        // AddImg(8);
     }

    void button1_Click(object sender, EventArgs e) {
        panel.Visible = false;

        btn = new Button();
		btn.Dock = DockStyle.Fill;
        btn.Font = new Font("Arial", btn.Width/2);
        btn.Text = "->";
        btn.BackColor = Color.FromArgb(200, 200, 200);
        btn.ForeColor = Color.FromArgb(150, 150, 200);
        thispnl.Controls.Add(btn, 0, 0);
        this.thispnl.SetColumnSpan(btn, 2);
        btn.Click += new EventHandler(button2_Click);

        numch = NumCh(numch, 1);
    }
    
    void button2_Click(object sender, EventArgs e) {
        btn.Visible = false;
        arraych = image();
        panel_tabl();
        panel_vr();
        panel_txt();
        panel_img();
        // numch = NumCh(numch, 1);
        AddImg(1);
        AddTxt(1);
    }

	void AddImg (int num) {
	// 	Button button = new Button ();
	// 	button.Dock = DockStyle.Top;
	// 	button.Height = 200;
	// 	button.Text = row.ToString ();
	// 	button.Click += new EventHandler (Button_Click);
	// 	_tableLayoutPanel.Controls.Add (button, 2, row);

        PictureBox imagech = new PictureBox();
        imagech.SizeMode = PictureBoxSizeMode.StretchImage;
        string strimgname = "img/" + num + ".jpg";
        Bitmap imagechjpg = new Bitmap(strimgname);
		imagech.Dock = DockStyle.Fill;
        imagech.Image = (Image)imagechjpg;
        panelimg.Controls.Add(imagech, 1, 0);
	// 	imagech.Click += new EventHandler(Image_Click);
	}

	void AddTxt (int num) {
        if (num != 18) {
            Label labelpnl = new Label();
            labelpnl.Dock = DockStyle.Top;
            labelpnl.BorderStyle = BorderStyle.FixedSingle;
            labelpnl.Dock = DockStyle.Fill;
            String strtxtname = arraych[num];
            // String strtxtname = "У тебя есть 10 секунд...";
            labelpnl.Text = strtxtname;
            labelpnl.Font = new Font("Times New Roman", 38);
            // label.BackColor = Color.FromArgb(207, 60, 60);
            // label.BackColor = Color.FromArgb(247, 240, 190);
            labelpnl.BackColor = Color.White;
            labelpnl.ForeColor = Color.Black;
            paneltxt.Controls.Add(labelpnl, 1, 0);
        // 	labelpnl.Click += new EventHandler(Label_Click);
        } else {
            PictureBox imagech = new PictureBox();
            imagech.SizeMode = PictureBoxSizeMode.StretchImage;
            string strimgname = "img/" + arraych[0];
            Bitmap imagechtxt = new Bitmap(strimgname);
            imagech.Dock = DockStyle.Fill;
            imagech.Image = (Image)imagechtxt;
            paneltxt.Controls.Add(imagech, 1, 0);
	    // 	imagech.Click += new EventHandler(Image_Click);
        }
	}

	void ClickR(object sender, EventArgs args) {
		// ((Control) sender).Visible = false;
		panelimg.Controls.Clear();
		paneltxt.Controls.Clear();

        // Создадим элемент PictureBox, поместим в него изображение,
        // добавим его на форму
        numch = NumCh(numch, 1);
        AddImg(numch);
        AddTxt(numch);
        // Console.Write("{0} ", numch);
	}

	void MakeChs(object sender, EventArgs args) {
		// ((Control) sender).Visible = false;
        string strchs = "Artur " + arraych[numch];
        MessageBox.Show(strchs, "Ваш выбор:");

		paneltabl.Visible = false;

        // Console.Write("{0} ", numch);
	}

	void ClickL(object sender, EventArgs args) {
		// ((Control) sender).Visible = false;
		panelimg.Controls.Clear();
		paneltxt.Controls.Clear();

        // Создадим элемент PictureBox, поместим в него изображение,
        // добавим его на форму
        numch = NumCh(numch, -1);
        AddImg(numch);
        AddTxt(numch);
        Console.Write("{0} ", numch);
	}
    
    int NumCh(int numch, int b) {
        numch = (numch + b + 25)%26 + 1;
        return numch;
    }

    /*
    void panel_1() {
        // Добавляем панель для размещения остальных элементов управления
		panel1 = new TableLayoutPanel ();
		panel1.AutoScroll = true;
		panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		panel1.ColumnCount = 5;
		panel1.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 20F));
		panel1.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 10F));
		panel1.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 40F));
		panel1.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 10F));
		panel1.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 20F));
		panel1.Dock = DockStyle.Fill;
		panel1.RowCount = 5;
		panel1.RowStyles.Add (new RowStyle (SizeType.Percent, 10F));
		panel1.RowStyles.Add (new RowStyle (SizeType.Percent, 40F));
		panel1.RowStyles.Add (new RowStyle (SizeType.Percent, 25F));
		panel1.RowStyles.Add (new RowStyle (SizeType.Percent, 20F));
		panel1.RowStyles.Add (new RowStyle (SizeType.Percent, 5F));
		panel1.TabIndex = 0;
        panel1.BackColor = Color.FromArgb(247, 240, 190);
		this.Controls.Add(panel1);

        button = new Button();
		button.Dock = DockStyle.Fill;
        button.Font = new Font("Arial", button.Width/2);
        button.Text = "Начать!";
        button.BackColor = Color.Green;
        button.ForeColor = Color.White;
        panel.Controls.Add(button, 2, 2);
        button.Click += new EventHandler(button1_Click);

        // Добавляем на панель метку
        // label_inf();
     }
*/

    static void Main() {
        // Создаем и запускаем форму
        Application.Run(new Trax());
    }
}
