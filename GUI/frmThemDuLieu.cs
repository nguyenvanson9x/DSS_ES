using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Globalization;
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
            bus = new BUS_ThemDuLieu();
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
                    getExcelFile(fullpath);
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
            string matruong = txtMaTruong.Text, tentruong = txtTenTruong.Text, manganh = txtMaNganh.Text, tennganh = txtTenNganh.Text, diemchuan = txtDiemChuan.Text, chitieu = txtChiTieu.Text, diachi =txtDiaChi.Text, namdaotao = txtNamDaoTao.Text, sldatuyen = txtDaTuyen.Text, lienhe =txtWebsite.Text, slNv = txtSoCanBo.Text, dvchuquan = txtDvChuquan.Text, tinhthanh = txtTinhThanh.Text;
            int group = 0;
            string sqlNganh = String.Format("Select NhomNganh From NhomNganh Where TenChuyenNganh=N'" + tennganh + "';");
            string sqlTruong = String.Format("Select * From Truong Where MaTruong=N'" + matruong + "';");
            if (matruong != "" && tentruong != "" && manganh != "" && tennganh != "" && diemchuan != "" && chitieu != "" && diachi != "" && namdaotao != "" && sldatuyen != "" && lienhe != "" && slNv != "" && dvchuquan != "" && tinhthanh != "")
            {
                try
                {
                    if (bus.checkSQL(sqlNganh))
                        group = bus.getGroup(tennganh);
                    else
                        group += bus.getNumberRow();
                    if (bus.checkSQL(sqlTruong))
                    {
                        addData(matruong, tentruong, diachi, lienhe, tinhthanh, dvchuquan, Convert.ToInt32(group, CultureInfo.InvariantCulture), tennganh, manganh, Convert.ToInt32(namdaotao, CultureInfo.InvariantCulture), Convert.ToInt32(slNv, CultureInfo.InvariantCulture), Convert.ToDouble(diemchuan, CultureInfo.InvariantCulture), Convert.ToInt32(chitieu, CultureInfo.InvariantCulture), Convert.ToInt32(sldatuyen, CultureInfo.InvariantCulture));
                        resetText();
                    }
                    else
                    {
                        MessageBox.Show(this, "Trường đã tồn tại trên hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
            resetText();
            pnInput.Visible = false;
            btnExcel.Visible = true;
        }
        private void resetText() 
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
        }
        private void getExcelFile(string path)
        {

            DataSet ds = new DataSet();
            string fileExtension = Path.GetExtension(path);
            string connectionString = "";
            if (fileExtension == ".xls")
                connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
            if (fileExtension == ".xlsx")
                connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {

                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    DataTable dtSheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    foreach (DataRow dr in dtSheet.Rows)
                    {
                        string sheetName = dr["TABLE_NAME"].ToString();
                        if (!sheetName.EndsWith("$"))
                            continue;
                        cmd.CommandText = "SELECT * FROM ["+sheetName+"]";

                        DataTable dt = new DataTable();
                        dt.TableName = sheetName;

                        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                        da.Fill(dt);

                        ds.Tables.Add(dt);
                    }
                    foreach (DataTable dt in ds.Tables)
                    {
                        object[] data = new object[dt.Columns.Count];
                        for (int curRow = 0; curRow < dt.Rows.Count; curRow++)
                        {
                            for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
                            {
                                data[curCol] = dt.Rows[curRow][curCol];
                            }
                            string matruong = data[0].ToString(), tentruong = data[1].ToString(), manganh = data[2].ToString(), tennganh = data[3].ToString(), group = data[4].ToString(), diemchuan = data[5].ToString(), chitieu = data[6].ToString(), diachi = data[8].ToString(), namdaotao = data[9].ToString(), sldatuyen = data[7].ToString(), lienhe = data[10].ToString(), slNv = data[11].ToString(), dvchuquan = data[12].ToString(), tinhthanh = data[13].ToString();
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
                    }
                    cmd = null;
                    conn.Close();
                    MessageBox.Show("Nhập dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) {
                    
                }
            }

        }

        private void addData(string matruong, string tentruong, string diachi, string lienhe, string tinhthanh, string dvchuquan, int group, string tennganh, string manganh, int namdaotao, int slNv, double diemchuan, int chitieu, int sldatuyen)
        {
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

        private void auto_complete(TextBox txt)
        {
            string type = "TenChuyenNganh";
            try
            {
                List<string> list = bus.auto_complete(type);
                AutoCompleteStringCollection source = new AutoCompleteStringCollection();
                source.AddRange(list.ToArray());

                txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt.AutoCompleteCustomSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Lỗi kết nối cơ sở dữ liệu. Vào phần Cấu hình để thiết lập thông số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmThemDuLieu_Load(object sender, EventArgs e)
        {
            auto_complete(txtTenNganh);
        }
    }
}
