using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamReader sr = null;

                try
                {
                    fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);

                    string content = sr.ReadToEnd();
                    richTextBox1.Text = content;

                    txtFilename.Text = ofd.SafeFileName;
                    txtUrl.Text = fs.Name;

                    txtChar.Text = content.Length.ToString();

                    txtLines.Text = richTextBox1.Lines.Count().ToString();

                    string[] source = content.Split(new char[] { '.', '?', ' ', '!', ';', ':', ',', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                    txtWord.Text = source.Length.ToString();
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Lỗi: Không tìm thấy file!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Lỗi: Bạn không có quyền truy cập file này!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Lỗi I/O: File có thể đang được mở bởi chương trình khác.\nChi tiết: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi không xác định", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sr != null) sr.Close();
                    if (fs != null) fs.Close();
                }
            }
        }
    }
}
