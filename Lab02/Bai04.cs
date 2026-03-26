using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab02
{
    public partial class Bai04 : Form
    {
        List<Student> dsHocVien = new List<Student>();

        public Bai04()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txtMSSV.Text) || string.IsNullOrEmpty(txtName.Text))
                {
                    throw new Exception("Nhập đầy đủ MSSV và họ tên");
                }
                
                if (!float.TryParse(txtToan.Text, out float diemToan) || !float.TryParse(txtVan.Text, out float diemVan))
                {
                    throw new Exception("Điểm Toán và Văn phải là số hợp lệ");
                }

                Student sv = new Student()
                {
                    MSSV = txtMSSV.Text,
                    HoTen = txtName.Text,
                    DienThoai = txtPhone.Text,
                    DiemToan = diemToan,
                    DiemVan = diemVan,
                    DTB = 0
                };

                dsHocVien.Add(sv);
                MessageBox.Show($"Đã thêm sinh viên {sv.HoTen} vào danh sách.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtMSSV.Clear(); txtName.Clear(); txtPhone.Clear(); txtToan.Clear(); txtVan.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (dsHocVien.Count == 0)
            {
                MessageBox.Show("Danh sách đang trống, hãy thêm học viên trước!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FileStream fs = null;
            try
            {
                // Mở luồng ghi file
                fs = new FileStream("input.txt", FileMode.OpenOrCreate);
                #pragma warning disable SYSLIB0011
                BinaryFormatter bf = new BinaryFormatter();
                #pragma warning restore SYSLIB0011

                bf.Serialize(fs, dsHocVien);

                MessageBox.Show("Đã ghi danh sách vào file input.txt!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FileStream fsIn = null;
            try
            {
                fsIn = new FileStream("input.txt", FileMode.Open);
                #pragma warning disable SYSLIB0011
                BinaryFormatter bf = new BinaryFormatter();
                #pragma warning restore SYSLIB0011
                List<Student> dsDoc = (List<Student>)bf.Deserialize(fsIn);
                fsIn.Close();

                string output = "";
                foreach (var sv in dsDoc)
                {
                    sv.DTB = (sv.DiemToan + sv.DiemVan) / 2;
                    output += $"{sv.MSSV}\n{sv.HoTen}\n{sv.DienThoai}\n{sv.DiemToan}\n{sv.DiemVan}\n{sv.DTB}\n\n";
                }
                richTextBox1.Text = output;

                using (FileStream fsOut = new FileStream("output.txt", FileMode.OpenOrCreate))
                {
                    bf.Serialize(fsOut, dsDoc);
                }
                MessageBox.Show("Đã đọc, tính toán và lưu vào output.txt");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Không tìm thấy file input.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                if (fsIn != null) fsIn.Close();
            }
        }
    }
}
