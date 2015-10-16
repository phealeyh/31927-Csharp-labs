namespace CityCentral
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openCitiesButton1 = new System.Windows.Forms.Button();
            this.openCityDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(396, 211);
            this.textBox1.TabIndex = 0;
            // 
            // openCitiesButton1
            // 
            this.openCitiesButton1.Location = new System.Drawing.Point(277, 237);
            this.openCitiesButton1.Name = "openCitiesButton1";
            this.openCitiesButton1.Size = new System.Drawing.Size(131, 23);
            this.openCitiesButton1.TabIndex = 1;
            this.openCitiesButton1.Text = "Select City File";
            this.openCitiesButton1.UseVisualStyleBackColor = true;
            //links event handler to function
            this.openCitiesButton1.Click += new System.EventHandler(this.openCitiesButton1_Click);
            // 
            // openCityDialog
            // 
            this.openCityDialog.FileName = "openFileDialog1";
            this.openCityDialog.Filter = "Text|*.txt|All|*.*";
            
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 264);
            this.Controls.Add(this.openCitiesButton1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "City Central";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button openCitiesButton1;
        private System.Windows.Forms.OpenFileDialog openCityDialog;
    }
}

