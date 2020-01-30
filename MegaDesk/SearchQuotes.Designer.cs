namespace MegaDesk
{
    partial class SearchQuotes
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
            this.MaterialSelect = new System.Windows.Forms.ComboBox();
            this.SelectByMatDisplay = new System.Windows.Forms.RichTextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MaterialSelect
            // 
            this.MaterialSelect.FormattingEnabled = true;
            this.MaterialSelect.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.MaterialSelect.Location = new System.Drawing.Point(104, 43);
            this.MaterialSelect.Name = "MaterialSelect";
            this.MaterialSelect.Size = new System.Drawing.Size(172, 21);
            this.MaterialSelect.TabIndex = 0;
            this.MaterialSelect.SelectedIndexChanged += new System.EventHandler(this.MaterialSelect_SelectedIndexChanged);
            // 
            // SelectByMatDisplay
            // 
            this.SelectByMatDisplay.Location = new System.Drawing.Point(35, 99);
            this.SelectByMatDisplay.Name = "SelectByMatDisplay";
            this.SelectByMatDisplay.Size = new System.Drawing.Size(320, 322);
            this.SelectByMatDisplay.TabIndex = 1;
            this.SelectByMatDisplay.Text = "";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(337, 99);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 322);
            this.vScrollBar1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select a Material ";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.SelectByMatDisplay);
            this.Controls.Add(this.MaterialSelect);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MaterialSelect;
        private System.Windows.Forms.RichTextBox SelectByMatDisplay;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label1;
    }
}