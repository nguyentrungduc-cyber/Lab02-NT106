using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
            Write_btn.Enabled = false;
        }

        private void Read_btn_Click(object sender, EventArgs e)
        {
            string selectedInputPath = "";
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn file input.txt";
                ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (ofd.ShowDialog() != DialogResult.OK) return;

                selectedInputPath = ofd.FileName;
                XuLy(selectedInputPath);
            }
        }

        private void Write_btn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Lưu kết quả";
                sfd.FileName = "output.txt";
                sfd.Filter = "Text files (*.txt)|*.txt";

                if (sfd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        foreach (var item in KetQua_listbox.Items)
                            sw.WriteLine(item.ToString());
                    }

                    MessageBox.Show("Ghi file thành công!\n" + sfd.FileName,
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("❌  Lỗi ghi file: " + exception.Message);
                }
            }
        }

        private void XuLy(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                int n = 0;

                foreach (string line in lines)
                {
                    string expression = line.Trim();
                    if (expression.Length <= 0)
                        continue;

                    string result = TinhToan(expression);
                    KetQua_listbox.Items.Add($"{expression} = {result}");
                    n++;

                }

                Write_btn.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Lỗi khi đọc file: {exception.Message}");
            }

        }

        private string TinhToan(string expression)
        {
            char[] ops = { '+', '-', '*', '/' };
            foreach (char op in ops)
            {
                for (int i = 1; i < expression.Length; i++)
                {
                    if (expression[i] != op) continue;

                    string leftStr = expression.Substring(0, i).Trim();
                    string rightStr = expression.Substring(i + 1).Trim();

                    if (!double.TryParse(leftStr, out double left))
                        continue;
                    if (!double.TryParse(rightStr, out double right))
                        continue;

                    double result;
                    switch (op)
                    {
                        case '+':
                            result = left + right;
                            break;
                        case '-':
                            result = left - right;
                            break;
                        case '*':
                            result = left * right;
                            break;
                        case '/':
                            if (right == 0)
                                return "Lỗi (chia 0)";
                            result = left / right;
                            break;
                        default:
                            continue;
                    }

                    return result == Math.Floor(result)
                        ? ((long)result).ToString()
                        : result.ToString("G");
                }
            }
            return "Không hợp lệ";
        }
    }
}
