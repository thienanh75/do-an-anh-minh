using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bien
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             <Kiểu dữ liêu> <Tên biến>;
             */
            int KieuSoNguyen= 5;
            float BienKieuSoThuc = 6.9f;
            string BienKieuChuoi = "Thomas - Family";
            bool BienKieuLuanLy = true;
            char BienKieuKyTu = 'A';

            //In gtrị của biến kiểu số nguyên ra màn hình => 5 
            Console.WriteLine(BienKieuChuoi);


            int aNum = 6;
            int bNum = 9;
            int cNum = aNum + bNum;

            Console.WriteLine("a + b = c : {0} + {1} = {2}", aNum, bNum, cNum);
            Console.ReadKey();
        }
    }
}


//BIẾN LÀ GÌ ? 
//biến -> có thể thay đổi
/*
    Biến: 
    * - Là 1 gtrị dữ liệu có thể thay đổi đc
    * - Là tên gọi tham chiếu đến 1 vùng nhứo nào đó trong 1g
    * - Là thành phần cốt lõi của 1 ngôn ngữ lập trình
    */

// => Why ???
/*
    * - Lưu trữ dữ liệu và tái sử dụng 
    * - Thao tác với bộ nhớ 1 cách dễ dàng
    */

