namespace MegaDesk
{
    partial class ViewAllQuotes
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
            this.AllQuoteOutput = new System.Windows.Forms.RichTextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.listButton = new System.Windows.Forms.Button();
            this.gridButton = new System.Windows.Forms.Button();
            this.orderGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AllQuoteOutput
            // 
            this.AllQuoteOutput.Location = new System.Drawing.Point(138, 55);
            this.AllQuoteOutput.Name = "AllQuoteOutput";
            this.AllQuoteOutput.Size = new System.Drawing.Size(498, 337);
            this.AllQuoteOutput.TabIndex = 0;
            this.AllQuoteOutput.Text = "";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(619, 55);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 337);
            this.vScrollBar1.TabIndex = 1;
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(196, 26);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(157, 23);
            this.listButton.TabIndex = 2;
            this.listButton.Text = "List View";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // gridButton
            // 
            this.gridButton.Location = new System.Drawing.Point(392, 26);
            this.gridButton.Name = "gridButton";
            this.gridButton.Size = new System.Drawing.Size(157, 23);
            this.gridButton.TabIndex = 3;
            this.gridButton.Text = "Grid View";
            this.gridButton.UseVisualStyleBackColor = true;
            this.gridButton.Click += new System.EventHandler(this.gridButton_Click);
            // 
            // orderGridView
            // 
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.Location = new System.Drawing.Point(28, 55);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.Size = new System.Drawing.Size(741, 337);
            this.orderGridView.TabIndex = 4;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orderGridView);
            this.Controls.Add(this.gridButton);
            this.Controls.Add(this.listButton);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.AllQuoteOutput);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox AllQuoteOutput;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.Button gridButton;
        private System.Windows.Forms.DataGridView orderGridView;
    }
}