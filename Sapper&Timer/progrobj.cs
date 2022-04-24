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
            timer1stop = !timer1stop;
            if (timer1stop) {
                timer1.Stop(); // остановка таймера
            } else {
                timer1.Start(); // запуск таймера
            }
        }

        void restart(object sender, EventArgs args) {
            rstart();
        }
        void rstart() {
            inicial(lvl);
            timer1.Start();
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
            // randommines();
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
