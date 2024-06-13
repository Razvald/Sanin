namespace LogProject.Controls
{
    partial class OrderControl
    {
        private System.ComponentModel.IContainer components = null;
        private Label lbl1;
        private Label lbl2;
        private Label lblOrderId;
        private Label lbl5;
        private Label lbl3;
        private Label lbl4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lbl2 = new Label();
            lbl1 = new Label();
            lblOrderId = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            lbl5 = new Label();
            lblAreaName = new Label();
            lblProjectAddress = new Label();
            lblProjectName = new Label();
            lblClientPhone = new Label();
            lblClientName = new Label();
            SuspendLayout();
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2.Location = new Point(4, 39);
            lbl2.Margin = new Padding(4, 0, 4, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(112, 31);
            lbl2.TabIndex = 3;
            lbl2.Text = "Телефон";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.Location = new Point(4, 5);
            lbl1.Margin = new Padding(4, 0, 4, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(116, 34);
            lbl1.TabIndex = 8;
            lbl1.Text = "Клиент ";
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrderId.Location = new Point(588, 83);
            lblOrderId.Margin = new Padding(4, 0, 4, 0);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(47, 42);
            lblOrderId.TabIndex = 15;
            lblOrderId.Text = "Id";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl3.Location = new Point(4, 75);
            lbl3.Margin = new Padding(4, 0, 4, 0);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(218, 31);
            lbl3.TabIndex = 16;
            lbl3.Text = "Название проекта";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl4.Location = new Point(4, 111);
            lbl4.Margin = new Padding(4, 0, 4, 0);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(184, 31);
            lbl4.TabIndex = 17;
            lbl4.Text = "Адрес проекта";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl5.Location = new Point(4, 147);
            lbl5.Margin = new Padding(4, 0, 4, 0);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(217, 31);
            lbl5.TabIndex = 18;
            lbl5.Text = "Название области";
            // 
            // lblAreaName
            // 
            lblAreaName.AutoSize = true;
            lblAreaName.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAreaName.Location = new Point(229, 147);
            lblAreaName.Margin = new Padding(4, 0, 4, 0);
            lblAreaName.Name = "lblAreaName";
            lblAreaName.Size = new Size(217, 31);
            lblAreaName.TabIndex = 19;
            lblAreaName.Text = "Название области";
            // 
            // lblProjectAddress
            // 
            lblProjectAddress.AutoSize = true;
            lblProjectAddress.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblProjectAddress.Location = new Point(196, 111);
            lblProjectAddress.Margin = new Padding(4, 0, 4, 0);
            lblProjectAddress.Name = "lblProjectAddress";
            lblProjectAddress.Size = new Size(184, 31);
            lblProjectAddress.TabIndex = 20;
            lblProjectAddress.Text = "Адрес проекта";
            // 
            // lblProjectName
            // 
            lblProjectName.AutoSize = true;
            lblProjectName.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblProjectName.Location = new Point(228, 75);
            lblProjectName.Margin = new Padding(4, 0, 4, 0);
            lblProjectName.Name = "lblProjectName";
            lblProjectName.Size = new Size(218, 31);
            lblProjectName.TabIndex = 21;
            lblProjectName.Text = "Название проекта";
            // 
            // lblClientPhone
            // 
            lblClientPhone.AutoSize = true;
            lblClientPhone.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClientPhone.Location = new Point(124, 39);
            lblClientPhone.Margin = new Padding(4, 0, 4, 0);
            lblClientPhone.Name = "lblClientPhone";
            lblClientPhone.Size = new Size(112, 31);
            lblClientPhone.TabIndex = 22;
            lblClientPhone.Text = "Телефон";
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblClientName.Location = new Point(128, 5);
            lblClientName.Margin = new Padding(4, 0, 4, 0);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(116, 34);
            lblClientName.TabIndex = 23;
            lblClientName.Text = "Клиент ";
            // 
            // OrderControl
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(lblClientName);
            Controls.Add(lblClientPhone);
            Controls.Add(lblProjectName);
            Controls.Add(lblProjectAddress);
            Controls.Add(lblAreaName);
            Controls.Add(lblOrderId);
            Controls.Add(lbl1);
            Controls.Add(lbl2);
            Controls.Add(lbl3);
            Controls.Add(lbl4);
            Controls.Add(lbl5);
            Cursor = Cursors.Hand;
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "OrderControl";
            Size = new Size(639, 200);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblAreaName;
        private Label lblProjectAddress;
        private Label lblProjectName;
        private Label lblClientPhone;
        private Label lblClientName;
    }
}
