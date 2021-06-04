using System;

namespace khoahocc_buoi_3
{
    class buoi3
    {
        static void Main()
        {
            //Phan1();
            //Phan2();
            BaiTap();
        }
        static void Phan1()
        {
            //1:Kiểu dữ liệu
            Console.Write(" \' \" \\ \0 \a \b ");
            Console.ReadLine();
            //2:ép kiểu dữ liệu
            //2.1: ép kiểu ngầm định
            short x = 10;
            int y = x;
            //2.2 ép kiểu tường minh
            int a = 256;
            double b = (double)a;
            //string c = (string) b; khong duoc
            //2.3 phương thức parse
            string _str = "10";
            int _int = int.Parse(_str); //NHỚ
            Console.ReadLine();
        }
        static void Phan2()
        {
            //cấu trúc điều kiện
            //ví dụ 2.1
            Console.WriteLine("Vi du 2.1: ");
            Console.Write("So nguyen can kiem tra la, N = ");
            string _str_N = Console.ReadLine();
            int _int_N = int.Parse(_str_N);
            string _KetQua_A = "";
            //a
            if (_int_N % 2 == 0)
            {
                _KetQua_A = "So chan ";
            }
            else
            {
                _KetQua_A = "So le ";
            }
            Console.WriteLine("N la " + _KetQua_A);
            //b
            string _KetQua_B = "";
            if (_int_N < 0)
            {
                _KetQua_B = "So am";
            }
            else
            {
                _KetQua_B = "So duong";
            }
            Console.WriteLine("N la " + _KetQua_B);
            Console.ReadLine();
        }
        static void BaiTap()
        {
            //Yêu cầu sử dụng lệnh điều kiện If else:
            // a) Kiểm tra các ngoại lệ khi nhập tên
            //Không nhập gì.
            //Nhập quá ngắn.
            //Nhập quá dài.
            //Nhâp số
            // b) Kiểm tra các ngoại lệ khi nhập điểm:
            //Không nhập gì.
            //kiếm tra nó là số ha không
            //Nhập điểm âm
            //Nhập quá phạm vi 0 đến 10.
            //Nhập chữ
            Console.WriteLine("Bai tap 1: Nhap thong tin sinh vien: ");
            //string _Hoten_KQ = NhapTen();// a)
            //Console.WriteLine("Xin chao ban " + _Hoten_KQ); // a)
            double _DiemHoa = NhapDiem("Hoa");
            double _DiemToan = NhapDiem("Toan");
            double _DiemLy = NhapDiem("Ly");
            Console.WriteLine("Diem mon hoa cua ban la: {0} đ", _DiemHoa);
            Console.WriteLine("Diem mon hoa cua ban la: {0} đ", _DiemToan);
            Console.WriteLine("Diem mon hoa cua ban la: {0} đ", _DiemLy);
            double _DTB = (_DiemHoa + _DiemLy + _DiemToan) / 3;
            string _HocLuc = Danhgiahocluc(_DTB);
            Console.WriteLine("Hoc luc cua ban la : {0} ", _HocLuc);
            Console.ReadLine();
        }
        static string NhapTen() // loi o day nay
        {
            Console.Write("Ho ten cua ban la: ");
            string _Hoten = Console.ReadLine();
            if (_Hoten != "" && _Hoten != " ") //cach 1 : kiểm tra rỗng
            {
                if (!char.IsNumber(_Hoten, 0)) //kiểm tra nó là số hay không
                {
                    if (_Hoten.Length >3) //kiem tra nhap qua ngan
                    {
                        return _Hoten;
                    }
                    else
                    {
                        Console.WriteLine("Ho ten cua ban qua ngan! ");
                        NhapTen();
                    }
                }
                else
                {
                    Console.WriteLine("Khong duoc nhap so vao ho ten! ");
                    NhapTen();
                }
            }
            else
            {
                Console.WriteLine("Ban chua nhap ho ten cua ban ! ");
                NhapTen();
            }
            //if (string.IsNullOrEmpty(_Hoten)) && string.IsNullOrWhiteSpace(_Hoten))
            //{

            //}
            return ""; // bo di se loi
        }
        static double NhapDiem(string _TenMonHoc)
        {
            double _dbl_Diem = 0.0;
            Console.Write("Diem mon {0} ban la: ", _TenMonHoc);
            string _str_Diem = Console.ReadLine();
            if (_str_Diem != "" && _str_Diem != " ") // DK1: kiem tra rong
            {
                if (char.IsNumber(_str_Diem,0)) // DK2 : kiem tra la so hay khong
                {
                    _dbl_Diem = double.Parse(_str_Diem);
                    if (_dbl_Diem >= 0) // DK3 : kiem tra nhap so am
                    {
                        if (_dbl_Diem <= 10) // DK4 : kiem tra >0 <10
                        {
                            return _dbl_Diem;
                        }
                        else
                        {
                            Console.WriteLine("Diem khong hop ly! ");
                            NhapDiem(_TenMonHoc);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ban phai nhap so duong! ");
                        NhapDiem(_TenMonHoc);
                    }
                }
                else
                {
                    Console.WriteLine("Ban phai nhap so! ");
                    NhapDiem(_TenMonHoc);
                }
            }
            else
            {
                Console.WriteLine("Ban chua nhap diem! ");
                NhapDiem(_TenMonHoc);
            }
            return _dbl_Diem;
        }
        static string Danhgiahocluc(double _DTB)
        {
            string _HocLuc = "";
            if (_DTB >=0 && _DTB <5)
            {
                _HocLuc = "Trung Binh";
            }
            else if (_DTB >=5 && _DTB <7)
            {
                _HocLuc = "Kha";
            }
            else if (_DTB >= 7 && _DTB < 10)
            {
                _HocLuc = "Gioi";
            }
                return _HocLuc;
        }
    }
}
