namespace pract_13
{
    partial class Settings
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
            this.label2 = new System.Windows.Forms.Label();
            this.countColumnsTable = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.countRowsTable = new System.Windows.Forms.NumericUpDown();
            this.SaveSizeTable = new System.Windows.Forms.Button();
            this.CanselSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.countColumnsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countRowsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество столбцов";
            // 
            // countColumnsTable
            // 
            this.countColumnsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countColumnsTable.Location = new System.Drawing.Point(34, 83);
            this.countColumnsTable.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countColumnsTable.Name = "countColumnsTable";
            this.countColumnsTable.Size = new System.Drawing.Size(210, 20);
            this.countColumnsTable.TabIndex = 2;
            this.countColumnsTable.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество строк";
            // 
            // countRowsTable
            // 
            this.countRowsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countRowsTable.Location = new System.Drawing.Point(34, 37);
            this.countRowsTable.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countRowsTable.Name = "countRowsTable";
            this.countRowsTable.Size = new System.Drawing.Size(210, 20);
            this.countRowsTable.TabIndex = 0;
            this.countRowsTable.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SaveSizeTable
            // 
            this.SaveSizeTable.Location = new System.Drawing.Point(34, 117);
            this.SaveSizeTable.Name = "SaveSizeTable";
            this.SaveSizeTable.Size = new System.Drawing.Size(97, 32);
            this.SaveSizeTable.TabIndex = 4;
            this.SaveSizeTable.Text = "Сохранить";
            this.SaveSizeTable.UseVisualStyleBackColor = true;
            // 
            // CanselSettings
            // 
            this.CanselSettings.Location = new System.Drawing.Point(147, 117);
            this.CanselSettings.Name = "CanselSettings";
            this.CanselSettings.Size = new System.Drawing.Size(97, 32);
            this.CanselSettings.TabIndex = 5;
            this.CanselSettings.Text = "Отмена";
            this.CanselSettings.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 161);
            this.ControlBox = false;
            this.Controls.Add(this.CanselSettings);
            this.Controls.Add(this.SaveSizeTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countColumnsTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countRowsTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Размер таблицы по умолчанию";
            ((System.ComponentModel.ISupportInitialize)(this.countColumnsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countRowsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown countColumnsTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown countRowsTable;
        private System.Windows.Forms.Button SaveSizeTable;
        private System.Windows.Forms.Button CanselSettings;
    }
}