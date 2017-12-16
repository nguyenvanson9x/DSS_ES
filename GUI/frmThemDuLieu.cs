using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;  
using BUS;
using DTO;
namespace GUI
{
    public partial class frmThemDuLieu : Form
    {
        private BUS_ThemDuLieu bus;
        public frmThemDuLieu()
        {
            InitializeComponent();
            pnInput.Visible = false;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.OpenFile() != null)
                {
                    string file = Path.GetFileName(openFileDialog1.FileName);
                    string path = Path.GetDirectoryName(openFileDialog1.FileName);
                    string fullpath = path + "\\" + file;
                    //getExcelFile(fullpath);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!pnInput.Visible)
            {
                btnExcel.Visible = false;
                pnInput.Visible = true;
            }
            else
            {
                btnExcel.Visible = true;
                pnInput.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string matruong = txtMaTruong.Text, tentruong = txtTenTruong.Text, manganh = txtMaNganh.Text, tennganh = txtTenNganh.Text, group ="", diemchuan = txtDiemChuan.Text, chitieu = txtChiTieu.Text, diachi =txtDiaChi.Text, namdaotao = txtNamDaoTao.Text, sldatuyen = txtDaTuyen.Text, lienhe =txtWebsite.Text, slNv = txtSoCanBo.Text, dvchuquan = txtDvChuquan.Text, tinhthanh = txtTinhThanh.Text;
            if (matruong != "" && tentruong != "" && manganh != "" && tennganh != "" && diemchuan != "" && chitieu != "" && diachi != "" && namdaotao != "" && sldatuyen != "" && lienhe != "" && slNv != "" && dvchuquan != "" && tinhthanh != "")
            {
                try
                {
                    group = bus.getGroup(tennganh);
                    MessageBox.Show(group);
                    string sqlTruong = @"INSERT INTO Truong(MaTruong,TenTruong,DiaChi,Website,TinhThanh,DVChuquan) VALUES(N'" + matruong + "',N'" + tentruong + "',N'" + diachi + "',N'" + lienhe + "',N'" + tinhthanh + "',N'" + dvchuquan + "');";
                    string sqlNhomNganh = @"INSERT INTO NhomNganh(NhomNganh,TenChuyenNganh) VALUES(" + group + ",N'" + tennganh + "');";
                    string sqlChuyenNganh = @"INSERT INTO ChuyenNganh(MaNganh,NhomNganh) VALUES(N'" + manganh + "'," + group + ");";
                    string sqlTruongNganh = @"INSERT INTO TruongNganh(MaTruong,MaNganh,NamDT,SoCB) VALUES(N'" + matruong + "',N'" + manganh + "'," + namdaotao + "," + slNv + ");";
                    string sqlTuyenSinh = @"INSERT INTO TuyenSinh(MaTruong,MaNganh,DiemChuan,ChiTieu,SLDaTuyen) VALUES(N'" + matruong + "',N'" + manganh + "'," + diemchuan + "," + chitieu + "," + sldatuyen + ");";

                    bus.excuteSQL(sqlTruong);
                    bus.excuteSQL(sqlNhomNganh);
                    bus.excuteSQL(sqlChuyenNganh);
                    bus.excuteSQL(sqlTruongNganh);
                    bus.excuteSQL(sqlTuyenSinh);
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Lỗi kết nối cơ sở dữ liệu. Vào phần Cấu hình để thiết lập thông số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoatClick(object sender, EventArgs e)
        {
            txtChiTieu.ResetText();
            txtDaTuyen.ResetText();
            txtDiaChi.ResetText();
            txtDiemChuan.ResetText();
            txtDvChuquan.ResetText();
            txtMaNganh.ResetText();
            txtMaTruong.ResetText();
            txtNamDaoTao.ResetText();
            txtSoCanBo.ResetText();
            txtTenNganh.ResetText();
            txtTenTruong.ResetText();
            txtTinhThanh.ResetText();
            txtWebsite.ResetText();
            pnInput.Visible = false;
            btnExcel.Visible = true;
        }

        /*
        private void getExcelFile(string path)
        {

            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(String.Format(path));
            Excel._Worksheet xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            string[] data=new string[colCount];
            //iterate over the rows and columns and print to the console as it appears in the file
            //excel is not zero based!!
            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    if (xlRange.Cells[i, j] as Excel.Range != null && (xlRange.Cells[i, j] as Excel.Range).Value2 != null)
                        data[j - 1] = (xlRange.Cells[i, j] as Excel.Range).Value2.ToString();
                }
            }
            string matruong = data[0], tentruong = data[1], manganh = data[2], tennganh = data[3], group = data[4], diemchuan = data[5], chitieu = data[6], diachi = data[8], namdaotao = data[9], sldatuyen = data[7], lienhe = data[10], slNv = data[11], dvchuquan = data[12], tinhthanh = data[13];
            string sqlTruong = @"INSERT INTO Truong(MaTruong,TenTruong,DiaChi,Website,TinhThanh,DVChuquan) VALUES(N'" + matruong + "',N'" + tentruong + "',N'" + diachi + "',N'" + lienhe + "',N'" + tinhthanh + "',N'" + dvchuquan + "');";
            string sqlNhomNganh = @"INSERT INTO NhomNganh(NhomNganh,TenChuyenNganh) VALUES(" + group + ",N'" + tennganh + "');";
            string sqlChuyenNganh = @"INSERT INTO ChuyenNganh(MaNganh,NhomNganh) VALUES(N'" + manganh + "'," + group + ");";
            string sqlTruongNganh = @"INSERT INTO TruongNganh(MaTruong,MaNganh,NamDT,SoCB) VALUES(N'" + matruong + "',N'" + manganh + "'," + namdaotao + "," + slNv + ");";
            string sqlTuyenSinh = @"INSERT INTO TuyenSinh(MaTruong,MaNganh,DiemChuan,ChiTieu,SLDaTuyen) VALUES(N'" + matruong + "',N'" + manganh + "'," + diemchuan + "," + chitieu + "," + sldatuyen + ");";
            bus.excuteSQL(sqlTruong);
            bus.excuteSQL(sqlNhomNganh);
            bus.excuteSQL(sqlChuyenNganh);
            bus.excuteSQL(sqlTruongNganh);
            bus.excuteSQL(sqlTuyenSinh);

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

         
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);


            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }
        */
    }
}
