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
            this.addBuildingBtn = new System.Windows.Forms.Button();
            this.buttonOpenBuilding = new System.Windows.Forms.Button();
            this.pictureBoxBuilding = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuilding)).BeginInit();
            this.SuspendLayout();
            // 
            // addBuildingBtn
            // 
            this.addBuildingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addBuildingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBuildingBtn.Location = new System.Drawing.Point(561, 138);
            this.addBuildingBtn.Name = "addBuildingBtn";
            this.addBuildingBtn.Size = new System.Drawing.Size(184, 49);
            this.addBuildingBtn.TabIndex = 0;
            this.addBuildingBtn.Text = "Добавить Здание";
            this.addBuildingBtn.UseVisualStyleBackColor = false;
            this.addBuildingBtn.Click += new System.EventHandler(this.addBuildingBtn_Click);
            // 
            // buttonOpenBuilding
            // 
            this.buttonOpenBuilding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonOpenBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenBuilding.Location = new System.Drawing.Point(561, 202);
            this.buttonOpenBuilding.Name = "buttonOpenBuilding";
            this.buttonOpenBuilding.Size = new System.Drawing.Size(184, 51);
            this.buttonOpenBuilding.TabIndex = 4;
            this.buttonOpenBuilding.Text = "Открыть сохраненное здание";
            this.buttonOpenBuilding.UseVisualStyleBackColor = false;
            this.buttonOpenBuilding.Click += new System.EventHandler(this.buttonDeserializeBuilding_Click);
            // 
            // pictureBoxBuilding
            // 
            this.pictureBoxBuilding.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxBuilding.Image = global::SPZ_BuildingPlaner.Properties.Resources.building;
            this.pictureBoxBuilding.Location = new System.Drawing.Point(0, 5);
            this.pictureBoxBuilding.Name = "pictureBoxBuilding";
            this.pictureBoxBuilding.Size = new System.Drawing.Size(447, 470);
            this.pictureBoxBuilding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBuilding.TabIndex = 3;
            this.pictureBoxBuilding.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(561, 403);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(184, 47);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTitle.Location = new System.Drawing.Point(524, 38);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(283, 42);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Building Planner";
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(833, 473);
            this.ControlBox = false;
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonOpenBuilding);
            this.Controls.Add(this.pictureBoxBuilding);
            this.Controls.Add(this.addBuildingBtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "menuForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.TransparencyKey = System.Drawing.Color.DarkSlateGray;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuilding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBuildingBtn;
        private System.Windows.Forms.PictureBox pictureBoxBuilding;
        private System.Windows.Forms.Button buttonOpenBuilding;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelTitle;
    }
}

