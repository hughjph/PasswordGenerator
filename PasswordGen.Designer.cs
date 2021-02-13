
namespace PasswordGenerator
{
    partial class PasswordGen
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
            this.capsCheck = new System.Windows.Forms.CheckBox();
            this.numbersCheck = new System.Windows.Forms.CheckBox();
            this.symbolsCheck = new System.Windows.Forms.CheckBox();
            this.lowerCheck = new System.Windows.Forms.CheckBox();
            this.lengthSelector = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.LengthText = new System.Windows.Forms.TextBox();
            this.GenButton = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lengthSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password Generator";
            // 
            // capsCheck
            // 
            this.capsCheck.AutoSize = true;
            this.capsCheck.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capsCheck.Location = new System.Drawing.Point(181, 74);
            this.capsCheck.Name = "capsCheck";
            this.capsCheck.Size = new System.Drawing.Size(177, 32);
            this.capsCheck.TabIndex = 1;
            this.capsCheck.Text = "Capital Letters";
            this.capsCheck.UseVisualStyleBackColor = true;
            // 
            // numbersCheck
            // 
            this.numbersCheck.AutoSize = true;
            this.numbersCheck.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbersCheck.Location = new System.Drawing.Point(181, 150);
            this.numbersCheck.Name = "numbersCheck";
            this.numbersCheck.Size = new System.Drawing.Size(124, 32);
            this.numbersCheck.TabIndex = 2;
            this.numbersCheck.Text = "Numbers";
            this.numbersCheck.UseVisualStyleBackColor = true;
            // 
            // symbolsCheck
            // 
            this.symbolsCheck.AutoSize = true;
            this.symbolsCheck.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolsCheck.Location = new System.Drawing.Point(181, 188);
            this.symbolsCheck.Name = "symbolsCheck";
            this.symbolsCheck.Size = new System.Drawing.Size(116, 32);
            this.symbolsCheck.TabIndex = 4;
            this.symbolsCheck.Text = "Symbols";
            this.symbolsCheck.UseVisualStyleBackColor = true;
            // 
            // lowerCheck
            // 
            this.lowerCheck.AutoSize = true;
            this.lowerCheck.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerCheck.Location = new System.Drawing.Point(181, 112);
            this.lowerCheck.Name = "lowerCheck";
            this.lowerCheck.Size = new System.Drawing.Size(221, 32);
            this.lowerCheck.TabIndex = 5;
            this.lowerCheck.Text = "Lower Case Letters";
            this.lowerCheck.UseVisualStyleBackColor = true;
            // 
            // lengthSelector
            // 
            this.lengthSelector.Location = new System.Drawing.Point(125, 271);
            this.lengthSelector.Maximum = 30;
            this.lengthSelector.Minimum = 8;
            this.lengthSelector.Name = "lengthSelector";
            this.lengthSelector.Size = new System.Drawing.Size(277, 45);
            this.lengthSelector.TabIndex = 6;
            this.lengthSelector.Value = 15;
            this.lengthSelector.Scroll += new System.EventHandler(this.lengthSelector_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Length";
            // 
            // LengthText
            // 
            this.LengthText.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengthText.Location = new System.Drawing.Point(321, 242);
            this.LengthText.Name = "LengthText";
            this.LengthText.ReadOnly = true;
            this.LengthText.Size = new System.Drawing.Size(81, 29);
            this.LengthText.TabIndex = 9;
            this.LengthText.Text = "15";
            // 
            // GenButton
            // 
            this.GenButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenButton.Location = new System.Drawing.Point(197, 335);
            this.GenButton.Name = "GenButton";
            this.GenButton.Size = new System.Drawing.Size(136, 49);
            this.GenButton.TabIndex = 10;
            this.GenButton.Text = "Generate";
            this.GenButton.UseVisualStyleBackColor = true;
            this.GenButton.Click += new System.EventHandler(this.GenButton_Click);
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(12, 423);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(529, 29);
            this.output.TabIndex = 11;
            // 
            // PasswordGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 500);
            this.Controls.Add(this.output);
            this.Controls.Add(this.GenButton);
            this.Controls.Add(this.LengthText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lengthSelector);
            this.Controls.Add(this.lowerCheck);
            this.Controls.Add(this.symbolsCheck);
            this.Controls.Add(this.numbersCheck);
            this.Controls.Add(this.capsCheck);
            this.Controls.Add(this.label1);
            this.Name = "PasswordGen";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.lengthSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox capsCheck;
        private System.Windows.Forms.CheckBox numbersCheck;
        private System.Windows.Forms.CheckBox symbolsCheck;
        private System.Windows.Forms.CheckBox lowerCheck;
        private System.Windows.Forms.TrackBar lengthSelector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LengthText;
        private System.Windows.Forms.Button GenButton;
        private System.Windows.Forms.TextBox output;
    }
}

