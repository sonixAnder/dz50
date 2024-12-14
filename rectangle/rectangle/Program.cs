using System;
using System.Drawing;
using System.Windows.Forms;

public class MainForm : Form
{
    public MainForm()
    {
        this.MouseDown += MainForm_MouseDown;
        this.MouseMove += MainForm_MouseMove;
    }

    private void MainForm_MouseDown(object sender, MouseEventArgs e)
    {
        int offset = 10;
        Rectangle rect = new Rectangle(offset,offset,this.ClientSize.Width - 2 * offset,this.ClientSize.Height - 2 * offset);

        if (e.Button == MouseButtons.Left)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                Application.Exit();
                return;
            }

            string message;
            if (rect.Contains(e.Location))
            {
                message = "Точка внутри прямоугольника.";
            }
            else if (rect.Left <= e.X && e.X <= rect.Right &&
                     (e.Y == rect.Top || e.Y == rect.Bottom) ||
                     rect.Top <= e.Y && e.Y <= rect.Bottom &&
                     (e.X == rect.Left || e.X == rect.Right))
            {
                message = "Точка на границе прямоугольника.";
            }
            else
            {
                message = "Точка снаружи прямоугольника.";
            }
            MessageBox.Show(message, "Информация о точке");
        }
        else if (e.Button == MouseButtons.Right)
        {
            string sizeInfo = $"Ширина = {this.ClientSize.Width}, Высота = {this.ClientSize.Height}";
            this.Text = sizeInfo;
        }
    }

    private void MainForm_MouseMove(object sender, MouseEventArgs e)
    {
        this.Text = $"Координаты: X = {e.X}, Y = {e.Y}";
    }

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainForm());
    }
}
