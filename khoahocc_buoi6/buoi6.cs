using System;

namespace khoahocc_buoi6
{
    class buoi6
    {
        //Cách khai báo biến toàn cục
        static int[,] m_mang_int;
        static int[] m_int = new int[5] { 4, 1, 6, 2, 8 };
        static void Main()
        {
            //Mảng 1 chiều , 2 chiều và vòng For, For each
            //Mảng 1 chiều
            //a.khai báo: Kiểu dữ liệu [] tên mảng = newKiểu dữ liệu[ số giá trị ]
            //vd: khai báo mảng 1 chiều có kiểu nguyên : int[]_manglnt = newint[3];   chỉ số sẽ chạy từ 0>2
            //b.khai báo và khởi tạo các giá trị cho mảng: Kiểu dữ liệu[] Tên mảng = new Kiểu dữ liệu [Số giá trị] {A1,A2,A3,....A số giá trị}
            //vd: mảng 1 chiều có kiểu chuỗi: string[]mangchuoi = new string [3]{"a", "b","c" };
            //Mảng 2 chiều
            //a.khai báo: Kiểu dữ liệu [,] tên mảng = newKiểu dữ liệu[ số hàng ,cột ]
            //b.khai báo và khởi tạo các giá trị cho mảng: Kiểu dữ liệu[,] Tên mảng = new Kiểu dữ liệu [Số hàng,cột] {{A11,A12},{A21,A22}}
    
            //Phan6_1();
            //Phan6_2();
            //Phan6_3();
            //Phan6_4();
            Phan6_5();
        }
        static void Phan6_1()
        {
            //Mảng 1 chiều
            //b.khai báo và khởi tạo các giá trị cho mảng: Kiểu dữ liệu[] Tên mảng = new Kiểu dữ liệu [Số giá trị] {A1,A2,A3,....A số giá trị}
            //vd: mảng 1 chiều có kiểu chuỗi: string[]mangchuoi = new string [3]{"a", "b","c" };
            string[] _mang_str = new string[3] { "Phan tu 1", "Phan tu 2", "Phan tu 3" }; //0,1,2
            Console.Write(_mang_str[1]);
            Console.ReadLine();
        }
        static void Phan6_2()
        {
            //Mảng 2 chiều
            //a.khai báo: Kiểu dữ liệu [,] tên mảng = newKiểu dữ liệu[ số hàng ,cột ]
            //b.khai báo và khởi tạo các giá trị cho mảng: Kiểu dữ liệu[,] Tên mảng = new Kiểu dữ liệu [Số hàng,cột] {{A11,A12},{A21,A22}}
            m_mang_int = new int[3, 4] { { 3, 54, 2, 3 },{4, 5, 6, 7}, { 8,9,10,11} };
            //int[,] _mang_int = new int[3, 4] { { 0, 1, 2, 3 }, { 4, 5, 6, 7 }, { 8, 9, 10, 11 } }; //khi chưa khai báo biến toàn cục
            /*Console.Write(m_mang_int[1, 0]);
            Console.ReadLine();*/
        }
        static void Phan6_3()
        {
            Phan6_2(); //Gọi phần 6_2 để khởi tạo mảng 2 chiều
            //For
            /*for ([Khoi tao]; [dieu kien];[buoc lap])
            {
                <Khoi lenh>
            }*/
            for (int i = 0; i<4;i++)
            {
                Console.Write("{0} \t", m_mang_int[0,i]);
            }
            Console.ReadLine();

        }
        static void Phan6_4()
        {
            //for each
            foreach(int _int_tam in m_int)
            {
                Console.Write("{0} \t", _int_tam);
            }
            Console.ReadLine();
        }
        static void Phan6_5()
        {
            //Mảng đa chiều ko cố định
            //trong đó int[] là kiểu dữ liệu
            int[][] _mang2_int = //khai báo mảng 1 chiều nhưng bên trong là nhiều mảng khác
            {
                new int[] {1,2,3},
                new int[] {4,3,5,2,6},                    //khai báo các mảng 1 chiều 
                new int[] {2,3,7,8,5,8}

            };
            //In ra màn hình mảng 2 chiều
            //Sử dụng 2 vòng for
            foreach (int[] _mang_int_tam in _mang2_int)
            {
                foreach (int _int_tam in _mang_int_tam)
                {
                    Console.Write("{0}\t", _int_tam);
                }
                Console.WriteLine("");
                
            }
            Console.ReadLine();
        }
        
    }
}