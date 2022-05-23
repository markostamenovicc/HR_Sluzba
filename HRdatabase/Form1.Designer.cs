
namespace HRdatabase
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_zaposleniForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(356, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "HR Program";
            // 
            // btn_zaposleniForm
            // 
            this.btn_zaposleniForm.Location = new System.Drawing.Point(387, 166);
            this.btn_zaposleniForm.Name = "btn_zaposleniForm";
            this.btn_zaposleniForm.Size = new System.Drawing.Size(156, 29);
            this.btn_zaposleniForm.TabIndex = 1;
            this.btn_zaposleniForm.Text = "Zaposleni";
            this.btn_zaposleniForm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 573);
            this.Controls.Add(this.btn_zaposleniForm);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_zaposleniForm;
    }
}

