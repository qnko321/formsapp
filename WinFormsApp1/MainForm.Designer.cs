namespace WinFormsApp1
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.searchStudent_textBox = new System.Windows.Forms.TextBox();
            this.searchStudent_button = new System.Windows.Forms.Button();
            this.averageClassGrade_label = new System.Windows.Forms.Label();
            this.calculateAverageGradeClass_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(139, 11);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(99, 23);
            this.AddStudentButton.TabIndex = 2;
            this.AddStudentButton.Text = "Добави Ученик";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 84);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 354);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добави Нов Клас";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddClassButton_Click);
            // 
            // searchStudent_textBox
            // 
            this.searchStudent_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchStudent_textBox.Location = new System.Drawing.Point(461, 14);
            this.searchStudent_textBox.Name = "searchStudent_textBox";
            this.searchStudent_textBox.Size = new System.Drawing.Size(246, 23);
            this.searchStudent_textBox.TabIndex = 5;
            // 
            // searchStudent_button
            // 
            this.searchStudent_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchStudent_button.Location = new System.Drawing.Point(713, 13);
            this.searchStudent_button.Name = "searchStudent_button";
            this.searchStudent_button.Size = new System.Drawing.Size(75, 23);
            this.searchStudent_button.TabIndex = 6;
            this.searchStudent_button.Text = "Търси";
            this.searchStudent_button.UseVisualStyleBackColor = true;
            this.searchStudent_button.Click += new System.EventHandler(this.searchStudent_button_Click);
            // 
            // averageClassGrade_label
            // 
            this.averageClassGrade_label.AutoSize = true;
            this.averageClassGrade_label.Location = new System.Drawing.Point(12, 52);
            this.averageClassGrade_label.Name = "averageClassGrade_label";
            this.averageClassGrade_label.Size = new System.Drawing.Size(0, 15);
            this.averageClassGrade_label.TabIndex = 0;
            // 
            // calculateAverageGradeClass_button
            // 
            this.calculateAverageGradeClass_button.Location = new System.Drawing.Point(12, 48);
            this.calculateAverageGradeClass_button.Name = "calculateAverageGradeClass_button";
            this.calculateAverageGradeClass_button.Size = new System.Drawing.Size(189, 23);
            this.calculateAverageGradeClass_button.TabIndex = 7;
            this.calculateAverageGradeClass_button.Text = "Изчисли среден успех на класа";
            this.calculateAverageGradeClass_button.UseVisualStyleBackColor = true;
            this.calculateAverageGradeClass_button.Click += new System.EventHandler(this.calculateAverageGradeClass_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculateAverageGradeClass_button);
            this.Controls.Add(this.averageClassGrade_label);
            this.Controls.Add(this.searchStudent_button);
            this.Controls.Add(this.searchStudent_textBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.comboBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ComboBox comboBox1;
        private Button AddStudentButton;
        private Label label1;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private TextBox searchStudent_textBox;
        private Button searchStudent_button;
        private Label averageClassGrade_label;
        private Button calculateAverageGradeClass_button;
    }
}