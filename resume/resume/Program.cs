using System;
using System.Windows.Forms;

public class ResumeApp : Form
{
    [STAThread]
    public static void Main()
    {
        string part1 = "���: ������ ������.";
        string part2 = "����: ����� ������������� � ���������� ���.";
        string part3 = "������: ����-��� ���������� ����.";
        string part4 = "���� �� ����, � ������� �����: Delta Force Hawk Ops.";


        int totalCharacters = part1.Length + part2.Length + part3.Length;
        int messageBoxCount = 3;
        int averageCharacters = totalCharacters / messageBoxCount;

        MessageBox.Show(part1, "������ (1 �� 3)");
        MessageBox.Show(part2, "������ (2 �� 3)");
        MessageBox.Show(part3, $"������� ��������: {averageCharacters}");
    }
}
