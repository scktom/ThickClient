
namespace Beadando
{
    partial class TelepulesekSzerkesztForm
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
            this.numericUpDownIr = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxOrszag = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxKozpont = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // comboBoxId
            // 
            this.comboBoxId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxId.FormattingEnabled = true;
            this.comboBoxId.Location = new System.Drawing.Point(87, 12);
            this.comboBoxId.Name = "comboBoxId";
            this.comboBoxId.Size = new System.Drawing.Size(76, 21);
            this.comboBoxId.TabIndex = 1;
            this.comboBoxId.SelectedValueChanged += new System.EventHandler(this.comboBoxId_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Irányítószám:";
            // 
            // numericUpDownIr
            // 
            this.numericUpDownIr.Enabled = false;
            this.numericUpDownIr.Location = new System.Drawing.Point(88, 52);
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
            this.numericUpDownIr.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownIr.TabIndex = 3;
            this.numericUpDownIr.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Település:";
            // 
            // textBoxNev
            // 
            this.textBoxNev.Enabled = false;
            this.textBoxNev.Location = new System.Drawing.Point(87, 91);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(121, 20);
            this.textBoxNev.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ország:";
            // 
            // comboBoxOrszag
            // 
            this.comboBoxOrszag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrszag.FormattingEnabled = true;
            this.comboBoxOrszag.Location = new System.Drawing.Point(87, 129);
            this.comboBoxOrszag.Name = "comboBoxOrszag";
            this.comboBoxOrszag.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrszag.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Központ:";
            // 
            // comboBoxKozpont
            // 
            this.comboBoxKozpont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKozpont.FormattingEnabled = true;
            this.comboBoxKozpont.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBoxKozpont.Location = new System.Drawing.Point(87, 168);
            this.comboBoxKozpont.Name = "comboBoxKozpont";
            this.comboBoxKozpont.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKozpont.TabIndex = 9;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(88, 214);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Szerkesztés";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // TelepulesekSzerkesztForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboBoxKozpont);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxOrszag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownIr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxId);
            this.Controls.Add(this.label1);
            this.Name = "TelepulesekSzerkesztForm";
            this.Text = "TelepulesekSzerkesztForm";
            this.Load += new System.EventHandler(this.TelepulesekSzerkesztForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownIr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxOrszag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxKozpont;
        private System.Windows.Forms.Button buttonUpdate;
    }
}