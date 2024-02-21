namespace WinFormsApp {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            label2 = new Label();
            inputBox = new TextBox();
            button1 = new Button();
            outputTextBox = new Label();
            inch = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(94, 28);
            label1.TabIndex = 0;
            label1.Text = "Távolság";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 68);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 1;
            label2.Text = "inch";
            // 
            // inputBox
            // 
            inputBox.Location = new Point(118, 61);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(125, 27);
            inputBox.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(131, 108);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Átváltás";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // outputTextBox
            // 
            outputTextBox.AutoSize = true;
            outputTextBox.Location = new Point(118, 179);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(0, 20);
            outputTextBox.TabIndex = 4;
            // 
            // inch
            // 
            inch.AutoSize = true;
            inch.Location = new Point(249, 179);
            inch.Name = "inch";
            inch.Size = new Size(22, 20);
            inch.TabIndex = 5;
            inch.Text = "m";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 227);
            Controls.Add(inch);
            Controls.Add(outputTextBox);
            Controls.Add(button1);
            Controls.Add(inputBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox inputBox;
        private Button button1;
        private Label outputTextBox;
        private Label inch;
    }
}
