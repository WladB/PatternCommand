
namespace UkrainianLanguage_VirtualSimulator
{
    partial class TaskEditingForm
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
            this.WorkingWithSectionsB = new System.Windows.Forms.Button();
            this.WorkingWithTopicsB = new System.Windows.Forms.Button();
            this.WorkingWithTasksB = new System.Windows.Forms.Button();
            this.UpdateRecordB = new System.Windows.Forms.Button();
            this.EditRadioButton = new System.Windows.Forms.RadioButton();
            this.DeleteRadioButton = new System.Windows.Forms.RadioButton();
            this.AddRadioButton = new System.Windows.Forms.RadioButton();
            this.FildPanel = new System.Windows.Forms.Panel();
            this.AddRecordB = new System.Windows.Forms.Button();
            this.BackPanel1 = new System.Windows.Forms.Panel();
            this.SearchCBox = new System.Windows.Forms.ComboBox();
            this.SearchTBox = new System.Windows.Forms.TextBox();
            this.TableLabel = new System.Windows.Forms.Label();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.BackPanel2 = new System.Windows.Forms.Panel();
            this.SearchCLabel = new System.Windows.Forms.Label();
            this.SearchTLabel = new System.Windows.Forms.Label();
            this.BackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.BackPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkingWithSectionsB
            // 
            this.WorkingWithSectionsB.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkingWithSectionsB.Location = new System.Drawing.Point(98, 16);
            this.WorkingWithSectionsB.Name = "WorkingWithSectionsB";
            this.WorkingWithSectionsB.Size = new System.Drawing.Size(140, 23);
            this.WorkingWithSectionsB.TabIndex = 0;
            this.WorkingWithSectionsB.Text = "Розділи";
            this.WorkingWithSectionsB.UseVisualStyleBackColor = true;
            this.WorkingWithSectionsB.Click += new System.EventHandler(this.WorkingWithSectionsB_Click);
            // 
            // WorkingWithTopicsB
            // 
            this.WorkingWithTopicsB.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkingWithTopicsB.Location = new System.Drawing.Point(275, 16);
            this.WorkingWithTopicsB.Name = "WorkingWithTopicsB";
            this.WorkingWithTopicsB.Size = new System.Drawing.Size(151, 23);
            this.WorkingWithTopicsB.TabIndex = 1;
            this.WorkingWithTopicsB.Text = "Теми ";
            this.WorkingWithTopicsB.UseVisualStyleBackColor = true;
            this.WorkingWithTopicsB.Click += new System.EventHandler(this.WorkingWithTopicsB_Click);
            // 
            // WorkingWithTasksB
            // 
            this.WorkingWithTasksB.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkingWithTasksB.Location = new System.Drawing.Point(461, 16);
            this.WorkingWithTasksB.Name = "WorkingWithTasksB";
            this.WorkingWithTasksB.Size = new System.Drawing.Size(151, 23);
            this.WorkingWithTasksB.TabIndex = 2;
            this.WorkingWithTasksB.Text = "Завдання";
            this.WorkingWithTasksB.UseVisualStyleBackColor = true;
            this.WorkingWithTasksB.Click += new System.EventHandler(this.WorkingWithTasksB_Click);
            // 
            // UpdateRecordB
            // 
            this.UpdateRecordB.Location = new System.Drawing.Point(18, 112);
            this.UpdateRecordB.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateRecordB.Name = "UpdateRecordB";
            this.UpdateRecordB.Size = new System.Drawing.Size(88, 26);
            this.UpdateRecordB.TabIndex = 34;
            this.UpdateRecordB.Text = "Редагувати";
            this.UpdateRecordB.UseVisualStyleBackColor = true;
            this.UpdateRecordB.Visible = false;
            this.UpdateRecordB.Click += new System.EventHandler(this.UpdateRecordB_Click);
            // 
            // EditRadioButton
            // 
            this.EditRadioButton.AutoSize = true;
            this.EditRadioButton.Location = new System.Drawing.Point(415, 61);
            this.EditRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditRadioButton.Name = "EditRadioButton";
            this.EditRadioButton.Size = new System.Drawing.Size(83, 17);
            this.EditRadioButton.TabIndex = 33;
            this.EditRadioButton.TabStop = true;
            this.EditRadioButton.Text = "Редагувати";
            this.EditRadioButton.UseVisualStyleBackColor = true;
            this.EditRadioButton.Visible = false;
            this.EditRadioButton.CheckedChanged += new System.EventHandler(this.EditRadioButton_CheckedChanged);
            // 
            // DeleteRadioButton
            // 
            this.DeleteRadioButton.AutoSize = true;
            this.DeleteRadioButton.Location = new System.Drawing.Point(309, 61);
            this.DeleteRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteRadioButton.Name = "DeleteRadioButton";
            this.DeleteRadioButton.Size = new System.Drawing.Size(73, 17);
            this.DeleteRadioButton.TabIndex = 32;
            this.DeleteRadioButton.TabStop = true;
            this.DeleteRadioButton.Text = "Видалити";
            this.DeleteRadioButton.UseVisualStyleBackColor = true;
            this.DeleteRadioButton.Visible = false;
            this.DeleteRadioButton.CheckedChanged += new System.EventHandler(this.DeleteRadioButton_CheckedChanged);
            // 
            // AddRadioButton
            // 
            this.AddRadioButton.AutoSize = true;
            this.AddRadioButton.Location = new System.Drawing.Point(204, 61);
            this.AddRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddRadioButton.Name = "AddRadioButton";
            this.AddRadioButton.Size = new System.Drawing.Size(63, 17);
            this.AddRadioButton.TabIndex = 31;
            this.AddRadioButton.TabStop = true;
            this.AddRadioButton.Text = "Додати";
            this.AddRadioButton.UseVisualStyleBackColor = true;
            this.AddRadioButton.Visible = false;
            this.AddRadioButton.CheckedChanged += new System.EventHandler(this.AddRadioButton_CheckedChanged);
            // 
            // FildPanel
            // 
            this.FildPanel.AutoScroll = true;
            this.FildPanel.Location = new System.Drawing.Point(117, 84);
            this.FildPanel.Margin = new System.Windows.Forms.Padding(2);
            this.FildPanel.Name = "FildPanel";
            this.FildPanel.Size = new System.Drawing.Size(552, 601);
            this.FildPanel.TabIndex = 30;
            this.FildPanel.Visible = false;
            // 
            // AddRecordB
            // 
            this.AddRecordB.Location = new System.Drawing.Point(18, 84);
            this.AddRecordB.Margin = new System.Windows.Forms.Padding(2);
            this.AddRecordB.Name = "AddRecordB";
            this.AddRecordB.Size = new System.Drawing.Size(88, 24);
            this.AddRecordB.TabIndex = 29;
            this.AddRecordB.Text = "Додати";
            this.AddRecordB.UseVisualStyleBackColor = true;
            this.AddRecordB.Visible = false;
            this.AddRecordB.Click += new System.EventHandler(this.AddRecordB_Click);
            // 
            // BackPanel1
            // 
            this.BackPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.BackPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackPanel1.Controls.Add(this.AddRadioButton);
            this.BackPanel1.Controls.Add(this.FildPanel);
            this.BackPanel1.Controls.Add(this.WorkingWithSectionsB);
            this.BackPanel1.Controls.Add(this.DeleteRadioButton);
            this.BackPanel1.Controls.Add(this.WorkingWithTopicsB);
            this.BackPanel1.Controls.Add(this.EditRadioButton);
            this.BackPanel1.Controls.Add(this.WorkingWithTasksB);
            this.BackPanel1.Controls.Add(this.UpdateRecordB);
            this.BackPanel1.Controls.Add(this.AddRecordB);
            this.BackPanel1.Location = new System.Drawing.Point(12, 10);
            this.BackPanel1.Name = "BackPanel1";
            this.BackPanel1.Size = new System.Drawing.Size(685, 704);
            this.BackPanel1.TabIndex = 41;
            // 
            // SearchCBox
            // 
            this.SearchCBox.FormattingEnabled = true;
            this.SearchCBox.Location = new System.Drawing.Point(522, 15);
            this.SearchCBox.Name = "SearchCBox";
            this.SearchCBox.Size = new System.Drawing.Size(121, 21);
            this.SearchCBox.TabIndex = 39;
            this.SearchCBox.SelectedIndexChanged += new System.EventHandler(this.Filtration_Click);
            this.SearchCBox.TextUpdate += new System.EventHandler(this.Filtration_Click);
            // 
            // SearchTBox
            // 
            this.SearchTBox.Location = new System.Drawing.Point(416, 15);
            this.SearchTBox.Name = "SearchTBox";
            this.SearchTBox.Size = new System.Drawing.Size(100, 20);
            this.SearchTBox.TabIndex = 38;
            this.SearchTBox.TextChanged += new System.EventHandler(this.Filtration_Click);
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableLabel.Location = new System.Drawing.Point(255, 41);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(121, 18);
            this.TableLabel.TabIndex = 37;
            this.TableLabel.Text = "Вміст таблиці:";
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(13, 61);
            this.DataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.RowTemplate.Height = 24;
            this.DataGrid.Size = new System.Drawing.Size(655, 624);
            this.DataGrid.TabIndex = 27;
            this.DataGrid.Visible = false;
            this.DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // BackPanel2
            // 
            this.BackPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.BackPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackPanel2.Controls.Add(this.SearchCLabel);
            this.BackPanel2.Controls.Add(this.SearchTLabel);
            this.BackPanel2.Controls.Add(this.DataGrid);
            this.BackPanel2.Controls.Add(this.TableLabel);
            this.BackPanel2.Controls.Add(this.SearchCBox);
            this.BackPanel2.Controls.Add(this.SearchTBox);
            this.BackPanel2.Location = new System.Drawing.Point(705, 10);
            this.BackPanel2.Name = "BackPanel2";
            this.BackPanel2.Size = new System.Drawing.Size(684, 704);
            this.BackPanel2.TabIndex = 35;
            // 
            // SearchCLabel
            // 
            this.SearchCLabel.AutoSize = true;
            this.SearchCLabel.Location = new System.Drawing.Point(526, 1);
            this.SearchCLabel.Name = "SearchCLabel";
            this.SearchCLabel.Size = new System.Drawing.Size(40, 13);
            this.SearchCLabel.TabIndex = 41;
            this.SearchCLabel.Text = "Розділ";
            // 
            // SearchTLabel
            // 
            this.SearchTLabel.AutoSize = true;
            this.SearchTLabel.Location = new System.Drawing.Point(420, 0);
            this.SearchTLabel.Name = "SearchTLabel";
            this.SearchTLabel.Size = new System.Drawing.Size(39, 13);
            this.SearchTLabel.TabIndex = 40;
            this.SearchTLabel.Text = "Назва";
            // 
            // TaskEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 724);
            this.Controls.Add(this.BackPanel2);
            this.Controls.Add(this.BackPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TaskEditingForm";
            this.Text = "Редагування завдань";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TaskEditing_FormClosed);
            this.Load += new System.EventHandler(this.TaskEditing_Load);
            this.BackPanel1.ResumeLayout(false);
            this.BackPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.BackPanel2.ResumeLayout(false);
            this.BackPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WorkingWithSectionsB;
        private System.Windows.Forms.Button WorkingWithTopicsB;
        private System.Windows.Forms.Button WorkingWithTasksB;
        private System.Windows.Forms.Button UpdateRecordB;
        private System.Windows.Forms.RadioButton EditRadioButton;
        private System.Windows.Forms.RadioButton DeleteRadioButton;
        private System.Windows.Forms.RadioButton AddRadioButton;
        private System.Windows.Forms.Panel FildPanel;
        private System.Windows.Forms.Button AddRecordB;
        private System.Windows.Forms.Panel BackPanel1;
        private System.Windows.Forms.ComboBox SearchCBox;
        private System.Windows.Forms.TextBox SearchTBox;
        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Panel BackPanel2;
        private System.Windows.Forms.Label SearchCLabel;
        private System.Windows.Forms.Label SearchTLabel;
    }
}