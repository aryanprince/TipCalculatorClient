namespace TipCalculatorClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBillAmt = new System.Windows.Forms.TextBox();
            this.txtNoOfPeople = new System.Windows.Forms.TextBox();
            this.txtTipPercent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBillAmt
            // 
            this.txtBillAmt.Location = new System.Drawing.Point(413, 70);
            this.txtBillAmt.Name = "txtBillAmt";
            this.txtBillAmt.Size = new System.Drawing.Size(125, 27);
            this.txtBillAmt.TabIndex = 0;
            // 
            // txtNoOfPeople
            // 
            this.txtNoOfPeople.Location = new System.Drawing.Point(413, 125);
            this.txtNoOfPeople.Name = "txtNoOfPeople";
            this.txtNoOfPeople.Size = new System.Drawing.Size(125, 27);
            this.txtNoOfPeople.TabIndex = 1;
            // 
            // txtTipPercent
            // 
            this.txtTipPercent.Location = new System.Drawing.Point(413, 179);
            this.txtTipPercent.Name = "txtTipPercent";
            this.txtTipPercent.Size = new System.Drawing.Size(125, 27);
            this.txtTipPercent.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bill Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "No of people";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tip Percent";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(334, 263);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(96, 29);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(346, 336);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(52, 20);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Result:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTipPercent);
            this.Controls.Add(this.txtNoOfPeople);
            this.Controls.Add(this.txtBillAmt);
            this.Name = "Form1";
            this.Text = "Tip Calculator App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBillAmt;
        private TextBox txtNoOfPeople;
        private TextBox txtTipPercent;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCalculate;
        private Label lblResult;
    }
}