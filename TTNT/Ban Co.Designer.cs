namespace TTNT
{
    partial class Ban_Co
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ban_Co));
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.btnRoi = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblComputer = new System.Windows.Forms.Label();
            this.picO = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.picX = new System.Windows.Forms.PictureBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnCaiDat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picO)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picX)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            // 
            // btnRoi
            // 
            this.btnRoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoi.Location = new System.Drawing.Point(690, 519);
            this.btnRoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnRoi.Name = "btnRoi";
            this.btnRoi.Size = new System.Drawing.Size(88, 35);
            this.btnRoi.TabIndex = 37;
            this.btnRoi.Text = "Chọn lại";
            this.btnRoi.UseVisualStyleBackColor = true;
            this.btnRoi.Click += new System.EventHandler(this.btnRoi_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(569, 519);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(89, 35);
            this.btnNew.TabIndex = 36;
            this.btnNew.Text = "Chơi lại";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblComputer.Location = new System.Drawing.Point(34, 180);
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
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblComputer);
            this.panel4.Controls.Add(this.picO);
            this.panel4.Location = new System.Drawing.Point(569, 145);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(153, 208);
            this.panel4.TabIndex = 35;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPlayer.Location = new System.Drawing.Point(46, 180);
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
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(1, 22);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(78, 37);
            this.lblTimer.TabIndex = 38;
            this.lblTimer.Text = "00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPlayer);
            this.panel3.Controls.Add(this.picX);
            this.panel3.Location = new System.Drawing.Point(30, 145);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 208);
            this.panel3.TabIndex = 34;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(745, 112);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(34, 37);
            this.btnThoat.TabIndex = 32;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Visible = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnColor
            // 
            this.btnColor.Image = ((System.Drawing.Image)(resources.GetObject("btnColor.Image")));
            this.btnColor.Location = new System.Drawing.Point(745, 70);
            this.btnColor.Margin = new System.Windows.Forms.Padding(2);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(34, 37);
            this.btnColor.TabIndex = 31;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Visible = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.Image = ((System.Drawing.Image)(resources.GetObject("btnCaiDat.Image")));
            this.btnCaiDat.Location = new System.Drawing.Point(745, 28);
            this.btnCaiDat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Size = new System.Drawing.Size(34, 37);
            this.btnCaiDat.TabIndex = 30;
            this.btnCaiDat.UseVisualStyleBackColor = true;
            this.btnCaiDat.Click += new System.EventHandler(this.btnCaiDat_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Location = new System.Drawing.Point(214, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 320);
            this.panel2.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.Location = new System.Drawing.Point(3, 109);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 100);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button7.Location = new System.Drawing.Point(3, 215);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 100);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button9.Location = new System.Drawing.Point(215, 215);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 100);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Location = new System.Drawing.Point(109, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 100);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button8.Location = new System.Drawing.Point(109, 215);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 100);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.Location = new System.Drawing.Point(215, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 100);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button6.Location = new System.Drawing.Point(215, 109);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 100);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button5.Location = new System.Drawing.Point(109, 109);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 100);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(217, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 53);
            this.panel1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic Tac Toe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Ban_Co
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.btnRoi);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnCaiDat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ban_Co";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bàn cờ";
            ((System.ComponentModel.ISupportInitialize)(this.picO)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picX)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Button btnRoi;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblComputer;
        public System.Windows.Forms.PictureBox picO;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblPlayer;
        public System.Windows.Forms.PictureBox picX;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnCaiDat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}