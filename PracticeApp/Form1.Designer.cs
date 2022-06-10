namespace PracticeApp
{
    partial class Form1
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
            this.insertNodeLabel = new System.Windows.Forms.Label();
            this.insertNodeTextBox = new System.Windows.Forms.TextBox();
            this.insertNodeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // insertNodeLabel
            // 
            this.insertNodeLabel.AutoSize = true;
            this.insertNodeLabel.Location = new System.Drawing.Point(186, 86);
            this.insertNodeLabel.Name = "insertNodeLabel";
            this.insertNodeLabel.Size = new System.Drawing.Size(76, 16);
            this.insertNodeLabel.TabIndex = 0;
            this.insertNodeLabel.Text = "Insert Node";
            // 
            // insertNodeTextBox
            // 
            this.insertNodeTextBox.Location = new System.Drawing.Point(189, 131);
            this.insertNodeTextBox.Name = "insertNodeTextBox";
            this.insertNodeTextBox.Size = new System.Drawing.Size(100, 22);
            this.insertNodeTextBox.TabIndex = 2;
            // 
            // insertNodeButton
            // 
            this.insertNodeButton.Location = new System.Drawing.Point(347, 131);
            this.insertNodeButton.Name = "insertNodeButton";
            this.insertNodeButton.Size = new System.Drawing.Size(75, 23);
            this.insertNodeButton.TabIndex = 3;
            this.insertNodeButton.Text = "Insert";
            this.insertNodeButton.UseVisualStyleBackColor = true;
            this.insertNodeButton.Click += new System.EventHandler(this.insertNodeButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "View Tree";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.insertNodeButton);
            this.Controls.Add(this.insertNodeTextBox);
            this.Controls.Add(this.insertNodeLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label insertNodeLabel;
        private System.Windows.Forms.TextBox insertNodeTextBox;
        private System.Windows.Forms.Button insertNodeButton;
        private System.Windows.Forms.Button button1;
    }
}

