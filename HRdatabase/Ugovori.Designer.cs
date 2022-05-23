
namespace HRdatabase
{
    partial class Ugovori
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
            this.dateTime_datum = new System.Windows.Forms.DateTimePicker();
            this.txt_osoba = new System.Windows.Forms.TextBox();
            this.cmb_ugovor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTime_datum
            // 
            this.dateTime_datum.Location = new System.Drawing.Point(115, 169);
            this.dateTime_datum.Name = "dateTime_datum";
            this.dateTime_datum.Size = new System.Drawing.Size(200, 23);
            this.dateTime_datum.TabIndex = 0;
            // 
            // txt_osoba
            // 
            this.txt_osoba.Location = new System.Drawing.Point(346, 169);
            this.txt_osoba.Name = "txt_osoba";
            this.txt_osoba.Size = new System.Drawing.Size(175, 23);
            this.txt_osoba.TabIndex = 1;
            // 
            // cmb_ugovor
            // 
            this.cmb_ugovor.FormattingEnabled = true;
            this.cmb_ugovor.Location = new System.Drawing.Point(556, 169);
            this.cmb_ugovor.Name = "cmb_ugovor";
            this.cmb_ugovor.Size = new System.Drawing.Size(121, 23);
            this.cmb_ugovor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Osoba";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tip Ugovora";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(459, 272);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(94, 29);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(359, 272);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(94, 29);
            this.btn_change.TabIndex = 22;
            this.btn_change.Text = "Change";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(512, 237);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(94, 29);
            this.btn_last.TabIndex = 23;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(257, 272);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 29);
            this.btn_add.TabIndex = 24;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(412, 237);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(94, 29);
            this.btn_next.TabIndex = 25;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(310, 237);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(94, 29);
            this.btn_prev.TabIndex = 26;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(210, 237);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(94, 29);
            this.btn_first.TabIndex = 27;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // Ugovori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_ugovor);
            this.Controls.Add(this.txt_osoba);
            this.Controls.Add(this.dateTime_datum);
            this.Name = "Ugovori";
            this.Text = "Ugovori";
            this.Load += new System.EventHandler(this.Ugovori_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTime_datum;
        private System.Windows.Forms.TextBox txt_osoba;
        private System.Windows.Forms.ComboBox cmb_ugovor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_first;
    }
}