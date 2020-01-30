namespace MegaDesk
{
    partial class DisplayQuote
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
            this.totalCostOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RushOutput = new System.Windows.Forms.TextBox();
            this.SurfaceOutput = new System.Windows.Forms.TextBox();
            this.DrawerOutput = new System.Windows.Forms.TextBox();
            this.AreaOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalCostOutput
            // 
            this.totalCostOutput.Location = new System.Drawing.Point(234, 207);
            this.totalCostOutput.Name = "totalCostOutput";
            this.totalCostOutput.ReadOnly = true;
            this.totalCostOutput.Size = new System.Drawing.Size(110, 20);
            this.totalCostOutput.TabIndex = 0;
            this.totalCostOutput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Cost";
            // 
            // RushOutput
            // 
            this.RushOutput.Location = new System.Drawing.Point(234, 165);
            this.RushOutput.Name = "RushOutput";
            this.RushOutput.ReadOnly = true;
            this.RushOutput.Size = new System.Drawing.Size(48, 20);
            this.RushOutput.TabIndex = 2;
            // 
            // SurfaceOutput
            // 
            this.SurfaceOutput.Location = new System.Drawing.Point(234, 127);
            this.SurfaceOutput.Name = "SurfaceOutput";
            this.SurfaceOutput.ReadOnly = true;
            this.SurfaceOutput.Size = new System.Drawing.Size(100, 20);
            this.SurfaceOutput.TabIndex = 3;
            // 
            // DrawerOutput
            // 
            this.DrawerOutput.Location = new System.Drawing.Point(234, 89);
            this.DrawerOutput.Name = "DrawerOutput";
            this.DrawerOutput.ReadOnly = true;
            this.DrawerOutput.Size = new System.Drawing.Size(100, 20);
            this.DrawerOutput.TabIndex = 4;
            // 
            // AreaOutput
            // 
            this.AreaOutput.Location = new System.Drawing.Point(234, 49);
            this.AreaOutput.Name = "AreaOutput";
            this.AreaOutput.ReadOnly = true;
            this.AreaOutput.Size = new System.Drawing.Size(100, 20);
            this.AreaOutput.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rush Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Drawers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Surface Material";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Area";
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 313);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AreaOutput);
            this.Controls.Add(this.DrawerOutput);
            this.Controls.Add(this.SurfaceOutput);
            this.Controls.Add(this.RushOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalCostOutput);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox totalCostOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RushOutput;
        private System.Windows.Forms.TextBox SurfaceOutput;
        private System.Windows.Forms.TextBox DrawerOutput;
        private System.Windows.Forms.TextBox AreaOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}