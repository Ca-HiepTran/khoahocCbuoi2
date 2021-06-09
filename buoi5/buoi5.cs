using System;

namespace buoi5
{
    class buoi5
    {
        static void Main()
        {
            //Phan5_1();
            //Phan5_2();
            //Phan5_3();
            //BaiTapBuoi5();
            BaiTapBuoi5_1();
        }
        static void Phan5_1()
        {
            //Buổi 5
            //5.1 Switch case
            //switch (_BienKiemTra)
            // {
            // case _KetQua1: [Lệnh thực thi 1];
            // case _KetQua2: [Lệnh thực thi 2];
            // }
            //VD :  in ra thứ
            Console.Write("Nhap so de kiem tra: ");
            string _BienKiemTra = Console.ReadLine();
            switch (_BienKiemTra)
            {
                case "1":
                    Console.Write("Hom nay la chu nhat !");
                    break;
                case "2":
                    Console.Write("Hom nay la thu hai !");
                    break;
                case "3":
                    Console.Write("Hom nay la thu ba !");
                    break;
                case "4":
                    Console.Write("Hom nay la thu tu !");
                    break;
            }
            Console.ReadLine();
        }
        static void Phan5_2()
        {
            //While
            //While ([Dieu kien dung])
            //{
            // Lệnh thực nếu đúng
            //}
            //VD:
            int i = 0;
            while (i<=20)
            {
                i++;
                if (i % 2 == 0)
                {
                    Console.Write("{0,-5} \n", i);
                }
                else
                {
                    Console.Write("{0,-5} ", i);
                }
                //i++; // tac dung nhu nhau nhung tuy muc dich thi de tren duoi
            }
            Console.ReadLine();
        }
        static void Phan5_3()
        {
            //Do.....While
            //Do
            //{
            //Cách lệnh  đúng
            //}
            //While ( điểu kiện để dừng )
            int i = 0;
            do
            {
                i++;
                if (i % 2 != 0)
                {
                    Console.Write("{0,-5} \n", i);
                }
                else
                {
                    Console.Write("{0,-5} ", i);
                }
                //i++; // tac dung nhu nhau nhung tuy muc dich thi de tren duoi
            }
            while (i <= 20);
            Console.ReadLine();
        }  
        static void BaiTapBuoi5()
        {
            //Bài tập 1 : Nhâp cho tên cho đến lúc dừng
            string _KiemTra = "Y";// khởi tạo biến kiểm tra bằng Y để bắt đàu
            int i = 1;// Khởi tạo biến đếm
            while (_KiemTra == "Y")// Nếu _Kiemtra = "Y" thì tiếp tục
            {
                Console.Write("({0}) Ho ten ban la gi ? Minh ten la: ", i );
                string _Hoten = Console.ReadLine();
                Console.WriteLine("Xin chao " + _Hoten);
                Console.Write("Ban muon tiep tuc hay khong(Y/N): ");
                _KiemTra = Console.ReadLine().ToUpper();
                i++;
            }
            Console.WriteLine("Ban da dung!");
            Console.ReadLine();
        }
        static void BaiTapBuoi5_1()
        {
            Console.Write("Nhap so muon chay den, N = ");
            string _str_N = Console.ReadLine();
            int _int_N = int.Parse(_str_N);
            int i = 0;
            while (i <= _int_N)// Điều kiện đúng
            {
                //Lệnh thực thi khi đk đúng
                Console.Write("{0}\t", i);
                i++; //i+=2 ( in ra số chẵn ) i+=3 ( chia hết cho 3  )
            }

            Console.ReadLine();
        }
    }
}
