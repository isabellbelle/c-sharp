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
        Int32 hod;
        String str = "";
        Random rndm;

        public Form1() {
            InitializeComponent();
        }

        // получение ссылки на github
        void clicklabel(object sender, System.EventArgs e) {
            MessageBox.Show ("https://github.com/isabellbelle", "info");
        }

        // получение ссылки на github
        void clickbutton(object sender, System.EventArgs e) {
            Int32 X = paneltabl.GetColumn((Control)sender),
            Y = paneltabl.GetRow((Control)sender);
            str += (3*Y + X).ToString();
            // Console.Write("{0} {1}", X, Y);
            var button = (Button)sender;
            button.Visible = false;
            TicTac = new PictureBox();
            TicTac.Image = Image.FromFile("img/tic.jpg");
            TicTac.SizeMode = PictureBoxSizeMode.StretchImage;
            TicTac.Dock = DockStyle.Fill;
            paneltabl.Controls.Add(TicTac, X, Y);
            listpole[3*Y + X] = 1;
            Console.WriteLine(listpole);
            hod += 1;
            makehod(hod, str);
            Console.WriteLine(str);
        }

        void makehod(Int32 hod, string str) {
                TicTac1 = new PictureBox();
                TicTac1.Image = Image.FromFile("img/tac.jpg");
                TicTac1.SizeMode = PictureBoxSizeMode.StretchImage;
                TicTac1.Dock = DockStyle.Fill;
                if (hod == 1) {
                    if (str[0] == '4') {
                        Int32 X, Y;
                        //Создание объекта для генерации чисел
                        rndm = new Random();
                        X = 2*rndm.Next(2);
                        Y = 2*rndm.Next(2);
                        Control button = paneltabl.GetControlFromPosition(X, Y);
                        button.Visible = false;
                        // button.Controls.Clear();
                        listpole[3*Y + X] = -1;
                        // button.Controls.Add(TicTac1);
                        paneltabl.Controls.Add(TicTac1, X, Y);
                        // paneltabl.Controls.Add(TicTac1, 2, 2);
                    } else {
                        Control button = paneltabl.GetControlFromPosition(1, 1);
                        button.Visible = false;
                        listpole[4] = -1;
                        paneltabl.Controls.Add(TicTac1, 1, 1);
                    }
                }
        }
    }
}
