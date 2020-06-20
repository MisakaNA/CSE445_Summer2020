using System;
using System.Windows.Forms;

namespace Project1_WFA
{
    public partial class Converter : Form
    {
        
        public Converter()
        {
            InitializeComponent();
        }

        //set the feature of the application when "Convert" button of c to f is clicked
        private void c2f_Click(object sender, EventArgs e)
        {
            TempConvertServ.Service1Client convertService = new TempConvertServ.Service1Client();
            var cValue = convertService.c2f(int.Parse(textBox1.Text));
            Fout.Text = cValue.ToString();
        }

        //set the feature of the application when "Convert" button of f to c is clicked
        private void f2c_Click(object sender, EventArgs e)
        {
            TempConvertServ.Service1Client convertService = new TempConvertServ.Service1Client();
            var fValue = convertService.f2c(int.Parse(textBox3.Text));
            Cout.Text = fValue.ToString();
        }
    }
}
