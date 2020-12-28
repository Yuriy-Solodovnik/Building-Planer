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
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Items.AddRange(new object[] {
            "Стена",
            "Окно",
            "Дверь",
            "Диван",
            "Стул",
            "Стол"});
            this.comboBoxItems.Location = new System.Drawing.Point(1081, 54);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(188, 21);
            this.comboBoxItems.TabIndex = 1;
            this.comboBoxItems.SelectedIndexChanged += new System.EventHandler(this.comboBoxItems_SelectedIndexChanged);
            // 
            // labelItems
            // 
            this.labelItems.AutoSize = true;
            this.labelItems.Location = new System.Drawing.Point(1081, 35);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(187, 13);
            this.labelItems.TabIndex = 2;
            this.labelItems.Text = "Выберите элемент для добавления";
            // 
            // floorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.labelItems);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.addFloorBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "floorForm";
            this.Text = "floorForm";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.floorForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addFloorBtn;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Label labelItems;
    }
}