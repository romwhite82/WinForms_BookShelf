using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private event EventHandler TextChangeCheck;

        void TextChangerReaction(object sender, EventArgs e)
        {
            if (tbAuthor.Text.Length > 3 && tbTitle.Text.Length > 3 && tbYear.Text.Length == 4)
                button1.Enabled = true;
        }

        public Form2()
        {
            InitializeComponent();
            TextChangeCheck = new EventHandler(TextChangerReaction);
            tbAuthor.TextChanged += TextChangeCheck;
            tbTitle.TextChanged += TextChangeCheck;
            tbYear.TextChanged += TextChangeCheck;

            
            MyFunction.InactHandler();
            
        }
                
        private void button1_Click(object sender, EventArgs e)
        {
            MyFunction.AddBookHandl(tbAuthor.Text, tbTitle.Text, tbYear.Text);
            this.Close();
        }


        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyFunction.ActHandler();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
