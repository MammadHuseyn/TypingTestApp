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
            btnStart_Click.Location = new Point(416, 268);
            btnStart_Click.Margin = new Padding(2, 2, 2, 2);
            btnStart_Click.Name = "btnStart_Click";
            btnStart_Click.Size = new Size(78, 20);
            btnStart_Click.TabIndex = 0;
            btnStart_Click.Text = "Start";
            btnStart_Click.UseVisualStyleBackColor = true;
            btnStart_Click.Click += button1_Click;
            // 
            // txtInput_TextChanged
            // 
            txtInput_TextChanged.AccessibleName = "txtInput_TextChanged";
            txtInput_TextChanged.BackColor = SystemColors.InactiveBorder;
            txtInput_TextChanged.Location = new Point(242, 190);
            txtInput_TextChanged.Margin = new Padding(2, 2, 2, 2);
            txtInput_TextChanged.Name = "txtInput_TextChanged";
            txtInput_TextChanged.Size = new Size(472, 23);
            txtInput_TextChanged.TabIndex = 1;
            txtInput_TextChanged.TextChanged += txtInput_TextChanged_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(313, 139);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 27);
            label1.TabIndex = 2;
            label1.Text = "TEST";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 502);
            Controls.Add(label1);
            Controls.Add(txtInput_TextChanged);
            Controls.Add(btnStart_Click);
            Margin = new Padding(2, 2, 2, 2);
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
