namespace SPZ_BuildingPlaner
{
    partial class floorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(floorForm));
            this.addFloorBtn = new System.Windows.Forms.Button();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.labelItems = new System.Windows.Forms.Label();
            this.pictureBoxRecycleBin = new System.Windows.Forms.PictureBox();
            this.labelFloorNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecycleBin)).BeginInit();
            this.SuspendLayout();
            // 
            // addFloorBtn
            // 
            this.addFloorBtn.Location = new System.Drawing.Point(1184, 529);
            this.addFloorBtn.Name = "addFloorBtn";
            this.addFloorBtn.Size = new System.Drawing.Size(75, 23);
            this.addFloorBtn.TabIndex = 0;
            this.addFloorBtn.Text = "Добавить этаж";
            this.addFloorBtn.UseVisualStyleBackColor = true;
            this.addFloorBtn.Click += new System.EventHandler(this.addFloorBtn_Click);
            this.addFloorBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.floorForm_MouseMove);
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.Items.AddRange(new object[] {
            "Стена",
            "Окно",
            "Дверь",
            "Диван",
            "Стул",
            "Стол",
            "Шкаф",
            "Тумбочка",
            "Кровать",
            "Цветок",
            "Холодильник",
            "Плита",
            "Раковина",
            "Кухонный столик",
            "Ванна",
            "Туалет"});
            this.comboBoxItems.Location = new System.Drawing.Point(1071, 120);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(188, 21);
            this.comboBoxItems.TabIndex = 1;
            this.comboBoxItems.TabStop = false;
            this.comboBoxItems.SelectedIndexChanged += new System.EventHandler(this.comboBoxItems_SelectedIndexChanged);
            this.comboBoxItems.MouseMove += new System.Windows.Forms.MouseEventHandler(this.floorForm_MouseMove);
            // 
            // labelItems
            // 
            this.labelItems.AutoSize = true;
            this.labelItems.Location = new System.Drawing.Point(1071, 101);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(187, 13);
            this.labelItems.TabIndex = 2;
            this.labelItems.Text = "Выберите элемент для добавления";
            this.labelItems.MouseMove += new System.Windows.Forms.MouseEventHandler(this.floorForm_MouseMove);
            // 
            // pictureBoxRecycleBin
            // 
            this.pictureBoxRecycleBin.Image = global::SPZ_BuildingPlaner.Properties.Resources.recycleBin;
            this.pictureBoxRecycleBin.Location = new System.Drawing.Point(1278, 159);
            this.pictureBoxRecycleBin.Name = "pictureBoxRecycleBin";
            this.pictureBoxRecycleBin.Size = new System.Drawing.Size(59, 63);
            this.pictureBoxRecycleBin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRecycleBin.TabIndex = 3;
            this.pictureBoxRecycleBin.TabStop = false;
            this.pictureBoxRecycleBin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.floorForm_MouseMove);
            // 
            // labelFloorNumber
            // 
            this.labelFloorNumber.AutoSize = true;
            this.labelFloorNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFloorNumber.Location = new System.Drawing.Point(23, 15);
            this.labelFloorNumber.Name = "labelFloorNumber";
            this.labelFloorNumber.Size = new System.Drawing.Size(75, 20);
            this.labelFloorNumber.TabIndex = 4;
            this.labelFloorNumber.Text = "Этаж №";
            // 
            // floorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.labelFloorNumber);
            this.Controls.Add(this.pictureBoxRecycleBin);
            this.Controls.Add(this.labelItems);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.addFloorBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "floorForm";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.floorForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecycleBin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addFloorBtn;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.PictureBox pictureBoxRecycleBin;
        private System.Windows.Forms.Label labelFloorNumber;
    }
}