using System;

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
            this.lblVid = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Image = global::Mihaela_11a_14.Properties.Resources.res_3208960c71a03d5ab31fbdfa8c869caf;
            this.lblName.Location = new System.Drawing.Point(2, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(141, 54);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Име на ястието";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDesc.Image = global::Mihaela_11a_14.Properties.Resources.res_3208960c71a03d5ab31fbdfa8c869caf;
            this.lblDesc.Location = new System.Drawing.Point(2, 106);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(141, 54);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Описание";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDesc.Click += new System.EventHandler(this.lblDesc_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Image = global::Mihaela_11a_14.Properties.Resources.res_3208960c71a03d5ab31fbdfa8c869caf;
            this.lblPrice.Location = new System.Drawing.Point(1, 179);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(141, 54);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Цена";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeigh
            // 
            this.lblWeigh.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWeigh.Image = global::Mihaela_11a_14.Properties.Resources.res_3208960c71a03d5ab31fbdfa8c869caf;
            this.lblWeigh.Location = new System.Drawing.Point(1, 253);
            this.lblWeigh.Name = "lblWeigh";
            this.lblWeigh.Size = new System.Drawing.Size(141, 54);
            this.lblWeigh.TabIndex = 3;
            this.lblWeigh.Text = "Грамаж";
            this.lblWeigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtName.Location = new System.Drawing.Point(199, 23);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 54);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtDesc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtDesc.Location = new System.Drawing.Point(199, 106);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(143, 54);
            this.txtDesc.TabIndex = 5;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPrice.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtPrice.Location = new System.Drawing.Point(199, 179);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(143, 54);
            this.txtPrice.TabIndex = 6;
            // 
            // txtWeigh
            // 
            this.txtWeigh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtWeigh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtWeigh.Location = new System.Drawing.Point(199, 253);
            this.txtWeigh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWeigh.Multiline = true;
            this.txtWeigh.Name = "txtWeigh";
            this.txtWeigh.Size = new System.Drawing.Size(143, 54);
            this.txtWeigh.TabIndex = 7;
            // 
            // cmbDishType
            // 
            this.cmbDishType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmbDishType.FormattingEnabled = true;
            this.cmbDishType.Items.AddRange(new object[] {
            "Салати ",
            "Предястия",
            "Основно ястие",
            "Супа",
            "Аламинут ",
            "Десерт"});
            this.cmbDishType.Location = new System.Drawing.Point(199, 350);
            this.cmbDishType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDishType.Name = "cmbDishType";
            this.cmbDishType.Size = new System.Drawing.Size(143, 24);
            this.cmbDishType.TabIndex = 8;
            this.cmbDishType.SelectedIndexChanged += new System.EventHandler(this.cmbDishType_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Image = global::Mihaela_11a_14.Properties.Resources.res_3208960c71a03d5ab31fbdfa8c869caf;
            this.btnAdd.Location = new System.Drawing.Point(416, 393);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(179, 87);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Добави";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.Image = global::Mihaela_11a_14.Properties.Resources.res_3208960c71a03d5ab31fbdfa8c869caf;
            this.btnEdit.Location = new System.Drawing.Point(702, 393);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(177, 87);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Промени";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Image = global::Mihaela_11a_14.Properties.Resources.res_3208960c71a03d5ab31fbdfa8c869caf;
            this.btnDelete.Location = new System.Drawing.Point(550, 528);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(186, 84);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Изтрий";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // lblVid
            // 
            this.lblVid.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVid.Image = global::Mihaela_11a_14.Properties.Resources.res_3208960c71a03d5ab31fbdfa8c869caf;
            this.lblVid.Location = new System.Drawing.Point(1, 331);
            this.lblVid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVid.Name = "lblVid";
            this.lblVid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVid.Size = new System.Drawing.Size(141, 54);
            this.lblVid.TabIndex = 12;
            this.lblVid.Text = "Вид на ястието ";
            this.lblVid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(351, 23);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(679, 340);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = global::Mihaela_11a_14.Properties.Resources.меню__1_;
            this.btnFind.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFind.Image = global::Mihaela_11a_14.Properties.Resources.res_3208960c71a03d5ab31fbdfa8c869caf;
            this.btnFind.Location = new System.Drawing.Point(229, 521);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(178, 91);
            this.btnFind.TabIndex = 15;
            this.btnFind.Text = "Намери";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtId.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtId.Location = new System.Drawing.Point(203, 425);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(141, 54);
            this.txtId.TabIndex = 17;
            // 
            // lblId
            // 
            this.lblId.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblId.Image = global::Mihaela_11a_14.Properties.Resources.res_3208960c71a03d5ab31fbdfa8c869caf;
            this.lblId.Location = new System.Drawing.Point(0, 426);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(141, 54);
            this.lblId.TabIndex = 16;
            this.lblId.Text = "Въведи id ";
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mihaela_11a_14.Properties.Resources.меню__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1037, 681);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblVid);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label lblVid;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
    }
}