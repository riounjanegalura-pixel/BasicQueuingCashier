namespace BasicQueuingCashier
{
    partial class CustomerView
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Now serving";
            // 
            // lblCurrentNumber
            // 
            this.lblCurrentNumber.AutoSize = true;
            this.lblCurrentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentNumber.Location = new System.Drawing.Point(324, 183);
            this.lblCurrentNumber.Name = "lblCurrentNumber";
            this.lblCurrentNumber.Size = new System.Drawing.Size(109, 39);
            this.lblCurrentNumber.TabIndex = 1;
            this.lblCurrentNumber.Text = "label2";
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCurrentNumber);
            this.Controls.Add(this.label1);
            this.Name = "CustomerView";
            this.Text = "CustomerView";
            this.Load += new System.EventHandler(this.CustomerView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentNumber;
    }
}