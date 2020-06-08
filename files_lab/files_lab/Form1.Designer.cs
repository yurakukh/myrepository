namespace files_lab
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
            this.create_directories = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.remove_directories = new System.Windows.Forms.Button();
            this.create_subdirectories = new System.Windows.Forms.Button();
            this.remove_subdirectories = new System.Windows.Forms.Button();
            this.findFile_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.findFile_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.preview_textBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // create_directories
            // 
            this.create_directories.Location = new System.Drawing.Point(53, 78);
            this.create_directories.Name = "create_directories";
            this.create_directories.Size = new System.Drawing.Size(197, 57);
            this.create_directories.TabIndex = 0;
            this.create_directories.Text = "Create 100 directories";
            this.create_directories.UseVisualStyleBackColor = true;
            this.create_directories.Click += new System.EventHandler(this.create_directories_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your options";
            // 
            // remove_directories
            // 
            this.remove_directories.Enabled = false;
            this.remove_directories.Location = new System.Drawing.Point(53, 171);
            this.remove_directories.Name = "remove_directories";
            this.remove_directories.Size = new System.Drawing.Size(197, 57);
            this.remove_directories.TabIndex = 3;
            this.remove_directories.Text = "Delete 100 directories";
            this.remove_directories.UseVisualStyleBackColor = true;
            this.remove_directories.Click += new System.EventHandler(this.remove_directories_Click);
            // 
            // create_subdirectories
            // 
            this.create_subdirectories.Location = new System.Drawing.Point(325, 78);
            this.create_subdirectories.Name = "create_subdirectories";
            this.create_subdirectories.Size = new System.Drawing.Size(197, 57);
            this.create_subdirectories.TabIndex = 4;
            this.create_subdirectories.Text = "Create 100 subdirectories";
            this.create_subdirectories.UseVisualStyleBackColor = true;
            this.create_subdirectories.Click += new System.EventHandler(this.create_subdirectories_Click);
            // 
            // remove_subdirectories
            // 
            this.remove_subdirectories.Enabled = false;
            this.remove_subdirectories.Location = new System.Drawing.Point(325, 171);
            this.remove_subdirectories.Name = "remove_subdirectories";
            this.remove_subdirectories.Size = new System.Drawing.Size(197, 57);
            this.remove_subdirectories.TabIndex = 5;
            this.remove_subdirectories.Text = "Remove 100 subdirectories";
            this.remove_subdirectories.UseVisualStyleBackColor = true;
            this.remove_subdirectories.Click += new System.EventHandler(this.remove_subdirectories_Click);
            // 
            // findFile_textBox
            // 
            this.findFile_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findFile_textBox.Location = new System.Drawing.Point(53, 322);
            this.findFile_textBox.Name = "findFile_textBox";
            this.findFile_textBox.Size = new System.Drawing.Size(303, 30);
            this.findFile_textBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(48, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Find a file";
            // 
            // findFile_button
            // 
            this.findFile_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findFile_button.Location = new System.Drawing.Point(382, 322);
            this.findFile_button.Name = "findFile_button";
            this.findFile_button.Size = new System.Drawing.Size(140, 30);
            this.findFile_button.TabIndex = 8;
            this.findFile_button.Text = "Find";
            this.findFile_button.UseVisualStyleBackColor = true;
            this.findFile_button.Click += new System.EventHandler(this.findFile_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(34, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Results:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1136, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Preview";
            // 
            // preview_textBox
            // 
            this.preview_textBox.Location = new System.Drawing.Point(875, 78);
            this.preview_textBox.Name = "preview_textBox";
            this.preview_textBox.ReadOnly = true;
            this.preview_textBox.Size = new System.Drawing.Size(611, 678);
            this.preview_textBox.TabIndex = 12;
            this.preview_textBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(38, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 346);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 782);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.preview_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.findFile_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.findFile_textBox);
            this.Controls.Add(this.remove_subdirectories);
            this.Controls.Add(this.create_subdirectories);
            this.Controls.Add(this.remove_directories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.create_directories);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_directories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button remove_directories;
        private System.Windows.Forms.Button create_subdirectories;
        private System.Windows.Forms.Button remove_subdirectories;
        private System.Windows.Forms.TextBox findFile_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button findFile_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox preview_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

