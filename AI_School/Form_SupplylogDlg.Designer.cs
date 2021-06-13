namespace AI_School
{
    partial class Form_SupplylogDlg
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
            this.comboBox_teacherId = new System.Windows.Forms.ComboBox();
            this.comboBox_studetsclassesId = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_dtsupply = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_subject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_count = new System.Windows.Forms.TextBox();
            this.label_number = new System.Windows.Forms.Label();
            this.label_itemsName = new System.Windows.Forms.Label();
            this.label_productName = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.button_action = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_teacherId
            // 
            this.comboBox_teacherId.FormattingEnabled = true;
            this.comboBox_teacherId.Location = new System.Drawing.Point(183, 41);
            this.comboBox_teacherId.Name = "comboBox_teacherId";
            this.comboBox_teacherId.Size = new System.Drawing.Size(232, 21);
            this.comboBox_teacherId.TabIndex = 69;
            // 
            // comboBox_studetsclassesId
            // 
            this.comboBox_studetsclassesId.FormattingEnabled = true;
            this.comboBox_studetsclassesId.Location = new System.Drawing.Point(183, 68);
            this.comboBox_studetsclassesId.Name = "comboBox_studetsclassesId";
            this.comboBox_studetsclassesId.Size = new System.Drawing.Size(232, 21);
            this.comboBox_studetsclassesId.TabIndex = 68;
            // 
            // dateTimePicker_dtsupply
            // 
            this.dateTimePicker_dtsupply.CustomFormat = "dd.MM.yyyy ";
            this.dateTimePicker_dtsupply.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_dtsupply.Location = new System.Drawing.Point(183, 123);
            this.dateTimePicker_dtsupply.Name = "dateTimePicker_dtsupply";
            this.dateTimePicker_dtsupply.Size = new System.Drawing.Size(232, 20);
            this.dateTimePicker_dtsupply.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Дата проведення";
            // 
            // textBox_subject
            // 
            this.textBox_subject.Location = new System.Drawing.Point(183, 150);
            this.textBox_subject.Name = "textBox_subject";
            this.textBox_subject.Size = new System.Drawing.Size(232, 20);
            this.textBox_subject.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Предмет";
            // 
            // textBox_count
            // 
            this.textBox_count.Location = new System.Drawing.Point(183, 96);
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.Size = new System.Drawing.Size(232, 20);
            this.textBox_count.TabIndex = 55;
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Location = new System.Drawing.Point(107, 103);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(72, 13);
            this.label_number.TabIndex = 54;
            this.label_number.Text = "Номер уроку";
            // 
            // label_itemsName
            // 
            this.label_itemsName.AutoSize = true;
            this.label_itemsName.Location = new System.Drawing.Point(125, 76);
            this.label_itemsName.Name = "label_itemsName";
            this.label_itemsName.Size = new System.Drawing.Size(32, 13);
            this.label_itemsName.TabIndex = 53;
            this.label_itemsName.Text = "Клас";
            // 
            // label_productName
            // 
            this.label_productName.AutoSize = true;
            this.label_productName.Location = new System.Drawing.Point(131, 49);
            this.label_productName.Name = "label_productName";
            this.label_productName.Size = new System.Drawing.Size(48, 13);
            this.label_productName.TabIndex = 52;
            this.label_productName.Text = "Вчитель";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(155, 15);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(22, 13);
            this.label_id.TabIndex = 51;
            this.label_id.Text = "id#";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(183, 12);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(232, 20);
            this.textBox_id.TabIndex = 50;
            // 
            // button_action
            // 
            this.button_action.Location = new System.Drawing.Point(318, 205);
            this.button_action.Name = "button_action";
            this.button_action.Size = new System.Drawing.Size(97, 40);
            this.button_action.TabIndex = 49;
            this.button_action.Text = "Внести зміни";
            this.button_action.UseVisualStyleBackColor = true;
            this.button_action.Click += new System.EventHandler(this.button_action_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(12, 205);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(97, 40);
            this.button_close.TabIndex = 48;
            this.button_close.Text = "Закрити";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // Form_SupplylogDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 251);
            this.Controls.Add(this.comboBox_teacherId);
            this.Controls.Add(this.comboBox_studetsclassesId);
            this.Controls.Add(this.dateTimePicker_dtsupply);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_subject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_count);
            this.Controls.Add(this.label_number);
            this.Controls.Add(this.label_itemsName);
            this.Controls.Add(this.label_productName);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.button_action);
            this.Controls.Add(this.button_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_SupplylogDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_SupplylogDlg";
            this.Load += new System.EventHandler(this.Form_SupplylogDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_teacherId;
        private System.Windows.Forms.ComboBox comboBox_studetsclassesId;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dtsupply;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_subject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_count;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.Label label_itemsName;
        private System.Windows.Forms.Label label_productName;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_id;
        public System.Windows.Forms.Button button_action;
        private System.Windows.Forms.Button button_close;
    }
}