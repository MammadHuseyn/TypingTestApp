﻿namespace TypingTest
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
            btnStart_Click = new Button();
            txtInput_TextChanged = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnStart_Click
            // 
            btnStart_Click.AccessibleName = "btnStart_Click";
            btnStart_Click.Location = new Point(594, 446);
            btnStart_Click.Name = "btnStart_Click";
            btnStart_Click.Size = new Size(112, 34);
            btnStart_Click.TabIndex = 0;
            btnStart_Click.Text = "button1";
            btnStart_Click.UseVisualStyleBackColor = true;
            btnStart_Click.Click += button1_Click;
            // 
            // txtInput_TextChanged
            // 
            txtInput_TextChanged.AccessibleName = "txtInput_TextChanged";
            txtInput_TextChanged.Location = new Point(356, 214);
            txtInput_TextChanged.Name = "txtInput_TextChanged";
            txtInput_TextChanged.Size = new Size(673, 31);
            txtInput_TextChanged.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 82);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 836);
            Controls.Add(label1);
            Controls.Add(txtInput_TextChanged);
            Controls.Add(btnStart_Click);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart_Click;
        private TextBox txtInput_TextChanged;
        private Label label1;
    }

}
