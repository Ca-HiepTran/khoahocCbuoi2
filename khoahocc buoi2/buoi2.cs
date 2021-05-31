using System;

namespace khoahocc_buoi2
{
    class buoi2
    {
        static void Main()
        {
            //Phan1_1();
            //Phan1_2();
            Phan1_3();
        }
        static void Phan1_1()
        {
            //    Phan 1.1
            //     buôi 2 : Biến , Hằng và các toán.
            //     cách in ra màn hình: VD: "chào mừng đến với ....."
            //    Console.Write("Chao mung den voi trung tam SPEC");
            //    Console.ReadLine();

            //    Khai báo biến
            //     <Kieu_du_Lieu> _Tenbien[= Gan gia tri];
            string _str = "3abc";
            int _int1 = 2;
            int _int2 = 2;
            double _dou = 2.2;
            //TH1: IN chuỗi
            Console.WriteLine("Chuoi vua khai bao: " + _str);
            //TH2: IN số thực ,số nguyên
            Console.WriteLine("so nguyen vua khai bao: {0} va {1}", _int1, _dou);
            Console.Write(_dou);

            Console.ReadLine();
        }
        //Cấu trúc: static void TenFunction(){Vùng code;}    
        static void Phan1_2()
        {
            //Nhập và đọc chuỗi vừa nhập vào màn hình.
            Console.Write("Ho va ten cua ban la gi? Ten minh la: ");
            string _HoTen = Console.ReadLine();
            Console.WriteLine("Xin chao ban " +  _HoTen);
            Console.WriteLine("So ky tu trong ten cua ban la: {0}", _HoTen.Length);
            Console.WriteLine("Ho ten in thuong: {0}",  _HoTen.ToLower());
            Console.WriteLine("HO TEN IN HOA: {0}", _HoTen.ToUpper());
            Console.WriteLine("Kiem tra co chu T: {0}", _HoTen.Contains("T"));
            //contains dung de xac dinh true false   Contains("phan dung lam chuan de xac dinh T F")
            Console.ReadLine();
        }

        static void Phan1_3()
        {
            //Toán tử
            Console.Write("Moi nhap so nguyen can kiem tra, N = ");
            string _str_SoNguyen = Console.ReadLine(); // đọc ký tự mà mình vừa ghi ra màn hình
            int _int_SoNguyen = Convert.ToInt32(_str_SoNguyen); //chuyển dạng biến từ chuỗi sang số nguyên
            //Toán tử 3 ngôi
            //a) kiểm tra chẵn lẻ
            string _ketqua_A = (_int_SoNguyen % 2 == 0) ? "So chan":"So le";
            Console.WriteLine("a) So N = {0} la {1}", _int_SoNguyen, _ketqua_A);
            
            //b) kiểm tra âm dương
            string _ketqua_B = (_int_SoNguyen >= 0) ? "So duong" : "So am";
            Console.WriteLine("b) So N = {0} la {1}", _int_SoNguyen, _ketqua_B);
            Console.ReadLine();

        }
    }
}
