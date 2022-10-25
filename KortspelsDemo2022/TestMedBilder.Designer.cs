
namespace KortspelsDemo2022
{
    partial class TestMedBilder
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
            this.BtVisaKort = new System.Windows.Forms.Button();
            this.PbK1 = new System.Windows.Forms.PictureBox();
            this.PbK2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbHogstaKort = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbK1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbK2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtVisaKort
            // 
            this.BtVisaKort.Location = new System.Drawing.Point(85, 239);
            this.BtVisaKort.Name = "BtVisaKort";
            this.BtVisaKort.Size = new System.Drawing.Size(131, 47);
            this.BtVisaKort.TabIndex = 1;
            this.BtVisaKort.Text = "Dra kort";
            this.BtVisaKort.UseVisualStyleBackColor = true;
            this.BtVisaKort.Click += new System.EventHandler(this.BtVisaKort_Click);
            // 
            // PbK1
            // 
            this.PbK1.Location = new System.Drawing.Point(205, 39);
            this.PbK1.Name = "PbK1";
            this.PbK1.Size = new System.Drawing.Size(131, 173);
            this.PbK1.TabIndex = 0;
            this.PbK1.TabStop = false;
            // 
            // PbK2
            // 
            this.PbK2.Location = new System.Drawing.Point(262, 39);
            this.PbK2.Name = "PbK2";
            this.PbK2.Size = new System.Drawing.Size(131, 173);
            this.PbK2.TabIndex = 2;
            this.PbK2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(588, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Högsta kortet";
            // 
            // TbHogstaKort
            // 
            this.TbHogstaKort.Location = new System.Drawing.Point(592, 71);
            this.TbHogstaKort.Name = "TbHogstaKort";
            this.TbHogstaKort.Size = new System.Drawing.Size(196, 26);
            this.TbHogstaKort.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(592, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 74);
            this.button1.TabIndex = 5;
            this.button1.Text = "Högsta kortet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TestMedBilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TbHogstaKort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PbK2);
            this.Controls.Add(this.BtVisaKort);
            this.Controls.Add(this.PbK1);
            this.Name = "TestMedBilder";
            this.Text = "TestMedBilder";
            ((System.ComponentModel.ISupportInitialize)(this.PbK1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbK2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtVisaKort;
        private System.Windows.Forms.PictureBox PbK1;
        private System.Windows.Forms.PictureBox PbK2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbHogstaKort;
        private System.Windows.Forms.Button button1;
    }
}