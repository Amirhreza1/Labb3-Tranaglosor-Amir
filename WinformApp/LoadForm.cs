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
using WinformApp;

namespace WinformApp
{
    public partial class LoadForm : Form
    {
        public WordList SelectedList;

        public LoadForm()
        {
            InitializeComponent();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string wordList = lbWordList.SelectedItem.ToString();
            SelectedList = WordList.LoadList(wordList);
            lbLanguages.Items.Clear();
            lbLanguages.Items.AddRange(SelectedList.Languages);
            lblWordCount.Text = $"Word count: {SelectedList.Count()}";
        }

        private void LoadForm_Load(object sender, EventArgs e)
        {
            LoadLists();

        }

        private void LoadLists()
        {
            lbWordList.Items.Clear();
            SelectedList = null;
            lbWordList.Items.AddRange(WordList.GetLists());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(SelectedList == null)
            {
                MessageBox.Show("Select a list first!!");
            }
            else
            {
               Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            NewListsForm newLists = new NewListsForm();
            newLists.ShowDialog();
            LoadLists();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }
    }

}
   