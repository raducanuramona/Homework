using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Humanizer;

namespace Homework
{
    public partial class Form1 : Form
    {
        public List<string> lang = new List<string> { "en", "fr", "de" };

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
             int numar = 0;
            if (Int32.TryParse(textBox1.Text,out numar))
            {
                string rezultat = numar.ToWords(new System.Globalization.CultureInfo(lang[comboBox1.SelectedIndex]));
                MessageBox.Show(rezultat);
            }     
      
        }
    }
}
