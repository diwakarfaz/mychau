using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COBAO.DAL;
namespace COBAO.BLL
{
    class COBAOMessage
    {
        public static string dialogresult = "";
        //chung 
        public static NhanVien NguoiDungHienTai = null;
        public static bool NeedLogin = false;
        public static int AlertDelayTime = 5000;
        public static bool AutoCloseAlert = true;
        public static bool IsLogin;
        public static NhanVien nhanvien = new NhanVienProvider().nvlist("10000").First();

        public static string DANGNHAPTHATBAI = Environment.NewLine + "Đăng nhập thất bại";
        public static string DACONGUOIDUNG = Environment.NewLine + "Tên đăng nhập này đã tồn tại";
        public static string SAIMATKHAU = Environment.NewLine + "Mật khẩu này không đúng";
        public static string SAIDODAI = Environment.NewLine + "Độ dài không hợp lệ";
        public static string THEMTHANHCONG = Environment.NewLine + "Thêm mới thông tin thành công";
        public static string THEMTHATBAI = Environment.NewLine + "Thêm mới thông tin thất bại";
        public static string SUACHUATHANHCONG = Environment.NewLine + "Sửa chữa thông tin thành công";
        public static string XOATHANHCONG = Environment.NewLine + "Xoá thông tin thành công";
        public static string XOATHATBAI = Environment.NewLine + "Xoá thông tin thất bại";
        public static string KHONGDUOCTRONG = Environment.NewLine + "Thông tin này không được để trống";
        public static string DATONTAI = Environment.NewLine + "thông tin này đã tồn tại";

        public static string THAYDOITHANHCONG = Environment.NewLine + "Thay đổi đơn giá lương thành công";

        internal static System.Windows.Forms.DialogResult show(string p, string Text, System.Windows.Forms.MessageBoxButtons messageBoxButtons, System.Windows.Forms.MessageBoxIcon messageBoxIcon)
        {
            throw new NotImplementedException();
        }
    }
}
