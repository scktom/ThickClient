
namespace Beadando
{
    partial class ElofizetesAddForm
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
            this.comboBoxNev = new System.Windows.Forms.ComboBox();
            this.comboBoxTarifa = new System.Windows.Forms.ComboBox();
            this.dateTimePickerKot = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerLemond = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ügyfél:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarifacsomag:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Szerződés megkötése:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Szerződés lemondása:";
            // 
            // comboBoxNev
            // 
            this.comboBoxNev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNev.FormattingEnabled = true;
            this.comboBoxNev.Location = new System.Drawing.Point(166, 12);
            this.comboBoxNev.Name = "comboBoxNev";
            this.comboBoxNev.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNev.TabIndex = 4;
            // 
            // comboBoxTarifa
            // 
            this.comboBoxTarifa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTarifa.FormattingEnabled = true;
            this.comboBoxTarifa.Location = new System.Drawing.Point(166, 41);
            this.comboBoxTarifa.Name = "comboBoxTarifa";
            this.comboBoxTarifa.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTarifa.TabIndex = 5;
            // 
            // dateTimePickerKot
            // 
            this.dateTimePickerKot.Location = new System.Drawing.Point(166, 79);
            this.dateTimePickerKot.Name = "dateTimePickerKot";
            this.dateTimePickerKot.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerKot.TabIndex = 6;
            // 
            // dateTimePickerLemond
            // 
            this.dateTimePickerLemond.Location = new System.Drawing.Point(166, 111);
            this.dateTimePickerLemond.Name = "dateTimePickerLemond";
            this.dateTimePickerLemond.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerLemond.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(212, 142);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Hozzáadás";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // ElofizetesAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 202);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dateTimePickerLemond);
            this.Controls.Add(this.dateTimePickerKot);
            this.Controls.Add(this.comboBoxTarifa);
            this.Controls.Add(this.comboBoxNev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ElofizetesAddForm";
            this.Text = "ElofizetesAddForm";
            this.Load += new System.EventHandler(this.ElofizetesAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxNev;
        private System.Windows.Forms.ComboBox comboBoxTarifa;
        private System.Windows.Forms.DateTimePicker dateTimePickerKot;
        private System.Windows.Forms.DateTimePicker dateTimePickerLemond;
        private System.Windows.Forms.Button buttonAdd;
    }
}