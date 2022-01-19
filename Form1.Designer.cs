
namespace IAProiect
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
            this.loadFile = new System.Windows.Forms.Button();
            this.loadFileTextBox = new System.Windows.Forms.TextBox();
            this.observeRadioButton = new System.Windows.Forms.RadioButton();
            this.queryEadioButton = new System.Windows.Forms.RadioButton();
            this.deleteQueryRadioButton = new System.Windows.Forms.RadioButton();
            this.executeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadFile
            // 
            this.loadFile.Location = new System.Drawing.Point(17, 511);
            this.loadFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadFile.Name = "loadFile";
            this.loadFile.Size = new System.Drawing.Size(100, 28);
            this.loadFile.TabIndex = 0;
            this.loadFile.Text = "Incarca";
            this.loadFile.UseVisualStyleBackColor = true;
            this.loadFile.Click += new System.EventHandler(this.loadFile_Click);
            // 
            // loadFileTextBox
            // 
            this.loadFileTextBox.Enabled = false;
            this.loadFileTextBox.Location = new System.Drawing.Point(125, 511);
            this.loadFileTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadFileTextBox.Multiline = true;
            this.loadFileTextBox.Name = "loadFileTextBox";
            this.loadFileTextBox.ReadOnly = true;
            this.loadFileTextBox.Size = new System.Drawing.Size(639, 27);
            this.loadFileTextBox.TabIndex = 1;
            // 
            // observeRadioButton
            // 
            this.observeRadioButton.AutoSize = true;
            this.observeRadioButton.Location = new System.Drawing.Point(858, 69);
            this.observeRadioButton.Name = "observeRadioButton";
            this.observeRadioButton.Size = new System.Drawing.Size(94, 20);
            this.observeRadioButton.TabIndex = 2;
            this.observeRadioButton.TabStop = true;
            this.observeRadioButton.Text = "Observatie";
            this.observeRadioButton.UseVisualStyleBackColor = true;
            // 
            // queryEadioButton
            // 
            this.queryEadioButton.AutoSize = true;
            this.queryEadioButton.Location = new System.Drawing.Point(858, 95);
            this.queryEadioButton.Name = "queryEadioButton";
            this.queryEadioButton.Size = new System.Drawing.Size(89, 20);
            this.queryEadioButton.TabIndex = 3;
            this.queryEadioButton.TabStop = true;
            this.queryEadioButton.Text = "Interogare";
            this.queryEadioButton.UseVisualStyleBackColor = true;
            // 
            // deleteQueryRadioButton
            // 
            this.deleteQueryRadioButton.AutoSize = true;
            this.deleteQueryRadioButton.Location = new System.Drawing.Point(858, 121);
            this.deleteQueryRadioButton.Name = "deleteQueryRadioButton";
            this.deleteQueryRadioButton.Size = new System.Drawing.Size(144, 20);
            this.deleteQueryRadioButton.TabIndex = 4;
            this.deleteQueryRadioButton.TabStop = true;
            this.deleteQueryRadioButton.Text = "Stergere interogare";
            this.deleteQueryRadioButton.UseVisualStyleBackColor = true;
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(887, 147);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(75, 23);
            this.executeButton.TabIndex = 5;
            this.executeButton.Text = "Executa";
            this.executeButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.deleteQueryRadioButton);
            this.Controls.Add(this.queryEadioButton);
            this.Controls.Add(this.observeRadioButton);
            this.Controls.Add(this.loadFileTextBox);
            this.Controls.Add(this.loadFile);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadFile;
        private System.Windows.Forms.TextBox loadFileTextBox;
        private System.Windows.Forms.RadioButton observeRadioButton;
        private System.Windows.Forms.RadioButton queryEadioButton;
        private System.Windows.Forms.RadioButton deleteQueryRadioButton;
        private System.Windows.Forms.Button executeButton;
    }
}

