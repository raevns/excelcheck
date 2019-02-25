using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using excelcheck.service;

namespace excelcheck
{
    public partial class unit5 : Form
    {

        List<listVO> lists = new List<listVO>();

        public unit5()
        {
            InitializeComponent();            
            file_list_grid.Columns.Add("file_name", "파일이름");
            file_list_grid.Columns.Add("row_num", "행갯수");
            file_list_grid.Columns.Add("set_check", "설정");
        }

        private void file_open_button_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Users\\kimdonghyun\\Desktop\\테스트데이터";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Filter = "CSV files (*.csv)|*.csv|Excel Files|*.xls;*.xlsx";
                
                foreach (string data in openFileDialog1.FileNames)
                {
                    listVO dataVO = new listVO();
                    dataVO.file_name = Path.GetFileName(data);
                    dataVO.row_num = 0;
                    dataVO.set_check = "N";
                    dataVO.file_root = Path.GetFullPath(data);
                    lists.Add(dataVO);
                }

                addFileNameGrid(lists);
            }
        }

        private void addFileNameGrid(List<listVO> lists)
        {
            file_list_grid.Columns.Clear();
            file_list_grid.DataSource = lists;
            
            file_list_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void save_setting_button_Click(object sender, EventArgs e)
        {
            int select_row = file_list_grid.SelectedRows[0].Index;
            Console.WriteLine(select_row);
        }
    }
}
