using System;

namespace khoahocc_buoi4
{
    class buoi4
    {
        static void Main() // Mặc định khi chạy sẽ chạy vào Main() trước
        {
            // Function ( phương thức )
            // phương thức 1 chiều :
               // Cấu trúc: Static void + [Tên phương thức] () {[Lệnh cần làm]};
               // VD: 
            //NV1();
            // phương thức 2 chiều (Function):
               // Cấu trúc:Static + kiểu dữ liệu đầu ra + [Tên phương thức] () {[Lệnh cần làm]};
               // VD:
            //int _Ketquanhanve = NV2();
            //Console.WriteLine("Ket qua tra ra la 4 + 5 = {0}", _Ketquanhanve);
            //Console.ReadLine();
            // phương thức 2 chiều có kèm theo (Function):
               // Cấu trúc:Static + kiểu dữ liệu đầu ra + [Tên phương thức] ([Kiểu dữ liệu đầu] vào TenBienKemTheo) {[Lệnh cần làm]};
               //VD:
            string _KetQuaNhanVe = NV3(5,6);
            Console.WriteLine("Ket qua nhan duoc", _KetQuaNhanVe);
            Console.ReadLine();
        }
        static void NV1() // phương thức 1 chiều :
        {
            Console.WriteLine("Day la nhiem vu 1 ");
            Console.ReadLine();
        }
        static int NV2() // phương thức 2 chiều (Function):
        {
            int _KetQuaDauRa = 0; // tạo biến đầu ra và khởi tạo biến
            _KetQuaDauRa = 4 + 5;
            //Console.WriteLine("Tra ra ket qua tong a + b = {0} ", _KetQuaDauRa);
            //Console.ReadLine();
            return _KetQuaDauRa; // trả lại kết quả
        }
        static string NV3(int _BienKemTheo)
        {
            string _Ketquadaura = "";
            if (_BienKemTheo % 2 == 0)
            {
                _Ketquadaura = "Chan";
            }
            else
            {
                _Ketquadaura = "Le";
            }
            return _Ketquadaura;
        }
        static string NV3(int _Biemkemtheo1, int _Bienkemtheo20) // phương thức 2 chiều có kèm theo (Function)
        {
            int _Ketquadaura = 0;// tạo biến đầu ra và khởi tạo biến
            _Ketquadaura = 4 + 5;
            return Convert.ToString(_Ketquadaura); // trả lại kết quả
        }
    }
}
