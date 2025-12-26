namespace TTNT
{
    partial class TIC_TAC_TOE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TIC_TAC_TOE));
            this.btnStart = new System.Windows.Forms.Button();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.picX = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblComputer = new System.Windows.Forms.Label();
            this.picO = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnCaiDat = new System.Windows.Forms.Button();
            this.btnDoiViTri = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picX)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picO)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(215, 401);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(142, 58);
            this.btnStart.TabIndex = 19;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPlayer.Location = new System.Drawing.Point(51, 180);
            this.lblPlayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(54, 17);
            this.lblPlayer.TabIndex = 2;
            this.lblPlayer.Text = "Player";
            this.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picX
            // 
            this.picX.Dock = System.Windows.Forms.DockStyle.Top;
            this.picX.ErrorImage = null;
            this.picX.Image = ((System.Drawing.Image)(resources.GetObject("picX.Image")));
            this.picX.Location = new System.Drawing.Point(0, 0);
            this.picX.Margin = new System.Windows.Forms.Padding(2);
            this.picX.Name = "picX";
            this.picX.Size = new System.Drawing.Size(153, 162);
            this.picX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picX.TabIndex = 2;
            this.picX.TabStop = false;
            this.picX.Click += new System.EventHandler(this.picX_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblComputer);
            this.panel2.Controls.Add(this.picO);
            this.panel2.Location = new System.Drawing.Point(347, 126);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 208);
            this.panel2.TabIndex = 21;
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblComputer.Location = new System.Drawing.Point(37, 180);
            this.lblComputer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(77, 17);
            this.lblComputer.TabIndex = 2;
            this.lblComputer.Text = "Computer";
            this.lblComputer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picO
            // 
            this.picO.Dock = System.Windows.Forms.DockStyle.Top;
            this.picO.Image = ((System.Drawing.Image)(resources.GetObject("picO.Image")));
            this.picO.Location = new System.Drawing.Point(0, 0);
            this.picO.Margin = new System.Windows.Forms.Padding(2);
            this.picO.Name = "picO";
            this.picO.Size = new System.Drawing.Size(153, 162);
            this.picO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picO.TabIndex = 2;
            this.picO.TabStop = false;
            this.picO.Click += new System.EventHandler(this.picO_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPlayer);
            this.panel1.Controls.Add(this.picX);
            this.panel1.Location = new System.Drawing.Point(67, 126);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 208);
            this.panel1.TabIndex = 20;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(527, 93);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(34, 37);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Visible = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnColor
            // 
            this.btnColor.Image = ((System.Drawing.Image)(resources.GetObject("btnColor.Image")));
            this.btnColor.Location = new System.Drawing.Point(527, 52);
            this.btnColor.Margin = new System.Windows.Forms.Padding(2);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(34, 37);
            this.btnColor.TabIndex = 26;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Visible = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.Image = ((System.Drawing.Image)(resources.GetObject("btnCaiDat.Image")));
            this.btnCaiDat.Location = new System.Drawing.Point(527, 11);
            this.btnCaiDat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Size = new System.Drawing.Size(34, 37);
            this.btnCaiDat.TabIndex = 25;
            this.btnCaiDat.UseVisualStyleBackColor = true;
            this.btnCaiDat.Click += new System.EventHandler(this.btnCaiDat_Click);
            // 
            // btnDoiViTri
            // 
            this.btnDoiViTri.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDoiViTri.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiViTri.Image")));
            this.btnDoiViTri.Location = new System.Drawing.Point(287, 217);
            this.btnDoiViTri.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoiViTri.Name = "btnDoiViTri";
            this.btnDoiViTri.Size = new System.Drawing.Size(36, 42);
            this.btnDoiViTri.TabIndex = 24;
            this.btnDoiViTri.UseVisualStyleBackColor = true;
            this.btnDoiViTri.Click += new System.EventHandler(this.btnDoiViTri_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Image = ((System.Drawing.Image)(resources.GetObject("btnChinhSua.Image")));
            this.btnChinhSua.Location = new System.Drawing.Point(238, 217);
            this.btnChinhSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(37, 42);
            this.btnChinhSua.TabIndex = 23;
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 44);
            this.label1.TabIndex = 22;
            this.label1.Text = "VS";
            // 
            // TIC_TAC_TOE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 485);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnCaiDat);
            this.Controls.Add(this.btnDoiViTri);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TIC_TAC_TOE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIC_TAC_TOE";
            this.Load += new System.EventHandler(this.TIC_TAC_TOE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picX)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picO)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.PictureBox picX;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.PictureBox picO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnCaiDat;
        private System.Windows.Forms.Button btnDoiViTri;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Label label1;
    }
}