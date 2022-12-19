namespace Translator_My
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.translateTextBox = new System.Windows.Forms.TextBox();
            this.langComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.viewDictionaryButton = new System.Windows.Forms.Button();
            this.translateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите слово";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Перевод";
            // 
            // wordTextBox
            // 
            this.wordTextBox.Location = new System.Drawing.Point(58, 214);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(227, 27);
            this.wordTextBox.TabIndex = 2;
            // 
            // translateTextBox
            // 
            this.translateTextBox.Location = new System.Drawing.Point(458, 214);
            this.translateTextBox.Name = "translateTextBox";
            this.translateTextBox.ReadOnly = true;
            this.translateTextBox.Size = new System.Drawing.Size(227, 27);
            this.translateTextBox.TabIndex = 3;
            // 
            // langComboBox
            // 
            this.langComboBox.FormattingEnabled = true;
            this.langComboBox.Items.AddRange(new object[] {
            "Перевести с русского",
            "Перевести с английского"});
            this.langComboBox.Location = new System.Drawing.Point(309, 52);
            this.langComboBox.Name = "langComboBox";
            this.langComboBox.Size = new System.Drawing.Size(151, 28);
            this.langComboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "----->";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Выберете язык";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(566, 393);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(95, 45);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // viewDictionaryButton
            // 
            this.viewDictionaryButton.Location = new System.Drawing.Point(693, 393);
            this.viewDictionaryButton.Name = "viewDictionaryButton";
            this.viewDictionaryButton.Size = new System.Drawing.Size(95, 45);
            this.viewDictionaryButton.TabIndex = 8;
            this.viewDictionaryButton.Text = "Словарь";
            this.viewDictionaryButton.UseVisualStyleBackColor = true;
            this.viewDictionaryButton.Click += new System.EventHandler(this.viewDictionaryButton_Click);
            // 
            // translateButton
            // 
            this.translateButton.Location = new System.Drawing.Point(309, 289);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(114, 62);
            this.translateButton.TabIndex = 9;
            this.translateButton.Text = "Перевести";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.viewDictionaryButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.langComboBox);
            this.Controls.Add(this.translateTextBox);
            this.Controls.Add(this.wordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox wordTextBox;
        private TextBox translateTextBox;
        private ComboBox langComboBox;
        private Label label3;
        private Label label4;
        private Button AddButton;
        private Button viewDictionaryButton;
        private Button translateButton;
    }
}