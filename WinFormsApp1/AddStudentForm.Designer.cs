namespace WinFormsApp1
{
    partial class AddStudentForm
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
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.class_comboBox = new System.Windows.Forms.ComboBox();
            this.addStudent_button = new System.Windows.Forms.Button();
            this.grades_FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(12, 27);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(260, 23);
            this.name_textBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Име:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Клас:";
            // 
            // class_comboBox
            // 
            this.class_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.class_comboBox.FormattingEnabled = true;
            this.class_comboBox.Location = new System.Drawing.Point(12, 92);
            this.class_comboBox.Name = "class_comboBox";
            this.class_comboBox.Size = new System.Drawing.Size(260, 23);
            this.class_comboBox.TabIndex = 4;
            // 
            // addStudent_button
            // 
            this.addStudent_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addStudent_button.Location = new System.Drawing.Point(106, 172);
            this.addStudent_button.Name = "addStudent_button";
            this.addStudent_button.Size = new System.Drawing.Size(75, 23);
            this.addStudent_button.TabIndex = 5;
            this.addStudent_button.Text = "Добави";
            this.addStudent_button.UseVisualStyleBackColor = true;
            this.addStudent_button.Click += new System.EventHandler(this.addStudent_button_Click);
            // 
            // grades_FlowLayoutPanel
            // 
            this.grades_FlowLayoutPanel.Location = new System.Drawing.Point(12, 156);
            this.grades_FlowLayoutPanel.Name = "grades_FlowLayoutPanel";
            this.grades_FlowLayoutPanel.Size = new System.Drawing.Size(260, 10);
            this.grades_FlowLayoutPanel.TabIndex = 6;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 207);
            this.Controls.Add(this.grades_FlowLayoutPanel);
            this.Controls.Add(this.addStudent_button);
            this.Controls.Add(this.class_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.label2);
            this.Name = "AddStudentForm";
            this.Text = "Добавяне на ученик";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox name_textBox;
        private Label label2;
        private Label label3;
        private ComboBox class_comboBox;
        private Button addStudent_button;
        private FlowLayoutPanel grades_FlowLayoutPanel;
    }
}