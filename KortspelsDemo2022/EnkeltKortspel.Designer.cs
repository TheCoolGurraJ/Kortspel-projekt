
namespace KortspelsDemo2022
{
    partial class EnkeltKortspel
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
            this.BtDraKort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbK1v = new System.Windows.Forms.TextBox();
            this.TbK1f = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtDraKort
            // 
            this.BtDraKort.Location = new System.Drawing.Point(98, 94);
            this.BtDraKort.Name = "BtDraKort";
            this.BtDraKort.Size = new System.Drawing.Size(85, 47);
            this.BtDraKort.TabIndex = 13;
            this.BtDraKort.Text = "Dra ett kort från kortleken";
            this.BtDraKort.UseVisualStyleBackColor = true;
            this.BtDraKort.Click += new System.EventHandler(this.BtDraKort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Valör";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Färg";
            // 
            // TbK1v
            // 
            this.TbK1v.Location = new System.Drawing.Point(145, 53);
            this.TbK1v.Name = "TbK1v";
            this.TbK1v.Size = new System.Drawing.Size(100, 20);
            this.TbK1v.TabIndex = 10;
            // 
            // TbK1f
            // 
            this.TbK1f.Location = new System.Drawing.Point(39, 53);
            this.TbK1f.Name = "TbK1f";
            this.TbK1f.Size = new System.Drawing.Size(100, 20);
            this.TbK1f.TabIndex = 9;
            // 
            // EnkeltKortspel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 277);
            this.Controls.Add(this.BtDraKort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbK1v);
            this.Controls.Add(this.TbK1f);
            this.Name = "EnkeltKortspel";
            this.Text = "EnkeltKortspel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtDraKort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbK1v;
        private System.Windows.Forms.TextBox TbK1f;
    }
}