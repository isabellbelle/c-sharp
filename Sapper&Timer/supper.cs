using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Xml;

using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;//add this namespace

// namespace shapes

class Sapper : Form {
    TableLayoutPanel thispnl; // на this
    Panel window; // на thispnl
    TableLayoutPanel panel; // на thispnl
    TableLayoutPanel paneltabl; // на window
    ImageList ImageList1;
    Button buttonexit;
    Int32 cnt;
    Int32 cntmn;
    bool flagchoice;
    List<List<int>> listpole;
    public Sapper() {
        this_bgn();
        label_inf();

        makeell();
        panel_tabl();
        createpole();
    }

    void this_bgn() {
        // Указываем заголовок окна
        this.Text = "Sapper";
        this.Height = 700; this.Width = 950;
        // this.Width = 875;
        
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
        // this.thispnl.SetColumnSpan(window, 2);
    }

    void label_Click(object sender, System.EventArgs e) {
        MessageBox.Show ("https://github.com/isabellbelle", "info");
    }

    // сознание panelbutton
    void create_pnlbtn() {
		panel = new TableLayoutPanel();
		panel.ColumnCount = 2;
		panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
		panel.Dock = DockStyle.Fill;
		panel.RowCount = 5;
		panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
		panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
		panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
		panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
		panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        thispnl.Controls.Add(panel, 1, 0);
        addbtn_pnlbtn();
    }

     // создание кнопок на panel button
    void addbtn_pnlbtn() {
        buttonexit = new Button();
		buttonexit.Dock = DockStyle.Fill;
        buttonexit.Font = new Font("Arial", buttonexit.Width/2);
        buttonexit.Text = "exit";
        buttonexit.BackColor = Color.Red;
        buttonexit.ForeColor = Color.FromArgb(250, 150, 150);
        panel.Controls.Add(buttonexit, 0, 4);
        buttonexit.Click += new EventHandler(end);
        
		Button buttonflag = new Button();
		buttonflag.Dock = DockStyle.Fill;
		// button.Text = row.ToString();
		buttonflag.Click += new EventHandler(choiceflag);

        // button.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
        buttonflag.BackgroundImage = ImageList1.Images[0];
        buttonflag.BackgroundImageLayout = ImageLayout.Center;
        // button.Size = button.BackgroundImage.Size;
        buttonflag.TabIndex = 1;
        buttonflag.TabStop = true;
		// button.Dock = DockStyle.Fill;
        panel.Controls.Add(buttonflag, 0, 1);
    }

    // нажатие buttonflag на panelbutton
    void choiceflag(object sender, EventArgs args) {
        flagchoice = !flagchoice;
        var buttonflag = (Button)sender;
        if (flagchoice == true) {
            buttonflag.BackColor = Color.FromArgb(150, 200, 150);
        } else {
            buttonflag.BackColor = Color.Transparent;
        }
    }

    // завершение программы
    void end(object sender, EventArgs args) {
        Environment.Exit(0);
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

    
    void makeell() {
        cnt = 10;
        cntmn = 11*cnt/10;
        flagchoice = false;
        ImageList1 = new ImageList();
        ImageList1.ImageSize = new Size(40, 40);
        ImageList1.Images.Add(Image.FromFile("img/fl.png"));
        ImageList1.Images.Add(Image.FromFile("img/mn.png"));
        ImageList1.Images.Add(Image.FromFile("img/vzr.png"));

        Graphics theGraphics = Graphics.FromHwnd(this.Handle);
        
        createlistpole();
        create_pnlbtn();
        }
    
    // создание массива игрового поля
    void createlistpole() {
        listpole = new List<List<int>>(); //динамический двумерный массив
        List<int> item = new List<int>(); //строка массива
 
        for (int i = 0; i < cnt; i++) {
            item = new List<int>();
            for (int j = 0; j < cnt; j++)
                item.Add(1); //строка массива заполняется просто суммой i и j
            listpole.Add(item); //строка добавляется в массив
        }
    /*
        for (int i = 0; i < cnt; i++) { //вывод массива          
            for (int j = 0; j < cnt; j++)
                Console.Write(listpole[i][j].ToString() + " ");
            Console.WriteLine();
        }
    */
    }
    
    // создание игрового поля
    void panel_tabl() {
		paneltabl = new TableLayoutPanel ();
		paneltabl.AutoScroll = true;
		paneltabl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		paneltabl.ColumnCount = cnt;
		paneltabl.Dock = DockStyle.Fill;
		paneltabl.RowCount = cnt;
        for (int i = 0; i < cnt; i++) {
            paneltabl.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 100F/cnt));
            paneltabl.RowStyles.Add (new RowStyle (SizeType.Percent, 100F/cnt));
        }
		paneltabl.TabIndex = 0;
        window.Controls.Add(paneltabl);
    }

    // создание кнопок на игровом поле
    void createpole() {
        for (int i = 0; i < cnt; i++) {
            for (int j = 0; j < cnt; j++)
                addbutton(i, j);
        }
	}
	
    void addbutton(int row, int column) {
		Button button = new Button();
		button.Dock = DockStyle.Fill;
		// button.Text = row.ToString();
		button.Click += new EventHandler(Button_Click);
		paneltabl.Controls.Add(button, column, row);
	}

    // добавление флага на кнопку
    void Button_Click(object sender, EventArgs args) {
        if (flagchoice == true) {
            addflag(sender);
        } else {
            // Int32 X = paneltabl.GetColumn((Control)sender), Y = paneltabl.GetRow((Control)sender);
            // choisesqr(X, Y);
        }
    }

	void addflag(object sender) {
        Int32 X = paneltabl.GetColumn((Control)sender), Y = paneltabl.GetRow((Control)sender);
        Console.Write("{0} {1}", X, Y);
        var button = (Button)sender;
        if(listpole[X][Y] < 0) { // проверка на наличие флага на кнопке
            cntmn += 1;
            listpole[X][Y] = -listpole[X][Y];
            // button.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            button.BackgroundImage = null;
            // button.TabIndex = 1;
            // button.TabStop = true;
            button.Dock = DockStyle.Fill;
        } else {
            if (cntmn > 0) {
                cntmn -= 1;
                listpole[X][Y] = -listpole[X][Y];
                button.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                button.BackgroundImage = ImageList1.Images[0];
                button.BackgroundImageLayout = ImageLayout.Center;
                // button.Size = button.BackgroundImage.Size;
                button.TabIndex = 1;
                button.TabStop = true;
                button.Dock = DockStyle.Fill;
            } else {
                MessageBox.Show("The maximum number of flags has been exceeded.", "Attention!");
            }
        }
        Console.Write(cntmn);
        // Console.Write("{0} {1}\n", X, Y);

        // button.Click += new System.EventHandler(this.button1_Click);
        // button.Click += new System.EventHandler(this.button1_Click);
	}

	void choisesqr(Int32 X, Int32 Y) {
		// ((Control)sender).Visible = false;
        if (listpole[X][Y] != 0 && listpole[X][Y] != 2) {
            listpole[X][Y] = 0;
            if (X > 0) {
                choisesqr(X - 1, Y);
            }
            if (X < cnt - 2) {
                choisesqr(X + 1, Y);
            }
            if (Y > 0) {
                choisesqr(X, Y - 1);
            }
            if (Y < cnt - 2) {
                choisesqr(X, Y + 1);
            }
        }
        if (listpole[X][Y] == 2) {
            MessageBox.Show("Game Over.", "Attention!");
        }
        // var form = button.FindForm();
	}



    static void Main() {
        // Создаем и запускаем форму
        Application.Run(new Sapper());
    }
}