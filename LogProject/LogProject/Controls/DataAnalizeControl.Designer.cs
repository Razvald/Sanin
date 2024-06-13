namespace LogProject.Controls
{
    partial class DataAnalizeControl
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
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            cmbProfile = new ComboBox();
            label1 = new Label();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1.25F;
            formsPlot1.Location = new Point(0, 69);
            formsPlot1.Margin = new Padding(3, 4, 3, 4);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(416, 364);
            formsPlot1.TabIndex = 0;
            // 
            // cmbProfile
            // 
            cmbProfile.FormattingEnabled = true;
            cmbProfile.Location = new Point(171, 20);
            cmbProfile.Margin = new Padding(3, 4, 3, 4);
            cmbProfile.Name = "cmbProfile";
            cmbProfile.Size = new Size(138, 28);
            cmbProfile.TabIndex = 1;
            cmbProfile.SelectedIndexChanged += cmbProfile_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 25);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 2;
            label1.Text = "Выберите профиль:";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(315, 20);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(86, 31);
            btnReturn.TabIndex = 3;
            btnReturn.Text = "Назад";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // DataAnalizeControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnReturn);
            Controls.Add(label1);
            Controls.Add(cmbProfile);
            Controls.Add(formsPlot1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DataAnalizeControl";
            Size = new Size(419, 437);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private ComboBox cmbProfile;
        private Label label1;
        private Button btnReturn;
    }
}
