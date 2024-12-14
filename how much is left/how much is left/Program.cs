using System;
using System.Windows.Forms;

public class MainForm : Form
{
    private Label instructionLabel;
    private TextBox dateInputTextBox;
    private Button calculateButton;
    private Label resultLabel;
    private RadioButton yearsRadioButton;
    private RadioButton monthsRadioButton;
    private RadioButton daysRadioButton;
    private RadioButton minutesRadioButton;
    private RadioButton secondsRadioButton;

    public MainForm()
    {
        this.Text = "���������� ������� �� ����";
        this.Size = new System.Drawing.Size(400, 300);
        this.StartPosition = FormStartPosition.CenterScreen;

        instructionLabel = new Label();
        instructionLabel.Text = "������� ���� (� ������� ��.��.����):";
        instructionLabel.Location = new System.Drawing.Point(10, 20);
        instructionLabel.Size = new System.Drawing.Size(300, 20);
        this.Controls.Add(instructionLabel);

        dateInputTextBox = new TextBox();
        dateInputTextBox.Location = new System.Drawing.Point(10, 50);
        dateInputTextBox.Size = new System.Drawing.Size(150, 20);
        this.Controls.Add(dateInputTextBox);

        calculateButton = new Button();
        calculateButton.Text = "��������� �����";
        calculateButton.Location = new System.Drawing.Point(170, 50);
        calculateButton.Click += CalculateButton_Click;
        this.Controls.Add(calculateButton);

        yearsRadioButton = new RadioButton();
        yearsRadioButton.Text = "����";
        yearsRadioButton.Location = new System.Drawing.Point(10, 80);
        yearsRadioButton.Checked = true;
        this.Controls.Add(yearsRadioButton);

        monthsRadioButton = new RadioButton();
        monthsRadioButton.Text = "������";
        monthsRadioButton.Location = new System.Drawing.Point(10, 110);
        this.Controls.Add(monthsRadioButton);

        daysRadioButton = new RadioButton();
        daysRadioButton.Text = "���";
        daysRadioButton.Location = new System.Drawing.Point(10, 140);
        this.Controls.Add(daysRadioButton);

        minutesRadioButton = new RadioButton();
        minutesRadioButton.Text = "������";
        minutesRadioButton.Location = new System.Drawing.Point(10, 170);
        this.Controls.Add(minutesRadioButton);

        secondsRadioButton = new RadioButton();
        secondsRadioButton.Text = "�������";
        secondsRadioButton.Location = new System.Drawing.Point(10, 200);
        this.Controls.Add(secondsRadioButton);

        resultLabel = new Label();
        resultLabel.Location = new System.Drawing.Point(10, 230);
        resultLabel.Size = new System.Drawing.Size(350, 20);
        this.Controls.Add(resultLabel);
    }

    private void CalculateButton_Click(object sender, EventArgs e)
    {
        DateTime inputDate;
        bool isValidDate = DateTime.TryParseExact(dateInputTextBox.Text, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out inputDate);

        if (isValidDate)
        {
            TimeSpan timeRemaining = inputDate - DateTime.Now;
            double result = 0;

            if (yearsRadioButton.Checked)
            {
                result = timeRemaining.Days / 365.25;
                resultLabel.Text = $"��������: {result:F2} ���";
            }
            else if (monthsRadioButton.Checked)
            {
                result = timeRemaining.Days / 30.44;
                resultLabel.Text = $"��������: {result:F2} �������";
            }
            else if (daysRadioButton.Checked)
            {
                result = timeRemaining.Days;
                resultLabel.Text = $"��������: {result} ����";
            }
            else if (minutesRadioButton.Checked)
            {
                result = timeRemaining.TotalMinutes;
                resultLabel.Text = $"��������: {result:F2} �����";
            }
            else if (secondsRadioButton.Checked)
            {
                result = timeRemaining.TotalSeconds;
                resultLabel.Text = $"��������: {result:F2} ������";
            }
        }
        else
        {
            resultLabel.Text = "������! ������� ���������� ���� � ������� ��.��.����.";
        }
    }

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new MainForm());
    }
}
