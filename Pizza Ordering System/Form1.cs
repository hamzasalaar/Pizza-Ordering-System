using System.Globalization;
using System.Windows.Forms;
using System.Diagnostics;

namespace Pizza_Ordering_System
{
    public partial class Form1 : Form
    {
        string[] pizzaNames = { "Sicilian", "Marine", "Napolitan", "Mixed" };
        double[] pizzaPrices = { 75.50, 80.50, 90.00, 95.50 };
        int[] calories = { 100, 125, 125, 140 };
        double[] additions = { 15, 10, 25, 40, 10 };
        public Form1()
        {
            InitializeComponent();

            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;

            textBox2.Multiline = true;
            sicilianRadbtn.Checked = false;
            marineRadbtn.Checked = false;
            napolitanRadbtn.Checked = false;
            mixedRadbtn.Checked = false;

            checkBox1.CheckedChanged += numericUpDown1_ValueChanged;
            checkBox2.CheckedChanged += numericUpDown1_ValueChanged;
            checkBox3.CheckedChanged += numericUpDown1_ValueChanged;
            checkBox4.CheckedChanged += numericUpDown1_ValueChanged;
            checkBox5.CheckedChanged += numericUpDown1_ValueChanged;
            sicilianRadbtn.CheckedChanged += numericUpDown1_ValueChanged;
            marineRadbtn.CheckedChanged += numericUpDown1_ValueChanged;
            napolitanRadbtn.CheckedChanged += numericUpDown1_ValueChanged;
            mixedRadbtn.CheckedChanged += numericUpDown1_ValueChanged;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // prevent the "ding" sound when Enter is pressed
                textBox2.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                // Capitalize the first letter of each word
                textBox1.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox1.Text);

                // Set the cursor position to the end of the textbox to prevent jumping
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (textBox2.Text != "" && textBox1.Text != "")
                {
                    groupBox2.Focus();
                    groupBox2.Enabled = true;
                    groupBox3.Enabled = true;
                    groupBox4.Enabled = true;
                    groupBox1.Enabled = false;
                }
                else MessageBox.Show("Name and address required!");
            }
        }

        double unitPrice = 0;
        double totalPrice = 0;
        double totalCal = 0;

        private void CalculatePrices(int pizzaIndex)
        {
            // Set unit price and total price based on selected pizza type and quantity
            unitPrice = pizzaPrices[pizzaIndex];
            totalPrice = unitPrice * Convert.ToDouble(numericUpDown1.Value);
            totalCal = calories[pizzaIndex] * Convert.ToDouble(numericUpDown1.Value);

            // Add additional toppings prices to the total price
            if (checkBox1.Checked)
                totalPrice += additions[0];
            if (checkBox2.Checked)
                totalPrice += additions[1];
            if (checkBox3.Checked)
                totalPrice += additions[2];
            if (checkBox4.Checked)
                totalPrice += additions[3];
            if (checkBox5.Checked)
                totalPrice += additions[4];

            // Update text boxes with new prices and calories
            textBox3.Text = unitPrice.ToString();
            textBox4.Text = totalPrice.ToString();
            textBox5.Text = totalCal.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (sicilianRadbtn.Checked)
            {
                pictureBox1.Image = imageList1.Images[0];
                CalculatePrices(0);
            }
            else if (marineRadbtn.Checked)
            {
                pictureBox1.Image = imageList1.Images[1];
                CalculatePrices(1);
            }
            else if (napolitanRadbtn.Checked)
            {
                pictureBox1.Image = imageList1.Images[2];
                CalculatePrices(2);
            }
            else if (mixedRadbtn.Checked)
            {
                pictureBox1.Image = imageList1.Images[3];
                CalculatePrices(3);
            }
        }

        public class InvoiceItem
        {
            public string PizzaType { get; set; }
            public int Quantity { get; set; }
            public double UnitPrice { get; set; }
            public double TotalPrice => Quantity * UnitPrice;

            public override string ToString()
            {
                return $"{PizzaType} {Quantity,40} x {UnitPrice,25:F2}  {TotalPrice,30:F2}";
            }
        }

        private List<InvoiceItem> invoices = new List<InvoiceItem>();

        private string GetSelectedPizzaType()
        {
            if (sicilianRadbtn.Checked)
                return pizzaNames[0];
            else if (marineRadbtn.Checked)
                return pizzaNames[1];
            else if (napolitanRadbtn.Checked)
                return pizzaNames[2];
            else if (mixedRadbtn.Checked)
                return pizzaNames[3];
            else
            {
                MessageBox.Show("Please select a pizza type.");
                return "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pizzaType = GetSelectedPizzaType();
            if (pizzaType != "")
            {
                int quantity = (int)numericUpDown1.Value;
                double unitPrice = Convert.ToDouble(textBox3.Text);

                InvoiceItem invoiceItem = new InvoiceItem
                {
                    PizzaType = pizzaType,
                    Quantity = quantity,
                    UnitPrice = unitPrice
                };

                invoices.Add(invoiceItem);
                UpdateInvoiceListBox();
                CalculateGrandTotal();

                button1.Enabled = false;
                
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
            }
        }

        private void UpdateInvoiceListBox()
        {
            listBox1.Items.Clear();
            foreach (var item in invoices)
            {
                listBox1.Items.Add(item);
            }
        }

        public void CalculateGrandTotal()
        {
            double grandTotal = invoices.Sum(item => item.TotalPrice);
            textBox6.Text = grandTotal.ToString("F2");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            for (int x = listBox1.SelectedIndices.Count - 1; x >= 0; x--)
            {
                int idx = listBox1.SelectedIndices[x];
                listBox1.Items.RemoveAt(idx);

                invoices.RemoveAt(idx);

                CalculateGrandTotal();
            }
        }

        private void resetGroupBoxes()
        {
            foreach (Control ctrl in groupBox2.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)ctrl;
                    radioButton.Checked = false;
                }
            }
            foreach (Control ctrl in groupBox4.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)ctrl;
                    checkBox.Checked = false;
                }
            }
            foreach (Control ctrl in groupBox3.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox textBox = (TextBox)ctrl;
                    textBox.Text = null;
                }
            }

            numericUpDown1.Value = 1;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Name and address required!");
            }
            else resetGroupBoxes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resetGroupBoxes();

            listBox1.Items.Clear();
            textBox1.Text = null;
            textBox2.Text = null;
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
