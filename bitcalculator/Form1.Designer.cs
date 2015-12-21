namespace bitcalculator
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
            this.tbSize = new System.Windows.Forms.TextBox();
            this.labelBits = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(12, 97);
            this.tbSize.Name = "tbSize";
            this.tbSize.ReadOnly = true;
            this.tbSize.Size = new System.Drawing.Size(378, 20);
            this.tbSize.TabIndex = 11;
            // 
            // labelBits
            // 
            this.labelBits.AutoSize = true;
            this.labelBits.Location = new System.Drawing.Point(9, 81);
            this.labelBits.Name = "labelBits";
            this.labelBits.Size = new System.Drawing.Size(55, 13);
            this.labelBits.TabIndex = 10;
            this.labelBits.Text = "Size (bits):";
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(9, 5);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(127, 13);
            this.labelInput.TabIndex = 9;
            this.labelInput.Text = "String to encode (UTF-8):";
            // 
            // textBoxInput
            // 
            this.textBoxInput.AcceptsReturn = true;
            this.textBoxInput.AcceptsTab = true;
            this.textBoxInput.Location = new System.Drawing.Point(12, 21);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(378, 57);
            this.textBoxInput.TabIndex = 8;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Developed by Janak.\r\n@zsrestha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 153);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.labelBits);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.textBoxInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bit Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Label labelBits;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label label1;
    }
}

