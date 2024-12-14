using System;
using System.Windows.Forms;

public class MainForm : Form
{
    private Label instructionLabel;
    private TextBox dateInputTextBox;
    private Button checkButton;
    private Label resultLabel;

    public MainForm()
    {
        this.Text = "Определение дня недели";
        this.Size = new System.Drawing.Size(400, 200);
        this.StartPosition = FormStartPosition.CenterScreen;

        instructionLabel = new Label();
        instructionLabel.Text = "Введите дату (в формате дд.мм.гггг):";
        instructionLabel.Location = new System.Drawing.Point(10, 20);
        instructionLabel.Size = new System.Drawing.Size(300, 20);
        this.Controls.Add(instructionLabel);

        dateInputTextBox = new TextBox();
        dateInputTextBox.Location = new System.Drawing.Point(10, 50);
        dateInputTextBox.Size = new System.Drawing.Size(150, 20);
        this.Controls.Add(dateInputTextBox);

        checkButton = new Button();
        checkButton.Text = "Определить день";
        checkButton.Location = new System.Drawing.Point(170, 50);
        checkButton.Click += CheckButton_Click;
        this.Controls.Add(checkButton);

        resultLabel = new Label();
        resultLabel.Location = new System.Drawing.Point(10, 80);
        resultLabel.Size = new System.Drawing.Size(300, 20);
        this.Controls.Add(resultLabel);
    }

    private void CheckButton_Click(object sender, EventArgs e)
    {
        DateTime inputDate;
        bool isValidDate = DateTime.TryParseExact(dateInputTextBox.Text, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out inputDate);

        if (isValidDate)
        {
            string dayOfWeek = GetDayOfWeekInRussian(inputDate.DayOfWeek);
            resultLabel.Text = "День недели: " + dayOfWeek;
        }
        else
        {
            resultLabel.Text = "Ошибка! Введите корректную дату в формате дд.мм.гггг.";
        }
    }

    private string GetDayOfWeekInRussian(DayOfWeek dayOfWeek)
    {
        switch (dayOfWeek)
        {
            case DayOfWeek.Monday:
                return "Понедельник";
            case DayOfWeek.Tuesday:
                return "Вторник";
            case DayOfWeek.Wednesday:
                return "Среда";
            case DayOfWeek.Thursday:
                return "Четверг";
            case DayOfWeek.Friday:
                return "Пятница";
            case DayOfWeek.Saturday:
                return "Суббота";
            case DayOfWeek.Sunday:
                return "Воскресенье";
            default:
                return "Неизвестный день";
        }
    }

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new MainForm());
    }
}
