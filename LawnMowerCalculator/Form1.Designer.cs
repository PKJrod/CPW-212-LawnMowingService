
namespace LawnMowerCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.sqftTxt = new System.Windows.Forms.TextBox();
            this.hoursTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.calculateCmd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Square Feet:";
            // 
            // sqftTxt
            // 
            this.sqftTxt.Location = new System.Drawing.Point(204, 63);
            this.sqftTxt.Name = "sqftTxt";
            this.sqftTxt.Size = new System.Drawing.Size(100, 22);
            this.sqftTxt.TabIndex = 1;
            // 
            // hoursTxt
            // 
            this.hoursTxt.Location = new System.Drawing.Point(204, 125);
            this.hoursTxt.Name = "hoursTxt";
            this.hoursTxt.ReadOnly = true;
            this.hoursTxt.Size = new System.Drawing.Size(100, 22);
            this.hoursTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hour to complete:";
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(204, 181);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.ReadOnly = true;
            this.priceTxt.Size = new System.Drawing.Size(100, 22);
            this.priceTxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price:";
            // 
            // calculateCmd
            // 
            this.calculateCmd.Location = new System.Drawing.Point(81, 257);
            this.calculateCmd.Name = "calculateCmd";
            this.calculateCmd.Size = new System.Drawing.Size(148, 65);
            this.calculateCmd.TabIndex = 6;
            this.calculateCmd.Text = "Calculate";
            this.calculateCmd.UseVisualStyleBackColor = true;
            this.calculateCmd.Click += new System.EventHandler(this.calculateCmd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculateCmd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hoursTxt);
            this.Controls.Add(this.sqftTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sqftTxt;
        private System.Windows.Forms.TextBox hoursTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calculateCmd;
    }
}

