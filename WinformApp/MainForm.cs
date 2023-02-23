using ClassLibrary;

namespace WinformApp
{
    public partial class MainForm : Form
    {
        private WordList Currentlist;
        private Word CurrentWord;
        private int TotalCount = 0;
        private int TotalCorrect = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void exiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm loadForm = new LoadForm();
            loadForm.ShowDialog();
            Currentlist = loadForm.SelectedList;

        }

        private void exiteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewListsForm newLists = new NewListsForm();
            newLists.ShowDialog();
        }

        private void editListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Currentlist != null)
            {
            EditListsForm neweditList = new EditListsForm(Currentlist);
            neweditList.Show();

            }
        }

        private void exiteToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void newListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            CurrentWord = Currentlist.GetWordToPractice();
            lblWord.Text = CurrentWord.Translations[CurrentWord.FromLanguage];
            lblFrom.Text = Currentlist.Languages[CurrentWord.FromLanguage];
            lblTo.Text = Currentlist.Languages[CurrentWord.ToLanguage];
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string GuessedWord = txtGuess.Text;
            string CorrectWord = CurrentWord.Translations[CurrentWord.ToLanguage];
            if (GuessedWord.ToLower() == CorrectWord.ToLower())
            {
                TotalCorrect++;
                MessageBox.Show("You guessed right!!");
            }
            else
            {
                MessageBox.Show($"You guessed wrong the wight answer was {CorrectWord}");
            }
            txtGuess.Text = string.Empty;
            TotalCount++;
                
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Du tränade på {TotalCount} ord av dessa var {TotalCorrect} rätt. Det är {(TotalCorrect / (float)TotalCount * 100):f0}% rätt ");
            TotalCorrect = 0;
            TotalCount = 0;
        }
    }
}