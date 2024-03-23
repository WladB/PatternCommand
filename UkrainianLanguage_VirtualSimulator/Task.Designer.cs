
namespace UkrainianLanguage_VirtualSimulator
{
    partial class Task
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
            this.AnswersPanel = new System.Windows.Forms.Panel();
            this.CheckButton = new System.Windows.Forms.Button();
            this.TaskCaptionLabel = new System.Windows.Forms.Label();
            this.TestType = new System.Windows.Forms.Label();
            this.TaskDescription = new System.Windows.Forms.TextBox();
            this.TaskDescriptionLabel = new System.Windows.Forms.Label();
            this.ViewingRules = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AnswersPanel
            // 
            this.AnswersPanel.AutoScroll = true;
            this.AnswersPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnswersPanel.Location = new System.Drawing.Point(35, 158);
            this.AnswersPanel.Name = "AnswersPanel";
            this.AnswersPanel.Size = new System.Drawing.Size(729, 200);
            this.AnswersPanel.TabIndex = 0;
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(246, 396);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(283, 42);
            this.CheckButton.TabIndex = 1;
            this.CheckButton.Text = "Перевірити";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // TaskCaptionLabel
            // 
            this.TaskCaptionLabel.AutoSize = true;
            this.TaskCaptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskCaptionLabel.Location = new System.Drawing.Point(335, 22);
            this.TaskCaptionLabel.Name = "TaskCaptionLabel";
            this.TaskCaptionLabel.Size = new System.Drawing.Size(147, 20);
            this.TaskCaptionLabel.TabIndex = 2;
            this.TaskCaptionLabel.Text = "Назва завдання";
            // 
            // TestType
            // 
            this.TestType.AutoSize = true;
            this.TestType.Location = new System.Drawing.Point(60, 366);
            this.TestType.Name = "TestType";
            this.TestType.Size = new System.Drawing.Size(59, 13);
            this.TestType.TabIndex = 4;
            this.TestType.Text = "Тип тестів";
            // 
            // TaskDescription
            // 
            this.TaskDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TaskDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskDescription.Location = new System.Drawing.Point(63, 78);
            this.TaskDescription.Multiline = true;
            this.TaskDescription.Name = "TaskDescription";
            this.TaskDescription.ReadOnly = true;
            this.TaskDescription.Size = new System.Drawing.Size(678, 62);
            this.TaskDescription.TabIndex = 6;
            // 
            // TaskDescriptionLabel
            // 
            this.TaskDescriptionLabel.AutoSize = true;
            this.TaskDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskDescriptionLabel.Location = new System.Drawing.Point(347, 59);
            this.TaskDescriptionLabel.Name = "TaskDescriptionLabel";
            this.TaskDescriptionLabel.Size = new System.Drawing.Size(120, 16);
            this.TaskDescriptionLabel.TabIndex = 7;
            this.TaskDescriptionLabel.Text = "Опис завдання";
            // 
            // ViewingRules
            // 
            this.ViewingRules.Location = new System.Drawing.Point(666, 364);
            this.ViewingRules.Name = "ViewingRules";
            this.ViewingRules.Size = new System.Drawing.Size(75, 23);
            this.ViewingRules.TabIndex = 8;
            this.ViewingRules.Text = "Правила";
            this.ViewingRules.UseVisualStyleBackColor = true;
            this.ViewingRules.Click += new System.EventHandler(this.ViewingRulesButton_Click);
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewingRules);
            this.Controls.Add(this.TaskDescriptionLabel);
            this.Controls.Add(this.TaskDescription);
            this.Controls.Add(this.TestType);
            this.Controls.Add(this.TaskCaptionLabel);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.AnswersPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Task";
            this.Text = "Проходження завдання";
            this.Load += new System.EventHandler(this.Task_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel AnswersPanel;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Label TaskCaptionLabel;
        private System.Windows.Forms.Label TestType;
        private System.Windows.Forms.TextBox TaskDescription;
        private System.Windows.Forms.Label TaskDescriptionLabel;
        private System.Windows.Forms.Button ViewingRules;
    }
}