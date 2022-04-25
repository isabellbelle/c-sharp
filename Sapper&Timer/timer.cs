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
        int min;
        int sec;
        Int32 cnt;
        Int32 cntmn;
        Int32 cntobj;
        Int32 lvl;
        TableLayoutPanel abc;
        bool fstep;
        private System.Windows.Forms.Label labeltime;

        private void timer1_Tick(object sender, EventArgs e) {
            sec = sec - 1; //каждую секунду счетчик таймера секунд уменьшается на 1
            if (min != 0 && sec == -1) {
                //минута кончается, а секундная переменная становится меньше единицы
                min = min - 1;
                sec = 59;
            }
            if (sec == -1) {
                // время вышло
                timer1.Stop();
                gameover("Time is over!");
            }
            labeltime.Text = String.Format("{0:d2}", min)
            + " : " + String.Format("{0:d2}", sec);
        }
        int inicial(Int32 lvl, Int32 fl) {
            int replay = 1;
            timer1stop = false;
            fstep = true;
            if (lvl== 2) {
                min = 0;
                sec = 40;
                cnt = 12;
                cntmn = 15;
            }
            if (lvl == 1) {
                    min = 1;
                    sec = 40;
                    cnt = 10;
                    cntmn = 11;
                cntobj = cnt*cnt;
            }
            if (lvl == 0) {
                min = 2;
                sec = 20;
                cnt = 8;
                cntmn = 12;
            }

            if (fl == 1) {
                DialogResult dialogResult = MessageBox.Show("level --- " + String.Format("{0:d}", lvl) +
                "\nplaying field --- " + String.Format("{0:d}", cnt) +
                "x"+ String.Format("{0:d}", cnt) +
                "\nmines --- " + String.Format("{0:d}", cntmn) +
                "\ntime --- " + String.Format("{0:d2}", min) + "min " +
                String.Format("{0:d2}", sec) + "sec\n" +
                "------------------------------------------------\n" +
                "space --- pause\n" + "right mouse button --- flag", "Info:",
                MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes) {
                    replay = 0;
                } else if (dialogResult == DialogResult.No) {
                    replay = 1;
                }
            } else {
                replay = 0;
            }

            if (replay == 0) {
                cntobj = cnt*cnt;
                labeltime.Dock = DockStyle.Fill;
                labeltime.Text = String.Format("{0:d2}", min)
                + " : " + String.Format("{0:d2}", sec);
                if (fl == 1)
                    abc.Visible = false;
            }
            return replay;
        }
        void timerchoice2(object sender, System.EventArgs e) {
            lvl = 2;
            labeltime = new System.Windows.Forms.Label();
            if (inicial(lvl, 1) == 0) {
                labeltime.Font = new Font("Times New Roman", 15);
                labeltime.TextAlign = ContentAlignment.MiddleCenter;
                createlistpole();
                InitializeComponent();
                panel.Controls.Add(labeltime, 6, 0);
            }
        }
        void timerchoice1(object sender, System.EventArgs e) {
            lvl = 1;
            labeltime = new System.Windows.Forms.Label();
            if (inicial(lvl, 1) == 0) {
                labeltime.Font = new Font("Times New Roman", 15);
                labeltime.TextAlign = ContentAlignment.MiddleCenter;
                createlistpole();
                InitializeComponent();
                panel.Controls.Add(labeltime, 6, 0);
            }
        }
        void timerchoice0(object sender, System.EventArgs e) {
            lvl = 0;
            labeltime = new System.Windows.Forms.Label();
            if (inicial(lvl, 1) == 0) {
                labeltime.Font = new Font("Times New Roman", 15);
                labeltime.TextAlign = ContentAlignment.MiddleCenter;
                createlistpole();
                InitializeComponent();
                panel.Controls.Add(labeltime, 7, 0);
            }
        }
        void createbgnpnl() {
            this.Name = "Form1";
            this.Text = "Sapper";

            abc = new TableLayoutPanel();
            abc.ColumnCount = 3;
            abc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            abc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            abc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            abc.Dock = DockStyle.Fill;
            int n = 3;
            abc.RowCount = 10;
            abc.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            for (int i = 0; i < n; i++) {
                abc.RowStyles.Add(new RowStyle(SizeType.Percent, 13F/n*4));
                abc.RowStyles.Add(new RowStyle(SizeType.Percent, 13F/n));
            }
            abc.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            abc.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            abc.RowStyles.Add(new RowStyle(SizeType.Percent, 1F));
            Controls.Add(abc);

            Button buttonlvl2 = new Button();
            buttonlvl2.Text = "lvl 2";
            buttonlvl2.Dock = DockStyle.Fill;
            buttonlvl2.Click += new EventHandler(timerchoice2);
            abc.Controls.Add(buttonlvl2, 1, 5);
            
            Button buttonlvl1 = new Button();
            buttonlvl1.Text = "lvl 1\n(recomended)";
            buttonlvl1.Dock = DockStyle.Fill;
            buttonlvl1.Click += new EventHandler(timerchoice1);
            abc.Controls.Add(buttonlvl1, 1, 3);
            
            Button buttonlvl0 = new Button();
            buttonlvl0.Text = "lvl 0";
            buttonlvl0.Dock = DockStyle.Fill;
            buttonlvl0.Click += new EventHandler(timerchoice0);
            abc.Controls.Add(buttonlvl0, 1, 1);

            abc.Controls.Add(label, 0, 8);
            abc.SetColumnSpan(label, 3);
        }
    }
}
