namespace Application_Launcher
{
    partial class Add_application
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
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CancelButtonF = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.StartCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ArgumentsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Application";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(77, 6);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(258, 20);
            this.PathTextBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelButtonF
            // 
            this.CancelButtonF.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButtonF.Location = new System.Drawing.Point(302, 103);
            this.CancelButtonF.Name = "CancelButtonF";
            this.CancelButtonF.Size = new System.Drawing.Size(75, 23);
            this.CancelButtonF.TabIndex = 5;
            this.CancelButtonF.Text = "Cancel";
            this.CancelButtonF.UseVisualStyleBackColor = true;
            this.CancelButtonF.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Savebutton.Location = new System.Drawing.Point(221, 103);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 23);
            this.Savebutton.TabIndex = 4;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // StartCheckBox
            // 
            this.StartCheckBox.AutoSize = true;
            this.StartCheckBox.Location = new System.Drawing.Point(293, 63);
            this.StartCheckBox.Name = "StartCheckBox";
            this.StartCheckBox.Size = new System.Drawing.Size(83, 17);
            this.StartCheckBox.TabIndex = 3;
            this.StartCheckBox.Text = "Default start";
            this.StartCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Arguments";
            // 
            // ArgumentsTextBox
            // 
            this.ArgumentsTextBox.Location = new System.Drawing.Point(77, 37);
            this.ArgumentsTextBox.Name = "ArgumentsTextBox";
            this.ArgumentsTextBox.Size = new System.Drawing.Size(258, 20);
            this.ArgumentsTextBox.TabIndex = 2;
            // 
            // Add_application
            // 
            this.AcceptButton = this.Savebutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButtonF;
            this.ClientSize = new System.Drawing.Size(389, 136);
            this.Controls.Add(this.ArgumentsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartCheckBox);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.CancelButtonF);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Add_application";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add application";
            this.Load += new System.EventHandler(this.Add_application_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CancelButtonF;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.CheckBox StartCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ArgumentsTextBox;
    }
}