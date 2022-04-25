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
    partial class Form1 {
        bool timer1stop;
        void pause(object sender, EventArgs args) {
            if (!fstep) {
                timer1stop = !timer1stop;
                if (timer1stop) {
                    buttonpause.Text = "cntue";
                    timer1.Stop(); // остановка таймера
                } else {
                    buttonpause.Text = "pause";
                    timer1.Start(); // запуск таймера
                }
            }
        }
        void clickspace(object sender, KeyEventArgs e) {
            // Console.Write("wert");
            if (e.KeyCode == Keys.Space) {
                buttonpause.PerformClick();
            }
        }

        void restart(object sender, EventArgs args) {
            if (!fstep) {
                rstart();
            }
        }
        void rstart() {
            timer1.Stop();
            inicial(lvl, 0);
            flagchoice = false;
            endgame = true;
            fstep = true;
            for (int i = 0; i < cnt; i++) {
                for (int j = 0; j < cnt; j++) {
                    if (listpole[i][j] < 0) {
                        paneltabl.GetControlFromPosition(i, j).Dispose();
                        addbutton(j, i);
                    }
                    if (listpole[i][j] == 0) {
                        addbutton(j, i);
                    }
                    listpole[i][j] = 1;
                }
            }
            buttonflag.BackColor = Color.Transparent;
            buttonflag.Text = String.Format("{0:d}", cntmn);
            }

        // завершение программы
        void end(object sender, EventArgs args) {
            exit();
        }
        void exit() {
            Environment.Exit(0);
        }

        void gameover(string str) {
            showmines();
            MessageBox.Show(str, "Attention!");
            {
                DialogResult dialogResult = MessageBox.Show("Start over?", "",
                MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes) {
                    rstart();
                }
                else if (dialogResult == DialogResult.No) {
                    exit();
                }
            }
        }
    }
}
