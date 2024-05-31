namespace Web_Cast_Operator
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
            this.intCastOperator = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.realNumberTextBox = new System.Windows.Forms.TextBox();
            this.outputWholeNumberLabel = new System.Windows.Forms.Label();
            this.intNumberLabel = new System.Windows.Forms.Label();
            this.doubleNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // intCastOperator
            // 
            this.intCastOperator.BackColor = System.Drawing.Color.White;
            this.intCastOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intCastOperator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.intCastOperator.Location = new System.Drawing.Point(43, 13);
            this.intCastOperator.Name = "intCastOperator";
            this.intCastOperator.Size = new System.Drawing.Size(253, 30);
            this.intCastOperator.TabIndex = 18;
            this.intCastOperator.Text = "Int Cast Operator";
            this.intCastOperator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(85, 270);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(672, 60);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "The (int) cast operator converts the value of the realNumber variable to an int. " +
    "The (int) cast operation then assigns the value it converted to the wholeNumber " +
    "variable.";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(678, 223);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(583, 224);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(462, 225);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(98, 23);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // realNumberTextBox
            // 
            this.realNumberTextBox.Location = new System.Drawing.Point(309, 82);
            this.realNumberTextBox.Name = "realNumberTextBox";
            this.realNumberTextBox.Size = new System.Drawing.Size(448, 20);
            this.realNumberTextBox.TabIndex = 13;
            this.realNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // outputWholeNumberLabel
            // 
            this.outputWholeNumberLabel.BackColor = System.Drawing.Color.White;
            this.outputWholeNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputWholeNumberLabel.Location = new System.Drawing.Point(306, 151);
            this.outputWholeNumberLabel.Name = "outputWholeNumberLabel";
            this.outputWholeNumberLabel.Size = new System.Drawing.Size(451, 23);
            this.outputWholeNumberLabel.TabIndex = 12;
            this.outputWholeNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // intNumberLabel
            // 
            this.intNumberLabel.BackColor = System.Drawing.Color.White;
            this.intNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intNumberLabel.Location = new System.Drawing.Point(82, 151);
            this.intNumberLabel.Name = "intNumberLabel";
            this.intNumberLabel.Size = new System.Drawing.Size(178, 23);
            this.intNumberLabel.TabIndex = 11;
            this.intNumberLabel.Text = "int wholeNumber:";
            this.intNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // doubleNumberLabel
            // 
            this.doubleNumberLabel.BackColor = System.Drawing.Color.White;
            this.doubleNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doubleNumberLabel.Location = new System.Drawing.Point(82, 83);
            this.doubleNumberLabel.Name = "doubleNumberLabel";
            this.doubleNumberLabel.Size = new System.Drawing.Size(178, 23);
            this.doubleNumberLabel.TabIndex = 10;
            this.doubleNumberLabel.Text = "double realNumber:";
            this.doubleNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 380);
            this.Controls.Add(this.intCastOperator);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.realNumberTextBox);
            this.Controls.Add(this.outputWholeNumberLabel);
            this.Controls.Add(this.intNumberLabel);
            this.Controls.Add(this.doubleNumberLabel);
            this.Name = "Form1";
            this.Text = "double moneyNumber to integer wholeNumber";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label intCastOperator;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox realNumberTextBox;
        private System.Windows.Forms.Label outputWholeNumberLabel;
        private System.Windows.Forms.Label intNumberLabel;
        private System.Windows.Forms.Label doubleNumberLabel;
    }
}

