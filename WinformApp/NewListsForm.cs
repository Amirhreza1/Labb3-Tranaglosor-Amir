using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformApp
{
    public partial class NewListsForm : Form
    {
        public NewListsForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLanguage.Text))
            {
                MessageBox.Show("Enter Language first!!");
            }
            else
            {
                lbLanguages.Items.Add(txtLanguage.Text);
                txtLanguage.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WordList wordList = new WordList(txtName.Text, lbLanguages.Items.Cast<string>().ToArray());
            wordList.Save();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
