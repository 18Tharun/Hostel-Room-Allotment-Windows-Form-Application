namespace HostelManagementApplication
{
    partial class roomAllotment
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
            this.Nametextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roomno = new System.Windows.Forms.TextBox();
            this.amt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PAYMENT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nametextbox
            // 
            this.Nametextbox.Location = new System.Drawing.Point(482, 54);
            this.Nametextbox.Margin = new System.Windows.Forms.Padding(5);
            this.Nametextbox.Name = "Nametextbox";
            this.Nametextbox.Size = new System.Drawing.Size(377, 46);
            this.Nametextbox.TabIndex = 0;
            this.Nametextbox.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "ENTER ROOM NUMBER";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // roomno
            // 
            this.roomno.Location = new System.Drawing.Point(482, 157);
            this.roomno.Margin = new System.Windows.Forms.Padding(5);
            this.roomno.Name = "roomno";
            this.roomno.Size = new System.Drawing.Size(377, 46);
            this.roomno.TabIndex = 3;
            // 
            // amt
            // 
            this.amt.Location = new System.Drawing.Point(479, 259);
            this.amt.Margin = new System.Windows.Forms.Padding(5);
            this.amt.Name = "amt";
            this.amt.Size = new System.Drawing.Size(377, 46);
            this.amt.TabIndex = 4;
            this.amt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 274);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "ENTER THE FEE AMOUNT";
            // 
            // PAYMENT
            // 
            this.PAYMENT.Location = new System.Drawing.Point(115, 349);
            this.PAYMENT.Margin = new System.Windows.Forms.Padding(5);
            this.PAYMENT.Name = "PAYMENT";
            this.PAYMENT.Size = new System.Drawing.Size(474, 74);
            this.PAYMENT.TabIndex = 6;
            this.PAYMENT.Text = "PROCEED TO PAY AND BOOK ROOM";
            this.PAYMENT.UseVisualStyleBackColor = true;
            this.PAYMENT.Click += new System.EventHandler(this.PAYMENT_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(657, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 74);
            this.button1.TabIndex = 7;
            this.button1.Text = "Enquiry";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // roomAllotment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PAYMENT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amt);
            this.Controls.Add(this.roomno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nametextbox);
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "roomAllotment";
            this.Text = "roomAllotment";
            this.Load += new System.EventHandler(this.roomAllotment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nametextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roomno;
        private System.Windows.Forms.TextBox amt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PAYMENT;
        private System.Windows.Forms.Button button1;
    }
}