using System;

namespace MegaDesk
{
    partial class AddQuote
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
            this.nameField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.materialString = new System.Windows.Forms.ComboBox();
            this.rushString = new System.Windows.Forms.ComboBox();
            this.drawersString = new System.Windows.Forms.ComboBox();
            this.widthNum = new System.Windows.Forms.NumericUpDown();
            this.depthNum = new System.Windows.Forms.NumericUpDown();
            this.Submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.widthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Full Name";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(263, 51);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(186, 20);
            this.nameField.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width ( 24 - 96 )";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Depth ( 12 - 48 )";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Number of Drawers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Surface Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(163, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Rush Order";
            // 
            // materialString
            // 
            this.materialString.FormattingEnabled = true;
            this.materialString.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.materialString.Location = new System.Drawing.Point(263, 221);
            this.materialString.MaxDropDownItems = 5;
            this.materialString.Name = "materialString";
            this.materialString.Size = new System.Drawing.Size(186, 21);
            this.materialString.TabIndex = 7;
            // 
            // rushString
            // 
            this.rushString.FormattingEnabled = true;
            this.rushString.Items.AddRange(new object[] {
            "0",
            "3",
            "5",
            "7"});
            this.rushString.Location = new System.Drawing.Point(263, 263);
            this.rushString.MaxDropDownItems = 4;
            this.rushString.Name = "rushString";
            this.rushString.Size = new System.Drawing.Size(121, 21);
            this.rushString.TabIndex = 8;
            // 
            // drawersString
            // 
            this.drawersString.FormattingEnabled = true;
            this.drawersString.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.drawersString.Location = new System.Drawing.Point(263, 179);
            this.drawersString.Name = "drawersString";
            this.drawersString.Size = new System.Drawing.Size(121, 21);
            this.drawersString.TabIndex = 9;
            // 
            // widthNum
            // 
            this.widthNum.Location = new System.Drawing.Point(263, 95);
            this.widthNum.Name = "widthNum";
            this.widthNum.Size = new System.Drawing.Size(120, 20);
            this.widthNum.TabIndex = 10;
            // 
            // depthNum
            // 
            this.depthNum.Location = new System.Drawing.Point(263, 137);
            this.depthNum.Name = "depthNum";
            this.depthNum.Size = new System.Drawing.Size(120, 20);
            this.depthNum.TabIndex = 11;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(215, 310);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(215, 46);
            this.Submit.TabIndex = 14;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.depthNum);
            this.Controls.Add(this.widthNum);
            this.Controls.Add(this.drawersString);
            this.Controls.Add(this.rushString);
            this.Controls.Add(this.materialString);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label1);
            this.Name = "AddQuote";
            this.Text = "Add a New Quote";
            ((System.ComponentModel.ISupportInitialize)(this.widthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox materialString;
        private System.Windows.Forms.ComboBox rushString;
        private System.Windows.Forms.ComboBox drawersString;
        private System.Windows.Forms.NumericUpDown widthNum;
        private System.Windows.Forms.NumericUpDown depthNum;        
        private System.Windows.Forms.Button Submit;
    }
}