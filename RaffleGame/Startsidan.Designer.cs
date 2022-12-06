
namespace RaffleGame
{
    partial class Startsidan
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
            this.Lbl_Start = new System.Windows.Forms.Label();
            this.Bt2Spelare = new System.Windows.Forms.Button();
            this.Bt3Spelare = new System.Windows.Forms.Button();
            this.Lbl_instruktioner = new System.Windows.Forms.Label();
            this.Tb_Sp1 = new System.Windows.Forms.TextBox();
            this.Tb_Sp2 = new System.Windows.Forms.TextBox();
            this.Tb_Sp3 = new System.Windows.Forms.TextBox();
            this.Lbl_Sp1 = new System.Windows.Forms.Label();
            this.Lbl_Sp2 = new System.Windows.Forms.Label();
            this.Lbl_Sp3 = new System.Windows.Forms.Label();
            this.Bt_Klart = new System.Windows.Forms.Button();
            this.Bt_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Start
            // 
            this.Lbl_Start.AutoSize = true;
            this.Lbl_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Start.Location = new System.Drawing.Point(195, 75);
            this.Lbl_Start.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Start.Name = "Lbl_Start";
            this.Lbl_Start.Size = new System.Drawing.Size(826, 73);
            this.Lbl_Start.TabIndex = 0;
            this.Lbl_Start.Text = "Välkommen till RaffleGame!";
            // 
            // Bt2Spelare
            // 
            this.Bt2Spelare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt2Spelare.Location = new System.Drawing.Point(219, 208);
            this.Bt2Spelare.Margin = new System.Windows.Forms.Padding(2);
            this.Bt2Spelare.Name = "Bt2Spelare";
            this.Bt2Spelare.Size = new System.Drawing.Size(139, 53);
            this.Bt2Spelare.TabIndex = 1;
            this.Bt2Spelare.Text = "2 Spelare";
            this.Bt2Spelare.UseVisualStyleBackColor = true;
            this.Bt2Spelare.Click += new System.EventHandler(this.Bt2Spelare_Click);
            // 
            // Bt3Spelare
            // 
            this.Bt3Spelare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt3Spelare.Location = new System.Drawing.Point(580, 208);
            this.Bt3Spelare.Margin = new System.Windows.Forms.Padding(2);
            this.Bt3Spelare.Name = "Bt3Spelare";
            this.Bt3Spelare.Size = new System.Drawing.Size(139, 53);
            this.Bt3Spelare.TabIndex = 2;
            this.Bt3Spelare.Text = "3 Spelare";
            this.Bt3Spelare.UseVisualStyleBackColor = true;
            this.Bt3Spelare.Click += new System.EventHandler(this.Bt3Spelare_Click);
            // 
            // Lbl_instruktioner
            // 
            this.Lbl_instruktioner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_instruktioner.AutoSize = true;
            this.Lbl_instruktioner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_instruktioner.Location = new System.Drawing.Point(202, 139);
            this.Lbl_instruktioner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_instruktioner.Name = "Lbl_instruktioner";
            this.Lbl_instruktioner.Size = new System.Drawing.Size(466, 25);
            this.Lbl_instruktioner.TabIndex = 3;
            this.Lbl_instruktioner.Text = "Vänligen välj hur många spelare som ska delta.";
            this.Lbl_instruktioner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tb_Sp1
            // 
            this.Tb_Sp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Sp1.Location = new System.Drawing.Point(413, 208);
            this.Tb_Sp1.Margin = new System.Windows.Forms.Padding(2);
            this.Tb_Sp1.Name = "Tb_Sp1";
            this.Tb_Sp1.Size = new System.Drawing.Size(124, 35);
            this.Tb_Sp1.TabIndex = 4;
            this.Tb_Sp1.Visible = false;
            // 
            // Tb_Sp2
            // 
            this.Tb_Sp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Sp2.Location = new System.Drawing.Point(413, 256);
            this.Tb_Sp2.Margin = new System.Windows.Forms.Padding(2);
            this.Tb_Sp2.Name = "Tb_Sp2";
            this.Tb_Sp2.Size = new System.Drawing.Size(124, 35);
            this.Tb_Sp2.TabIndex = 5;
            this.Tb_Sp2.Visible = false;
            // 
            // Tb_Sp3
            // 
            this.Tb_Sp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Sp3.Location = new System.Drawing.Point(413, 306);
            this.Tb_Sp3.Margin = new System.Windows.Forms.Padding(2);
            this.Tb_Sp3.Name = "Tb_Sp3";
            this.Tb_Sp3.Size = new System.Drawing.Size(124, 35);
            this.Tb_Sp3.TabIndex = 6;
            this.Tb_Sp3.Visible = false;
            // 
            // Lbl_Sp1
            // 
            this.Lbl_Sp1.AutoSize = true;
            this.Lbl_Sp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Sp1.Location = new System.Drawing.Point(417, 190);
            this.Lbl_Sp1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Sp1.Name = "Lbl_Sp1";
            this.Lbl_Sp1.Size = new System.Drawing.Size(96, 25);
            this.Lbl_Sp1.TabIndex = 7;
            this.Lbl_Sp1.Text = "Spelare 1";
            this.Lbl_Sp1.Visible = false;
            // 
            // Lbl_Sp2
            // 
            this.Lbl_Sp2.AutoSize = true;
            this.Lbl_Sp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Sp2.Location = new System.Drawing.Point(417, 238);
            this.Lbl_Sp2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Sp2.Name = "Lbl_Sp2";
            this.Lbl_Sp2.Size = new System.Drawing.Size(96, 25);
            this.Lbl_Sp2.TabIndex = 8;
            this.Lbl_Sp2.Text = "Spelare 2";
            this.Lbl_Sp2.Visible = false;
            // 
            // Lbl_Sp3
            // 
            this.Lbl_Sp3.AutoSize = true;
            this.Lbl_Sp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Sp3.Location = new System.Drawing.Point(417, 288);
            this.Lbl_Sp3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Sp3.Name = "Lbl_Sp3";
            this.Lbl_Sp3.Size = new System.Drawing.Size(96, 25);
            this.Lbl_Sp3.TabIndex = 9;
            this.Lbl_Sp3.Text = "Spelare 3";
            this.Lbl_Sp3.Visible = false;
            // 
            // Bt_Klart
            // 
            this.Bt_Klart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Klart.Location = new System.Drawing.Point(580, 298);
            this.Bt_Klart.Margin = new System.Windows.Forms.Padding(2);
            this.Bt_Klart.Name = "Bt_Klart";
            this.Bt_Klart.Size = new System.Drawing.Size(139, 34);
            this.Bt_Klart.TabIndex = 10;
            this.Bt_Klart.Text = "Klart";
            this.Bt_Klart.UseVisualStyleBackColor = true;
            this.Bt_Klart.Visible = false;
            this.Bt_Klart.Click += new System.EventHandler(this.Bt_Klart_Click);
            // 
            // Bt_Back
            // 
            this.Bt_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Back.Location = new System.Drawing.Point(82, 75);
            this.Bt_Back.Name = "Bt_Back";
            this.Bt_Back.Size = new System.Drawing.Size(87, 33);
            this.Bt_Back.TabIndex = 11;
            this.Bt_Back.Text = "←";
            this.Bt_Back.UseVisualStyleBackColor = true;
            this.Bt_Back.Click += new System.EventHandler(this.Bt_Back_Click);
            // 
            // Startsidan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 423);
            this.Controls.Add(this.Bt_Back);
            this.Controls.Add(this.Bt_Klart);
            this.Controls.Add(this.Lbl_Sp3);
            this.Controls.Add(this.Lbl_Sp2);
            this.Controls.Add(this.Lbl_Sp1);
            this.Controls.Add(this.Tb_Sp3);
            this.Controls.Add(this.Tb_Sp2);
            this.Controls.Add(this.Tb_Sp1);
            this.Controls.Add(this.Lbl_instruktioner);
            this.Controls.Add(this.Bt3Spelare);
            this.Controls.Add(this.Bt2Spelare);
            this.Controls.Add(this.Lbl_Start);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Startsidan";
            this.Text = "RaffleGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Start;
        private System.Windows.Forms.Button Bt2Spelare;
        private System.Windows.Forms.Button Bt3Spelare;
        private System.Windows.Forms.Label Lbl_instruktioner;
        private System.Windows.Forms.TextBox Tb_Sp1;
        private System.Windows.Forms.TextBox Tb_Sp2;
        private System.Windows.Forms.TextBox Tb_Sp3;
        private System.Windows.Forms.Label Lbl_Sp1;
        private System.Windows.Forms.Label Lbl_Sp2;
        private System.Windows.Forms.Label Lbl_Sp3;
        private System.Windows.Forms.Button Bt_Klart;
        private System.Windows.Forms.Button Bt_Back;
    }
}