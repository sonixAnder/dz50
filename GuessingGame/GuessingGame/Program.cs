using System;
using System.Windows.Forms;

public class guessingGame : Form
{
    private int lowerBound;
    private int upperBound;
    private int guess;
    private int attempts;

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new guessingGame());
    }

    public guessingGame()
    {
        StartGame();
    }

    private void StartGame()
    {
        lowerBound = 1;
        upperBound = 2000;
        attempts = 0;

        while (true)
        {
            attempts++;
            guess = (lowerBound + upperBound) / 2;

            DialogResult result = MessageBox.Show($"Ваше число {guess}?\n\nНажмите:\nДа - если угадано\nНет - если ваше число меньше\nОтмена - если больше",$"Попытка {attempts}",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show($"Число угадано! Это {guess}.\nПотребовалось попыток: {attempts}","Победа!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                break;
            }
            else if (result == DialogResult.No)
            {
                upperBound = guess - 1;
            }
            else if (result == DialogResult.Cancel)
            {
                lowerBound = guess + 1;
            }

            if (lowerBound > upperBound)
            {
                MessageBox.Show("Что-то пошло не так. Попробуйте снова!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                break;
            }
        }

        DialogResult playAgain = MessageBox.Show("Хотите сыграть еще раз?", "Сыграем?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

        if (playAgain == DialogResult.Yes)
        {
            StartGame();
        }
        else
        {
            Application.Exit();
        }
    }
}
