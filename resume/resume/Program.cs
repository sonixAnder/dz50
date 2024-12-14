using System;
using System.Windows.Forms;

public class ResumeApp : Form
{
    [STAThread]
    public static void Main()
    {
        string part1 = "Имя: Максим Серкин.";
        string part2 = "Опыт: Будет накапливаться в разработке игр.";
        string part3 = "Навыки: Пока-что выдающихся нету.";
        string part4 = "Одна из игры, в которые играю: Delta Force Hawk Ops.";


        int totalCharacters = part1.Length + part2.Length + part3.Length;
        int messageBoxCount = 3;
        int averageCharacters = totalCharacters / messageBoxCount;

        MessageBox.Show(part1, "Резюме (1 из 3)");
        MessageBox.Show(part2, "Резюме (2 из 3)");
        MessageBox.Show(part3, $"Среднее символов: {averageCharacters}");
    }
}
