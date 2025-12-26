using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTNT
{
    public partial class frmTrangchu: Form
    {
        public frmTrangchu()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPlay.BackColor = ColorTranslator.FromHtml("#1F45C6"); // xanh nền
            //Di chuyển tới from TIC TAC TOE
            TIC_TAC_TOE ticTacToe = new TIC_TAC_TOE();
            ticTacToe.Show();

            //Ẩn from Trang chủ 
            this.Hide();
        }

        private bool theoDoiTrangThaiCaiDat = false;

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            // Đảo ngược trạng thái
            theoDoiTrangThaiCaiDat = !theoDoiTrangThaiCaiDat;

            btnColor.Visible = theoDoiTrangThaiCaiDat;
            btnThoat.Visible = theoDoiTrangThaiCaiDat;

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            // Tạo một hộp thoại chọn màu
            ColorDialog mauNen = new ColorDialog();

            // Hiển thị hộp thoại và kiểm tra xem người dùng đã chọn màu và nhấn OK hay không
            if (mauNen.ShowDialog() == DialogResult.OK)
            {
                // Thay đổi màu nền của Form bằng màu đã chọn
                this.BackColor = mauNen.Color;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
