using System;
using System.Collections.Generic;
using System.Collections;
using ConsoleApp2;
using ConsoleApp1;
using ConsoleApp3; 
namespace doanGT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.Clear();

            Console.WriteLine("DANH SÁCH NHÂN VIÊN THUỘC CÔNG TY DS001\n");
            List<nhanvien> list = new List<nhanvien>();
            list.Add(new nhanvien(4493, "Lý Thiên A", 20, 1.5, 7, "Có"));
            list.Add(new nhanvien(2910, "Võ Ngọc B", 21, 2.4, 3, "Có"));
            list.Add(new nhanvien(1182, "Đoàn Anh C", 35, 1.6, 4, "Có"));
            list.Add(new nhanvien(4519, "Đoàn Minh D", 40, 2.4, 2, "Không"));
            list.Add(new nhanvien(4506, "Nguyễn Nhật E", 50, 1.3, 1, "Không"));
            Binarytree binarytree = new Binarytree();
            for (int i = 0; i < 5; i++)
            {
                binarytree.Insert(list[i]);
            }
            binarytree.TraverseInOrder(binarytree.root);
            int timkiem;

            do
            {
                //MENU
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("                -  ĐỒ ÁN: CẤU TRÚC DỮ LIỆU VÀ GIẢI THUẬT  -               ");
                Console.WriteLine("                          NHÓM 2 - LỚP: DS001                           \n");
                Console.WriteLine("*************** MENU CHƯƠNG TRÌNH TÌM KIẾM NHÂN VIÊN  ****************");
                Console.WriteLine("*                                                                        *");
                Console.WriteLine("*        1. Chèn thêm thông tin nhân viên và in ra danh sách mới         *");
                Console.WriteLine("*        2. Tra cứu thông tin nhân viên theo ID                          *");
                Console.WriteLine("*        3. Tra cứu thông tin nhân viên theo họ tên                      *");
                Console.WriteLine("*        4. Tra cứu thông tin nhân viên thuộc khoảng tuổi cần tìm        *");
                Console.WriteLine("*        5. Thông tin nhân viên có độ tuổi lớn nhất và bé nhất           *");
                Console.WriteLine("*        6. Tra cứu hệ số lương của nhân viên thuộc khoảng cần tìm       *");
                Console.WriteLine("*        7. Tra cứu bảo hiểm nhân viên đã có/chưa có                     *");
                Console.WriteLine("*        8. Xóa nhân viên nghỉ quá số ngày quy định                      *");
                Console.WriteLine("*        9. Thoát menu chương trình                                      *");
                Console.WriteLine("*                                                                        *");
                Console.WriteLine("**************************************************************************\n");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Yêu cầu tìm kiếm bạn cần là: ");
                timkiem = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                switch (timkiem)
                {
                    case 1:
                        
                            Console.WriteLine("Chèn thêm thông tin nhân viên và in ra danh sách mới ");
                            Console.WriteLine("....................................................\n");
                            Console.WriteLine("Danh sách sau khi chèn thêm nhân viên:");
                            list.Add(new nhanvien(4482, "Nguyễn Nhật F", 50, 1.9, 1, "Không"));
                            for (int i = 0; i < list.Count; i++)
                            {
                                binarytree.Insert(list[i]);
                            }
                            binarytree.Print();

                        
                        break;

                    case 2:
                        
                            Console.WriteLine("Tra cứu thông tin nhân viên theo ID");
                            Console.WriteLine("...................................\n");
                            Console.Write("Nhập số ID muốn tìm: ");
                            int ID = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("\nNhân viên có ID {0} là:", ID);
                            if (binarytree.timID(ID, binarytree.root) == null)
                            {
                                Console.WriteLine("Không tồn tại nhân viên nào có ID là {0}.", ID);
                            }
                            else
                            {
                                Console.WriteLine(binarytree.timID(ID, binarytree.root).Data);
                            }

                        

                        break;

                    case 3:
                        
                            Console.WriteLine("Tra cứu thông tin nhân viên theo họ tên");
                            Console.WriteLine(".......................................\n");
                            Console.Write("Nhập họ tên nhân viên bạn muốn tìm: ");
                            string hoten = Console.ReadLine().ToUpper();
                            int temp3 = 0;
                            Console.WriteLine("\nThông tin nhân viên {0}:", hoten.ToLower());
                            binarytree.timhoten(hoten.ToLower(), binarytree.root, ref temp3);
                            if (temp3 == 0)
                            {
                                Console.WriteLine("Không có nhân viên nào có dữ liệu thỏa yêu cầu tìm kiếm.");
                            }

                        
                        break;

                    case 4:
                        Console.WriteLine("Tra cứu thông tin nhân viên thuộc khoảng tuổi cần tìm");
                        Console.WriteLine(".....................................................\n");
                        Console.Write("Tuổi nhỏ nhất bạn muốn tìm: ");
                        int min = int.Parse(Console.ReadLine());
                        Console.Write("Tuổi lớn nhất bạn muốn tìm: ");
                        int max = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nDanh sách nhân viên có độ tuổi trong khoảng yêu cầu tìm kiếm từ {0} đến {1} là:", min, max);
                        int temp4 = 0;
                        binarytree.timTuoi(min, max, binarytree.root, ref temp4);
                        if (temp4 == 0)
                        {
                            Console.WriteLine("Không có nhân viên nào có dữ liệu thỏa yêu cầu tìm kiếm.");
                        }

                        break;

                    case 5:
                        Console.WriteLine("Tra cứu thông tin nhân viên có độ tuổi nhỏ nhất và lớn nhất");
                        Console.WriteLine("..........................................................\n");
                        Console.Write("Nhân viên có độ tuổi nhỏ nhất: ");
                        binarytree.print_min();
                        Console.Write("Nhân viên có độ tuổi lớn nhất: ");
                        binarytree.print_max();
                        break;

                    case 6:
                        Console.WriteLine("Tra cứu hệ số lương của nhân viên thuộc khoảng cần tìm");
                        Console.WriteLine(".....................................................\n");
                        Console.Write("Hệ số lương nhỏ nhất bạn cần tìm: ");
                        double hsl1 = double.Parse(Console.ReadLine());
                        Console.Write("Hệ số lương lớn nhất bạn cần tìm: ");
                        double hsl2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("\nDanh sách nhân viên có hệ số lương khoảng yêu cầu tìm kiếm từ {0} đến {1} là:", hsl1, hsl2);
                        int temp6 = 0;
                        binarytree.timhsl(hsl1, hsl2, binarytree.root, ref temp6);
                        if (temp6 == 0)
                        {
                            Console.WriteLine("Không có nhân viên nào có dữ liệu thỏa yêu cầu tìm kiếm.");
                        }

                        break;

                    case 7:
                        Console.WriteLine("Tra cứu bảo hiểm nhân viên đã có/chưa có");
                        Console.WriteLine("........................................\n");
                        Console.Write("Bạn muốn tìm nhân viên CÓ hay KHÔNG CÓ bảo hiểm ? Vui lòng nhập có hoặc không: ");
                        string BH = Console.ReadLine().ToUpper();
                        int temp7 = 0;
                        Console.WriteLine("Danh sách các nhân viên {0} bảo hiểm:", BH.ToLower());
                        binarytree.timBH(BH.Replace(" ", ""), binarytree.root, ref temp7);
                        if (temp7 == 0)
                        {
                            Console.WriteLine("Không có nhân viên nào có dữ liệu thỏa điều kiện tìm kiếm.");
                        }

                        break;

                    case 8:
                        Console.WriteLine("Xóa nhân viên nghỉ quá số ngày quy định");
                        Console.WriteLine(".......................................\n");
                        Console.Write("Số ngày nghỉ theo quy định: ");
                        int ngaynghi = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nDanh sách nhân viên sau khi xóa vì nghỉ quá {0} ngày:", ngaynghi);
                        binarytree.print_Remove(binarytree.root, ngaynghi);

                        break;

                    case 9:
                        Console.WriteLine("Đã thoát chương trình.");

                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("KHÔNG TÌM THẤY YÊU CẦU BẠN TÌM KIẾM. XIN VUI LÒNG NHẬP LẠI NHÉ ...");
                        break;
                }
            } while (timkiem != 9);
            Console.ReadLine();
        }
    }
}







   