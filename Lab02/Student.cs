using System;

namespace Lab02
{
    [Serializable] // Cực kỳ quan trọng để dùng BinaryFormatter 
    public class Student
    {
        public string MSSV { get; set; }     // [cite: 239]
        public string HoTen { get; set; }    // [cite: 240]
        public string DienThoai { get; set; } // [cite: 241]
        public float DiemToan { get; set; }  // [cite: 242]
        public float DiemVan { get; set; }   // [cite: 243]
        public float DTB { get; set; }       // [cite: 244]
    }
}