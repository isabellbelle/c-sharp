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
        Random rndm;
        List<List<int>> listpole;
        bool flagchoice;
        bool endgame;
        void randommines(Int32 X1, Int32 Y1) {
            Int32 X, Y;
            //Создание объекта для генерации чисел
            rndm = new Random();
            for (int i = 0; i < cntmn; i++) {
                //Получаем случайное число
                X = rndm.Next(cnt);
                Y = rndm.Next()%cnt;
                while(listpole[X][Y]/10 >= 10 || (X == X1 && Y == Y1)) {
                // while(listpole[X][Y]/10 != 0) {
                    X = rndm.Next(cnt);
                    Y = rndm.Next()%cnt;
                }
                listpole[X][Y] = 100;
                if (X > 0) {
                    listpole[X - 1][Y] += 10;
                    if (Y > 0) {
                        listpole[X - 1][Y - 1] += 10;
                    }
                    if (Y < cnt - 1) {
                        listpole[X - 1][Y + 1] += 10;
                    }
                }
                if (X < cnt - 1) {
                    listpole[X + 1][Y] += 10;
                    if (Y > 0) {
                        listpole[X + 1][Y - 1] += 10;
                    }
                    if (Y < cnt - 1) {
                        listpole[X + 1][Y + 1] += 10;
                    }
                }
                if (Y > 0) {
                    listpole[X][Y - 1] += 10;
                }
                if (Y < cnt - 1) {
                    listpole[X][Y + 1] += 10;
                }
            }
            choisesqr(X1, Y1);
        }
        void createlistpole() {
            flagchoice = false;
            endgame = true;
            listpole = new List<List<int>>(); //динамический двумерный массив
            List<int> item = new List<int>(); //строка массива
            for (int i = 0; i < cnt; i++) {
                item = new List<int>();
                for (int j = 0; j < cnt; j++)
                    item.Add(1); //строка массива заполняется просто суммой i и j
                listpole.Add(item); //строка добавляется в массив
            }
        }
    }
}
