
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
            this.SuspendLayout();
            // 
            // Lbl_Start
            // 
            this.Lbl_Start.AutoSize = true;
            this.Lbl_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Start.Location = new System.Drawing.Point(331, 119);
            this.Lbl_Start.Name = "Lbl_Start";
            this.Lbl_Start.Size = new System.Drawing.Size(826, 73);
            this.Lbl_Start.TabIndex = 0;
            this.Lbl_Start.Text = "Välkommen till RaffleGame!";
            // 
            // Bt2Spelare
            // 
            this.Bt2Spelare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt2Spelare.Location = new System.Drawing.Point(376, 323);
            this.Bt2Spelare.Name = "Bt2Spelare";
            this.Bt2Spelare.Size = new System.Drawing.Size(178, 82);
            this.Bt2Spelare.TabIndex = 1;
            this.Bt2Spelare.Text = "2 Spelare";
            this.Bt2Spelare.UseVisualStyleBackColor = true;
            this.Bt2Spelare.Click += new System.EventHandler(this.Bt2Spelare_Click);
            // 
            // Bt3Spelare
            // 
            this.Bt3Spelare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt3Spelare.Location = new System.Drawing.Point(840, 323);
            this.Bt3Spelare.Name = "Bt3Spelare";
            this.Bt3Spelare.Size = new System.Drawing.Size(178, 82);
            this.Bt3Spelare.TabIndex = 2;
            this.Bt3Spelare.Text = "3 Spelare";
            this.Bt3Spelare.UseVisualStyleBackColor = true;
            this.Bt3Spelare.Click += new System.EventHandler(this.Bt3Spelare_Click);
            // 
            // Lbl_instruktioner
            // 
            this.Lbl_instruktioner.AutoSize = true;
            this.Lbl_instruktioner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_instruktioner.Location = new System.Drawing.Point(475, 216);
            this.Lbl_instruktioner.Name = "Lbl_instruktioner";
            this.Lbl_instruktioner.Size = new System.Drawing.Size(460, 25);
            this.Lbl_instruktioner.TabIndex = 3;
            this.Lbl_instruktioner.Text = "Vänligen välj hur många spelare som ska delta";
            // 
            // Tb_Sp1
            // 
            this.Tb_Sp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Sp1.Location = new System.Drawing.Point(625, 323);
            this.Tb_Sp1.Name = "Tb_Sp1";
            this.Tb_Sp1.Size = new System.Drawing.Size(159, 35);
            this.Tb_Sp1.TabIndex = 4;
            this.Tb_Sp1.Visible = false;
            // 
            // Tb_Sp2
            // 
            this.Tb_Sp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Sp2.Location = new System.Drawing.Point(625, 397);
            this.Tb_Sp2.Name = "Tb_Sp2";
            this.Tb_Sp2.Size = new System.Drawing.Size(159, 35);
            this.Tb_Sp2.TabIndex = 5;
            this.Tb_Sp2.Visible = false;
            // 
            // Tb_Sp3
            // 
            this.Tb_Sp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Sp3.Location = new System.Drawing.Point(625, 474);
            this.Tb_Sp3.Name = "Tb_Sp3";
            this.Tb_Sp3.Size = new System.Drawing.Size(159, 35);
            this.Tb_Sp3.TabIndex = 6;
            this.Tb_Sp3.Visible = false;
            this.Tb_Sp3.TextChanged += new System.EventHandler(this.Tb_Sp3_TextChanged);
            // 
            // Lbl_Sp1
            // 
            this.Lbl_Sp1.AutoSize = true;
            this.Lbl_Sp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Sp1.Location = new System.Drawing.Point(630, 295);
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
            this.Lbl_Sp2.Location = new System.Drawing.Point(630, 369);
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
            this.Lbl_Sp3.Location = new System.Drawing.Point(630, 446);
            this.Lbl_Sp3.Name = "Lbl_Sp3";
            this.Lbl_Sp3.Size = new System.Drawing.Size(96, 25);
            this.Lbl_Sp3.TabIndex = 9;
            this.Lbl_Sp3.Text = "Spelare 3";
            this.Lbl_Sp3.Visible = false;
            this.Lbl_Sp3.Click += new System.EventHandler(this.Lbl_Sp3_Click);
            // 
            // Bt_Klart
            // 
            this.Bt_Klart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Klart.Location = new System.Drawing.Point(816, 446);
            this.Bt_Klart.Name = "Bt_Klart";
            this.Bt_Klart.Size = new System.Drawing.Size(138, 52);
            this.Bt_Klart.TabIndex = 10;
            this.Bt_Klart.Text = "Klart";
            this.Bt_Klart.UseVisualStyleBackColor = true;
            this.Bt_Klart.Visible = false;
            this.Bt_Klart.Click += new System.EventHandler(this.Bt_Klart_Click);
            // 
            // Startsidan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 629);
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
    }
}