namespace FileRWAlex
{
    partial class FileRWForm
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblCompare = new System.Windows.Forms.Label();
            this.lblCases = new System.Windows.Forms.Label();
            this.lblOuput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(193, 157);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(104, 40);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // lblCompare
            // 
            this.lblCompare.AutoSize = true;
            this.lblCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompare.Location = new System.Drawing.Point(56, 9);
            this.lblCompare.Name = "lblCompare";
            this.lblCompare.Size = new System.Drawing.Size(485, 25);
            this.lblCompare.TabIndex = 1;
            this.lblCompare.Text = "Compare strings on each line of input.txt. file";
            // 
            // lblCases
            // 
            this.lblCases.AutoSize = true;
            this.lblCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCases.Location = new System.Drawing.Point(169, 46);
            this.lblCases.Name = "lblCases";
            this.lblCases.Size = new System.Drawing.Size(228, 25);
            this.lblCases.TabIndex = 2;
            this.lblCases.Text = "(Cases doesn\'t matter)";
            // 
            // lblOuput
            // 
            this.lblOuput.AutoSize = true;
            this.lblOuput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOuput.Location = new System.Drawing.Point(71, 228);
            this.lblOuput.Name = "lblOuput";
            this.lblOuput.Size = new System.Drawing.Size(250, 25);
            this.lblOuput.TabIndex = 3;
            this.lblOuput.Text = "(Cases doesn\'t matter)";
            // 
            // FileRWForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 295);
            this.Controls.Add(this.lblOuput);
            this.Controls.Add(this.lblCases);
            this.Controls.Add(this.lblCompare);
            this.Controls.Add(this.btnCheck);
            this.Name = "FileRWForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblCompare;
        private System.Windows.Forms.Label lblCases;
        private System.Windows.Forms.Label lblOuput;
    }
}

