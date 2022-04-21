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
            this.panel = new System.Windows.Forms.TableLayoutPanel(); // на thispnl
            this.paneltabl = new System.Windows.Forms.TableLayoutPanel(); // на window
            this.ImageList1 = new System.Windows.Forms.ImageList();
            this.buttonpause = new System.Windows.Forms.Button();
            this.buttonrestart = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            // this.SuspendLayout();
            // Указываем заголовок окна
            this.Name = "Form1";
            this.Text = "Sapper";
            // this.Height = 700;
            // this.Width = 950;
            this.Height = 720;
            this.Width = 800;
            
            this.thispnl = new TableLayoutPanel();
            this.thispnl.ColumnCount = 2;
            this.thispnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            this.thispnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            this.thispnl.Dock = DockStyle.Fill;
            this.thispnl.RowCount = 2;
            this.thispnl.RowStyles.Add(new RowStyle(SizeType.Percent, 92F));
            this.thispnl.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));

            this.window = new Panel();
            this.window.Dock = DockStyle.Fill;
            window.BackColor = Color.FromArgb(160, 160, 160);
            thispnl.Controls.Add(this.window, 0, 0);;
            thispnl.SetColumnSpan(this.window, 2);
            
            Label label = new Label();
            label.Dock = DockStyle.Top;
            label.BorderStyle = BorderStyle.FixedSingle;
            label.Height = 2*this.Height/28;
            // label.Dock = DockStyle.Fill;
            label.Text = "Made by isabelle.\n(tap here)";
            label.Font = new Font("Times New Roman", 12);
            label.BackColor = Color.White;
            label.ForeColor = Color.Black;
            label.Click += new EventHandler(clicklabel);
            thispnl.Controls.Add(label, 1, 1);
            
            ImageList1 = new ImageList();
            ImageList1.ImageSize = new Size(40, 40);
            ImageList1.Images.Add(Image.FromFile("img/fl.png"));
            ImageList1.Images.Add(Image.FromFile("img/mn.png"));
            ImageList1.Images.Add(Image.FromFile("img/vzr.png"));
            Graphics theGraphics = Graphics.FromHwnd(this.Handle);
            
            panel = new TableLayoutPanel();
            panel.ColumnCount = 7;
            for (int i = 0; i < panel.ColumnCount; i++)
                panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F/panel.ColumnCount));
            panel.Dock = DockStyle.Fill;
            panel.RowCount = 1;
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            thispnl.Controls.Add(panel, 0, 1);
            
            buttonexit = new Button();
            buttonexit.Dock = DockStyle.Fill;
            // buttonexit.Font = new Font("Arial", buttonexit.Width/2);
            buttonexit.Font = new Font("Arial", 15);
            buttonexit.Text = "exit";
            buttonexit.BackColor = Color.Red;
            // buttonexit.ForeColor = Color.FromArgb(250, 150, 150);
            buttonexit.ForeColor = Color.White;
            buttonexit.Click += new EventHandler(end);
            panel.Controls.Add(buttonexit, 0, 0);
            
            buttonrestart = new Button();
            buttonrestart.Dock = DockStyle.Fill;
            buttonrestart.Font = new Font("Arial", 14);
            buttonrestart.Text = "restart";
            buttonrestart.BackColor = Color.Magenta;
            buttonrestart.ForeColor = Color.White;
            // buttonrestart.Click += new EventHandler(restart);
            panel.Controls.Add(buttonrestart, 1, 0);
            
            buttonpause = new Button();
            buttonpause.Dock = DockStyle.Fill;
            buttonpause.Font = new Font("Arial", 14);
            buttonpause.Text = "pause";
            buttonpause.BackColor = Color.Cyan;
            buttonpause.ForeColor = Color.White;
            // buttonpause.Click += new EventHandler(pause);
            panel.Controls.Add(buttonpause, 2, 0);

            Button buttonflag = new Button();
            buttonflag.Dock = DockStyle.Fill;
            buttonflag.Click += new EventHandler(choiceflag);
            buttonflag.BackgroundImage = ImageList1.Images[0];
            buttonflag.BackgroundImageLayout = ImageLayout.Center;
            buttonflag.TabIndex = 1;
            buttonflag.TabStop = true;
            panel.Controls.Add(buttonflag, 3, 0);
            
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
            createpole();

         
            // this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            // this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // this.ClientSize = new System.Drawing.Size(300, 253);
            this.Controls.Add(this.thispnl);

            // this.Controls.Add(this.button3);
            // this.Controls.Add(this.button2);
            // this.Controls.Add(this.button1);
            // this.Controls.Add(this.label8);
            // this.Controls.Add(this.label7);
            // this.Controls.Add(this.label6);
            // this.Controls.Add(this.textBox3);
            // this.Controls.Add(this.textBox2);
            // this.Controls.Add(this.textBox1);
            // this.Controls.Add(this.label5);
            // this.Controls.Add(this.label4);
            // this.Controls.Add(this.label3);
            // this.Controls.Add(this.label2);
            // this.Controls.Add(this.label1);
            // this.Name = "Form1";
            // this.Text = "Таймер";
            
            // this.ResumeLayout(false);
            // this.PerformLayout();
        }

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
            button.BackColor = Color.FromArgb(240, 240, 240);
            button.Click += new EventHandler(clickbutton);
            paneltabl.Controls.Add(button, column, row);
        }

        private System.Windows.Forms.TableLayoutPanel thispnl; // на this
        private System.Windows.Forms.Panel window; // на thispnl
        private System.Windows.Forms.TableLayoutPanel panel; // на thispnl
        private System.Windows.Forms.TableLayoutPanel paneltabl; // на window
        private System.Windows.Forms.ImageList ImageList1;
        private System.Windows.Forms.Button buttonpause;
        private System.Windows.Forms.Button buttonrestart;
        private System.Windows.Forms.Button buttonexit;
        
        // private System.Windows.Forms.List<List<int>> listpole;
        // TableLayoutPanel thispnl; // на this
        // Panel window; // на thispnl
        // TableLayoutPanel panel; // на thispnl
        // TableLayoutPanel paneltabl; // на window
        // private System.Windows.Forms.Timer timer1;
        // private System.Windows.Forms.Label label1;
        // private System.Windows.Forms.Label label2;
        // private System.Windows.Forms.Label label3;
        // private System.Windows.Forms.Label label4;
        // private System.Windows.Forms.Label label5;
        // private System.Windows.Forms.TextBox textBox1;
        // private System.Windows.Forms.TextBox textBox2;
        // private System.Windows.Forms.TextBox textBox3;
        // private System.Windows.Forms.Label label6;
        // private System.Windows.Forms.Label label7;
        // private System.Windows.Forms.Label label8;
        // private System.Windows.Forms.Button button1;
        // private System.Windows.Forms.Button button2;
        // private System.Windows.Forms.Button button3;

    }
}
