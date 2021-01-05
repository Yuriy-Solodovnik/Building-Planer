namespace SPZ_BuildingPlaner
{
    partial class BuildingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildingForm));
            this.addFloorBtn = new System.Windows.Forms.Button();
            this.comboBoxMapSize = new System.Windows.Forms.ComboBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelChoseFloor = new System.Windows.Forms.Label();
            this.comboBoxFloorsList = new System.Windows.Forms.ComboBox();
            this.buttonChangeFloor = new System.Windows.Forms.Button();
            this.buttonSaveBuilding = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addFloorBtn
            // 
            this.addFloorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addFloorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addFloorBtn.Location = new System.Drawing.Point(232, 151);
            this.addFloorBtn.Name = "addFloorBtn";
            this.addFloorBtn.Size = new System.Drawing.Size(161, 55);
            this.addFloorBtn.TabIndex = 1;
            this.addFloorBtn.Text = "Добавить Этаж";
            this.addFloorBtn.UseVisualStyleBackColor = false;
            this.addFloorBtn.Click += new System.EventHandler(this.addFloorBtn_Click);
            // 
            // comboBoxMapSize
            // 
            this.comboBoxMapSize.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxMapSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxMapSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMapSize.FormattingEnabled = true;
            this.comboBoxMapSize.Items.AddRange(new object[] {
            "50х50 13",
            "25х25 26",
            "20х20 32"});
            this.comboBoxMapSize.Location = new System.Drawing.Point(232, 55);
            this.comboBoxMapSize.Name = "comboBoxMapSize";
            this.comboBoxMapSize.Size = new System.Drawing.Size(161, 21);
            this.comboBoxMapSize.TabIndex = 4;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSize.Location = new System.Drawing.Point(218, 26);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(189, 16);
            this.labelSize.TabIndex = 3;
            this.labelSize.Text = "Выберите размеры поля";
            // 
            // labelChoseFloor
            // 
            this.labelChoseFloor.AutoSize = true;
            this.labelChoseFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChoseFloor.Location = new System.Drawing.Point(45, 26);
            this.labelChoseFloor.Name = "labelChoseFloor";
            this.labelChoseFloor.Size = new System.Drawing.Size(119, 16);
            this.labelChoseFloor.TabIndex = 5;
            this.labelChoseFloor.Text = "Список этажей";
            // 
            // comboBoxFloorsList
            // 
            this.comboBoxFloorsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFloorsList.FormattingEnabled = true;
            this.comboBoxFloorsList.Location = new System.Drawing.Point(23, 55);
            this.comboBoxFloorsList.Name = "comboBoxFloorsList";
            this.comboBoxFloorsList.Size = new System.Drawing.Size(165, 21);
            this.comboBoxFloorsList.TabIndex = 6;
            // 
            // buttonChangeFloor
            // 
            this.buttonChangeFloor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonChangeFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeFloor.Location = new System.Drawing.Point(232, 212);
            this.buttonChangeFloor.Name = "buttonChangeFloor";
            this.buttonChangeFloor.Size = new System.Drawing.Size(161, 55);
            this.buttonChangeFloor.TabIndex = 7;
            this.buttonChangeFloor.Text = "Изменить Этаж";
            this.buttonChangeFloor.UseVisualStyleBackColor = false;
            this.buttonChangeFloor.Click += new System.EventHandler(this.buttonChangeFloor_Click);
            // 
            // buttonSaveBuilding
            // 
            this.buttonSaveBuilding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSaveBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveBuilding.Location = new System.Drawing.Point(232, 273);
            this.buttonSaveBuilding.Name = "buttonSaveBuilding";
            this.buttonSaveBuilding.Size = new System.Drawing.Size(161, 55);
            this.buttonSaveBuilding.TabIndex = 8;
            this.buttonSaveBuilding.Text = "Сохранить Здание";
            this.buttonSaveBuilding.UseVisualStyleBackColor = false;
            this.buttonSaveBuilding.Click += new System.EventHandler(this.buttonSaveBuilding_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(232, 354);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(161, 30);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // BuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 407);
            this.ControlBox = false;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSaveBuilding);
            this.Controls.Add(this.buttonChangeFloor);
            this.Controls.Add(this.comboBoxFloorsList);
            this.Controls.Add(this.labelChoseFloor);
            this.Controls.Add(this.comboBoxMapSize);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.addFloorBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuildingForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addFloorBtn;
        private System.Windows.Forms.ComboBox comboBoxMapSize;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelChoseFloor;
        private System.Windows.Forms.ComboBox comboBoxFloorsList;
        private System.Windows.Forms.Button buttonChangeFloor;
        private System.Windows.Forms.Button buttonSaveBuilding;
        private System.Windows.Forms.Button buttonExit;
    }
}