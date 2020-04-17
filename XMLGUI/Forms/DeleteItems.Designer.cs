namespace XMLGUI.Forms
{
    partial class DeleteItems
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
            this.btnId = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.paramTxtBox = new System.Windows.Forms.TextBox();
            this.btnDateOfOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Удаление записей";
            // 
            // btnId
            // 
            this.btnId.Location = new System.Drawing.Point(26, 91);
            this.btnId.Name = "btnId";
            this.btnId.Size = new System.Drawing.Size(122, 81);
            this.btnId.TabIndex = 1;
            this.btnId.Text = "Код";
            this.btnId.UseVisualStyleBackColor = true;
            this.btnId.Click += new System.EventHandler(this.btnId_Click);
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(154, 91);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(97, 81);
            this.btnName.TabIndex = 2;
            this.btnName.Text = "Название";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // paramTxtBox
            // 
            this.paramTxtBox.Location = new System.Drawing.Point(37, 51);
            this.paramTxtBox.Name = "paramTxtBox";
            this.paramTxtBox.Size = new System.Drawing.Size(328, 22);
            this.paramTxtBox.TabIndex = 3;
            // 
            // btnDateOfOrder
            // 
            this.btnDateOfOrder.Location = new System.Drawing.Point(257, 91);
            this.btnDateOfOrder.Name = "btnDateOfOrder";
            this.btnDateOfOrder.Size = new System.Drawing.Size(120, 81);
            this.btnDateOfOrder.TabIndex = 4;
            this.btnDateOfOrder.Text = "Дата поступления в магазин";
            this.btnDateOfOrder.UseVisualStyleBackColor = true;
            this.btnDateOfOrder.Click += new System.EventHandler(this.btnDateOfOrder_Click);
            // 
            // DeleteItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 206);
            this.Controls.Add(this.btnDateOfOrder);
            this.Controls.Add(this.paramTxtBox);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.btnId);
            this.Controls.Add(this.label1);
            this.Name = "DeleteItems";
            this.Text = "DeleteItems";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnId;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.TextBox paramTxtBox;
        private System.Windows.Forms.Button btnDateOfOrder;
    }
}