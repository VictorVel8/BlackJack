namespace BlackJack
{
    partial class Form1
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
            this.split = new System.Windows.Forms.Button();
            this.hit = new System.Windows.Forms.Button();
            this.stand = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dealer = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.Label();
            this.sdealer = new System.Windows.Forms.Label();
            this.splayer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // split
            // 
            this.split.Location = new System.Drawing.Point(513, 448);
            this.split.Name = "split";
            this.split.Size = new System.Drawing.Size(117, 50);
            this.split.TabIndex = 0;
            this.split.Text = "Imparte Cartile";
            this.split.UseVisualStyleBackColor = true;
            this.split.Click += new System.EventHandler(this.split_Click);
            // 
            // hit
            // 
            this.hit.Location = new System.Drawing.Point(257, 448);
            this.hit.Name = "hit";
            this.hit.Size = new System.Drawing.Size(102, 50);
            this.hit.TabIndex = 1;
            this.hit.Text = "Hit";
            this.hit.UseVisualStyleBackColor = true;
            this.hit.Visible = false;
            this.hit.Click += new System.EventHandler(this.hit_Click);
            // 
            // stand
            // 
            this.stand.Location = new System.Drawing.Point(765, 448);
            this.stand.Name = "stand";
            this.stand.Size = new System.Drawing.Size(116, 50);
            this.stand.TabIndex = 2;
            this.stand.Text = "Stand";
            this.stand.UseVisualStyleBackColor = true;
            this.stand.Visible = false;
            this.stand.Click += new System.EventHandler(this.stand_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(470, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Carti dealer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(470, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Carti player:";
            // 
            // dealer
            // 
            this.dealer.AutoSize = true;
            this.dealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealer.Location = new System.Drawing.Point(527, 94);
            this.dealer.Name = "dealer";
            this.dealer.Size = new System.Drawing.Size(0, 29);
            this.dealer.TabIndex = 5;
            // 
            // player
            // 
            this.player.AutoSize = true;
            this.player.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player.Location = new System.Drawing.Point(508, 295);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(0, 29);
            this.player.TabIndex = 6;
            // 
            // sdealer
            // 
            this.sdealer.AutoSize = true;
            this.sdealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdealer.Location = new System.Drawing.Point(945, 44);
            this.sdealer.Name = "sdealer";
            this.sdealer.Size = new System.Drawing.Size(0, 24);
            this.sdealer.TabIndex = 7;
            // 
            // splayer
            // 
            this.splayer.AutoSize = true;
            this.splayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splayer.Location = new System.Drawing.Point(945, 268);
            this.splayer.Name = "splayer";
            this.splayer.Size = new System.Drawing.Size(0, 24);
            this.splayer.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "label3";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splayer);
            this.Controls.Add(this.sdealer);
            this.Controls.Add(this.player);
            this.Controls.Add(this.dealer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stand);
            this.Controls.Add(this.hit);
            this.Controls.Add(this.split);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button split;
        private System.Windows.Forms.Button hit;
        private System.Windows.Forms.Button stand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dealer;
        private System.Windows.Forms.Label player;
        private System.Windows.Forms.Label sdealer;
        private System.Windows.Forms.Label splayer;
        private System.Windows.Forms.Label label1;
    }
}

