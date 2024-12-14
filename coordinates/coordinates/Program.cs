using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public class MainForm : Form
{
    private List<StaticBox> staticBoxes = new List<StaticBox>();
    private Point startPoint;
    private bool isDrawing = false;

    public MainForm()
    {
        this.Text = "Static Boxes Application";
        this.Size = new Size(800, 600);
        this.MouseDown += MainForm_MouseDown;
        this.MouseMove += MainForm_MouseMove;
        this.MouseUp += MainForm_MouseUp;
        this.MouseClick += MainForm_MouseClick;
        this.DoubleClick += MainForm_DoubleClick;
    }

    private void MainForm_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            startPoint = e.Location;
            isDrawing = true;
        }
    }

    private void MainForm_MouseMove(object sender, MouseEventArgs e)
    {
        if (isDrawing)
        {
            this.Invalidate();
        }
    }

    private void MainForm_MouseUp(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left && isDrawing)
        {
            var width = e.X - startPoint.X;
            var height = e.Y - startPoint.Y;

            if (Math.Abs(width) < 10 || Math.Abs(height) < 10)
            {
                MessageBox.Show("Минимальный размер статик-бокса 10x10 пикселей.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                staticBoxes.Add(new StaticBox(startPoint, new Size(width, height), staticBoxes.Count + 1));
            }
            isDrawing = false;
            this.Invalidate();
        }
    }

    private void MainForm_MouseClick(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right)
        {
            foreach (var box in staticBoxes)
            {
                if (box.Contains(e.Location))
                {
                    MessageBox.Show($"Площадь: {box.Area} \nКоординаты: {box.TopLeft}", "Информация о статике");
                }
            }
        }
    }

    private void MainForm_DoubleClick(object sender, EventArgs e)
    {
        if (e is MouseEventArgs me)
        {
            var clickedBox = staticBoxes.Find(box => box.Contains(me.Location));

            if (clickedBox != null)
            {
                staticBoxes.Remove(clickedBox);
                this.Invalidate();
            }
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        foreach (var box in staticBoxes)
        {
            e.Graphics.FillRectangle(Brushes.AliceBlue, box.Rectangle);
            e.Graphics.DrawRectangle(Pens.Black, box.Rectangle);
            e.Graphics.DrawString(box.Number.ToString(), this.Font, Brushes.Black, box.Rectangle.Location);
        }

        if (isDrawing)
        {
            var currentWidth = Cursor.Position.X - this.Left - startPoint.X;
            var currentHeight = Cursor.Position.Y - this.Top - startPoint.Y;
            e.Graphics.DrawRectangle(Pens.Gray, startPoint.X, startPoint.Y, currentWidth, currentHeight);
        }
    }

    public static void Main()
    {
        Application.Run(new MainForm());
    }
}

public class StaticBox
{
    public Point TopLeft { get; }
    public Size Size { get; }
    public int Number { get; }

    public StaticBox(Point topLeft, Size size, int number)
    {
        TopLeft = topLeft;
        Size = size;
        Number = number;
    }

    public Rectangle Rectangle => new Rectangle(TopLeft, Size);
    public int Area => Size.Width * Size.Height;

    public bool Contains(Point point)
    {
        return Rectangle.Contains(point);
    }
}
