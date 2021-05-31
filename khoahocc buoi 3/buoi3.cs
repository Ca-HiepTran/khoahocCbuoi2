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
            //Nhập điểm âm
            //Nhập quá phạm vi 0 đến 10.
            //Nhập chữ
            Console.WriteLine("Bai tap 1: Nhap thong tin sinh vien: ");
            string _Hoten_KQ = NhapDiem();
            Console.WriteLine("Xin chao ban " + _Hoten_KQ);
            Console.ReadLine();
        }
        private static string NhapDiem() // loi o day nay
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
                        NhapDiem();
                    }
                }
                else
                {
                    Console.WriteLine("Khong duoc nhap so vao ho ten! ");
                    NhapDiem();
                }
            }
            else
            {
                Console.WriteLine("Ban chua nhap ho ten cua ban ! ");
                NhapDiem();
            }
            //if (string.IsNullOrEmpty(_Hoten)) && string.IsNullOrWhiteSpace(_Hoten))
            //{

            //}
            return ""; // bo di se loi
        }
    }
}
