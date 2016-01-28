namespace MinMaxAvg_2Dim
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.minButton = new System.Windows.Forms.Button();
            this.MaxButton = new System.Windows.Forms.Button();
            this.averageButton = new System.Windows.Forms.Button();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.averageTextBox = new System.Windows.Forms.TextBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(288, 217);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // minButton
            // 
            this.minButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minButton.Location = new System.Drawing.Point(306, 25);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(91, 37);
            this.minButton.TabIndex = 1;
            this.minButton.Text = "Minimum";
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // MaxButton
            // 
            this.MaxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxButton.Location = new System.Drawing.Point(306, 100);
            this.MaxButton.Name = "MaxButton";
            this.MaxButton.Size = new System.Drawing.Size(91, 35);
            this.MaxButton.TabIndex = 2;
            this.MaxButton.Text = "Maximum";
            this.MaxButton.UseVisualStyleBackColor = true;
            this.MaxButton.Click += new System.EventHandler(this.MaxButton_Click);
            // 
            // averageButton
            // 
            this.averageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageButton.Location = new System.Drawing.Point(306, 165);
            this.averageButton.Name = "averageButton";
            this.averageButton.Size = new System.Drawing.Size(91, 37);
            this.averageButton.TabIndex = 3;
            this.averageButton.Text = "Average";
            this.averageButton.UseVisualStyleBackColor = true;
            this.averageButton.Click += new System.EventHandler(this.averageButton_Click);
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(421, 34);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(100, 20);
            this.minTextBox.TabIndex = 4;
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(421, 100);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxTextBox.TabIndex = 5;
            // 
            // averageTextBox
            // 
            this.averageTextBox.Location = new System.Drawing.Point(421, 165);
            this.averageTextBox.Name = "averageTextBox";
            this.averageTextBox.Size = new System.Drawing.Size(100, 20);
            this.averageTextBox.TabIndex = 6;
            // 
            // displayButton
            // 
            this.displayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayButton.Location = new System.Drawing.Point(338, 225);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(169, 49);
            this.displayButton.TabIndex = 7;
            this.displayButton.Text = "Display Array";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 286);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.averageTextBox);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.averageButton);
            this.Controls.Add(this.MaxButton);
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Minimum, Maximum, Average";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Button MaxButton;
        private System.Windows.Forms.Button averageButton;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.TextBox averageTextBox;
        private System.Windows.Forms.Button displayButton;
    }
}

