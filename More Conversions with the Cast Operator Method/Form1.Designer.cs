﻿namespace More_Conversions_with_the_Cast_Operator_Method
{
    partial class castOperatorForm
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
            this.decimalNumberLabel = new System.Windows.Forms.Label();
            this.intNumberLabel = new System.Windows.Forms.Label();
            this.outputWholeNumberLabel = new System.Windows.Forms.Label();
            this.moneyNumberTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // decimalNumberLabel
            // 
            this.decimalNumberLabel.BackColor = System.Drawing.Color.White;
            this.decimalNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalNumberLabel.Location = new System.Drawing.Point(68, 67);
            this.decimalNumberLabel.Name = "decimalNumberLabel";
            this.decimalNumberLabel.Size = new System.Drawing.Size(178, 23);
            this.decimalNumberLabel.TabIndex = 0;
            this.decimalNumberLabel.Text = "Decimal Number:";
            this.decimalNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // intNumberLabel
            // 
            this.intNumberLabel.BackColor = System.Drawing.Color.White;
            this.intNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intNumberLabel.Location = new System.Drawing.Point(68, 123);
            this.intNumberLabel.Name = "intNumberLabel";
            this.intNumberLabel.Size = new System.Drawing.Size(178, 23);
            this.intNumberLabel.TabIndex = 1;
            this.intNumberLabel.Text = "Whole Number:";
            this.intNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outputWholeNumberLabel
            // 
            this.outputWholeNumberLabel.BackColor = System.Drawing.Color.White;
            this.outputWholeNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputWholeNumberLabel.Location = new System.Drawing.Point(292, 123);
            this.outputWholeNumberLabel.Name = "outputWholeNumberLabel";
            this.outputWholeNumberLabel.Size = new System.Drawing.Size(451, 23);
            this.outputWholeNumberLabel.TabIndex = 2;
            this.outputWholeNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // moneyNumberTextBox
            // 
            this.moneyNumberTextBox.Location = new System.Drawing.Point(295, 66);
            this.moneyNumberTextBox.Name = "moneyNumberTextBox";
            this.moneyNumberTextBox.Size = new System.Drawing.Size(448, 20);
            this.moneyNumberTextBox.TabIndex = 3;
            this.moneyNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(448, 197);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(98, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click_1);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(567, 196);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(659, 195);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // castOperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(801, 307);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.moneyNumberTextBox);
            this.Controls.Add(this.outputWholeNumberLabel);
            this.Controls.Add(this.intNumberLabel);
            this.Controls.Add(this.decimalNumberLabel);
            this.Name = "castOperatorForm";
            this.Text = "More Conversion using the Cast Operator Method - decimal moneyNumber to integer w" +
    "holeNumber";
            this.Load += new System.EventHandler(this.castOperatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label decimalNumberLabel;
        private System.Windows.Forms.Label intNumberLabel;
        private System.Windows.Forms.Label outputWholeNumberLabel;
        private System.Windows.Forms.TextBox moneyNumberTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}
