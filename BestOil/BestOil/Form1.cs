namespace BestOil
{
    public partial class Form1 : Form
    {
        // Цены на топливо и товары
        private readonly decimal[] fuelPrices = { 16.40m, 17.20m, 18.50m }; // Пример цен
        private const decimal hotDogPrice = 50.00m;
        private const decimal hamburgerPrice = 40.40m;
        private const decimal friesPrice = 35.20m;
        private const decimal colaPrice = 80.40m;
        private decimal totalRevenue = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeForm()
        {
            comboBoxFuel.Items.AddRange(new string[] { "АИ-92", "АИ-95", "Дизель" });
            comboBoxFuel.SelectedIndex = 0;
            UpdateFuelPrice();

            comboBoxFuel.SelectedIndexChanged += (s, e) => UpdateFuelPrice();
            radioButtonQuantity.CheckedChanged += (s, e) => ToggleFuelInput();
            radioButtonSum.CheckedChanged += (s, e) => ToggleFuelInput();
        }
        private void UpdateFuelPrice()
        {
            textBoxFuelPrice.Text = fuelPrices[comboBoxFuel.SelectedIndex].ToString("0.00");
        }

        private void ToggleFuelInput()
        {
            textBoxQuantity.Enabled = radioButtonQuantity.Checked;
            textBoxSum.Enabled = radioButtonSum.Checked;

            if (radioButtonQuantity.Checked) textBoxSum.Clear();
            if (radioButtonSum.Checked) textBoxQuantity.Clear();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            decimal fuelTotal = CalculateFuelTotal();
            decimal cafeTotal = CalculateCafeTotal();
            decimal total = fuelTotal + cafeTotal;

            labelFuelTotal.Text = $"{fuelTotal:0.00} руб.";
            labelCafeTotal.Text = $"{cafeTotal:0.00} руб.";
            labelTotalSum.Text = $"{total:0.00} руб.";

            totalRevenue += total;

        }

        private decimal CalculateFuelTotal()
        {
            decimal price = fuelPrices[comboBoxFuel.SelectedIndex];
            if (radioButtonQuantity.Checked && decimal.TryParse(textBoxQuantity.Text, out decimal liters))
            {
                return liters * price;
            }
            else if (radioButtonSum.Checked && decimal.TryParse(textBoxSum.Text, out decimal amount))
            {
                textBoxQuantity.Text = (amount / price).ToString("0.00");
                return amount;
            }
            return 0;
        }

        private decimal CalculateCafeTotal()
        {
            decimal total = 0;
            if (checkBoxHotDog.Checked && int.TryParse(textBoxHotDogQuantity.Text, out int hotDogs))
                total += hotDogs * hotDogPrice;

            if (checkBoxHamburger.Checked && int.TryParse(textBoxHamburgerQuantity.Text, out int hamburgers))
                total += hamburgers * hamburgerPrice;

            if (checkBoxFries.Checked && int.TryParse(textBoxFriesQuantity.Text, out int fries))
                total += fries * friesPrice;

            if (checkBoxCola.Checked && int.TryParse(textBoxColaQuantity.Text, out int colas))
                total += colas * colaPrice;

            return total;
        }

        private void ResetForm()
        {
            comboBoxFuel.SelectedIndex = 0;
            textBoxQuantity.Clear();
            textBoxSum.Clear();
            checkBoxHotDog.Checked = checkBoxHamburger.Checked = checkBoxFries.Checked = checkBoxCola.Checked = false;
            textBoxHotDogQuantity.Clear();
            textBoxHamburgerQuantity.Clear();
            textBoxFriesQuantity.Clear();
            textBoxColaQuantity.Clear();
            labelFuelTotal.Text = "0.00 руб.";
            labelCafeTotal.Text = "0.00 руб.";
            labelTotalSum.Text = "0.00 руб.";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show($"Общая выручка за день: {totalRevenue:0.00} руб.", "Итоговая выручка");
        }

        //на методы ниже не надо обращать внимание, если их удалить, программа не будет работать
        private void comboBoxFuel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonSum_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFuelPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxCola_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCafeTotal_Click(object sender, EventArgs e)
        {

        }

        private void labelFuelTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
