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
    public partial class TIC_TAC_TOE: Form
    {
        private Ban_Co ban_Co;

        public static Image PlayerImage { get; private set; }
        public static Image ComputerImage { get; private set; }
        // Khai báo một biến private string để lưu trữ ký hiệu của người chơi "X"
        private string playerSymbol;

        // Khai báo một biến private string để lưu trữ ký hiệu của máy tính "X"
        private string computerSymbol;
        // Khai báo các biến private string để lưu trữ đường dẫn đến các tệp hình ảnh.

        // Đường dẫn mặc định cho hình ảnh 'X'. Cần thay bằng đường dẫn thực tế.
        private string xImagePath = "x.png";
        // Đường dẫn mặc định cho hình ảnh 'O'. Cần thay bằng đường dẫn thực tế.
        private string oImagePath = "o.png";

        // Khai báo các biến private string để lưu trữ tên hiển thị của người chơi và máy tính.
        private string playerDisplayName = "Người chơi";
        private string computerDisplayName = "Máy tính";

        // Khai báo một danh sách private List để lưu trữ các cặp hình ảnh (hình ảnh 'O', hình ảnh 'X').
        private List<Tuple<Image, Image>> imagePairs = new List<Tuple<Image, Image>>();

        // Khai báo một biến private int để theo dõi chỉ số của cặp hình ảnh hiện tại đang được hiển thị.
        private int VT = 0;

        public TIC_TAC_TOE()
        {
            InitializeComponent();
            // Tạo instance của Form bàn cờ
            ban_Co = new Ban_Co();
            ban_Co.Owner = this;
        }

        // Phương thức private để tải các cặp hình ảnh từ tệp vào danh sách imagePairs.
        private void LoadImagePairs()
        {
            // Sử dụng khối try-catch để xử lý các lỗi có thể xảy ra khi tải tệp hình ảnh.
            try
            {
                // Thêm một cặp hình ảnh mới vào danh sách.
                // Tuple.Create tạo một tuple chứa hai đối tượng Image được tải từ các tệp.
                imagePairs.Add(Tuple.Create(Image.FromFile("o.png"), Image.FromFile("x.png")));
                // Thêm một cặp hình ảnh khác vào danh sách.
                imagePairs.Add(Tuple.Create(Image.FromFile("o1.png"), Image.FromFile("x1.png")));
                // Thêm một cặp hình ảnh khác vào danh sách.
                imagePairs.Add(Tuple.Create(Image.FromFile("o2.png"), Image.FromFile("x2.png")));

                // Bạn có thể thêm các cặp hình ảnh khác vào đây nếu cần, ví dụ:
                // imagePairs.Add(Tuple.Create(Image.FromFile("o3.png"), Image.FromFile("x3.png")));
            }
            catch (Exception ex)
            {
                // Nếu có bất kỳ lỗi nào xảy ra trong quá trình tải ảnh (ví dụ: tệp không tồn tại),
                // hiển thị một hộp thoại thông báo lỗi cho người dùng.
                MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}", "Lỗi");
            }
        }

        private void TIC_TAC_TOE_Load(object sender, EventArgs e)
        {
            // Thiết lập ký hiệu mặc định cho người chơi là "X".
            playerSymbol = "X";
            // Thiết lập ký hiệu mặc định cho máy tính là "O".
            computerSymbol = "O";

            // Gọi phương thức LoadImagePairs để tải các cặp hình ảnh vào danh sách.
            LoadImagePairs();

            /* ThayDoiAnh();*/ // Đoạn code này bị comment lại, có thể là một phương thức không còn được sử dụng.

            // Sử dụng khối try-catch để xử lý các lỗi có thể xảy ra khi tải tệp hình ảnh (lặp lại việc tải ảnh).
            try
            {
                // Thêm cặp ảnh 1 vào danh sách.
                imagePairs.Add(Tuple.Create(Image.FromFile("o.png"), Image.FromFile("x.png")));
                // Thêm cặp ảnh 2 vào danh sách.
                imagePairs.Add(Tuple.Create(Image.FromFile("o1.png"), Image.FromFile("x1.png")));
                // Thêm cặp ảnh 3 vào danh sách.
                imagePairs.Add(Tuple.Create(Image.FromFile("o2.png"), Image.FromFile("x2.png")));
                // ... Thêm các cặp ảnh khác nếu cần ...

                // Hiển thị cặp ảnh đầu tiên khi form được tải.
                if (imagePairs.Count > 0)
                {
                    // Gán hình ảnh 'O' của cặp đầu tiên cho picO.
                    picO.Image = imagePairs[VT].Item1;
                    // Gán hình ảnh 'X' của cặp đầu tiên cho picX.
                    picX.Image = imagePairs[VT].Item2;
                }
            }
            catch (Exception ex)
            {
                // Nếu có lỗi xảy ra khi tải ảnh, hiển thị thông báo lỗi.
                MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}", "Lỗi");
            }

            //Mặc định là 2 hình ảnh X O đầu tiên
            PlayerImage = imagePairs[VT].Item1;
            ComputerImage = imagePairs[VT].Item2;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {

            // Tăng chỉ số VT để chuyển sang cặp ảnh tiếp theo trong danh sách.
            VT++;

            // Kiểm tra nếu đã đến cuối danh sách các cặp ảnh.
            if (VT >= imagePairs.Count)
            {
                // Nếu đã đến cuối, đặt lại chỉ số VT về 0 để quay lại cặp ảnh đầu tiên.
                VT = 0;
            }

            // Kiểm tra nếu danh sách imagePairs có chứa ít nhất một cặp ảnh.
            if (imagePairs.Count > 0)
            {
                // Cập nhật thuộc tính Image của PictureBox picO bằng hình ảnh 'O' từ cặp ảnh hiện tại.
                picO.Image = imagePairs[VT].Item1;
                // Cập nhật thuộc tính Image của PictureBox picX bằng hình ảnh 'X' từ cặp ảnh hiện tại.
                picX.Image = imagePairs[VT].Item2;
                // Cập nhật thuộc tính static PlayerImage bằng hình ảnh hiện tại của picX.
                PlayerImage = picX.Image;
                // Cập nhật thuộc tính static ComputerImage bằng hình ảnh hiện tại của picO.
                ComputerImage = picO.Image;
            }

        }

        private void btnDoiViTri_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu danh sách imagePairs có chứa ít nhất một cặp ảnh.
            if (imagePairs.Count > 0)
            {
                // Lấy cặp ảnh hiện tại dựa trên chỉ số VT.
                Tuple<Image, Image> currentPair = imagePairs[VT];

                // Tạo một cặp ảnh mới bằng cách đảo ngược thứ tự của hai hình ảnh trong cặp hiện tại.
                Tuple<Image, Image> reversedPair = Tuple.Create(currentPair.Item2, currentPair.Item1);

                // Cập nhật cặp ảnh tại vị trí VT trong danh sách imagePairs bằng cặp ảnh đã đảo ngược.
                imagePairs[VT] = reversedPair;

                // Cập nhật hiển thị trên các PictureBox.
                // Gán hình ảnh đầu tiên của cặp đảo ngược (ban đầu là 'X') cho picO.
                picO.Image = reversedPair.Item1;
                // Gán hình ảnh thứ hai của cặp đảo ngược (ban đầu là 'O') cho picX.
                picX.Image = reversedPair.Item2;
                // Cập nhật PlayerImage bằng hình ảnh hiện tại của picX (sau khi đổi chỗ).
                PlayerImage = picX.Image;
                // Cập nhật ComputerImage bằng hình ảnh hiện tại của picO (sau khi đổi chỗ).
                ComputerImage = picO.Image;
            }
        }

        private void picX_Click(object sender, EventArgs e)
        {
            // Gán hình ảnh hiện tại của picX cho thuộc tính static PlayerImage.
            PlayerImage = picX.Image;

            // Gán hình ảnh hiện tại của picO cho thuộc tính static ComputerImage.
            ComputerImage = picO.Image;

            // Đặt kiểu viền của picX thành FixedSingle để cho biết nó đã được chọn.
            picX.BorderStyle = BorderStyle.FixedSingle;

            // Bỏ kiểu viền của picO (đặt thành None).
            picO.BorderStyle = BorderStyle.None;
        }

        private void picO_Click(object sender, EventArgs e)
        {
            // Gán hình ảnh hiện tại của picO cho thuộc tính static PlayerImage.
            PlayerImage = picO.Image;

            // Gán hình ảnh hiện tại của picX cho thuộc tính static ComputerImage.
            ComputerImage = picX.Image;

            // Đặt kiểu viền của picO thành FixedSingle để cho biết nó đã được chọn.
            picO.BorderStyle = BorderStyle.FixedSingle;

            // Bỏ kiểu viền của picX (đặt thành None).
            picX.BorderStyle = BorderStyle.None;

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
            // Tạo một instance mới của hộp thoại chọn màu (ColorDialog).
            ColorDialog mauNen = new ColorDialog();

            // Hiển thị hộp thoại chọn màu và kiểm tra kết quả trả về.
            // DialogResult.OK cho biết người dùng đã chọn một màu và nhấn nút OK.
            if (mauNen.ShowDialog() == DialogResult.OK)
            {
                // Thay đổi màu nền (BackColor) của form hiện tại (this) bằng màu mà người dùng đã chọn từ hộp thoại.
                this.BackColor = mauNen.Color;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem instance của form bàn cờ (frmBanCo) có tồn tại hay không (không phải là null).
            if (ban_Co != null)
            {
                // Gán hình ảnh đã chọn từ form TIC_TAC_TOE (lưu trong PlayerImage và ComputerImage của nó)
                // vào các thuộc tính static của lớp Ban_Co.
                // Các thuộc tính static này sẽ được form Ban_Co sử dụng để hiển thị ảnh trên các nút.
                Ban_Co.NguoiChoiImage = PlayerImage; // Gán ảnh Người chơi
                Ban_Co.MayTinhImage = ComputerImage; // Gán ảnh Máy tính

                // Gán hình ảnh đã chọn cho người chơi (PlayerImage) vào PictureBox picX trên form bàn cờ.
                ban_Co.picX.Image = PlayerImage;
                // Gán hình ảnh đã chọn cho máy tính (ComputerImage) vào PictureBox picO trên form bàn cờ.
                ban_Co.picO.Image = ComputerImage;
                // Thiết lập chế độ hiển thị ảnh của picX trên form bàn cờ là StretchImage,
                // để hình ảnh tự động điều chỉnh kích thước vừa với PictureBox.
                ban_Co.picX.SizeMode = PictureBoxSizeMode.StretchImage;
                // Thiết lập chế độ hiển thị ảnh của picO trên form bàn cờ là StretchImage.
                ban_Co.picO.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            // Hiển thị form bàn cờ.
            ban_Co.Show();
            // Gọi phương thức StartTimer() trên form bàn cờ để bắt đầu bộ đếm thời gian (nếu có).
            ban_Co.StartTimer();
            // Ẩn form menu hiện tại (tùy chọn, có thể muốn giữ lại form menu).
            this.Hide();
        }
    }
}
