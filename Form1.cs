namespace worsesteamgames;

public partial class Form1 : Form
{
    GuessingGame game;

    public Form1()
    {
        InitializeComponent();
        game = new GuessingGame();
        UpdateGuessesLeft();
        UpdateLogLabel();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    // Reset button
    private void button1_Click(object sender, EventArgs e)
    {
        Form1 newForm = new Form1();
        newForm.Show();
        this.Dispose(false);
    }

    // Exit Button
    private void buttonExit_Click(object sender, EventArgs e)
    {
        this.Dispose(false);
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
    {

    }

    private void guessBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
    {

    }

    private void label1_Click_1(object sender, EventArgs e)
    {

    }

    private void buttonCheat_Click(object sender, EventArgs e)
    {
        labelAnswer1.Text = game.num1.ToString();
        labelAnswer2.Text = game.num2.ToString();
        labelAnswer3.Text = game.num3.ToString();
    }

    private void labelAnswer1_Click(object sender, EventArgs e)
    {

    }

    // Guess button
    private void buttonGuess_Click(object sender, EventArgs e)
    {
        string result = "";
        try
        {
            result = game.MakeGuess(int.Parse(guessBox1.Text), int.Parse(guessBox2.Text), int.Parse(guessBox3.Text));
            labelFeedback.Text = result;
        }
        catch
        {
            Console.WriteLine("Bad parse");
        }
        UpdateGuessesLeft();

        UpdateLogLabel();

        if (result == "Close")
        {
            // Display SmallClick.png
            pictureBox1.Image = Properties.Resources._1;
        }
        else if (result == "Correct")
        {
            // Display BigClick.png
            pictureBox1.Image = Properties.Resources._2;
            labelWin.Text = "YOU WIN!!!!";
        }
        else
        {
            pictureBox1.Image = null;
        }
    }

    private void UpdateGuessesLeft()
    {
        labelGuesses.Text = "Guesses Left: " + game.guessesLeft + " / " + game.maxGuesses;
    }

    private void UpdateLogLabel()
    {
        labelLog.Text = "Latest Guesses:\n" + game.prevGuesses1[0] + " - " + game.prevGuesses1[1] + " - " + game.prevGuesses1[2] + ": " + game.prevResult1 + "\n" +
            game.prevGuesses2[0] + " - " + game.prevGuesses2[1] + " - " + game.prevGuesses2[2] + ": " + game.prevResult2 + "\n" +
            game.prevGuesses3[0] + " - " + game.prevGuesses3[1] + " - " + game.prevGuesses3[2] + ": " + game.prevResult3;
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }
}
