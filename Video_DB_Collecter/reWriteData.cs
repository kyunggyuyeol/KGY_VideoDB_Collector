using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_DB_Collecter
{
    class reWriteData
    {

        public string FileLV_3 { get; set; }

        public string Message { get; set; }

        public reWriteData(string FileLV_3, string Message)
        {
            this.FileLV_3 = FileLV_3;
            this.Message = Message;
        }
    }
}
