using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeBook
{
    public partial class GradeBook : Form
    {
        public GradeBook()
        {
            InitializeComponent();
            Form1 f1 = new Form1();
            label7.Text = f1.textBox1.Text;
        }

        private void GradeBook_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
