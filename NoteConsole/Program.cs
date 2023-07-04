using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteConsole
{
    class Program
    {
        public static void Them_ghi_chu(string name)
        {
            int type;
            Console.WriteLine("      |---------Ban nhap 1 hay n ghi chu?----|");
            Console.WriteLine("      |-------------1. Mot ghi chu-----------|");
            Console.WriteLine("      |-------------2. Nhieu ghi chu---------|");
            Console.WriteLine("      |-------------3. Cancel----------------|");

            Console.Write("Nhap lua chon: ");
            type = Convert.ToInt32(Console.ReadLine());
            switch (type)
            {
                case 1:
                    Console.Write("Nhap ghi chu cua ban: ");
                    string noi_dung = Console.ReadLine();
                    File.WriteAllText(name + ".txt", noi_dung);
                    Console.WriteLine("Ghi chu vua nhap la: " + noi_dung);
                    break;
                case 2:

                    Console.Write("Nhap so luong ghi chu: ");
                    int lenght = Convert.ToInt32(Console.ReadLine());
                    string[] list_noi_dung = new string[lenght];
                    for (int i = 0; i < list_noi_dung.Length; i++)
                    {
                        Console.Write("      --------------Nhap ghi chu thu {0}: ", i);
                        list_noi_dung[i] = Console.ReadLine();
                    }
                    File.WriteAllLines(name + ".txt", list_noi_dung);
                    break;
                case 3:
                    break;
            }
        }
        public static void Cap_nhat_ghi_chu(string name)
        {
            int type;
            string noi_dung_cap_nhat = string.Empty;
            int lenght = 0;
            string[] list_noi_dung_cap_nhat = null;
            int vt = 0;
            Console.WriteLine("      |-----------Ban muon THAY THE hay GHI TIEP hay CAP NHAT?----|");
            Console.WriteLine("      |-------------1. Thay the ghi chu---------------------------|");
            Console.WriteLine("      |-------------2. Ghi tiep tuc vao ghi chu da co-------------|");
            Console.WriteLine("      |-------------3. Cap nhat ghi chu vao muc duoc chon---------|");
            Console.Write("Nhap lua chon: ");
            int chon_loai_cap_nhat = Convert.ToInt32(Console.ReadLine());

            switch (chon_loai_cap_nhat)
            {
                case 1: //thay the
                    Console.WriteLine("      |---------Ban nhap 1 hay n ghi chu?----|");
                    Console.WriteLine("      |-------------1. Mot ghi chu-----------|");
                    Console.WriteLine("      |-------------2. Nhieu ghi chu---------|");
                    Console.WriteLine("      |-------------3. Cancel----------------|");

                    Console.Write("Nhap lua chon: ");
                    type = Convert.ToInt32(Console.ReadLine());

                    switch (type)
                    {
                        case 1: //1 ghi chu
                            Console.Write("Nhap ghi chu cua ban: ");
                            noi_dung_cap_nhat = Console.ReadLine();
                            if (File.Exists(name + ".txt"))
                            {
                                File.WriteAllText(name + ".txt", noi_dung_cap_nhat);
                            }
                            else
                            {
                                Console.WriteLine("/////////////////////////////////////////////////////////");
                                Console.WriteLine("Ten nguoi dung khong ton tai! Moi ban tao ghi chu moi");
                                Console.WriteLine("/////////////////////////////////////////////////////////");
                                Console.WriteLine("\n");
                            }
                            break;

                        case 2: // n ghi chu
                            Console.Write("Nhap so luong ghi chu: ");
                            lenght = Convert.ToInt32(Console.ReadLine());
                            list_noi_dung_cap_nhat = new string[lenght];
                            for (int i = 0; i < list_noi_dung_cap_nhat.Length; i++)
                            {
                                Console.Write("      --------------Nhap ghi chu thu {0}: ", i);
                                list_noi_dung_cap_nhat[i] = Console.ReadLine();
                            }
                            if (File.Exists(name + ".txt"))
                            {
                                File.WriteAllLines(name + ".txt", list_noi_dung_cap_nhat);
                            }
                            else
                            {
                                Console.WriteLine("/////////////////////////////////////////////////////////");
                                Console.WriteLine("Ten nguoi dung khong ton tai! Moi ban tao ghi chu moi");
                                Console.WriteLine("/////////////////////////////////////////////////////////");
                                Console.WriteLine("\n");
                            }
                            break;
                    }
                    break;
                case 2: //ghi tiep tuc
                    Console.WriteLine("      |---------Ban nhap 1 hay n ghi chu?----|");
                    Console.WriteLine("      |-------------1. Mot ghi chu-----------|");
                    Console.WriteLine("      |-------------2. Nhieu ghi chu---------|");
                    Console.WriteLine("      |-------------3. Cancel----------------|");

                    Console.Write("Nhap lua chon: ");
                    type = Convert.ToInt32(Console.ReadLine());
                    switch (type) //1 ghi chu
                    {
                        case 1:
                            Console.Write("Nhap ghi chu cua ban: ");
                            noi_dung_cap_nhat = Console.ReadLine();
                            if (File.Exists(name + ".txt"))
                            {
                                File.AppendAllText(name + ".txt", noi_dung_cap_nhat);
                            }
                            else
                            {
                                Console.WriteLine("/////////////////////////////////////////////////////////");
                                Console.WriteLine("Ten nguoi dung khong ton tai! Moi ban tao ghi chu moi");
                                Console.WriteLine("/////////////////////////////////////////////////////////");
                                Console.WriteLine("\n");
                            }
                            break;

                        case 2: //n ghi chu
                            Console.Write("Nhap so luong ghi chu: ");
                            lenght = Convert.ToInt32(Console.ReadLine());
                            list_noi_dung_cap_nhat = new string[lenght];
                            for (int i = 0; i < list_noi_dung_cap_nhat.Length; i++)
                            {
                                Console.Write("      --------------Nhap ghi chu thu {0}: ", i);
                                list_noi_dung_cap_nhat[i] = Console.ReadLine();
                            }
                            if (File.Exists(name + ".txt"))
                            {
                                File.AppendAllLines(name + ".txt", list_noi_dung_cap_nhat);
                            }
                            else
                            {
                                Console.WriteLine("/////////////////////////////////////////////////////////");
                                Console.WriteLine("Ten nguoi dung khong ton tai! Moi ban tao ghi chu moi");
                                Console.WriteLine("/////////////////////////////////////////////////////////");
                                Console.WriteLine("\n");
                            }
                            break;
                    }
                    break;
                case 3: //cap nhat ghi chu voi vi tri duoc chon

                    Console.Write("Nhap vi tri ghi chu ma ban muon sua: ");
                    vt = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Nhap ghi chu moi: ");
                    noi_dung_cap_nhat = Console.ReadLine();

                    if (File.Exists(name + ".txt"))
                    {
                        string[] a = File.ReadAllLines(name + ".txt");
                        for (int i = 0; i < a.Length; ++i)
                        {
                            if (i == vt)
                            {
                                a[vt] = noi_dung_cap_nhat;
                            }
                        }
                        File.WriteAllLines(name + ".txt", a);
                    }
                    else
                    {
                        Console.WriteLine("/////////////////////////////////////////////////////////");
                        Console.WriteLine("Ten nguoi dung khong ton tai! Moi ban tao ghi chu moi");
                        Console.WriteLine("/////////////////////////////////////////////////////////");
                        Console.WriteLine("\n");
                    } 

                    break;

                case 4:
                    Console.Write("Nhap vi tri ghi chu ma ban muon xoa: ");
                    vt = Convert.ToInt32(Console.ReadLine());



                    if (File.Exists(name + ".txt"))
                    {
                        string[] a = File.ReadAllLines(name + ".txt");
                        for (int i = 0; i < a.Length; ++i)
                        {
                            if (i == vt)
                            {
                                a[vt].Remove(vt);
                            }
                        }
                        File.WriteAllLines(name + ".txt", a);
                    }
                    else
                    {
                        Console.WriteLine("/////////////////////////////////////////////////////////");
                        Console.WriteLine("Ten nguoi dung khong ton tai! Moi ban tao ghi chu moi");
                        Console.WriteLine("/////////////////////////////////////////////////////////");
                        Console.WriteLine("\n");
                    }
                    break;
            }
        }

        public static void Xoa_ghi_chu(string name)
        {
            int vt = 0;

            Console.Write("Nhap vi tri ghi chu ma ban muon xoa: ");
            vt = Convert.ToInt32(Console.ReadLine());

            if (File.Exists(name + ".txt"))
            {
                string[] a = File.ReadAllLines(name + ".txt");

                List<string> temp = a.ToList();

                for (int i = 0; i < a.Length; i++)
                {
                    if (i == vt)
                    {
                        temp.RemoveAt(vt);
                    }
                }
                File.WriteAllLines(name + ".txt", temp);
            }
            else
            {
                Console.WriteLine("/////////////////////////////////////////////////////////");
                Console.WriteLine("Ten nguoi dung khong ton tai! Moi ban tao ghi chu moi");
                Console.WriteLine("/////////////////////////////////////////////////////////");
                Console.WriteLine("\n");
            }

        }
        public static void Menu(int lua_chon, string name)
        {
            switch (lua_chon)
            {
                case 1:
                    Them_ghi_chu(name);
                    break;
                case 2:
                    if (File.Exists(name + ".txt"))
                    {
                        string[] a = File.ReadAllLines(name + ".txt");
                        Console.WriteLine("Ghi chu trong file la: ");
                        for (int i = 0; i < a.Length; ++i)
                        {
                            Console.Write(i + ". ");
                            Console.WriteLine(a[i]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("/////////////////////////////////////////////////////////");
                        Console.WriteLine("Ten nguoi dung khong ton tai! Moi ban tao ghi chu moi");
                        Console.WriteLine("/////////////////////////////////////////////////////////");
                        Console.WriteLine("\n");
                    }
                    break;
                case 3:
                    Cap_nhat_ghi_chu(name);
                    break;
                case 4:
                    Xoa_ghi_chu(name);

                    return;


            }
        }
        static void Main(string[] args)
        {
            int lua_chon;
            Console.Write("Nhap ten ban: ");
            string name = Console.ReadLine();


            do
            {
                Console.WriteLine("===============MENU===============");
                Console.WriteLine("----------1.Them ghi chu----------");
                Console.WriteLine("----------2.Xem ghi chu-----------");
                Console.WriteLine("----------3.Cap nhat ghi chu------");
                Console.WriteLine("----------4.Xoa ghi chu-----------");
                Console.WriteLine("----------5.Thoat-----------------");
                Console.WriteLine("==================================");

                Console.Write("Nhap lua chon: ");
                lua_chon = Convert.ToInt32(Console.ReadLine());
                Menu(lua_chon, name);
            } while (lua_chon != 5);




            Console.ReadKey();
        }
    }
}
