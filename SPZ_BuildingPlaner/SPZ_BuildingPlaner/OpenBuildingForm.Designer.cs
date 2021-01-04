namespace SPZ_BuildingPlaner
{
    partial class OpenBuildingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenBuildingForm));
            this.labelFloor = new System.Windows.Forms.Label();
            this.buttonFloorUp = new System.Windows.Forms.Button();
            this.buttonFloorDown = new System.Windows.Forms.Button();
            this.pictureBoxFloorContent = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFloorContent)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFloor.Location = new System.Drawing.Point(751, 329);
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(88, 24);
            this.labelFloor.TabIndex = 1;
            this.labelFloor.Text = "Этаж №";
            // 
            // buttonFloorUp
            // 
            this.buttonFloorUp.BackgroundImage = global::SPZ_BuildingPlaner.Properties.Resources.upArrow;
            this.buttonFloorUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFloorUp.Location = new System.Drawing.Point(774, 205);
            this.buttonFloorUp.Name = "buttonFloorUp";
            this.buttonFloorUp.Size = new System.Drawing.Size(75, 75);
            this.buttonFloorUp.TabIndex = 3;
            this.buttonFloorUp.UseVisualStyleBackColor = true;
            this.buttonFloorUp.Click += new System.EventHandler(this.buttonFloorUp_Click);
            // 
            // buttonFloorDown
            // 
            this.buttonFloorDown.BackgroundImage = global::SPZ_BuildingPlaner.Properties.Resources.downArrow;
            this.buttonFloorDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFloorDown.Location = new System.Drawing.Point(774, 402);
            this.buttonFloorDown.Name = "buttonFloorDown";
            this.buttonFloorDown.Size = new System.Drawing.Size(75, 75);
            this.buttonFloorDown.TabIndex = 2;
            this.buttonFloorDown.UseVisualStyleBackColor = true;
            this.buttonFloorDown.Click += new System.EventHandler(this.buttonFloorDown_Click);
            // 
            // pictureBoxFloorContent
            // 
            this.pictureBoxFloorContent.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxFloorContent.Name = "pictureBoxFloorContent";
            this.pictureBoxFloorContent.Size = new System.Drawing.Size(680, 680);
            this.pictureBoxFloorContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFloorContent.TabIndex = 0;
            this.pictureBoxFloorContent.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(711, 659);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(192, 30);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // OpenBuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 701);
            this.ControlBox = false;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonFloorUp);
            this.Controls.Add(this.buttonFloorDown);
            this.Controls.Add(this.labelFloor);
            this.Controls.Add(this.pictureBoxFloorContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Movable = false;
            this.Name = "OpenBuildingForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.OpenBuildingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFloorContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFloorContent;
        private System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.Button buttonFloorDown;
        private System.Windows.Forms.Button buttonFloorUp;
        private System.Windows.Forms.Button buttonExit;
    }
}