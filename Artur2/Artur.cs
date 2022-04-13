using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Xml;

// using System;
using System.Collections.Generic;
using System.ComponentModel;
// using System.Data;
// using System.Drawing;
using System.Linq;
using System.Text;
// using System.Windows.Forms;
using System.Drawing.Drawing2D;//add this namespace

// namespace shapes

class Trax : Form {
    Panel window; // на thispnl
    TableLayoutPanel panel; // на thispnl
    TableLayoutPanel paneltabl; // на window
    TableLayoutPanel panelvr; // на paneltabl
    TableLayoutPanel panelimg; // на paneltabl
    TableLayoutPanel paneltxt; // на paneltabl
    TableLayoutPanel thispnl; // на this
    TableLayoutPanel mkchspnl; // на window
    TableLayoutPanel paneldng; // на window
    TableLayoutPanel paneldnglbl; // на paneldng
    TableLayoutPanel endpnl; // на paneldng
    TableLayoutPanel cngtpnl; // на window
    Button button;
    Button btn;
    Button buttonl;
    Button buttonc;
    Button buttonx;
    Button buttonr;
    Button buttonred;
    Button buttonylw;
    Button buttongrn;
    Int32 numch;
    TextBox textBox1;
    TextBox textBox2;
    TextBox textBox3;
    string [] arraych;
    string prt;
    string prt1;
    string txt1;

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
        this_bgn();
        label_inf();

        makeell();

