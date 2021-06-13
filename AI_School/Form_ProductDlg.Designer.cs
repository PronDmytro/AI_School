namespace NAUM_APTEKA_2021
{
    partial class Form_ProductDlg
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
            this.textBox_productName = new System.Windows.Forms.TextBox();
            this.label_itemsName = new System.Windows.Forms.Label();
            this.textBox_itemsCount = new System.Windows.Forms.TextBox();
            this.label_cost = new System.Windows.Forms.Label();
            this.textBox_cost = new System.Windows.Forms.TextBox();
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
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox_id_TextChanged);
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
            this.label_productName.Location = new System.Drawing.Point(32, 41);
            this.label_productName.Name = "label_productName";
            this.label_productName.Size = new System.Drawing.Size(87, 13);
            this.label_productName.TabIndex = 5;
            this.label_productName.Text = "Назва продукту";
            // 
            // textBox_productName
            // 
            this.textBox_productName.Location = new System.Drawing.Point(125, 38);
            this.textBox_productName.Name = "textBox_productName";
            this.textBox_productName.Size = new System.Drawing.Size(511, 20);
            this.textBox_productName.TabIndex = 4;
            // 
            // label_itemsName
            // 
            this.label_itemsName.AutoSize = true;
            this.label_itemsName.Location = new System.Drawing.Point(18, 67);
            this.label_itemsName.Name = "label_itemsName";
            this.label_itemsName.Size = new System.Drawing.Size(101, 13);
            this.label_itemsName.TabIndex = 6;
            this.label_itemsName.Text = "Кількість продукту";
            // 
            // textBox_itemsCount
            // 
            this.textBox_itemsCount.Location = new System.Drawing.Point(125, 64);
            this.textBox_itemsCount.Name = "textBox_itemsCount";
            this.textBox_itemsCount.Size = new System.Drawing.Size(511, 20);
            this.textBox_itemsCount.TabIndex = 7;
            // 
            // label_cost
            // 
            this.label_cost.AutoSize = true;
            this.label_cost.Location = new System.Drawing.Point(42, 93);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(77, 13);
            this.label_cost.TabIndex = 8;
            this.label_cost.Text = "Ціна продукту";
            this.label_cost.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_cost
            // 
            this.textBox_cost.Location = new System.Drawing.Point(125, 90);
            this.textBox_cost.Name = "textBox_cost";
            this.textBox_cost.Size = new System.Drawing.Size(511, 20);
            this.textBox_cost.TabIndex = 9;
            // 
            // label_comment
            // 
            this.label_comment.AutoSize = true;
            this.label_comment.Location = new System.Drawing.Point(65, 119);
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
            // Form_ProductDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 202);
            this.Controls.Add(this.textBox_comment);
            this.Controls.Add(this.label_comment);
            this.Controls.Add(this.textBox_cost);
            this.Controls.Add(this.label_cost);
            this.Controls.Add(this.textBox_itemsCount);
            this.Controls.Add(this.label_itemsName);
            this.Controls.Add(this.label_productName);
            this.Controls.Add(this.textBox_productName);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.button_action);
            this.Controls.Add(this.button_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_ProductDlg";
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
        private System.Windows.Forms.TextBox textBox_productName;
        private System.Windows.Forms.Label label_itemsName;
        private System.Windows.Forms.TextBox textBox_itemsCount;
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.TextBox textBox_cost;
        private System.Windows.Forms.Label label_comment;
        private System.Windows.Forms.TextBox textBox_comment;
        public System.Windows.Forms.Button button_action;
    }
}