﻿namespace project
{
    partial class ReFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReFood));
            this.groupBoxA = new System.Windows.Forms.GroupBox();
            this.cbbCountReF = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbFood = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cbbTable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.groupBoxA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCountReF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxA
            // 
            this.groupBoxA.BackColor = System.Drawing.Color.White;
            this.groupBoxA.Controls.Add(this.btnAccept);
            this.groupBoxA.Controls.Add(this.cbbCountReF);
            this.groupBoxA.Controls.Add(this.label6);
            this.groupBoxA.Controls.Add(this.cbbCount);
            this.groupBoxA.Controls.Add(this.label5);
            this.groupBoxA.Controls.Add(this.cbbFood);
            this.groupBoxA.Controls.Add(this.label2);
            this.groupBoxA.Controls.Add(this.label4);
            this.groupBoxA.Controls.Add(this.label3);
            this.groupBoxA.Controls.Add(this.txtTotal);
            this.groupBoxA.Controls.Add(this.cbbTable);
            this.groupBoxA.Controls.Add(this.label1);
            this.groupBoxA.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxA.Name = "groupBoxA";
            this.groupBoxA.Size = new System.Drawing.Size(804, 401);
            this.groupBoxA.TabIndex = 25;
            this.groupBoxA.TabStop = false;
            this.groupBoxA.Text = "Đổi Trả";
            // 
            // cbbCountReF
            // 
            this.cbbCountReF.BackColor = System.Drawing.Color.White;
            this.cbbCountReF.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbCountReF.Location = new System.Drawing.Point(324, 280);
            this.cbbCountReF.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cbbCountReF.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cbbCountReF.Name = "cbbCountReF";
            this.cbbCountReF.Size = new System.Drawing.Size(174, 34);
            this.cbbCountReF.TabIndex = 31;
            this.cbbCountReF.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(182, 283);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 26);
            this.label6.TabIndex = 30;
            this.label6.Text = "Trả lại:";
            // 
            // cbbCount
            // 
            this.cbbCount.BackColor = System.Drawing.Color.White;
            this.cbbCount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbCount.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cbbCount.Location = new System.Drawing.Point(324, 230);
            this.cbbCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cbbCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cbbCount.Name = "cbbCount";
            this.cbbCount.Size = new System.Drawing.Size(174, 34);
            this.cbbCount.TabIndex = 29;
            this.cbbCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(182, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 26);
            this.label5.TabIndex = 28;
            this.label5.Text = "Số lượng:";
            // 
            // cbbFood
            // 
            this.cbbFood.BackColor = System.Drawing.Color.Silver;
            this.cbbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFood.FormattingEnabled = true;
            this.cbbFood.Location = new System.Drawing.Point(324, 179);
            this.cbbFood.Name = "cbbFood";
            this.cbbFood.Size = new System.Drawing.Size(241, 39);
            this.cbbFood.TabIndex = 27;
            this.cbbFood.TextChanged += new System.EventHandler(this.cbbFood_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(182, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 26);
            this.label2.TabIndex = 26;
            this.label2.Text = "Món trả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(573, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "VNĐ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(182, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 26);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tổng:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Location = new System.Drawing.Point(324, 135);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(241, 32);
            this.txtTotal.TabIndex = 23;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbbTable
            // 
            this.cbbTable.BackColor = System.Drawing.Color.Silver;
            this.cbbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTable.FormattingEnabled = true;
            this.cbbTable.Location = new System.Drawing.Point(324, 83);
            this.cbbTable.Name = "cbbTable";
            this.cbbTable.Size = new System.Drawing.Size(241, 39);
            this.cbbTable.TabIndex = 21;
            this.cbbTable.TextChanged += new System.EventHandler(this.cbbTable_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(182, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "Số bàn:";
            // 
            // btnAccept
            // 
            this.btnAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnAccept.BackColor = System.Drawing.Color.Transparent;
            this.btnAccept.BackgroundImage = global::project.Properties.Resources.checkedicon;
            this.btnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Location = new System.Drawing.Point(739, 344);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(59, 51);
            this.btnAccept.TabIndex = 26;
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // ReFood
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 425);
            this.Controls.Add(this.groupBoxA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReFood";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi trả món";
            this.TopMost = true;
            this.groupBoxA.ResumeLayout(false);
            this.groupBoxA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCountReF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cbbTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.ComboBox cbbFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown cbbCount;
        public System.Windows.Forms.NumericUpDown cbbCountReF;
        private System.Windows.Forms.Label label6;
    }
}