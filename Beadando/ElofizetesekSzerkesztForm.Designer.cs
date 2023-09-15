
namespace Beadando
{
    partial class ElofizetesekSzerkesztForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxId = new System.Windows.Forms.ComboBox();
            this.comboBoxNev = new System.Windows.Forms.ComboBox();
            this.comboBoxCsomag = new System.Windows.Forms.ComboBox();
            this.dateTimePickerKot = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerLemond = new System.Windows.Forms.DateTimePicker();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ügyfél:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarifacsomag:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Szerődés megkötése:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Szerződés Lemondása:";
            // 
            // comboBoxId
            // 
            this.comboBoxId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxId.FormattingEnabled = true;
            this.comboBoxId.Location = new System.Drawing.Point(135, 116);
            this.comboBoxId.Name = "comboBoxId";
            this.comboBoxId.Size = new System.Drawing.Size(121, 21);
            this.comboBoxId.TabIndex = 5;
            this.comboBoxId.SelectedValueChanged += new System.EventHandler(this.comboBoxId_SelectedValueChanged);
            // 
            // comboBoxNev
            // 
            this.comboBoxNev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNev.FormattingEnabled = true;
            this.comboBoxNev.Location = new System.Drawing.Point(135, 152);
            this.comboBoxNev.Name = "comboBoxNev";
            this.comboBoxNev.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNev.TabIndex = 6;
            // 
            // comboBoxCsomag
            // 
            this.comboBoxCsomag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCsomag.FormattingEnabled = true;
            this.comboBoxCsomag.Location = new System.Drawing.Point(135, 199);
            this.comboBoxCsomag.Name = "comboBoxCsomag";
            this.comboBoxCsomag.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCsomag.TabIndex = 7;
            // 
            // dateTimePickerKot
            // 
            this.dateTimePickerKot.Location = new System.Drawing.Point(135, 250);
            this.dateTimePickerKot.Name = "dateTimePickerKot";
            this.dateTimePickerKot.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerKot.TabIndex = 8;
            // 
            // dateTimePickerLemond
            // 
            this.dateTimePickerLemond.Location = new System.Drawing.Point(135, 288);
            this.dateTimePickerLemond.Name = "dateTimePickerLemond";
            this.dateTimePickerLemond.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerLemond.TabIndex = 9;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(153, 327);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Szerkesztés";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // ElofizetesekSzerkesztForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 459);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dateTimePickerLemond);
            this.Controls.Add(this.dateTimePickerKot);
            this.Controls.Add(this.comboBoxCsomag);
            this.Controls.Add(this.comboBoxNev);
            this.Controls.Add(this.comboBoxId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ElofizetesekSzerkesztForm";
            this.Text = "ElofizetesekSzerkesztForm";
            this.Load += new System.EventHandler(this.ElofizetesekSzerkesztForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxId;
        private System.Windows.Forms.ComboBox comboBoxNev;
        private System.Windows.Forms.ComboBox comboBoxCsomag;
        private System.Windows.Forms.DateTimePicker dateTimePickerKot;
        private System.Windows.Forms.DateTimePicker dateTimePickerLemond;
        private System.Windows.Forms.Button buttonUpdate;
    }
}