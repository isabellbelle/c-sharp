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
            createlabel();
            createbgnpnl();
            createlistpole();
        }

        // получение ссылки на github
        void clicklabel(object sender, System.EventArgs e) {
            MessageBox.Show ("https://github.com/isabellbelle", "info");
        }
        
        // нажатие buttonflag на panelbutton
        void choiceflag(object sender, EventArgs args) {
            if (!timer1stop) {
                flagchoice = !flagchoice;
                // var buttonflag = (Button)sender;
                if (flagchoice == true) {
                    buttonflag.BackColor = Color.FromArgb(150, 200, 150);
                } else {
                    buttonflag.BackColor = Color.Transparent;
                }
            }
        }

        // добавление флага на кнопку
        void clickbutton(object sender, EventArgs args) {
            if (fstep && !flagchoice) {
                randommines(paneltabl.GetColumn((Control)sender),
                paneltabl.GetRow((Control)sender));
                timer1.Start();
                fstep = !fstep;
            }
            if (!timer1stop) {
                if (flagchoice == true) {
                    addflag(sender);
                } else {
                    Int32 X = paneltabl.GetColumn((Control)sender),
                    Y = paneltabl.GetRow((Control)sender);
                    if (listpole[X][Y] > 0)
                        choisesqr(X, Y);
                }
                if (cntobj - cntmn == 0 && endgame == true) {
                    timer1.Stop();
                    gameover("You win!");
                }
            }
        }

        void addflag(object sender) {
            Int32 X = paneltabl.GetColumn((Control)sender),
            Y = paneltabl.GetRow((Control)sender);
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
            buttonflag.Text = String.Format("{0:d}", cntmn);
            // buttonflag.TextAlign = ContentAlignment.TopRight;
            // buttonflag.Enabled = true;
        }
    
        Int32 choisesqr(Int32 X, Int32 Y) {
            Int32 count = 0;
            Int32 a = 0, b = 0, c = 0, d = 0;
            cntobj -= 1;
            paneltabl.GetControlFromPosition(X, Y).Dispose();
            if (listpole[X][Y]/10 < 10) {
                if (listpole[X][Y]/10 != 0) {
                    PictureBox TicTac1 = new PictureBox();
                    TicTac1.Image = Image.FromFile("img/" + listpole[X][Y]/10 + ".png");
                    TicTac1.SizeMode = PictureBoxSizeMode.StretchImage;
                    TicTac1.Dock = DockStyle.Fill;
                    paneltabl.Controls.Add(TicTac1, X, Y);
                    listpole[X][Y] = -150;
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
            } else {
                if (listpole[X][Y] >= 100) {
                    listpole[X][Y] = -200;

                    Button button = new Button();
                    button.Dock = DockStyle.Fill;
                    paneltabl.Controls.Add(button, X, Y);

                    endgame = false;
                    // TimeSpan interval = new TimeSpan(0, 0, 2);
                    addpic(button);
                    timer1.Stop();
                    gameover("The explosion, was a mine.");
                }
            }
            return count;
        }
        void picnull(object button1) {
            Thread.Sleep(2000);
            var button = (Button)button1;
            button.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            button.BackgroundImage = null;
            button.BackgroundImageLayout = ImageLayout.Center;
            button.TabIndex = 1;
            button.TabStop = true;
            button.Dock = DockStyle.Fill;
            Thread.Sleep(2000);
        }
        void addpic(object button1) {
            var button = (Button)button1;
            button.BackColor = Color.FromArgb(250, 50, 50);
            button.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            button.BackgroundImage = ImageList1.Images[2];
            button.BackgroundImageLayout = ImageLayout.Center;
            button.TabIndex = 1;
            button.TabStop = true;
            button.Dock = DockStyle.Fill;
        }
        void addmine(object button1) {
            var button = (Button)button1;
            button.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            button.BackgroundImage = ImageList1.Images[1];
            button.BackgroundImageLayout = ImageLayout.Center;
            button.TabIndex = 1;
            button.TabStop = true;
            button.Dock = DockStyle.Fill;
        }

        void showmines() {
            for (int i = 0; i < cnt; i++) {
                for (int j = 0; j < cnt; j++) {
                    if (listpole[i][j]/10 != -20) {
                        if (listpole[i][j]/10 < 0 && listpole[i][j]/10 != -15) {
                            listpole[i][j] = -listpole[i][j];
                            paneltabl.GetControlFromPosition(i, j).Dispose();
                            addbutton(j, i);
                        }
                        if (listpole[i][j]/10 >= 10) {
                            listpole[i][j] = -200;
                            Button button = (Button)paneltabl.GetControlFromPosition(i, j);
                            Button button1 = (Button)button;
                            button.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                            button.BackgroundImage = ImageList1.Images[1];
                            button.BackgroundImageLayout = ImageLayout.Center;
                            button.TabIndex = 1;
                            button.TabStop = true;
                            button.Dock = DockStyle.Fill;
                        }
                    }
                }
            }
        }
    }
}
