namespace TTNT
{
    partial class frmTrangchu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangchu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnCaiDat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(48, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 63);
            this.panel1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic Tac Toe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(160, 345);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(112, 50);
            this.btnPlay.TabIndex = 31;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(400, 107);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(34, 37);
            this.btnThoat.TabIndex = 30;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Visible = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnColor
            // 
            this.btnColor.Image = ((System.Drawing.Image)(resources.GetObject("btnColor.Image")));
            this.btnColor.Location = new System.Drawing.Point(400, 66);
            this.btnColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(34, 37);
            this.btnColor.TabIndex = 29;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Visible = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.Image = ((System.Drawing.Image)(resources.GetObject("btnCaiDat.Image")));
            this.btnCaiDat.Location = new System.Drawing.Point(400, 25);
            this.btnCaiDat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Size = new System.Drawing.Size(34, 37);
            this.btnCaiDat.TabIndex = 28;
            this.btnCaiDat.UseVisualStyleBackColor = true;
            this.btnCaiDat.Click += new System.EventHandler(this.btnCaiDat_Click);
            // 
            // frmTrangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 437);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnCaiDat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmTrangchu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnCaiDat;
    }
}

