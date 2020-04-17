namespace XMLGUI.Forms
{
    partial class FilterProperties
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
            this.paramTxtBox = new System.Windows.Forms.TextBox();
            this.btnProvider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDateOfOrder = new System.Windows.Forms.Button();
            this.btnAge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paramTxtBox
            // 
            this.paramTxtBox.Location = new System.Drawing.Point(15, 49);
            this.paramTxtBox.Name = "paramTxtBox";
            this.paramTxtBox.Size = new System.Drawing.Size(373, 22);
            this.paramTxtBox.TabIndex = 0;
            // 
            // btnProvider
            // 
            this.btnProvider.Location = new System.Drawing.Point(148, 88);
            this.btnProvider.Name = "btnProvider";
            this.btnProvider.Size = new System.Drawing.Size(117, 51);
            this.btnProvider.TabIndex = 1;
            this.btnProvider.Text = "Поставщик";
            this.btnProvider.UseVisualStyleBackColor = true;
            this.btnProvider.Click += new System.EventHandler(this.OnBtnApplyClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск элементов по:";
            // 
            // btnDateOfOrder
            // 
            this.btnDateOfOrder.Location = new System.Drawing.Point(15, 88);
            this.btnDateOfOrder.Name = "btnDateOfOrder";
            this.btnDateOfOrder.Size = new System.Drawing.Size(127, 51);
            this.btnDateOfOrder.TabIndex = 3;
            this.btnDateOfOrder.Text = "Дата поступления";
            this.btnDateOfOrder.UseVisualStyleBackColor = true;
            this.btnDateOfOrder.Click += new System.EventHandler(this.dataoforder_Click);
            // 
            // btnAge
            // 
            this.btnAge.Location = new System.Drawing.Point(271, 88);
            this.btnAge.Name = "btnAge";
            this.btnAge.Size = new System.Drawing.Size(117, 51);
            this.btnAge.TabIndex = 4;
            this.btnAge.Text = "Возраст";
            this.btnAge.UseVisualStyleBackColor = true;
            this.btnAge.Click += new System.EventHandler(this.btnAge_Click);
            // 
            // FilterProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 159);
            this.Controls.Add(this.btnAge);
            this.Controls.Add(this.btnDateOfOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProvider);
            this.Controls.Add(this.paramTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FilterProperties";
            this.Text = "Filter properties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox paramTxtBox;
        private System.Windows.Forms.Button btnProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDateOfOrder;
        private System.Windows.Forms.Button btnAge;
    }
}