using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Xml;

using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace supper {
    static class Program {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
