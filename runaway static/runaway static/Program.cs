using System;
using System.Drawing;
using System.Windows.Forms;

public class MainForm : Form
{
    private Label movingLabel;
    private Random random;
    private int escapeDistance = 50;

    public MainForm()
    {
        this.Text = "Убегающий статик";
        this.Size = new Size(800, 600);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.StartPosition = FormStartPosition.CenterScreen;

        movingLabel = new Label();
        movingLabel.Text = "Не поймаешь :)";
        movingLabel.AutoSize = true;
        movingLabel.Location = new Point(350, 250);
        movingLabel.BackColor = Color.LightBlue;
        movingLabel.Font = new Font("Arial", 14, FontStyle.Bold);
        this.Controls.Add(movingLabel);

        random = new Random();

        this.MouseMove += MainForm_MouseMove;
    }

    private void MainForm_MouseMove(object sender, MouseEventArgs e)
    {
        if (IsCursorCloseToLabel(e.Location))
        {
            MoveLabelAwayFromCursor();
        }
    }

    private bool IsCursorCloseToLabel(Point cursorPosition)
    {
        var labelCenter = new Point(movingLabel.Left + movingLabel.Width / 2, movingLabel.Top + movingLabel.Height / 2);
        double distance = Math.Sqrt(Math.Pow(cursorPosition.X - labelCenter.X, 2) + Math.Pow(cursorPosition.Y - labelCenter.Y, 2));

        return distance < escapeDistance;
    }

    private void MoveLabelAwayFromCursor()
    {
        int newX, newY;

        do
        {
            newX = random.Next(0, this.ClientSize.Width - movingLabel.Width);
            newY = random.Next(0, this.ClientSize.Height - movingLabel.Height);
        } while (new Rectangle(newX, newY, movingLabel.Width, movingLabel.Height).IntersectsWith(new Rectangle(movingLabel.Left, movingLabel.Top, movingLabel.Width, movingLabel.Height)));

        movingLabel.Location = new Point(newX, newY);
    }

    public static void Main()
    {
        Application.Run(new MainForm());
    }
}
