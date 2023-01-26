using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesTax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SalesCostTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float cost = float.Parse(SalesCostTB.Text) / 50;
                StateTaxLB.Text = $"Your state tax is 6% costing you: {cost * 3}";
                FedTaxLB.Text = $"Your federal tax is 2% costing you: {cost}";
                TotalLB.Text = $"Total cost: {int.Parse(SalesCostTB.Text) + (cost * 4)}";
            }
            catch (FormatException)
            {
                if (SalesCostTB.Text == "")
                {
                    StateTaxLB.Text = "Your state tax is 6% costing you: ";
                    FedTaxLB.Text = "Your federal tax is 2% costing you: ";
                    TotalLB.Text = "Total cost: ";
                }
                else
                {
                    StateTaxLB.Text = "Please input a int into the cost textbox";
                    FedTaxLB.Text = "Please input a int into the cost textbox";
                    TotalLB.Text = "Please input a int into the cost textbox";
                }
            }
        }
    }
}
