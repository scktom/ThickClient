
namespace Beadando
{
    partial class TelepulesekAddForm
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
            this.numericUpDownIr = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxKozpont = new System.Windows.Forms.ComboBox();
            this.comboBoxOrszag = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Irányítószám:";
            // 
            // numericUpDownIr
            // 
            this.numericUpDownIr.Location = new System.Drawing.Point(126, 13);
            this.numericUpDownIr.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownIr.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownIr.Name = "numericUpDownIr";
            this.numericUpDownIr.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownIr.TabIndex = 1;
            this.numericUpDownIr.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Település:";
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(126, 59);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(100, 20);
            this.textBoxNev.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ország:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Központ:";
            // 
            // comboBoxKozpont
            // 
            this.comboBoxKozpont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKozpont.FormattingEnabled = true;
            this.comboBoxKozpont.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBoxKozpont.Location = new System.Drawing.Point(126, 144);
            this.comboBoxKozpont.Name = "comboBoxKozpont";
            this.comboBoxKozpont.Size = new System.Drawing.Size(71, 21);
            this.comboBoxKozpont.TabIndex = 7;
            // 
            // comboBoxOrszag
            // 
            this.comboBoxOrszag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrszag.FormattingEnabled = true;
            this.comboBoxOrszag.Location = new System.Drawing.Point(126, 103);
            this.comboBoxOrszag.Name = "comboBoxOrszag";
            this.comboBoxOrszag.Size = new System.Drawing.Size(100, 21);
            this.comboBoxOrszag.TabIndex = 8;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(91, 184);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Hozzáadás";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // TelepulesekAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 258);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxOrszag);
            this.Controls.Add(this.comboBoxKozpont);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownIr);
            this.Controls.Add(this.label1);
            this.Name = "TelepulesekAddForm";
            this.Text = "TelepulesekAddForm";
            this.Load += new System.EventHandler(this.TelepulesekAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownIr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxKozpont;
        private System.Windows.Forms.ComboBox comboBoxOrszag;
        private System.Windows.Forms.Button buttonAdd;
    }
}