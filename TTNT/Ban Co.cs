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
    public partial class Ban_Co: Form
    {
        private Button[] o_nut;
        private char[] o_banCo;
        private char o_nguoiChoi = 'X';
        private char o_mayTinh = 'O';

        // Thêm các thuộc tính static để lưu trữ ảnh
        public static Image NguoiChoiImage { get; set; }
        public static Image MayTinhImage { get; set; }

        // Tên hiển thị cho người chơi và máy tính (có thể lấy từ form TIC_TAC_TOE nếu muốn)
        private string tenNguoiChoi = "Người chơi";
        private string tenMayTinh = "Máy tính";


        private TimeSpan tongTG;
        // Khai báo biến kiểu DateTime tên tgStart
        private DateTime tgStart;
        // Khai báo biến boolean tên isGameRunning
        private bool isGameRunning = false;
        // Khai báo biến kiểu Timer tên gameTimer
        private System.Windows.Forms.Timer gameTimer;
        public Ban_Co()
        {
            InitializeComponent();
            o_nut = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            o_banCo = new char[9];
            InitializeTimer();
            KhoiTaoBanCo();
           
        }

        public void StartTimer()
        {
            isGameRunning = true;
            tgStart = DateTime.Now;
            GameTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (isGameRunning)
            {
                // Tính thời gian đã trôi qua kể từ khi bắt đầu ván đấu
                TimeSpan currentTime = DateTime.Now - tgStart;

                // Cập nhật tổng thời gian đã chơi
                tongTG = currentTime;

                // Định dạng và hiển thị thời gian trên Label
                lblTimer.Text = tongTG.ToString(@"mm\:ss");
            }
        }

        private void InitializeTimer()
        {
            gameTimer = new Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;
            tongTG = TimeSpan.Zero;
            lblTimer.Text = "00:00";
        }


        private void KhoiTaoBanCo()
        {
            for (int i = 0; i < 9; i++)
            {
                // Đặt ô trong mảng logic (o_banCo) về trạng thái trống (' ')
                o_banCo[i] = ' ';

                // Xóa văn bản hiển thị trên nút bấm tương ứng
                o_nut[i].Text = " ";
                
                // Đảm bảo không có ảnh nền cũ
                o_nut[i].BackgroundImage = null;

                // Kích hoạt lại nút để người chơi có thể bấm
                o_nut[i].Enabled = true;

        
            }
        }

        // Xử lý hành động khi người chơi click vào một nút trên bàn cờ.
        private void XuLyClickNut(Button nutBam)
        {
            // Bắt đầu timer nếu đây là nước đi đầu tiên (hoặc nếu timer chưa chạy)
            if (!isGameRunning)
            {
                StartTimer();
            }

            // Tìm chỉ số (vị trí) của nút bấm trong mảng o_nut
            int viTri = Array.IndexOf(o_nut, nutBam);

            // Chỉ xử lý nếu ô cờ tại vị trí đó còn trống
            if (o_banCo[viTri] == ' ')
            {
                // Cập nhật trạng thái của ô trong mảng logic(o_banCo) là ký tự của người chơi
                o_banCo[viTri] = o_nguoiChoi;
                
                /*nutBam.Text = o_nguoiChoi.ToString();
                nutBam.Enabled = false;*/

                // Hiển thị ảnh nếu có, nếu không thì hiển thị ký tự
                if (NguoiChoiImage != null)
                {
                    // Đặt ảnh nền cho nút bấm
                    nutBam.BackgroundImage = NguoiChoiImage;
                    // Đặt chế độ hiển thị ảnh để ảnh co giãn vừa với nút
                    nutBam.BackgroundImageLayout = ImageLayout.Stretch;
                }

                if (KiemTraNguoiThang(o_banCo, o_nguoiChoi))
                {
                    MessageBox.Show("Bạn đã thắng!");
                    KhoiTaoBanCo();
                    return;
                }

                if (KiemTraHoa(o_banCo))
                {
                    MessageBox.Show("Hòa!");
                    KhoiTaoBanCo();
                    return;
                }

                ThucHienNuocDiMayTinh();
            }
        }

        private void ThucHienNuocDiMayTinh()
        {
            int nuocDiTotNhat = TimNuocDiTotNhat(o_banCo);

            if (MayTinhImage != null)
            {
                o_nut[nuocDiTotNhat].BackgroundImage = MayTinhImage;
                o_nut[nuocDiTotNhat].BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (nuocDiTotNhat != -1)
            {
                o_banCo[nuocDiTotNhat] = o_mayTinh;
                if (MayTinhImage != null)
                {
                    o_nut[nuocDiTotNhat].BackgroundImage = MayTinhImage;
                    o_nut[nuocDiTotNhat].BackgroundImageLayout = ImageLayout.Stretch;
                }
                o_nut[nuocDiTotNhat].Enabled = false;

                if (KiemTraNguoiThang(o_banCo, o_mayTinh))
                {
                    MessageBox.Show("Máy tính đã thắng!");
                    KhoiTaoBanCo();
                    return;
                }

                if (KiemTraHoa(o_banCo))
                {
                    MessageBox.Show("Hòa!");
                    KhoiTaoBanCo();
                    return;
                }
            }
        }
        private int TimNuocDiTotNhat(char[] banCo)
        {
            int nuocDiTotNhat = -1;
            int diemTotNhat = int.MinValue;

            for (int i = 0; i < 9; i++)
            {
                if (banCo[i] == ' ')
                {
                    banCo[i] = o_mayTinh;
                    int diem = Minimax(banCo, 0, false);
                    banCo[i] = ' ';

                    if (diem > diemTotNhat)
                    {
                        diemTotNhat = diem;
                        nuocDiTotNhat = i;
                    }
                }
            }

            return nuocDiTotNhat;
        }
        // Thuật toán Minimax để tìm nước đi tối ưu trong trò chơi Tic-Tac-Toe.
        private int Minimax(char[] banCo, int doSau, bool laMayTinh)
        {
            // 1. Các trường hợp cơ sở (điều kiện dừng đệ quy)
            // Nếu máy tính thắng ở trạng thái hiện tại
            if (KiemTraNguoiThang(banCo, o_mayTinh))
            {
                // Trả về điểm dương, ưu tiên thắng sớm hơn (doSau nhỏ hơn -> điểm cao hơn)
                return 10 - doSau;
            }

            // Nếu người chơi thắng ở trạng thái hiện tại
            if (KiemTraNguoiThang(banCo, o_nguoiChoi))
            {
                // Trả về điểm âm, ưu tiên thua muộn hơn (doSau lớn hơn -> điểm ít âm hơn)
                return doSau - 10;
            }

            // Nếu bàn cờ hòa (không còn ô trống và không ai thắng)
            if (KiemTraHoa(banCo))
            {
                // Trả về 0 (hòa không có lợi hay hại cho ai)
                return 0;
            }

            // Trả về 0 (hòa không có lợi hay hại cho ai)
            // Nếu là lượt của máy tính (Maximizer)
            if (laMayTinh)
            {
                // Khởi tạo điểm tốt nhất bằng giá trị nhỏ nhất
                int diemTotNhat = int.MinValue;
                // Duyệt qua tất cả các ô trên bàn cờ
                for (int i = 0; i < 9; i++)
                {
                    // Nếu ô hiện tại còn trống
                    if (banCo[i] == ' ')
                    {
                        // Tạm thời thực hiện nước đi của máy tính vào ô này
                        banCo[i] = o_mayTinh;
                        // Gọi đệ quy Minimax cho lượt của người chơi (Minimizer)
                        // Máy tính muốn tìm nước đi mang lại điểm cao nhất từ các trạng thái tiếp theo
                        diemTotNhat = Math.Max(diemTotNhat, Minimax(banCo, doSau + 1, false));
                        // Hoàn tác nước đi để thử các nước đi khác
                        banCo[i] = ' ';
                    }
                }
                // Trả về điểm cao nhất mà máy tính có thể đạt được
                return diemTotNhat;
            }
            // Nếu là lượt của người chơi (Minimizer)
            else
            {
                // Khởi tạo điểm tốt nhất bằng giá trị lớn nhất
                int diemTotNhat = int.MaxValue;
                // Duyệt qua tất cả các ô trên bàn cờ
                for (int i = 0; i < 9; i++)
                {
                    // Nếu ô hiện tại còn trống
                    if (banCo[i] == ' ')
                    {
                        // Tạm thời thực hiện nước đi của người chơi vào ô này
                        banCo[i] = o_nguoiChoi;
                        // Gọi đệ quy Minimax cho lượt của máy tính (Maximizer)
                        // Người chơi muốn tìm nước đi khiến máy tính đạt được điểm thấp nhất
                        diemTotNhat = Math.Min(diemTotNhat, Minimax(banCo, doSau + 1, true));
                        // Hoàn tác nước đi để thử các nước đi khác
                        banCo[i] = ' ';
                    }
                }
                // Trả về điểm thấp nhất mà người chơi có thể khiến máy tính nhận được
                return diemTotNhat;
            }
        }

        // Định nghĩa tất cả các đường thẳng chiến thắng trên bàn cờ (ngang, dọc, chéo)
        private bool KiemTraNguoiThang(char[] banCo, char nguoiChoi)
        {
            int[][] cacDuongThang = new int[][]
            {
                     // Hàng 1
                    new int[] { 0, 1, 2 },
                    // Hàng 2
                    new int[] { 3, 4, 5 },
                    // Hàng 3
                    new int[] { 6, 7, 8 },
                    // Cột 1
                    new int[] { 0, 3, 6 },
                    // Cột 2
                    new int[] { 1, 4, 7 },
                    // Cột 3
                    new int[] { 2, 5, 8 },
                    // Đường chéo chính
                    new int[] { 0, 4, 8 },
                     // Đường chéo phụ
                    new int[] { 2, 4, 6 }
            };
            // Duyệt qua từng đường thẳng chiến thắng
            foreach (int[] duongThang in cacDuongThang)
            {
                // Kiểm tra xem cả ba ô trong đường thẳng đó có cùng là ký tự của người chơi đang kiểm tra không
                if (banCo[duongThang[0]] == nguoiChoi && banCo[duongThang[1]] == nguoiChoi && banCo[duongThang[2]] == nguoiChoi)
                {
                    // Nếu có, người chơi đó đã thắng
                    return true;
                }
            }
            // Nếu không có đường thẳng nào thỏa mãn, không ai thắng
            return false;
        }
        //Kiểm tra xem ván đấu có hòa hay không
        private bool KiemTraHoa(char[] banCo)
        {
            // Ván đấu hòa khi không còn ô trống nào (' ') trên bàn cờ và chưa có ai thắng
            // Phương thức Contains kiểm tra xem mảng banCo có chứa ký tự ' ' hay không.
            // Nếu không chứa (nghĩa là tất cả các ô đều đã được đánh), thì đó là hòa.
            return !banCo.Contains(' ');
        }

        private void Ban_Co_Load(object sender, EventArgs e)
        {
            // Khởi động lại timer (nếu bạn muốn tính thời gian cho mỗi ván)
            StartTimer();
        }

        // Các hàm xử lý sự kiện click cho từng nút bấm trên bàn cờ
        // Mỗi hàm này chỉ đơn giản gọi phương thức XuLyClickNut và truyền vào nút tương ứng
        private void button1_Click(object sender, EventArgs e)
        {
            XuLyClickNut(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XuLyClickNut(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XuLyClickNut(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XuLyClickNut(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            XuLyClickNut(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            XuLyClickNut(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            XuLyClickNut(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            XuLyClickNut(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            XuLyClickNut(button9);
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

        private void btnRoi_Click(object sender, EventArgs e)
        {
            this.Close();
            TIC_TAC_TOE ttt = new TIC_TAC_TOE();
            ttt.Show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            KhoiTaoBanCo();
        }
    }
}
