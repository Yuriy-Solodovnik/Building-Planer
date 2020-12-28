namespace SPZ_BuildingPlaner
{
    partial class menuForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuForm));
            this.addFloorBtn = new System.Windows.Forms.Button();
            this.labelSize = new System.Windows.Forms.Label();
            this.comboBoxMapSize = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addFloorBtn
            // 
            this.addFloorBtn.Location = new System.Drawing.Point(604, 363);
            this.addFloorBtn.Name = "addFloorBtn";
            this.addFloorBtn.Size = new System.Drawing.Size(184, 75);
            this.addFloorBtn.TabIndex = 0;
            this.addFloorBtn.Text = "Добавить Этаж";
            this.addFloorBtn.UseVisualStyleBackColor = true;
            this.addFloorBtn.Click += new System.EventHandler(this.addFloorBtn_Click);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(655, 9);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(133, 13);
            this.labelSize.TabIndex = 1;
            this.labelSize.Text = "Выберите размеры поля";
            // 
            // comboBoxMapSize
            // 
            this.comboBoxMapSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxMapSize.FormattingEnabled = true;
            this.comboBoxMapSize.Items.AddRange(new object[] {
            "50х50 13",
            "25х25 26",
            "20х20 32"});
            this.comboBoxMapSize.Location = new System.Drawing.Point(658, 25);
            this.comboBoxMapSize.Name = "comboBoxMapSize";
            this.comboBoxMapSize.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMapSize.TabIndex = 2;
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxMapSize);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.addFloorBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menuForm";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addFloorBtn;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.ComboBox comboBoxMapSize;
    }
}

