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
            this.addFloorBtn = new System.Windows.Forms.Button();
            this.comboBoxMapSize = new System.Windows.Forms.ComboBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelChoseFloor = new System.Windows.Forms.Label();
            this.comboBoxFloorsList = new System.Windows.Forms.ComboBox();
            this.buttonChangeFloor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addFloorBtn
            // 
            this.addFloorBtn.Location = new System.Drawing.Point(151, 237);
            this.addFloorBtn.Name = "addFloorBtn";
            this.addFloorBtn.Size = new System.Drawing.Size(130, 55);
            this.addFloorBtn.TabIndex = 1;
            this.addFloorBtn.Text = "Добавить Этаж";
            this.addFloorBtn.UseVisualStyleBackColor = true;
            this.addFloorBtn.Click += new System.EventHandler(this.addFloorBtn_Click);
            // 
            // comboBoxMapSize
            // 
            this.comboBoxMapSize.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxMapSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxMapSize.FormattingEnabled = true;
            this.comboBoxMapSize.Items.AddRange(new object[] {
            "50х50 13",
            "25х25 26",
            "20х20 32"});
            this.comboBoxMapSize.Location = new System.Drawing.Point(151, 55);
            this.comboBoxMapSize.Name = "comboBoxMapSize";
            this.comboBoxMapSize.Size = new System.Drawing.Size(130, 21);
            this.comboBoxMapSize.TabIndex = 4;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(148, 39);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(133, 13);
            this.labelSize.TabIndex = 3;
            this.labelSize.Text = "Выберите размеры поля";
            // 
            // labelChoseFloor
            // 
            this.labelChoseFloor.AutoSize = true;
            this.labelChoseFloor.Location = new System.Drawing.Point(32, 40);
            this.labelChoseFloor.Name = "labelChoseFloor";
            this.labelChoseFloor.Size = new System.Drawing.Size(84, 13);
            this.labelChoseFloor.TabIndex = 5;
            this.labelChoseFloor.Text = "Список этажей";
            // 
            // comboBoxFloorsList
            // 
            this.comboBoxFloorsList.FormattingEnabled = true;
            this.comboBoxFloorsList.Location = new System.Drawing.Point(12, 55);
            this.comboBoxFloorsList.Name = "comboBoxFloorsList";
            this.comboBoxFloorsList.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFloorsList.TabIndex = 6;
            // 
            // buttonChangeFloor
            // 
            this.buttonChangeFloor.Location = new System.Drawing.Point(12, 237);
            this.buttonChangeFloor.Name = "buttonChangeFloor";
            this.buttonChangeFloor.Size = new System.Drawing.Size(121, 55);
            this.buttonChangeFloor.TabIndex = 7;
            this.buttonChangeFloor.Text = "Изменить Этаж";
            this.buttonChangeFloor.UseVisualStyleBackColor = true;
            this.buttonChangeFloor.Click += new System.EventHandler(this.buttonChangeFloor_Click);
            // 
            // BuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 303);
            this.Controls.Add(this.buttonChangeFloor);
            this.Controls.Add(this.comboBoxFloorsList);
            this.Controls.Add(this.labelChoseFloor);
            this.Controls.Add(this.comboBoxMapSize);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.addFloorBtn);
            this.Name = "BuildingForm";
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
    }
}