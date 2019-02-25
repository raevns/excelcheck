using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excelcheck.service
{
    class listVO
    {
        public String file_name { set; get; }//파일이름
        public int row_num { set; get; } //행갯수
        public String set_check { set; get; } //설정을 햇는지 안햇는지
        public String file_root { set; get; }//파일경로
    }
}
