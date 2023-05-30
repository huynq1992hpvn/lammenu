using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("1. In hinh chu nhat");
                Console.WriteLine("2. In hinh tam giac vuong");
                Console.WriteLine("3. In tam giac can");
                Console.WriteLine("4. Thoat");
                Console.WriteLine("Nhap vao lua chon cua ban");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("nhap vao chieu rong");
                        int chieurong = int.Parse(Console.ReadLine());
                        Console.WriteLine("nhap vao chieu rong");
                        int chieudai = int.Parse(Console.ReadLine());
                        for (int i = 0; i < chieurong; i++)
                        {
                            for (int j = 0; j < chieudai; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        Console.WriteLine("nhap vao kich thuoc hinh tam giac");
                        // in tam giac vuong o top-left
                        int size = int.Parse(Console.ReadLine());
                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j <= i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine();
                        // in tam giac vuong o top-right
                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j < size - i - 1; j++)
                            {
                                Console.Write(" ");
                            }
                            for (int j = 0; j <= i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine();
                        // In tam giác vuông có cạnh góc vuông ở bottom-left
                        Console.WriteLine("Bottom-left triangle:");
                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j < size - i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine();

                        // In tam giác vuông có cạnh góc vuông ở bottom-right
                        Console.WriteLine("Bottom-right triangle:");
                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                Console.Write(" ");
                            }
                            for (int j = 0; j < size - i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Console.WriteLine("nhap vao chieu cao cua tam giac can");
                        int chieucao = int.Parse(Console.ReadLine());
                        for (int i = 0; i < chieucao; i++)
                        {
                            for (int j = 0; j < chieucao - i - 1; j++)
                            {
                                Console.Write(" ");
                            }
                            for (int j = 0; j < 2 * i + 1; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        Console.WriteLine("thoat chuong trinh");
                        break;
                    default:
                        Console.WriteLine("nhap sai du lieu");
                        break;
                }
                Console.WriteLine();

            }while (choice != 4);
        }
    }
}
