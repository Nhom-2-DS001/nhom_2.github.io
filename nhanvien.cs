using System;

namespace ConsoleApp1
{
    class nhanvien
    {
        public int id;
        public string hoten;
        public int tuoi;
        public double hsl;
        public string baohiem;
        public int ngaynghi;

        public int getId()
        {
            return id;
        }

        public string getHoTen()
        {
            return hoten;
        }

        public int getTuoi()
        {
            return tuoi;
        }

        public double getHSL()
        {
            return hsl;
        }

        public string getBH()
        {
            return baohiem;
        }

        public int getNghi()
        {
            return ngaynghi;
        }

        public nhanvien(int id, string hoten, int tuoi, double hsl, int ngaynghi,string baohiem)
        {
            this.id = id;
            this.hoten = hoten;
            this.tuoi = tuoi;
            this.hsl = hsl;          
            this.ngaynghi = ngaynghi;
            this.baohiem = baohiem;
        }

        override public string ToString()
        {
            return "ID: " + id + "\t" + "HỌ TÊN: " + hoten + "\t" + "TUỔI: " + tuoi + "\t" + "HỆ SỐ LƯƠNG: " + hsl + "\t" + "SỐ NGÀY NGHỈ: " + ngaynghi + "\t\t" + "TÌNH TRẠNG BẢO HIỂM: " + baohiem;
        }
    }
}


    

