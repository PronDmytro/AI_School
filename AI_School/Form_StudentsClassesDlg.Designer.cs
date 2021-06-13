namespace AI_School
{
    partial class Form_StudentsClassesDlg
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
            this.button_close = new System.Windows.Forms.Button();
            this.button_action = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_productName = new System.Windows.Forms.Label();
            this.textBox_className = new System.Windows.Forms.TextBox();
            this.label_itemsName = new System.Windows.Forms.Label();
            this.textBox_studentsCount = new System.Windows.Forms.TextBox();
            this.label_cost = new System.Windows.Forms.Label();
            this.textBox_classTeacher = new System.Windows.Forms.TextBox();
            this.label_comment = new System.Windows.Forms.Label();
            this.textBox_comment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(12, 148);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(97, 40);
            this.button_close.TabIndex = 0;
            this.button_close.Text = "Закрити";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_action
            // 
            this.button_action.Location = new System.Drawing.Point(539, 148);
            this.button_action.Name = "button_action";
            this.button_action.Size = new System.Drawing.Size(97, 40);
            this.button_action.TabIndex = 1;
            this.button_action.Text = "Внести зміни";
            this.button_action.UseVisualStyleBackColor = true;
            this.button_action.Click += new System.EventHandler(this.button_action_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(125, 12);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(511, 20);
            this.textBox_id.TabIndex = 2;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(97, 15);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(22, 13);
            this.label_id.TabIndex = 3;
            this.label_id.Text = "id#";
            // 
            // label_productName
            // 
            this.label_productName.AutoSize = true;
            this.label_productName.Location = new System.Drawing.Point(38, 45);
            this.label_productName.Name = "label_productName";
            this.label_productName.Size = new System.Drawing.Size(71, 13);
            this.label_productName.TabIndex = 5;
            this.label_productName.Text = "Назва класу";
            // 
            // textBox_className
            // 
            this.textBox_className.Location = new System.Drawing.Point(125, 38);
            this.textBox_className.Name = "textBox_className";
            this.textBox_className.Size = new System.Drawing.Size(511, 20);
            this.textBox_className.TabIndex = 4;
            // 
            // label_itemsName
            // 
            this.label_itemsName.AutoSize = true;
            this.label_itemsName.Location = new System.Drawing.Point(29, 71);
            this.label_itemsName.Name = "label_itemsName";
            this.label_itemsName.Size = new System.Drawing.Size(80, 13);
            this.label_itemsName.TabIndex = 6;
            this.label_itemsName.Text = "Кількість учнів";
            // 
            // textBox_studentsCount
            // 
            this.textBox_studentsCount.Location = new System.Drawing.Point(125, 64);
            this.textBox_studentsCount.Name = "textBox_studentsCount";
            this.textBox_studentsCount.Size = new System.Drawing.Size(511, 20);
            this.textBox_studentsCount.TabIndex = 7;
            // 
            // label_cost
            // 
            this.label_cost.AutoSize = true;
            this.label_cost.Location = new System.Drawing.Point(22, 97);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(97, 13);
            this.label_cost.TabIndex = 8;
            this.label_cost.Text = "Класний керівник";
            // 
            // textBox_classTeacher
            // 
            this.textBox_classTeacher.Location = new System.Drawing.Point(125, 90);
            this.textBox_classTeacher.Name = "textBox_classTeacher";
            this.textBox_classTeacher.Size = new System.Drawing.Size(511, 20);
            this.textBox_classTeacher.TabIndex = 9;
            // 
            // label_comment
            // 
            this.label_comment.AutoSize = true;
            this.label_comment.Location = new System.Drawing.Point(65, 123);
            this.label_comment.Name = "label_comment";
            this.label_comment.Size = new System.Drawing.Size(54, 13);
            this.label_comment.TabIndex = 10;
            this.label_comment.Text = "Примітка";
            // 
            // textBox_comment
            // 
            this.textBox_comment.Location = new System.Drawing.Point(125, 116);
            this.textBox_comment.Name = "textBox_comment";
            this.textBox_comment.Size = new System.Drawing.Size(511, 20);
            this.textBox_comment.TabIndex = 11;
            // 
            // Form_StudentsClassesDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 202);
            this.Controls.Add(this.textBox_comment);
            this.Controls.Add(this.label_comment);
            this.Controls.Add(this.textBox_classTeacher);
            this.Controls.Add(this.label_cost);
            this.Controls.Add(this.textBox_studentsCount);
            this.Controls.Add(this.label_itemsName);
            this.Controls.Add(this.label_productName);
            this.Controls.Add(this.textBox_className);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.button_action);
            this.Controls.Add(this.button_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_StudentsClassesDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ProductDlg";
            this.Load += new System.EventHandler(this.Form_ProductDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_productName;
        private System.Windows.Forms.TextBox textBox_className;
        private System.Windows.Forms.Label label_itemsName;
        private System.Windows.Forms.TextBox textBox_studentsCount;
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.TextBox textBox_classTeacher;
        private System.Windows.Forms.Label label_comment;
        private System.Windows.Forms.TextBox textBox_comment;
        public System.Windows.Forms.Button button_action;
    }
}