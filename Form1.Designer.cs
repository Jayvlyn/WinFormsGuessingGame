namespace worsesteamgames;

partial class Form1
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
        buttonReset = new Button();
        titleLabel = new Label();
        guessBox1 = new MaskedTextBox();
        guessBox2 = new MaskedTextBox();
        guessBox3 = new MaskedTextBox();
        buttonGuess = new Button();
        buttonExit = new Button();
        labelFeedback = new Label();
        buttonCheat = new Button();
        labelAnswer1 = new Label();
        labelAnswer2 = new Label();
        labelAnswer3 = new Label();
        pictureBox1 = new PictureBox();
        labelLog = new Label();
        labelWin = new Label();
        labelGuesses = new Label();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // buttonReset
        // 
        buttonReset.Location = new Point(935, 12);
        buttonReset.Name = "buttonReset";
        buttonReset.Size = new Size(128, 63);
        buttonReset.TabIndex = 0;
        buttonReset.Text = "Reset";
        buttonReset.UseVisualStyleBackColor = true;
        buttonReset.Click += button1_Click;
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Location = new Point(507, 137);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(170, 25);
        titleLabel.TabIndex = 4;
        titleLabel.Text = "Guess the safe code";
        titleLabel.Click += label1_Click;
        // 
        // guessBox1
        // 
        guessBox1.Location = new Point(401, 201);
        guessBox1.Mask = "0";
        guessBox1.Name = "guessBox1";
        guessBox1.Size = new Size(100, 31);
        guessBox1.TabIndex = 5;
        guessBox1.TextAlign = HorizontalAlignment.Center;
        guessBox1.ValidatingType = typeof(int);
        guessBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
        // 
        // guessBox2
        // 
        guessBox2.Location = new Point(535, 201);
        guessBox2.Mask = "0";
        guessBox2.Name = "guessBox2";
        guessBox2.Size = new Size(100, 31);
        guessBox2.TabIndex = 6;
        guessBox2.TextAlign = HorizontalAlignment.Center;
        guessBox2.ValidatingType = typeof(int);
        guessBox2.MaskInputRejected += guessBox2_MaskInputRejected;
        // 
        // guessBox3
        // 
        guessBox3.Location = new Point(662, 201);
        guessBox3.Mask = "0";
        guessBox3.Name = "guessBox3";
        guessBox3.Size = new Size(100, 31);
        guessBox3.TabIndex = 7;
        guessBox3.TextAlign = HorizontalAlignment.Center;
        guessBox3.ValidatingType = typeof(int);
        // 
        // buttonGuess
        // 
        buttonGuess.Location = new Point(440, 292);
        buttonGuess.Name = "buttonGuess";
        buttonGuess.Size = new Size(308, 73);
        buttonGuess.TabIndex = 8;
        buttonGuess.Text = "Guess";
        buttonGuess.UseVisualStyleBackColor = true;
        buttonGuess.Click += buttonGuess_Click;
        // 
        // buttonExit
        // 
        buttonExit.Location = new Point(1073, 12);
        buttonExit.Name = "buttonExit";
        buttonExit.Size = new Size(128, 63);
        buttonExit.TabIndex = 9;
        buttonExit.Text = "Exit";
        buttonExit.UseVisualStyleBackColor = true;
        buttonExit.Click += buttonExit_Click;
        // 
        // labelFeedback
        // 
        labelFeedback.AutoSize = true;
        labelFeedback.Location = new Point(440, 253);
        labelFeedback.Name = "labelFeedback";
        labelFeedback.Size = new Size(308, 25);
        labelFeedback.TabIndex = 10;
        labelFeedback.Text = "v Click this button to make a guess! v";
        labelFeedback.Click += label1_Click_1;
        // 
        // buttonCheat
        // 
        buttonCheat.Location = new Point(296, 201);
        buttonCheat.Name = "buttonCheat";
        buttonCheat.Size = new Size(69, 31);
        buttonCheat.TabIndex = 11;
        buttonCheat.Text = "Cheat";
        buttonCheat.UseVisualStyleBackColor = true;
        buttonCheat.Click += buttonCheat_Click;
        // 
        // labelAnswer1
        // 
        labelAnswer1.AutoSize = true;
        labelAnswer1.Location = new Point(440, 173);
        labelAnswer1.Name = "labelAnswer1";
        labelAnswer1.Size = new Size(20, 25);
        labelAnswer1.TabIndex = 12;
        labelAnswer1.Text = "?";
        labelAnswer1.Click += labelAnswer1_Click;
        // 
        // labelAnswer2
        // 
        labelAnswer2.AutoSize = true;
        labelAnswer2.Location = new Point(576, 173);
        labelAnswer2.Name = "labelAnswer2";
        labelAnswer2.Size = new Size(20, 25);
        labelAnswer2.TabIndex = 13;
        labelAnswer2.Text = "?";
        // 
        // labelAnswer3
        // 
        labelAnswer3.AutoSize = true;
        labelAnswer3.Location = new Point(702, 173);
        labelAnswer3.Name = "labelAnswer3";
        labelAnswer3.Size = new Size(20, 25);
        labelAnswer3.TabIndex = 14;
        labelAnswer3.Text = "?";
        // 
        // pictureBox1
        // 
        pictureBox1.Location = new Point(337, 414);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(726, 288);
        pictureBox1.TabIndex = 15;
        pictureBox1.TabStop = false;
        pictureBox1.Click += pictureBox1_Click;
        // 
        // labelLog
        // 
        labelLog.AutoSize = true;
        labelLog.Location = new Point(12, 12);
        labelLog.Name = "labelLog";
        labelLog.Size = new Size(131, 25);
        labelLog.TabIndex = 16;
        labelLog.Text = "Latest Guesses:";
        // 
        // labelWin
        // 
        labelWin.AutoSize = true;
        labelWin.Location = new Point(440, 62);
        labelWin.Name = "labelWin";
        labelWin.Size = new Size(0, 25);
        labelWin.TabIndex = 17;
        // 
        // labelGuesses
        // 
        labelGuesses.AutoSize = true;
        labelGuesses.Location = new Point(507, 368);
        labelGuesses.Name = "labelGuesses";
        labelGuesses.Size = new Size(114, 25);
        labelGuesses.TabIndex = 18;
        labelGuesses.Text = "Guesses Left:";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1213, 745);
        Controls.Add(labelGuesses);
        Controls.Add(labelWin);
        Controls.Add(labelLog);
        Controls.Add(pictureBox1);
        Controls.Add(labelAnswer3);
        Controls.Add(labelAnswer2);
        Controls.Add(labelAnswer1);
        Controls.Add(buttonCheat);
        Controls.Add(labelFeedback);
        Controls.Add(buttonExit);
        Controls.Add(buttonGuess);
        Controls.Add(guessBox3);
        Controls.Add(guessBox2);
        Controls.Add(guessBox1);
        Controls.Add(titleLabel);
        Controls.Add(buttonReset);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button buttonReset;
    private Label titleLabel;
    private MaskedTextBox guessBox1;
    private MaskedTextBox guessBox2;
    private MaskedTextBox guessBox3;
    private Button buttonGuess;
    private Button buttonExit;
    private Label labelFeedback;
    private Button buttonCheat;
    private Label labelAnswer1;
    private Label labelAnswer2;
    private Label labelAnswer3;
    private PictureBox pictureBox1;
    private Label labelLog;
    private Label labelWin;
    private Label labelGuesses;
}
