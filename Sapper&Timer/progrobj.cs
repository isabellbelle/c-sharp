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
        void pause(object sender, EventArgs args) {
            // остановка таймера
            timer1.Stop();
        }

        void restart(object sender, EventArgs args) {
            cnt = 10;
            cntmn = 11*cnt/10;
            cntobj = cnt*cnt;
            flagchoice = false;
            endgame = true;
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
            randommines();
        }

        // завершение программы
        void end(object sender, EventArgs args) {
            Environment.Exit(0);
        }

        void gameover() {
            paneltabl.Visible = false;
        }
    }
}
