
namespace IS_Students
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mtUpdate = new MetroFramework.Controls.MetroTile();
            this.mtAdd = new MetroFramework.Controls.MetroTile();
            this.mtEdit = new MetroFramework.Controls.MetroTile();
            this.mtDelete = new MetroFramework.Controls.MetroTile();
            this.mtSave = new MetroFramework.Controls.MetroTile();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mtUpdate
            // 
            this.mtUpdate.Location = new System.Drawing.Point(13, 70);
            this.mtUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtUpdate.Name = "mtUpdate";
            this.mtUpdate.Size = new System.Drawing.Size(111, 76);
            this.mtUpdate.TabIndex = 0;
            this.mtUpdate.Text = "Обновить";
            this.mtUpdate.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            // 
            // mtAdd
            // 
            this.mtAdd.Location = new System.Drawing.Point(137, 70);
            this.mtAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtAdd.Name = "mtAdd";
            this.mtAdd.Size = new System.Drawing.Size(112, 76);
            this.mtAdd.TabIndex = 0;
            this.mtAdd.Text = "Добавить";
            this.mtAdd.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtAdd.Click += new System.EventHandler(this.mtAdd_Click);
            // 
            // mtEdit
            // 
            this.mtEdit.Location = new System.Drawing.Point(266, 70);
            this.mtEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtEdit.Name = "mtEdit";
            this.mtEdit.Size = new System.Drawing.Size(146, 76);
            this.mtEdit.TabIndex = 0;
            this.mtEdit.Text = "Редактировать";
            this.mtEdit.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            // 
            // mtDelete
            // 
            this.mtDelete.BackColor = System.Drawing.Color.Red;
            this.mtDelete.CustomBackground = true;
            this.mtDelete.Location = new System.Drawing.Point(430, 70);
            this.mtDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtDelete.Name = "mtDelete";
            this.mtDelete.Size = new System.Drawing.Size(118, 76);
            this.mtDelete.TabIndex = 0;
            this.mtDelete.Text = "Удалить";
            this.mtDelete.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            // 
            // mtSave
            // 
            this.mtSave.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.mtSave.CustomBackground = true;
            this.mtSave.Location = new System.Drawing.Point(566, 70);
            this.mtSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtSave.Name = "mtSave";
            this.mtSave.Size = new System.Drawing.Size(135, 76);
            this.mtSave.TabIndex = 0;
            this.mtSave.Text = "Сохранить";
            this.mtSave.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 172);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(688, 199);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 392);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mtSave);
            this.Controls.Add(this.mtDelete);
            this.Controls.Add(this.mtEdit);
            this.Controls.Add(this.mtAdd);
            this.Controls.Add(this.mtUpdate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(11, 33, 11, 11);
            this.Text = "Студенты";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtUpdate;
        private MetroFramework.Controls.MetroTile mtAdd;
        private MetroFramework.Controls.MetroTile mtEdit;
        private MetroFramework.Controls.MetroTile mtDelete;
        private MetroFramework.Controls.MetroTile mtSave;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

