using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace davaleba_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student obj_student = new Student();

            string university = txtBoxName.Text;
            int year = int.Parse(txtBoxYear.Text);

            obj_student.university = university;
            obj_student.year = year;

            labelResult.Text = $"უნივერსიტეტი: {university}\n              კურსი: {year}";
        }
    }
}
