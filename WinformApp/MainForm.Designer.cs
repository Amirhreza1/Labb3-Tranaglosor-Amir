namespace WinformApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exiteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblFrom = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exiteToolStripMenuItem,
            this.exiteToolStripMenuItem1,
            this.editListaToolStripMenuItem,
            this.newListsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exiteToolStripMenuItem
            // 
            this.exiteToolStripMenuItem.Name = "exiteToolStripMenuItem";
            this.exiteToolStripMenuItem.Size = new System.Drawing.Size(262, 34);
            this.exiteToolStripMenuItem.Text = "Set active word list";
            this.exiteToolStripMenuItem.Click += new System.EventHandler(this.exiteToolStripMenuItem_Click);
            // 
            // exiteToolStripMenuItem1
            // 
            this.exiteToolStripMenuItem1.Name = "exiteToolStripMenuItem1";
            this.exiteToolStripMenuItem1.Size = new System.Drawing.Size(262, 34);
            this.exiteToolStripMenuItem1.Text = "New Lists";
            this.exiteToolStripMenuItem1.Click += new System.EventHandler(this.exiteToolStripMenuItem1_Click);
            // 
            // editListaToolStripMenuItem
            // 
            this.editListaToolStripMenuItem.Name = "editListaToolStripMenuItem";
            this.editListaToolStripMenuItem.Size = new System.Drawing.Size(262, 34);
            this.editListaToolStripMenuItem.Text = "Edit Lists";
            this.editListaToolStripMenuItem.Click += new System.EventHandler(this.editListaToolStripMenuItem_Click);
            // 
            // newListsToolStripMenuItem
            // 
            this.newListsToolStripMenuItem.Name = "newListsToolStripMenuItem";
            this.newListsToolStripMenuItem.Size = new System.Drawing.Size(262, 34);
            this.newListsToolStripMenuItem.Text = "Exite";
            this.newListsToolStripMenuItem.Click += new System.EventHandler(this.newListsToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTo);
            this.panel1.Controls.Add(this.lblWord);
            this.panel1.Controls.Add(this.btnGuess);
            this.panel1.Controls.Add(this.lblFrom);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.txtGuess);
            this.panel1.Location = new System.Drawing.Point(0, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 383);
            this.panel1.TabIndex = 1;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTo.Location = new System.Drawing.Point(587, 76);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(133, 24);
            this.lblTo.TabIndex = 12;
            this.lblTo.Text = "To Language";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWord.Location = new System.Drawing.Point(150, 76);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(67, 24);
            this.lblWord.TabIndex = 11;
            this.lblWord.Text = "Word ";
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(643, 140);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(112, 34);
            this.btnGuess.TabIndex = 10;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFrom.Location = new System.Drawing.Point(337, 76);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(158, 24);
            this.lblFrom.TabIndex = 8;
            this.lblFrom.Text = "From Language";
            this.lblFrom.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(219, 312);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(112, 34);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(473, 312);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 34);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(219, 140);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(366, 31);
            this.txtGuess.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(247, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "from";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(46, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "Translate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(532, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "to";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exiteToolStripMenuItem;
        private ToolStripMenuItem exiteToolStripMenuItem1;
        private Panel panel1;
        private ToolStripMenuItem editListaToolStripMenuItem;
        private ToolStripMenuItem newListsToolStripMenuItem;
        private Label lblFrom;
        private Button btnStop;
        private Button btnStart;
        private TextBox txtGuess;
        private Button btnGuess;
        private Label lblTo;
        private Label lblWord;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}