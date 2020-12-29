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
            this.pictureBoxBuilding = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuilding)).BeginInit();
            this.SuspendLayout();
            // 
            // addFloorBtn
            // 
            this.addFloorBtn.Location = new System.Drawing.Point(593, 352);
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
            this.labelSize.Location = new System.Drawing.Point(644, 60);
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
            this.comboBoxMapSize.Location = new System.Drawing.Point(647, 76);
            this.comboBoxMapSize.Name = "comboBoxMapSize";
            this.comboBoxMapSize.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMapSize.TabIndex = 2;
            // 
            // pictureBoxBuilding
            // 
            this.pictureBoxBuilding.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxBuilding.Image = global::SPZ_BuildingPlaner.Properties.Resources.building;
            this.pictureBoxBuilding.Location = new System.Drawing.Point(0, 5);
            this.pictureBoxBuilding.Name = "pictureBoxBuilding";
            this.pictureBoxBuilding.Size = new System.Drawing.Size(447, 447);
            this.pictureBoxBuilding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBuilding.TabIndex = 3;
            this.pictureBoxBuilding.TabStop = false;
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxBuilding);
            this.Controls.Add(this.comboBoxMapSize);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.addFloorBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menuForm";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuilding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addFloorBtn;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.ComboBox comboBoxMapSize;
        private System.Windows.Forms.PictureBox pictureBoxBuilding;
    }
}

