namespace lab2
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
            btnCalculatePower = new Button();
            txtBase = new TextBox();
            txtExponent = new TextBox();
            lblPowerResult = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCalculatePower
            // 
            btnCalculatePower.Location = new Point(118, 182);
            btnCalculatePower.Name = "btnCalculatePower";
            btnCalculatePower.Size = new Size(75, 23);
            btnCalculatePower.TabIndex = 0;
            btnCalculatePower.Text = "Calculate";
            btnCalculatePower.UseVisualStyleBackColor = true;
            btnCalculatePower.Click += btnCalculatePower_Click_1;
            // 
            // txtBase
            // 
            txtBase.Location = new Point(227, 182);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(100, 23);
            txtBase.TabIndex = 1;
            // 
            // txtExponent
            // 
            txtExponent.Location = new Point(333, 183);
            txtExponent.Name = "txtExponent";
            txtExponent.Size = new Size(100, 23);
            txtExponent.TabIndex = 2;
            // 
            // lblPowerResult
            // 
            lblPowerResult.AutoSize = true;
            lblPowerResult.Location = new Point(227, 224);
            lblPowerResult.Name = "lblPowerResult";
            lblPowerResult.Size = new Size(39, 15);
            lblPowerResult.TabIndex = 3;
            lblPowerResult.Text = "Result";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 164);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 4;
            label1.Text = "Base";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(333, 164);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 5;
            label2.Text = "Exponent";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblPowerResult);
            Controls.Add(txtExponent);
            Controls.Add(txtBase);
            Controls.Add(btnCalculatePower);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculatePower;
        private TextBox txtBase;
        private TextBox txtExponent;
        private Label lblPowerResult;
        private Label label1;
        private Label label2;
    }
}
