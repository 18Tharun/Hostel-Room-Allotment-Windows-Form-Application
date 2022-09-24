namespace HostelManagementApplication
{
    partial class vacate
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RoomNumber = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.leave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vacate the Hostel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room number :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // RoomNumber
            // 
            this.RoomNumber.Location = new System.Drawing.Point(409, 98);
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.Size = new System.Drawing.Size(230, 46);
            this.RoomNumber.TabIndex = 3;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(409, 164);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(230, 46);
            this.name.TabIndex = 4;
            // 
            // leave
            // 
            this.leave.Location = new System.Drawing.Point(358, 258);
            this.leave.Name = "leave";
            this.leave.Size = new System.Drawing.Size(147, 47);
            this.leave.TabIndex = 5;
            this.leave.Text = "leave";
            this.leave.UseVisualStyleBackColor = true;
            this.leave.Click += new System.EventHandler(this.leave_Click);
            // 
            // vacate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 369);
            this.Controls.Add(this.leave);
            this.Controls.Add(this.name);
            this.Controls.Add(this.RoomNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "vacate";
            this.Text = "vacate";
            this.Load += new System.EventHandler(this.vacate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RoomNumber;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button leave;
    }
}