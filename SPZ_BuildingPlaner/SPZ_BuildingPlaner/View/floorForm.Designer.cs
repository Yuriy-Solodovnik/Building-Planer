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
            this.labelFloorNumber = new System.Windows.Forms.Label();
            this.pictureBoxInfo = new System.Windows.Forms.PictureBox();
            this.pictureBoxRecycleBin = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecycleBin)).BeginInit();
            this.SuspendLayout();
            // 
            // addFloorBtn
            // 
            this.addFloorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addFloorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addFloorBtn.Location = new System.Drawing.Point(1155, 631);
            this.addFloorBtn.Name = "addFloorBtn";
            this.addFloorBtn.Size = new System.Drawing.Size(192, 35);
            this.addFloorBtn.TabIndex = 0;
            this.addFloorBtn.Text = "Добавить этаж";
            this.addFloorBtn.UseVisualStyleBackColor = false;
            this.addFloorBtn.Click += new System.EventHandler(this.addFloorBtn_Click);
            this.addFloorBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.floorForm_MouseMove);
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.comboBoxItems.Size = new System.Drawing.Size(271, 21);
            this.comboBoxItems.TabIndex = 1;
            this.comboBoxItems.TabStop = false;
            this.comboBoxItems.SelectedIndexChanged += new System.EventHandler(this.comboBoxItems_SelectedIndexChanged);
            this.comboBoxItems.MouseMove += new System.Windows.Forms.MouseEventHandler(this.floorForm_MouseMove);
            // 
            // labelItems
            // 
            this.labelItems.AutoSize = true;
            this.labelItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelItems.Location = new System.Drawing.Point(1071, 101);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(271, 16);
            this.labelItems.TabIndex = 2;
            this.labelItems.Text = "Выберите элемент для добавления";
            this.labelItems.MouseMove += new System.Windows.Forms.MouseEventHandler(this.floorForm_MouseMove);
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
            // pictureBoxInfo
            // 
            this.pictureBoxInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxInfo.Image = global::SPZ_BuildingPlaner.Properties.Resources.info;
            this.pictureBoxInfo.Location = new System.Drawing.Point(1035, 87);
            this.pictureBoxInfo.Name = "pictureBoxInfo";
            this.pictureBoxInfo.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInfo.TabIndex = 5;
            this.pictureBoxInfo.TabStop = false;
            this.pictureBoxInfo.Click += new System.EventHandler(this.pictureBoxInfo_Click);
            // 
            // pictureBoxRecycleBin
            // 
            this.pictureBoxRecycleBin.Image = global::SPZ_BuildingPlaner.Properties.Resources.recycleBin;
            this.pictureBoxRecycleBin.Location = new System.Drawing.Point(891, 631);
            this.pictureBoxRecycleBin.Name = "pictureBoxRecycleBin";
            this.pictureBoxRecycleBin.Size = new System.Drawing.Size(96, 95);
            this.pictureBoxRecycleBin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRecycleBin.TabIndex = 3;
            this.pictureBoxRecycleBin.TabStop = false;
            this.pictureBoxRecycleBin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.floorForm_MouseMove);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(1155, 687);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(192, 30);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonExit_Click);
            this.buttonExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.floorForm_MouseMove);
            // 
            // floorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBoxInfo);
            this.Controls.Add(this.labelFloorNumber);
            this.Controls.Add(this.pictureBoxRecycleBin);
            this.Controls.Add(this.labelItems);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.addFloorBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Movable = false;
            this.Name = "floorForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.floorForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxInfo;
        private System.Windows.Forms.Button buttonExit;
    }
}