        panel_bgn();
        button_bgn();
        image_bgn();
    }

    void this_bgn() {
        // Указываем заголовок окна
        this.Text = "Artur";
        this.Height = 700; this.Width = 950;
        
		thispnl = new TableLayoutPanel();
		thispnl.ColumnCount = 2;
		thispnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
		thispnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
		thispnl.Dock = DockStyle.Fill;
		thispnl.RowCount = 2;
		thispnl.RowStyles.Add(new RowStyle(SizeType.Percent, 95F));
		thispnl.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
        Controls.Add(thispnl);

        window = new Panel();
		window.Dock = DockStyle.Fill;
        this.thispnl.Controls.Add(window, 0, 0);
        this.thispnl.SetColumnSpan(window, 2);
    }

    void label_Click(object sender, System.EventArgs e) {
        MessageBox.Show ("https://github.com/isabellbelle");
    }

    void label_inf() {
        Label label = new Label();
		label.Dock = DockStyle.Top;
        label.BorderStyle = BorderStyle.FixedSingle;
        label.Height = this.Height/25;
        label.Text = "Made by isabelle. (tap here)";
        label.Font = new Font("Times New Roman", 10);
        label.BackColor = Color.White;
        label.ForeColor = Color.Black;
        label.Click += new EventHandler(label_Click);
        
        thispnl.Controls.Add(label, 1, 1);
    }

    void panel_bgn() {
		panel = new TableLayoutPanel();
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
		window.Controls.Add(panel);
    }

    void image_bgn() {
        PictureBox sp = new PictureBox();
        sp.SizeMode = PictureBoxSizeMode.StretchImage;
        Bitmap imgsp = new Bitmap ("img/sp.jpg");
		sp.Dock = DockStyle.Top;
        sp.Height = this.Width*3/5;
        sp.Image = (Image)imgsp;
        panel.Controls.Add(sp, 1, 1);
        panel.SetColumnSpan(sp, 3);
    }

    void button_bgn() { // вызов button1_Click
        // Добавляем кнопку в коллекцию элементов управления формы
        button = new Button();
		button.Dock = DockStyle.Fill;
        button.Font = new Font("Arial", button.Width/2);
        button.Text = "Начать!";
        button.BackColor = Color.Green;
        button.ForeColor = Color.White;
        panel.Controls.Add(button, 2, 2);
        button.Click += new EventHandler(button1_Click);
    }

    void makeell() {}

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
		paneltabl.RowStyles.Add (new RowStyle (SizeType.Percent, 2F));
		paneltabl.RowStyles.Add (new RowStyle (SizeType.Percent, 60F));
		paneltabl.RowStyles.Add (new RowStyle (SizeType.Percent, 1F));
		paneltabl.RowStyles.Add (new RowStyle (SizeType.Percent, 20F));
		paneltabl.RowStyles.Add (new RowStyle (SizeType.Percent, 2F));
		paneltabl.TabIndex = 0;
        paneltabl.BackColor = Color.FromArgb(215,220,210);
		window.Controls.Add(paneltabl);
        
        // this.thispnl.Controls.Add(paneltabl, 0, 0);
        // this.thispnl.SetColumnSpan(paneltabl, 2);
    }

    void panel_vr() { // панель с кнопками на paneltabl
        // Добавляем панель для размещения остальных элементов управления
		panelvr = new TableLayoutPanel ();
		panelvr.AutoScroll = true;
		panelvr.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		panelvr.ColumnCount = 9;
		panelvr.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 5F));
		panelvr.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 30F));
		panelvr.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 3F));
		panelvr.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 10.5F));
		panelvr.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 3F));
		panelvr.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 10.5F));
		panelvr.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 3F));
		panelvr.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 30F));
		panelvr.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 5F));
		panelvr.Dock = DockStyle.Fill;
		panelvr.RowCount = 3;
		panelvr.RowStyles.Add (new RowStyle (SizeType.Percent, 10F));
		panelvr.RowStyles.Add (new RowStyle (SizeType.Percent, 80F));
		panelvr.RowStyles.Add (new RowStyle (SizeType.Percent, 10F));
		panelvr.TabIndex = 0;
        // panelvr.BackColor = Color.FromArgb(215,220,210);
		paneltabl.Controls.Add(panelvr, 0, 5);

        buttonl = new Button();
		buttonl.Dock = DockStyle.Fill;
        buttonl.Font = new Font("Arial", buttonl.Width/2);
        buttonl.Text = "<-";
        buttonl.BackColor = Color.Blue;
        buttonl.ForeColor = Color.White;
        panelvr.Controls.Add(buttonl, 1, 0);
        panelvr.SetRowSpan(buttonl, 3);
        buttonl.Click += new EventHandler(ClickL);

        buttonc = new Button();
		buttonc.Dock = DockStyle.Fill;
        buttonc.Font = new Font("Arial", buttonc.Width/2);
        buttonc.Text = "v";
        buttonc.BackColor = Color.Green;
        buttonc.ForeColor = Color.White;
        panelvr.Controls.Add(buttonc, 5, 1);
        buttonc.Click += new EventHandler(MakeChs);

        buttonx = new Button();
		buttonx.Dock = DockStyle.Fill;
        buttonx.Font = new Font("Arial", buttonx.Width/2);
        buttonx.Text = "x";
        buttonx.BackColor = Color.Red;
        buttonx.ForeColor = Color.White;
        panelvr.Controls.Add(buttonx, 3, 1);
        buttonx.Click += new EventHandler(End);

        buttonr = new Button();
		buttonr.Dock = DockStyle.Fill;
        buttonr.Font = new Font("Arial", buttonr.Width/2);
        buttonr.Text = "->";
        buttonr.BackColor = Color.Blue;
        buttonr.ForeColor = Color.White;
        panelvr.Controls.Add(buttonr, 7, 0);
        buttonr.Click += new EventHandler(ClickR);
        panelvr.SetRowSpan(buttonr, 3);
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
        // paneltxt.BackColor = Color.FromArgb(215,220,210);
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
        // panelimg.BackColor = Color.FromArgb(215,220,210);
		paneltabl.Controls.Add(panelimg, 0, 3);

        // // Создадим элемент PictureBox, поместим в него изображение,
        // // добавим его на форму
        // AddImg(8);
     }

    void button1_Click(object sender, EventArgs e) { // вызов button1_Click, image()
        window.Controls.Clear();

        arraych = image();

        btn = new Button();
		btn.Dock = DockStyle.Fill;
        btn.Font = new Font("Arial", btn.Width*2);
        btn.Text = "->";
        btn.BackColor = Color.FromArgb(230, 230, 230);
        btn.ForeColor = Color.White;
        window.Controls.Add(btn);
        btn.Click += new EventHandler(button2_Click);

        // numch = NumCh(numch, 1);
        numch = 1;
    }
    
    
    // вызов panel_tabl, panel_vr, panel_txt, panel_img, AddImg, AddTxt
    void button2_Click(object sender, EventArgs e) {
        window.Controls.Clear();

        panel_tabl();
        panel_vr();
        panel_txt();
        panel_img();

        AddImg(numch);
        AddTxt(numch);
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

        MakeChsPnl();
        MakeChsBtn();

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
        // Console.Write("{0} ", numch);
	}
    
    int NumCh(int numch, int b) {
        numch = (numch + b + 25)%26 + 1;
        return numch;
    }

	void MakeChsPnl(){
		mkchspnl = new TableLayoutPanel();
		mkchspnl.AutoScroll = true;
		mkchspnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		mkchspnl.ColumnCount = 2;
		mkchspnl.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 50F));
		mkchspnl.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 50F));
		mkchspnl.Dock = DockStyle.Fill;
		mkchspnl.RowCount = 2;
		mkchspnl.RowStyles.Add (new RowStyle (SizeType.Percent, 2F));
		mkchspnl.RowStyles.Add (new RowStyle (SizeType.Percent, 98F));
		mkchspnl.TabIndex = 0;
        mkchspnl.BackColor = Color.FromArgb(220, 220, 220);
		window.Controls.Add(mkchspnl);
	}
    
	void MakeChsBtn() {
        btn = new Button();
		btn.Dock = DockStyle.Fill;
        btn.Font = new Font("Arial", btn.Width*2);
        btn.Text = "<-";
        btn.BackColor = Color.FromArgb(230, 200, 200);
        btn.ForeColor = Color.FromArgb(90, 50, 50);
        mkchspnl.Controls.Add(btn, 0, 1);
        btn.Click += new EventHandler(button2_Click);
        
        Button btnr;
        btnr = new Button();
		btnr.Dock = DockStyle.Fill;
        btnr.Font = new Font("Arial", btnr.Width*2);
        btnr.Text = "->";
        btnr.BackColor = Color.FromArgb(200, 230, 200);
        btnr.ForeColor = Color.FromArgb(50, 90, 50);
        mkchspnl.Controls.Add(btnr, 1, 1);
        btnr.Click += new EventHandler(DngPnl);
    }
    
    void DngPnl(object sender, EventArgs args) {
        window.Controls.Clear();
        // Добавляем панель для размещения остальных элементов управления
		paneldng = new TableLayoutPanel ();
		paneldng.AutoScroll = true;
		paneldng.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		paneldng.ColumnCount = 1;
		paneldng.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 100F));
		paneldng.Dock = DockStyle.Fill;
		paneldng.RowCount = 7;
		paneldng.RowStyles.Add (new RowStyle (SizeType.Percent, 3F));
		paneldng.RowStyles.Add (new RowStyle (SizeType.Percent, 50F));
		paneldng.RowStyles.Add (new RowStyle (SizeType.Percent, 2F));
		paneldng.RowStyles.Add (new RowStyle (SizeType.Percent, 19F));
		paneldng.RowStyles.Add (new RowStyle (SizeType.Percent, 2F));
		paneldng.RowStyles.Add (new RowStyle (SizeType.Percent, 21F));
		paneldng.RowStyles.Add (new RowStyle (SizeType.Percent, 3F));
		paneldng.TabIndex = 0;
        paneldng.BackColor = Color.FromArgb(240, 245, 240);
		window.Controls.Add(paneldng);

        button = new Button();
		button.Dock = DockStyle.Fill;
        button.Font = new Font("Arial", button.Width/2);
        button.Text = "Выполнить!";
        button.BackColor = Color.Green;
        button.ForeColor = Color.White;
        paneldng.Controls.Add(button, 0, 5);
        button.Click += new EventHandler(button_Click1);

        DngPnlLbl();
		paneldng.Controls.Add(panelimg, 0, 1);
    }
    
    void DngPnlLbl() { // панель с подписью
        // Добавляем панель для размещения остальных элементов управления
		paneldnglbl = new TableLayoutPanel ();
		paneldnglbl.AutoScroll = true;
		paneldnglbl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		paneldnglbl.ColumnCount = 9;
		paneldnglbl.ColumnStyles.Add (new ColumnStyle(SizeType.Percent, 3F));
		paneldnglbl.ColumnStyles.Add (new ColumnStyle(SizeType.Percent, 25F));
		paneldnglbl.ColumnStyles.Add (new ColumnStyle(SizeType.Percent, 3F));
		paneldnglbl.ColumnStyles.Add (new ColumnStyle(SizeType.Percent, 25F));
		paneldnglbl.ColumnStyles.Add (new ColumnStyle(SizeType.Percent, 3F));
		paneldnglbl.ColumnStyles.Add (new ColumnStyle(SizeType.Percent, 25F));
		paneldnglbl.ColumnStyles.Add (new ColumnStyle(SizeType.Percent, 3F));
		paneldnglbl.ColumnStyles.Add (new ColumnStyle(SizeType.Percent, 13F));
		paneldnglbl.ColumnStyles.Add (new ColumnStyle(SizeType.Percent, 1F));
		paneldnglbl.Dock = DockStyle.Fill;
		paneldnglbl.RowCount = 1;
		paneldnglbl.RowStyles.Add (new RowStyle (SizeType.Percent, 100F));
		paneldnglbl.TabIndex = 0;
        // paneldnglbl.BackColor = Color.FromArgb(215,220,210);
		paneldng.Controls.Add(paneldnglbl, 0, 3);
        
        // Добавляем на панель текстовое поле
        textBox1 = new TextBox();
        textBox1.Multiline = true;
        textBox1.Text = "огурцом";
        textBox1.Font = new Font("Times New Roman", 20);
        textBox1.Dock = DockStyle.Fill;
        paneldnglbl.Controls.Add(textBox1, 1, 0);
        
        // Добавляем на панель текстовое поле
        textBox2 = new TextBox();
        textBox2.Multiline = true;
        textBox2.Text = "трахнуть";
        textBox2.Font = new Font("Times New Roman", 20);
        textBox2.Dock = DockStyle.Fill;
        paneldnglbl.Controls.Add(textBox2, 3, 0);
        
        // Добавляем на панель текстовое поле
        textBox3 = new TextBox();
        textBox3.Multiline = true;
        textBox3.Text = "анал";
        textBox3.Font = new Font("Times New Roman", 20);
        textBox3.Dock = DockStyle.Fill;
        paneldnglbl.Controls.Add(textBox3, 5, 0);
        
        PictureBox imagepng = new PictureBox();
        imagepng.SizeMode = PictureBoxSizeMode.StretchImage;
        Bitmap imagechpng = new Bitmap("img/plus2.png");
		imagepng.Dock = DockStyle.Fill;
        imagepng.Image = (Image)imagechpng;
        imagepng.Click += new EventHandler(plusclick);
        paneldnglbl.Controls.Add(imagepng, 7, 0);

        prt = ""; prt1 = "";

        // Label label3 = new Label();
        // label3.Width = 2*textBox3.Width/5;
        // Point[] plusArray = {
        //     new Point(label3.Width/3, 0),
        //     new Point(2*label3.Width/3, 0),
        //     new Point(2*label3.Width/3, label3.Width/3),
        //     new Point(label3.Width, label3.Width/3),
        //     new Point(label3.Width, 2*label3.Width/3),
        //     new Point(2*label3.Width/3, 2*label3.Width/3),
        //     new Point(2*label3.Width/3, label3.Width),
        //     new Point(label3.Width/3, label3.Width),
        //     new Point(label3.Width/3, 2*label3.Width/3),
        //     new Point(0, 2*label3.Width/3),
        //     new Point(0, 1*label3.Width/3),
        //     new Point(label3.Width/3, 1*label3.Width/3),
        //     new Point(label3.Width/3, 0)};
        // GraphicsPath plusPath = new GraphicsPath();
        // plusPath.AddLines(plusArray);

        // label3.Region = new Region(plusPath);
        // plusPath.Dispose();
    }
    
    void button_Click1(object sender, EventArgs args) {
        string txt = Convert.ToString(textBox1.Text) + " " +
        Convert.ToString(textBox2.Text) + " " +
        Convert.ToString(textBox3.Text) + "!";
        
        txt1 = Convert.ToString(textBox1.Text) + " " +
        Convert.ToString(textBox2.Text).Substring(0, Convert.ToString(textBox2.Text).Length - 2) +
        "ли " + Convert.ToString(textBox3.Text);

        if (prt != "") {
            txt = prt + " и " + txt;
            txt1 = prt1 + " и " + txt1 + " " + arraych[numch] + " Артура!";
        }
        txt1 = "Вы "  + txt1 + " " + arraych[numch] + " Артура!";
        
        paneldnglbl.Visible = false;
        button.Visible = false;

        button = new Button();
		button.Dock = DockStyle.Fill;
        button.Font = new Font("Arial", button.Width/(2 + (txt.Length + 39)/80));
        button.Text = txt;
        button.BackColor = Color.Green;
        button.ForeColor = Color.White;
        paneldng.Controls.Add(button, 0, 3);
        button.Click += new EventHandler(cngtclick);

        PanelEnd();
        EndBtn();
    }
    
    void plusclick(object sender, EventArgs args) {

        if (prt != "") {
            prt += ", ";
            prt1 += ", ";
        }

        textBox1.Controls.Clear();

        prt = prt + Convert.ToString(textBox1.Text) + " " +
        Convert.ToString(textBox2.Text) + " " +
        Convert.ToString(textBox3.Text);
        
        prt1 = prt1 + Convert.ToString(textBox1.Text) + " " +
        Convert.ToString(textBox2.Text).Substring(0, Convert.ToString(textBox2.Text).Length - 2) + "ли " +
        Convert.ToString(textBox3.Text);
    }
    
	void PanelEnd(){
		endpnl = new TableLayoutPanel();
		endpnl.AutoScroll = true;
		endpnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		endpnl.ColumnCount = 3;
		endpnl.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 20F));
		endpnl.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 20F));
		endpnl.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 20F));
		endpnl.Dock = DockStyle.Fill;
		endpnl.RowCount = 1;
		endpnl.TabIndex = 0;
		paneldng.Controls.Add(endpnl, 0, 5);
	}
    
	void EndBtn() {
        buttonred = new Button();
		buttonred.Dock = DockStyle.Fill;
        buttonred.Font = new Font("Arial", buttonred.Width/2);
        buttonred.Text = "exit";
        buttonred.BackColor = Color.Red;
        buttonred.ForeColor = Color.FromArgb(250, 150, 150);
        endpnl.Controls.Add(buttonred, 0, 0);
        buttonred.Click += new EventHandler(End);
        
        buttonylw = new Button();
		buttonylw.Dock = DockStyle.Fill;
        buttonylw.Font = new Font("Arial", buttonylw.Width/2);
        buttonylw.Text = "start over";
        buttonylw.BackColor = Color.Yellow;
        buttonylw.ForeColor = Color.FromArgb(20, 20, 20);
        endpnl.Controls.Add(buttonylw, 1, 0);
        buttonylw.Click += new EventHandler(button1_Click);
        
        buttongrn = new Button();
		buttongrn.Dock = DockStyle.Fill;
        buttongrn.Font = new Font("Arial", buttongrn.Width/2);
        buttongrn.Text = "change the action";
        buttongrn.BackColor = Color.Blue;
        buttongrn.ForeColor = Color.FromArgb(150, 150, 250);
        endpnl.Controls.Add(buttongrn, 2, 0);
        buttongrn.Click += new EventHandler(DngPnl);
    }

    void End(object sender, EventArgs args) {
        Environment.Exit(0);
    }

    void cngtclick(object sender, EventArgs args) {
        window.Controls.Clear();
        PanelCngt();
        CreatePanelCngt();
        PanelCngtLabel();
    }

    void CreatePanelCngt() {
        PictureBox Cngt = new PictureBox();
        Cngt.SizeMode = PictureBoxSizeMode.StretchImage;
		Cngt.Dock = DockStyle.Fill;
        Bitmap image4 = new Bitmap ("img/Cngt.jpg");
        Cngt.ClientSize = new Size(this.Width, this.Height);
        Cngt.Top = 0;
        Cngt.Left = 0;
        Cngt.Image = (Image)image4;
        // window.Controls.Add(Cngt);
    }

    void PanelCngt() {
		cngtpnl = new TableLayoutPanel();
		cngtpnl.AutoScroll = true;
		cngtpnl.Dock = DockStyle.Fill;
		cngtpnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		cngtpnl.ColumnCount = 3;
		cngtpnl.ColumnCount = 3;
		cngtpnl.ColumnStyles.Add (new ColumnStyle(SizeType.Percent, 25F));
		cngtpnl.ColumnStyles.Add (new ColumnStyle(SizeType.Percent, 50F));
		cngtpnl.ColumnStyles.Add (new ColumnStyle(SizeType.Percent, 25F));
		cngtpnl.RowCount = 5;
		cngtpnl.RowStyles.Add (new RowStyle (SizeType.Percent, 35F));
		cngtpnl.RowStyles.Add (new RowStyle (SizeType.Percent, 25F));
		cngtpnl.RowStyles.Add (new RowStyle (SizeType.Percent, 2F));
		cngtpnl.RowStyles.Add (new RowStyle (SizeType.Percent, 36F));
		cngtpnl.RowStyles.Add (new RowStyle (SizeType.Percent, 2F));
        cngtpnl.BackColor = Color.White;
		cngtpnl.Dock = DockStyle.Fill;
		cngtpnl.TabIndex = 0;
		window.Controls.Add(cngtpnl);

        PictureBox s_3 = new PictureBox();
        s_3.SizeMode = PictureBoxSizeMode.StretchImage;
        Bitmap mg3 = new Bitmap ("img/s-3.jpg");
        s_3.Dock = DockStyle.Fill;;
        s_3.Image = (Image)mg3;
        cngtpnl.Controls.Add(s_3, 0, 0);

        PictureBox s_4 = new PictureBox();
        s_4.SizeMode = PictureBoxSizeMode.StretchImage;
        Bitmap mg4 = new Bitmap ("img/s-4.jpg");
        s_4.Dock = DockStyle.Fill;;
        s_4.Image = (Image)mg4;
        cngtpnl.Controls.Add(s_4, 1, 0);

        PictureBox s_5 = new PictureBox();
        s_5.SizeMode = PictureBoxSizeMode.StretchImage;
        Bitmap mg5 = new Bitmap ("img/s-5.jpg");
        s_5.Dock = DockStyle.Fill;;
        s_5.Image = (Image)mg5;
        cngtpnl.Controls.Add(s_5, 2, 0);

        PictureBox s_6 = new PictureBox();
        s_6.SizeMode = PictureBoxSizeMode.StretchImage;
        Bitmap mg6 = new Bitmap ("img/hrt.png");
        s_6.Dock = DockStyle.Fill;;
        s_6.Image = (Image)mg6;
        cngtpnl.Controls.Add(s_6, 0, 1);

        PictureBox s_7 = new PictureBox();
        s_7.SizeMode = PictureBoxSizeMode.StretchImage;
        Bitmap mg7 = new Bitmap ("img/hrt.png");
        s_7.Dock = DockStyle.Fill;;
        s_7.Image = (Image)mg7;
        cngtpnl.Controls.Add(s_7, 2, 1);

        cngtpnl.Controls.Add(panelimg, 1, 1);
	}

    void PanelCngtLabel() {

        PictureBox s = new PictureBox();
        s.SizeMode = PictureBoxSizeMode.StretchImage;
        Bitmap image5 = new Bitmap ("img/s.jpg");
        s.Dock = DockStyle.Fill;;
        s.Image = (Image)image5;
        cngtpnl.Controls.Add(s, 0, 3);

        PictureBox s_2 = new PictureBox();
        s_2.SizeMode = PictureBoxSizeMode.StretchImage;
        Bitmap image6 = new Bitmap ("img/s-2.jpg");
        s_2.Dock = DockStyle.Fill;;
        s_2.Image = (Image)image6;
        cngtpnl.Controls.Add(s_2, 2, 3);

        Label label1 = new Label();
        label1.Text = txt1;
        label1.Dock = DockStyle.Fill;
        label1.Font = new Font("Times New Roman", 3/2*label1.Width/(2 + (txt1.Length + 39)/40));
        // label1.BackColor = Color.White;
        label1.ForeColor = Color.Red;
        cngtpnl.Controls.Add(label1, 1, 3);
	}

    static void Main() {
        // Создаем и запускаем форму
        Application.Run(new Trax());
    }
}
