namespace WinFormsApp1
{
    partial class AddNewClassForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.className_textBox = new System.Windows.Forms.TextBox();
            this.addClass_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клас:";
            // 
            // className_textBox
            // 
            this.className_textBox.Location = new System.Drawing.Point(54, 20);
            this.className_textBox.Name = "className_textBox";
            this.className_textBox.Size = new System.Drawing.Size(41, 23);
            this.className_textBox.TabIndex = 1;
            // 
            // addClass_button
            // 
            this.addClass_button.Location = new System.Drawing.Point(79, 61);
            this.addClass_button.Name = "addClass_button";
            this.addClass_button.Size = new System.Drawing.Size(75, 23);
            this.addClass_button.TabIndex = 2;
            this.addClass_button.Text = "Добави";
            this.addClass_button.UseVisualStyleBackColor = true;
            this.addClass_button.Click += new System.EventHandler(this.addClass_button_Click);
            // 
            // AddNewClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 96);
            this.Controls.Add(this.addClass_button);
            this.Controls.Add(this.className_textBox);
            this.Controls.Add(this.label1);
            this.Name = "AddNewClassForm";
            this.Text = "Добавяне на нов клас";
            this.Load += new System.EventHandler(this.AddNewClassForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox className_textBox;
        private Button addClass_button;
    }
}