
namespace Beadando
{
    partial class UgyfelSzerkesztForm
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
            this.comboBoxId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSzhely = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxLakhely = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCim = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // comboBoxId
            // 
            this.comboBoxId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxId.FormattingEnabled = true;
            this.comboBoxId.Location = new System.Drawing.Point(113, 10);
            this.comboBoxId.Name = "comboBoxId";
            this.comboBoxId.Size = new System.Drawing.Size(121, 21);
            this.comboBoxId.TabIndex = 1;
            this.comboBoxId.SelectedValueChanged += new System.EventHandler(this.comboBoxId_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név:";
            // 
            // textBoxNev
            // 
            this.textBoxNev.Enabled = false;
            this.textBoxNev.Location = new System.Drawing.Point(113, 37);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(121, 20);
            this.textBoxNev.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Születési hely:";
            // 
            // comboBoxSzhely
            // 
            this.comboBoxSzhely.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSzhely.FormattingEnabled = true;
            this.comboBoxSzhely.Location = new System.Drawing.Point(113, 63);
            this.comboBoxSzhely.Name = "comboBoxSzhely";
            this.comboBoxSzhely.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSzhely.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Születési idő:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lakhely:";
            // 
            // comboBoxLakhely
            // 
            this.comboBoxLakhely.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLakhely.FormattingEnabled = true;
            this.comboBoxLakhely.Location = new System.Drawing.Point(113, 120);
            this.comboBoxLakhely.Name = "comboBoxLakhely";
            this.comboBoxLakhely.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLakhely.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cím:";
            // 
            // textBoxCim
            // 
            this.textBoxCim.Enabled = false;
            this.textBoxCim.Location = new System.Drawing.Point(113, 147);
            this.textBoxCim.Name = "textBoxCim";
            this.textBoxCim.Size = new System.Drawing.Size(121, 20);
            this.textBoxCim.TabIndex = 11;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(130, 173);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Szerkesztés";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // UgyfelSzerkesztForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 259);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxCim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxLakhely);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSzhely);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxId);
            this.Controls.Add(this.label1);
            this.Name = "UgyfelSzerkesztForm";
            this.Text = "UgyfelSzerkesztForm";
            this.Load += new System.EventHandler(this.UgyfelSzerkesztForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSzhely;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxLakhely;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCim;
        private System.Windows.Forms.Button buttonUpdate;
    }
}