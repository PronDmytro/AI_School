namespace AI_School
{
    partial class Form_TeachersDlg
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
            this.button_action = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.textBox_nameTch = new System.Windows.Forms.TextBox();
            this.textBox_expTch = new System.Windows.Forms.TextBox();
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
            this.label_productNameId.Size = new System.Drawing.Size(68, 13);
            this.label_productNameId.TabIndex = 7;
            this.label_productNameId.Text = "ПІБ вчителя";
            // 
            // label_drugstoreAddress
            // 
            this.label_drugstoreAddress.AutoSize = true;
            this.label_drugstoreAddress.Location = new System.Drawing.Point(119, 74);
            this.label_drugstoreAddress.Name = "label_drugstoreAddress";
            this.label_drugstoreAddress.Size = new System.Drawing.Size(33, 13);
            this.label_drugstoreAddress.TabIndex = 8;
            this.label_drugstoreAddress.Text = "Стаж";
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
            // textBox_nameTch
            // 
            this.textBox_nameTch.Location = new System.Drawing.Point(169, 41);
            this.textBox_nameTch.Name = "textBox_nameTch";
            this.textBox_nameTch.Size = new System.Drawing.Size(160, 20);
            this.textBox_nameTch.TabIndex = 1;
            // 
            // textBox_expTch
            // 
            this.textBox_expTch.Location = new System.Drawing.Point(169, 67);
            this.textBox_expTch.Name = "textBox_expTch";
            this.textBox_expTch.Size = new System.Drawing.Size(160, 20);
            this.textBox_expTch.TabIndex = 2;
            // 
            // Form_TeachersDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 198);
            this.Controls.Add(this.textBox_nameTch);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_action);
            this.Controls.Add(this.textBox_expTch);
            this.Controls.Add(this.label_drugstoreAddress);
            this.Controls.Add(this.label_productNameId);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.textBox_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_TeachersDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_DrugstoreDlg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_productNameId;
        private System.Windows.Forms.Label label_drugstoreAddress;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.TextBox textBox_nameTch;
        private System.Windows.Forms.TextBox textBox_expTch;
        public System.Windows.Forms.Button button_action;
    }
}