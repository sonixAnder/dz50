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

            DialogResult result = MessageBox.Show($"���� ����� {guess}?\n\n�������:\n�� - ���� �������\n��� - ���� ���� ����� ������\n������ - ���� ������",$"������� {attempts}",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show($"����� �������! ��� {guess}.\n������������� �������: {attempts}","������!",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
                MessageBox.Show("���-�� ����� �� ���. ���������� �����!","������",MessageBoxButtons.OK,MessageBoxIcon.Error);
                break;
            }
        }

        DialogResult playAgain = MessageBox.Show("������ ������� ��� ���?", "�������?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

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
