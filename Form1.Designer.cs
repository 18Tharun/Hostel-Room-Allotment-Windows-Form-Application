namespace HostelManagementApplication
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
            this.button1 = new System.Windows.Forms.Button();
            this.VACATE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 172);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "FIND A ROOM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VACATE
            // 
            this.VACATE.Location = new System.Drawing.Point(441, 173);
            this.VACATE.Margin = new System.Windows.Forms.Padding(5);
            this.VACATE.Name = "VACATE";
            this.VACATE.Size = new System.Drawing.Size(219, 35);
            this.VACATE.TabIndex = 1;
            this.VACATE.Text = "VACATE ROOM";
            this.VACATE.UseVisualStyleBackColor = true;
            this.VACATE.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 332);
            this.Controls.Add(this.VACATE);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button VACATE;
    }
}

