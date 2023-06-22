namespace fukuv0622
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
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 45);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(31, 102);
            button1.Margin = new Padding(8, 9, 8, 9);
            button1.Name = "button1";
            button1.Size = new Size(193, 69);
            button1.TabIndex = 1;
            button1.Text = "Avg";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 399);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(8, 9, 8, 9);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}