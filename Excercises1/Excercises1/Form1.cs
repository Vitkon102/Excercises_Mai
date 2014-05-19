using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excercises1.CShap;

namespace Excercises1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            students sv_A = new students();
            sv_A.Name = " Tạ Thị Mai ";
            MessageBox.Show(sv_A.Name);
        }
    }
}
