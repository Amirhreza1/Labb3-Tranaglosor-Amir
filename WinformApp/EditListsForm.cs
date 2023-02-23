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
    public partial class EditListsForm : Form
    {
        private WordList CurrentList;
        public EditListsForm(WordList list)
        {
            CurrentList = list;
            InitializeComponent();
        }

        private void EditListsForm_Load(object sender, EventArgs e)
        {
            
            foreach(string language in CurrentList.Languages)
            {
                DataGridViewColumn c = new DataGridViewTextBoxColumn();
                c.HeaderText = language;
                dgwWords.Columns.Add(c);
            }
            CurrentList.List(0, word =>
            {
                dgwWords.Rows.Add(word);
            });
        }

        private void btnSave_click(object sender, EventArgs e)
        {
            CurrentList.Save();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnewWord.Text))
            {
                MessageBox.Show("Enter word First!!");
            }
            else
            {
                string[] words = txtnewWord.Text.Split(',');
                if(words.Length != CurrentList.Languages.Length)
                {
                    MessageBox.Show("wrong number of words!!");
                }
                else
                {
                    CurrentList.Add(words);
                    dgwWords.Rows.Add(words);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            if(dgwWords.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Select row first!!");
            }
            else
            {

                DataGridViewRow selectedRow = dgwWords.SelectedRows[0];
                string word = selectedRow.Cells[0].Value.ToString();
                CurrentList.Remove(0, word);
                dgwWords.Rows.Remove(selectedRow);




            }
        }
    }
}
