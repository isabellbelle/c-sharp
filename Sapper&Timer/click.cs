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
                if (listpole[X][Y] > 0)
                    choisesqr(X, Y);
            }
            if (cntobj == 0 && endgame == true) {    
                MessageBox.Show ("You win!", "Game over!");
            }
        }

        void addflag(object sender) {
            Int32 X = paneltabl.GetColumn((Control)sender),
            Y = paneltabl.GetRow((Control)sender);
            // Console.Write("{0} {1}", X, Y);
            var button = (Button)sender;
            if(listpole[X][Y] < 0) { // проверка на наличие флага на кнопке
                cntmn += 1;
                cntobj += 1;
                listpole[X][Y] = -listpole[X][Y];
                button.BackgroundImage = null;
                button.Dock = DockStyle.Fill;
            } else {
                if (cntmn > 0) {
                    cntobj -= 1;
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
    
        Int32 choisesqr(Int32 X, Int32 Y) {
            // ((Control)sender).Visible = false;
        Int32 count = 0;
        Int32 a = 0, b = 0, c = 0, d = 0;
        cntobj -= 1;
        // object sender1;
        paneltabl.GetControlFromPosition(X, Y).Visible = false;
        if (listpole[X][Y]/10 < 10) {
            if (listpole[X][Y]/10 != 0) {
                PictureBox TicTac1 = new PictureBox();
                TicTac1.Image = Image.FromFile("img/" + listpole[X][Y]/10 + ".png");
                TicTac1.SizeMode = PictureBoxSizeMode.StretchImage;
                TicTac1.Dock = DockStyle.Fill;
                paneltabl.Controls.Add(TicTac1, X, Y);
                listpole[X][Y] = 0;
                count = 1;
            } else {
                listpole[X][Y] = 0;
                if (X > 0 && listpole[X - 1][Y] > 0) {
                    a = choisesqr(X - 1, Y);
                }
                if (X < cnt - 1 && listpole[X + 1][Y] > 0) {
                    b = choisesqr(X + 1, Y);
                }
                if (Y > 0 && listpole[X][Y - 1] > 0) {
                    c = choisesqr(X, Y - 1);
                }
                if (Y < cnt - 1 && listpole[X][Y + 1] > 0) {
                    d = choisesqr(X, Y + 1);
                }

                if (X > 0 && Y > 0 && listpole[X - 1][Y - 1] > 0) {
                    choisesqr(X - 1, Y - 1);
                }
                if (X > 0 && Y < cnt - 1 && listpole[X - 1][Y + 1] > 0) {
                    choisesqr(X - 1, Y + 1);
                }
                if (X < cnt - 1 && Y > 0 && listpole[X + 1][Y - 1] > 0) {
                    choisesqr(X + 1, Y - 1);
                }
                if (X < cnt - 1 && Y < cnt - 1 && listpole[X + 1][Y + 1] > 0) {
                    choisesqr(X + 1, Y + 1);
                }
            }
            // paneltabl.Controls.Add(TicTac1, 1, 1);
            if (X > 0) {
                // sender1.Location = new Point(X - 1, Y);
                // X = paneltabl.GetColumn((Control)sender);
                // Y = paneltabl.GetRow((Control)sender);
                // a = choisesqr(X - 1, Y, sender1);
            }
        } else {
            if (listpole[X][Y] >= 100) {
                // var button = (Button)sender;
                // Int32 j = 1;
                TimeSpan interval = new TimeSpan(0, 0, 2);
                // var button = (Button)sender;
                // button.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                // button.BackgroundImage = ImageList1.Images[2];
                // button.BackgroundImageLayout = ImageLayout.Center;
                // button.TabStop = true;
                // button.Dock = DockStyle.Fill;
                PictureBox TicTac1 = new PictureBox();
                TicTac1.Image = ImageList1.Images[2];
                paneltabl.BackgroundImageLayout = ImageLayout.Center;
                Button button = new Button();
                button.Dock = DockStyle.Fill;
                paneltabl.Controls.Add(button, X, Y);
                button.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                button.BackgroundImage = ImageList1.Images[2];
                button.BackgroundImageLayout = ImageLayout.Center;
                button.TabStop = true;
                button.Dock = DockStyle.Fill;
                // paneltabl.Controls.Add(TicTac1, X, Y);

                MessageBox.Show("Game Over.", "Attention!");
                listpole[X][Y] = 0;
            }
        }


            // var form = button.FindForm();
        return count;
        }
        
    }
}
