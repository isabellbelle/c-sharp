using System;
using System.Collections.Generic;
using System.ComponentModel;
// using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace supper {
    public partial class Form1 : Form {
        public Form1() {
            randommines();
            InitializeComponent();
        }

        // получение ссылки на github
        void clicklabel(object sender, System.EventArgs e) {
            MessageBox.Show ("https://github.com/isabellbelle", "info");
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

        // добавление флага на кнопку
        void clickbutton(object sender, EventArgs args) {
            if (flagchoice == true) {
                addflag(sender);
            } else {
                Int32 X = paneltabl.GetColumn((Control)sender),
                Y = paneltabl.GetRow((Control)sender);
                choisesqr(X, Y, sender);
            }
        }

        void pic(object sender, Int32 n) {
            var button = (Button)sender;
            // button.BackgroundImage = null;
            button.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            button.BackgroundImage = ImageList1.Images[2];
            button.BackgroundImageLayout = ImageLayout.Center;
            // button.TabIndex = 1;
            button.TabStop = true;
            button.Dock = DockStyle.Fill;
        }

        void addflag(object sender) {
            Int32 X = paneltabl.GetColumn((Control)sender),
            Y = paneltabl.GetRow((Control)sender);
            // Console.Write("{0} {1}", X, Y);
            var button = (Button)sender;
            if(listpole[X][Y] < 0) { // проверка на наличие флага на кнопке
                cntmn += 1;
                listpole[X][Y] = -listpole[X][Y];
                button.BackgroundImage = null;
                button.Dock = DockStyle.Fill;
            } else {
                if (cntmn > 0) {
                    cntmn -= 1;
                    listpole[X][Y] = -listpole[X][Y];
                    button.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                    button.BackgroundImage = ImageList1.Images[0];
                    button.BackgroundImageLayout = ImageLayout.Center;
                    button.TabIndex = 1;
                    button.TabStop = true;
                    button.Dock = DockStyle.Fill;
                } else {
                    MessageBox.Show("The maximum number of flags has been exceeded.", "Attention!");
                }
            }
            // Console.Write(cntmn);

            // button.Click += new System.EventHandler(this.button1_Click);
            // button.Click += new System.EventHandler(this.button1_Click);
        }

        // завершение программы
        void end(object sender, EventArgs args) {
            Environment.Exit(0);
        }
    
        Int32 choisesqr(Int32 X, Int32 Y, object sender) {
            // ((Control)sender).Visible = false;
        Int32 count = 0, a = 0, b = 0, c = 0, d = 0;
        object sender1;
            if (listpole[X][Y]/10 == 0) {
                listpole[X][Y] = 0;
                if (X > 0) {
                    // sender1.Location = new Point(X - 1, Y);
                    // X = paneltabl.GetColumn((Control)sender);
                    // Y = paneltabl.GetRow((Control)sender);
                    a = choisesqr(X - 1, Y, sender1);
                }
                // if (X < cnt - 2) {
                //     b = choisesqr(X + 1, Y);
                // }
                // if (Y > 0) {
                //     c = choisesqr(X, Y - 1);
                // }
                // if (Y < cnt - 2) {
                //     d = choisesqr(X, Y + 1);
                // }
            /*
            if (a*c > 0) {
                choisesqr(X - 1, Y - 1);
            }
            if (a*d > 0) {
                choisesqr(X - 1, Y + 1);
            }
            if (b*c > 0) {
                choisesqr(X + 1, Y - 1);
            }
            if (b*d > 0) {
                choisesqr(X + 1, Y + 1);
            }
            */
            } else {
                if (listpole[X][Y] >= 100) {
                    var button = (Button)sender;
                    // Int32 j = 1;
                    TimeSpan interval = new TimeSpan(0, 0, 2);
                    pic(sender, 1);
                    MessageBox.Show("Game Over.", "Attention!");
                }
            }


            // var form = button.FindForm();
            return count;
        }
        
    }
}
