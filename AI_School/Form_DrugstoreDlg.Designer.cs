namespace NAUM_APTEKA_2021
{
    partial class Form_DrugstoreDlg
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
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_productNameId = new System.Windows.Forms.Label();
            this.label_drugstoreAddress = new System.Windows.Forms.Label();
            this.dateTimePicker_regDt = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_modDt = new System.Windows.Forms.DateTimePicker();
            this.label_regDt = new System.Windows.Forms.Label();
            this.label_modDt = new System.Windows.Forms.Label();
            this.button_action = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.textBox_nameDrugstore = new System.Windows.Forms.TextBox();
            this.textBox_addressDrugstore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(141, 21);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(22, 13);
            this.label_id.TabIndex = 5;
            this.label_id.Text = "id#";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(169, 14);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(160, 20);
            this.textBox_id.TabIndex = 7;
            this.textBox_id.TabStop = false;
            // 
            // label_productNameId
            // 
            this.label_productNameId.AutoSize = true;
            this.label_productNameId.Location = new System.Drawing.Point(86, 48);
            this.label_productNameId.Name = "label_productNameId";
            this.label_productNameId.Size = new System.Drawing.Size(77, 13);
            this.label_productNameId.TabIndex = 7;
            this.label_productNameId.Text = "Назва аптеки";
            // 
            // label_drugstoreAddress
            // 
            this.label_drugstoreAddress.AutoSize = true;
            this.label_drugstoreAddress.Location = new System.Drawing.Point(119, 74);
            this.label_drugstoreAddress.Name = "label_drugstoreAddress";
            this.label_drugstoreAddress.Size = new System.Drawing.Size(44, 13);
            this.label_drugstoreAddress.TabIndex = 8;
            this.label_drugstoreAddress.Text = "Адреса";
            // 
            // dateTimePicker_regDt
            // 
            this.dateTimePicker_regDt.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dateTimePicker_regDt.Enabled = false;
            this.dateTimePicker_regDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_regDt.Location = new System.Drawing.Point(169, 92);
            this.dateTimePicker_regDt.Name = "dateTimePicker_regDt";
            this.dateTimePicker_regDt.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker_regDt.TabIndex = 3;
            // 
            // dateTimePicker_modDt
            // 
            this.dateTimePicker_modDt.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dateTimePicker_modDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_modDt.Location = new System.Drawing.Point(169, 118);
            this.dateTimePicker_modDt.Name = "dateTimePicker_modDt";
            this.dateTimePicker_modDt.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker_modDt.TabIndex = 4;
            // 
            // label_regDt
            // 
            this.label_regDt.AutoSize = true;
            this.label_regDt.Location = new System.Drawing.Point(23, 99);
            this.label_regDt.Name = "label_regDt";
            this.label_regDt.Size = new System.Drawing.Size(140, 13);
            this.label_regDt.TabIndex = 12;
            this.label_regDt.Text = "Дата першого постачання";
            // 
            // label_modDt
            // 
            this.label_modDt.AutoSize = true;
            this.label_modDt.Location = new System.Drawing.Point(8, 125);
            this.label_modDt.Name = "label_modDt";
            this.label_modDt.Size = new System.Drawing.Size(155, 13);
            this.label_modDt.TabIndex = 13;
            this.label_modDt.Text = "Дата останнього постачання";
            // 
            // button_action
            // 
            this.button_action.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_action.Location = new System.Drawing.Point(206, 149);
            this.button_action.Name = "button_action";
            this.button_action.Size = new System.Drawing.Size(123, 37);
            this.button_action.TabIndex = 5;
            this.button_action.Text = "Додати";
            this.button_action.UseVisualStyleBackColor = true;
            this.button_action.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_close
            // 
            this.button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_close.Location = new System.Drawing.Point(12, 149);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(123, 37);
            this.button_close.TabIndex = 6;
            this.button_close.Text = "Відміна";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // textBox_nameDrugstore
            // 
            this.textBox_nameDrugstore.Location = new System.Drawing.Point(169, 41);
            this.textBox_nameDrugstore.Name = "textBox_nameDrugstore";
            this.textBox_nameDrugstore.Size = new System.Drawing.Size(160, 20);
            this.textBox_nameDrugstore.TabIndex = 1;
            // 
            // textBox_addressDrugstore
            // 
            this.textBox_addressDrugstore.Location = new System.Drawing.Point(169, 67);
            this.textBox_addressDrugstore.Name = "textBox_addressDrugstore";
            this.textBox_addressDrugstore.Size = new System.Drawing.Size(160, 20);
            this.textBox_addressDrugstore.TabIndex = 2;
            // 
            // Form_DrugstoreDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 198);
            this.Controls.Add(this.textBox_nameDrugstore);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_action);
            this.Controls.Add(this.label_modDt);
            this.Controls.Add(this.label_regDt);
            this.Controls.Add(this.dateTimePicker_modDt);
            this.Controls.Add(this.dateTimePicker_regDt);
            this.Controls.Add(this.textBox_addressDrugstore);
            this.Controls.Add(this.label_drugstoreAddress);
            this.Controls.Add(this.label_productNameId);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.textBox_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_DrugstoreDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_DrugstoreDlg";
            this.Load += new System.EventHandler(this.Form_DrugstoreDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_productNameId;
        private System.Windows.Forms.Label label_drugstoreAddress;
        private System.Windows.Forms.DateTimePicker dateTimePicker_regDt;
        private System.Windows.Forms.DateTimePicker dateTimePicker_modDt;
        private System.Windows.Forms.Label label_regDt;
        private System.Windows.Forms.Label label_modDt;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.TextBox textBox_nameDrugstore;
        private System.Windows.Forms.TextBox textBox_addressDrugstore;
        public System.Windows.Forms.Button button_action;
    }
}