using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;

namespace supper {
    // class Form1 {
    partial class Form1 {
        // private System.ComponentModel.IContainer components = null;
        private void InitializeComponent() {
            // this.components = new System.ComponentModel.Container();
            // this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.thispnl = new System.Windows.Forms.TableLayoutPanel(); // на this
            this.window = new System.Windows.Forms.Panel(); // на thispnl
            this.paneltabl = new System.Windows.Forms.TableLayoutPanel(); // на window
            this.ImageList1 = new System.Windows.Forms.ImageList();
            // this.SuspendLayout();
            // Указываем заголовок окна
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.Height = 720; this.Width = 760;
            // this.Width = 875;
            
            this.thispnl = new TableLayoutPanel();
            this.thispnl.ColumnCount = 2;
            this.thispnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            this.thispnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.thispnl.Dock = DockStyle.Fill;
            this.thispnl.RowCount = 2;
            this.thispnl.RowStyles.Add(new RowStyle(SizeType.Percent, 95F));
            this.thispnl.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));

            this.window = new Panel();
            this.window.Dock = DockStyle.Fill;
            
            Label label = new Label();
            label.Dock = DockStyle.Top;
            label.BorderStyle = BorderStyle.FixedSingle;
            label.Height = this.Height/25;
            label.Text = "Made by isabelle. (tap here)";
            label.Font = new Font("Times New Roman", 10);
            label.BackColor = Color.White;
            label.ForeColor = Color.Black;
            label.Click += new EventHandler(clicklabel);
            
            ImageList1 = new ImageList();
            ImageList1.ImageSize = new Size(200, 250);
            ImageList1.Images.Add(Image.FromFile("img/tic.jpg"));
            ImageList1.Images.Add(Image.FromFile("img/tac.jpg"));
            Graphics theGraphics = Graphics.FromHwnd(this.Handle);
            
            paneltabl = new TableLayoutPanel ();
            paneltabl.AutoScroll = true;
            paneltabl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            paneltabl.ColumnCount = 3;
            paneltabl.Dock = DockStyle.Fill;
            paneltabl.RowCount = 3;
            for (int i = 0; i < 3; i++) {
                paneltabl.ColumnStyles.Add (new ColumnStyle (SizeType.Percent, 100F/3));
                paneltabl.RowStyles.Add (new RowStyle (SizeType.Percent, 100F/3));
            }
            paneltabl.TabIndex = 0;

            this.Controls.Add(this.thispnl);
            this.thispnl.Controls.Add(this.window, 0, 0);
            this.thispnl.SetColumnSpan(window, 2);
            thispnl.Controls.Add(label, 1, 1);
            window.Controls.Add(paneltabl);

            createpole();
            createlistpole();
        }

        void createpole() {
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++)
                    addbutton(i, j);
            }
        }
        
        void addbutton(int row, int column) {
            Button button = new Button();
            button.Dock = DockStyle.Fill;
            button.Click += new EventHandler(clickbutton);
            paneltabl.Controls.Add(button, column, row);
        }

        void createlistpole() {
            hod = 0;
            listpole = new List<int>();
                for (int j = 0; j < 9; j++)
                    listpole.Add(0); //строка массива заполняется просто суммой i и j
        }

        private System.Windows.Forms.TableLayoutPanel thispnl; // на this
        private System.Windows.Forms.Panel window; // на thispnl
        private System.Windows.Forms.TableLayoutPanel paneltabl; // на window
        private System.Windows.Forms.ImageList ImageList1;
        List<int> listpole;
        PictureBox TicTac;
        PictureBox TicTac1;
    }
}
