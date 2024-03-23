
namespace UkrainianLanguage_VirtualSimulator
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
            this.ListPanel = new System.Windows.Forms.Panel();
            this.InformLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.EntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReestrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditingTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyCabinetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListPanel
            // 
            this.ListPanel.AutoScroll = true;
            this.ListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListPanel.Location = new System.Drawing.Point(20, 77);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(760, 361);
            this.ListPanel.TabIndex = 1;
            // 
            // InformLabel
            // 
            this.InformLabel.AutoSize = true;
            this.InformLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InformLabel.Location = new System.Drawing.Point(273, 44);
            this.InformLabel.Name = "InformLabel";
            this.InformLabel.Size = new System.Drawing.Size(231, 20);
            this.InformLabel.TabIndex = 2;
            this.InformLabel.Text = "Оберіть потрібний розділ:";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(605, 37);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Visible = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EntryToolStripMenuItem,
            this.ReestrationToolStripMenuItem,
            this.EditingTasksToolStripMenuItem,
            this.ExitToolStripMenuItem,
            this.MyCabinetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // EntryToolStripMenuItem
            // 
            this.EntryToolStripMenuItem.Name = "EntryToolStripMenuItem";
            this.EntryToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.EntryToolStripMenuItem.Text = "Увійти";
            this.EntryToolStripMenuItem.Click += new System.EventHandler(this.EntryButton_Click);
            // 
            // ReestrationToolStripMenuItem
            // 
            this.ReestrationToolStripMenuItem.Name = "ReestrationToolStripMenuItem";
            this.ReestrationToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.ReestrationToolStripMenuItem.Text = "Зареєструватись";
            this.ReestrationToolStripMenuItem.Click += new System.EventHandler(this.Reestration_Click);
            // 
            // EditingTasksToolStripMenuItem
            // 
            this.EditingTasksToolStripMenuItem.Enabled = false;
            this.EditingTasksToolStripMenuItem.Name = "EditingTasksToolStripMenuItem";
            this.EditingTasksToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.EditingTasksToolStripMenuItem.Text = "Редагувати завдання";
            this.EditingTasksToolStripMenuItem.Visible = false;
            this.EditingTasksToolStripMenuItem.Click += new System.EventHandler(this.EditingTasks_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ExitToolStripMenuItem.Text = "Вихід";
            this.ExitToolStripMenuItem.Visible = false;
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MyCabinetToolStripMenuItem
            // 
            this.MyCabinetToolStripMenuItem.Name = "MyCabinetToolStripMenuItem";
            this.MyCabinetToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.MyCabinetToolStripMenuItem.Text = "Особистий кабінет";
            this.MyCabinetToolStripMenuItem.Visible = false;
            this.MyCabinetToolStripMenuItem.Click += new System.EventHandler(this.MyCabinetToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.InformLabel);
            this.Controls.Add(this.ListPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label InformLabel;
        private System.Windows.Forms.Button BackButton;
        public System.Windows.Forms.Panel ListPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReestrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditingTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyCabinetToolStripMenuItem;
    }
}

