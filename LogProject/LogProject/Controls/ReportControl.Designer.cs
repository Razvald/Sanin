namespace LogProject.Controls
{
    partial class ReportControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            lblPicket = new Label();
            lblPicketX = new Label();
            txtPicketX = new TextBox();
            lblPicketY = new Label();
            txtPicketY = new TextBox();
            lblPicketValue = new Label();
            txtPicketValue = new TextBox();
            lblProfilePoint = new Label();
            lblProfilePointX = new Label();
            txtProfilePointX = new TextBox();
            lblProfilePointY = new Label();
            txtProfilePointY = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // lblPicket
            // 
            lblPicket.AutoSize = true;
            lblPicket.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPicket.Location = new Point(17, 20);
            lblPicket.Name = "lblPicket";
            lblPicket.Size = new Size(75, 28);
            lblPicket.TabIndex = 0;
            lblPicket.Text = "Picket:";
            // 
            // lblPicketX
            // 
            lblPicketX.AutoSize = true;
            lblPicketX.Location = new Point(34, 67);
            lblPicketX.Name = "lblPicketX";
            lblPicketX.Size = new Size(21, 20);
            lblPicketX.TabIndex = 1;
            lblPicketX.Text = "X:";
            // 
            // txtPicketX
            // 
            txtPicketX.Location = new Point(69, 63);
            txtPicketX.Margin = new Padding(3, 4, 3, 4);
            txtPicketX.Name = "txtPicketX";
            txtPicketX.Size = new Size(114, 27);
            txtPicketX.TabIndex = 2;
            // 
            // lblPicketY
            // 
            lblPicketY.AutoSize = true;
            lblPicketY.Location = new Point(34, 104);
            lblPicketY.Name = "lblPicketY";
            lblPicketY.Size = new Size(20, 20);
            lblPicketY.TabIndex = 3;
            lblPicketY.Text = "Y:";
            // 
            // txtPicketY
            // 
            txtPicketY.Location = new Point(68, 100);
            txtPicketY.Margin = new Padding(3, 4, 3, 4);
            txtPicketY.Name = "txtPicketY";
            txtPicketY.Size = new Size(114, 27);
            txtPicketY.TabIndex = 4;
            // 
            // lblPicketValue
            // 
            lblPicketValue.AutoSize = true;
            lblPicketValue.Location = new Point(34, 142);
            lblPicketValue.Name = "lblPicketValue";
            lblPicketValue.Size = new Size(48, 20);
            lblPicketValue.TabIndex = 5;
            lblPicketValue.Text = "Value:";
            // 
            // txtPicketValue
            // 
            txtPicketValue.Location = new Point(91, 138);
            txtPicketValue.Margin = new Padding(3, 4, 3, 4);
            txtPicketValue.Name = "txtPicketValue";
            txtPicketValue.Size = new Size(114, 27);
            txtPicketValue.TabIndex = 6;
            // 
            // lblProfilePoint
            // 
            lblProfilePoint.AutoSize = true;
            lblProfilePoint.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblProfilePoint.Location = new Point(17, 179);
            lblProfilePoint.Name = "lblProfilePoint";
            lblProfilePoint.Size = new Size(135, 28);
            lblProfilePoint.TabIndex = 7;
            lblProfilePoint.Text = "Profile Point:";
            // 
            // lblProfilePointX
            // 
            lblProfilePointX.AutoSize = true;
            lblProfilePointX.Location = new Point(34, 224);
            lblProfilePointX.Name = "lblProfilePointX";
            lblProfilePointX.Size = new Size(21, 20);
            lblProfilePointX.TabIndex = 8;
            lblProfilePointX.Text = "X:";
            // 
            // txtProfilePointX
            // 
            txtProfilePointX.Location = new Point(69, 220);
            txtProfilePointX.Margin = new Padding(3, 4, 3, 4);
            txtProfilePointX.Name = "txtProfilePointX";
            txtProfilePointX.Size = new Size(114, 27);
            txtProfilePointX.TabIndex = 9;
            // 
            // lblProfilePointY
            // 
            lblProfilePointY.AutoSize = true;
            lblProfilePointY.Location = new Point(34, 265);
            lblProfilePointY.Name = "lblProfilePointY";
            lblProfilePointY.Size = new Size(20, 20);
            lblProfilePointY.TabIndex = 10;
            lblProfilePointY.Text = "Y:";
            // 
            // txtProfilePointY
            // 
            txtProfilePointY.Location = new Point(68, 261);
            txtProfilePointY.Margin = new Padding(3, 4, 3, 4);
            txtProfilePointY.Name = "txtProfilePointY";
            txtProfilePointY.Size = new Size(114, 27);
            txtProfilePointY.TabIndex = 11;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(3, 328);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(117, 41);
            btnSubmit.TabIndex = 12;
            btnSubmit.Text = "Отправить";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // ReportControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(btnSubmit);
            Controls.Add(txtProfilePointY);
            Controls.Add(lblProfilePointY);
            Controls.Add(txtProfilePointX);
            Controls.Add(lblProfilePointX);
            Controls.Add(lblProfilePoint);
            Controls.Add(txtPicketValue);
            Controls.Add(lblPicketValue);
            Controls.Add(txtPicketY);
            Controls.Add(lblPicketY);
            Controls.Add(txtPicketX);
            Controls.Add(lblPicketX);
            Controls.Add(lblPicket);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReportControl";
            Size = new Size(257, 373);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPicket;
        private Label lblPicketX;
        private TextBox txtPicketX;
        private Label lblPicketY;
        private TextBox txtPicketY;
        private Label lblPicketValue;
        private TextBox txtPicketValue;
        private Label lblProfilePoint;
        private Label lblProfilePointX;
        private TextBox txtProfilePointX;
        private Label lblProfilePointY;
        private TextBox txtProfilePointY;
        private Button btnSubmit;
    }
}
