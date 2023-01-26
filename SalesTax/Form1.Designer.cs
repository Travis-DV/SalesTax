namespace SalesTax
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SalesCostTB = new System.Windows.Forms.TextBox();
            this.StateTaxLB = new System.Windows.Forms.Label();
            this.TotalLB = new System.Windows.Forms.Label();
            this.FedTaxLB = new System.Windows.Forms.Label();
            this.SalesCostLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SalesCostTB
            // 
            this.SalesCostTB.Location = new System.Drawing.Point(24, 59);
            this.SalesCostTB.Name = "SalesCostTB";
            this.SalesCostTB.Size = new System.Drawing.Size(100, 20);
            this.SalesCostTB.TabIndex = 0;
            this.SalesCostTB.TextChanged += new System.EventHandler(this.SalesCostTB_TextChanged);
            // 
            // StateTaxLB
            // 
            this.StateTaxLB.AutoSize = true;
            this.StateTaxLB.Location = new System.Drawing.Point(176, 34);
            this.StateTaxLB.Name = "StateTaxLB";
            this.StateTaxLB.Size = new System.Drawing.Size(162, 13);
            this.StateTaxLB.TabIndex = 1;
            this.StateTaxLB.Text = "Your state tax is 6% costing you: ";
            // 
            // TotalLB
            // 
            this.TotalLB.AutoSize = true;
            this.TotalLB.Location = new System.Drawing.Point(176, 82);
            this.TotalLB.Name = "TotalLB";
            this.TotalLB.Size = new System.Drawing.Size(60, 13);
            this.TotalLB.TabIndex = 2;
            this.TotalLB.Text = "Total cost: ";
            // 
            // FedTaxLB
            // 
            this.FedTaxLB.AutoSize = true;
            this.FedTaxLB.Location = new System.Drawing.Point(176, 59);
            this.FedTaxLB.Name = "FedTaxLB";
            this.FedTaxLB.Size = new System.Drawing.Size(171, 13);
            this.FedTaxLB.TabIndex = 3;
            this.FedTaxLB.Text = "Your federal tax is 2% costing you: ";
            // 
            // SalesCostLB
            // 
            this.SalesCostLB.AutoSize = true;
            this.SalesCostLB.Location = new System.Drawing.Point(21, 34);
            this.SalesCostLB.Name = "SalesCostLB";
            this.SalesCostLB.Size = new System.Drawing.Size(59, 13);
            this.SalesCostLB.TabIndex = 4;
            this.SalesCostLB.Text = "Sales cost:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 144);
            this.Controls.Add(this.SalesCostLB);
            this.Controls.Add(this.FedTaxLB);
            this.Controls.Add(this.TotalLB);
            this.Controls.Add(this.StateTaxLB);
            this.Controls.Add(this.SalesCostTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SalesCostTB;
        private System.Windows.Forms.Label StateTaxLB;
        private System.Windows.Forms.Label TotalLB;
        private System.Windows.Forms.Label FedTaxLB;
        private System.Windows.Forms.Label SalesCostLB;
    }
}

