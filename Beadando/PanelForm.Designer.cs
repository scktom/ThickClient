﻿
namespace Beadando
{
    partial class PanelForm
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
            this.tabla = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.numericUpDownID = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Location = new System.Drawing.Point(13, 13);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.Size = new System.Drawing.Size(1404, 323);
            this.tabla.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(139, 342);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Hozzáadás";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Lista
            // 
            this.Lista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Lista.FormattingEnabled = true;
            this.Lista.Items.AddRange(new object[] {
            "Országok",
            "Települések",
            "Ügyfelek",
            "Tarifacsomagok",
            "Előfizetések"});
            this.Lista.Location = new System.Drawing.Point(12, 342);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(121, 21);
            this.Lista.TabIndex = 2;
            this.Lista.SelectedValueChanged += new System.EventHandler(this.Lista_SelectedValueChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(221, 343);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Szerkesztés";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(302, 343);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Törlés";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // numericUpDownID
            // 
            this.numericUpDownID.Location = new System.Drawing.Point(383, 346);
            this.numericUpDownID.Name = "numericUpDownID";
            this.numericUpDownID.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // PanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownID);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.tabla);
            this.Name = "PanelForm";
            this.Text = "PanelForm";
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox Lista;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.NumericUpDown numericUpDownID;
        private System.Windows.Forms.Label label1;
    }
}