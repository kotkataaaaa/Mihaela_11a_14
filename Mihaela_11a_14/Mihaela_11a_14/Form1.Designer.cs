namespace Mihaela_11a_14
{
    partial class Form1
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblWeigh = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtWeigh = new System.Windows.Forms.TextBox();
            this.cmbDishType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Image = global::Mihaela_11a_14.Properties.Resources.res_3208960c71a03d5ab31fbdfa8c869caf;
            this.lblName.Location = new System.Drawing.Point(32, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(142, 54);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Име на ястието";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDesc.Image = global::Mihaela_11a_14.Properties.Resources.res_3208960c71a03d5ab31fbdfa8c869caf;
            this.lblDesc.Location = new System.Drawing.Point(32, 119);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(142, 54);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Описание";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDesc.Click += new System.EventHandler(this.lblDesc_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Image = global::Mihaela_11a_14.Properties.Resources.res_3208960c71a03d5ab31fbdfa8c869caf;
            this.lblPrice.Location = new System.Drawing.Point(33, 207);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(142, 54);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Цена";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeigh
            // 
            this.lblWeigh.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWeigh.Image = global::Mihaela_11a_14.Properties.Resources.res_3208960c71a03d5ab31fbdfa8c869caf;
            this.lblWeigh.Location = new System.Drawing.Point(33, 309);
            this.lblWeigh.Name = "lblWeigh";
            this.lblWeigh.Size = new System.Drawing.Size(142, 54);
            this.lblWeigh.TabIndex = 3;
            this.lblWeigh.Text = "Грамаж";
            this.lblWeigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtName.Location = new System.Drawing.Point(235, 32);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 54);
            this.txtName.TabIndex = 4;
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtDesc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtDesc.Location = new System.Drawing.Point(235, 119);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(142, 54);
            this.txtDesc.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPrice.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtPrice.Location = new System.Drawing.Point(235, 207);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(142, 54);
            this.txtPrice.TabIndex = 6;
            // 
            // txtWeigh
            // 
            this.txtWeigh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtWeigh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtWeigh.Location = new System.Drawing.Point(235, 309);
            this.txtWeigh.Multiline = true;
            this.txtWeigh.Name = "txtWeigh";
            this.txtWeigh.Size = new System.Drawing.Size(142, 54);
            this.txtWeigh.TabIndex = 7;
            // 
            // cmbDishType
            // 
            this.cmbDishType.FormattingEnabled = true;
            this.cmbDishType.Location = new System.Drawing.Point(494, 62);
            this.cmbDishType.Name = "cmbDishType";
            this.cmbDishType.Size = new System.Drawing.Size(235, 24);
            this.cmbDishType.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Image = global::Mihaela_11a_14.Properties.Resources.res_3208960c71a03d5ab31fbdfa8c869caf;
            this.btnAdd.Location = new System.Drawing.Point(479, 380);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 60);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Добави";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.Image = global::Mihaela_11a_14.Properties.Resources.res_3208960c71a03d5ab31fbdfa8c869caf;
            this.btnEdit.Location = new System.Drawing.Point(639, 442);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 60);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Промени";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Image = global::Mihaela_11a_14.Properties.Resources.res_3208960c71a03d5ab31fbdfa8c869caf;
            this.btnDelete.Location = new System.Drawing.Point(747, 517);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 60);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Изтрий";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mihaela_11a_14.Properties.Resources.меню__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(936, 608);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbDishType);
            this.Controls.Add(this.txtWeigh);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblWeigh);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblWeigh;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtWeigh;
        private System.Windows.Forms.ComboBox cmbDishType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}