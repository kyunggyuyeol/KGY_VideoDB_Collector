using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Video_DB_Collecter
{
    public class DataClass
    {
        //클립 01, 02, 03, 04 다들어갈 예정
        //DB UPDATE 편리함을 가져가야함.
        public string FilePath { get; set; }

        public string Cat_Type { get; set; }

        public string FileLV_1 { get; set; }

        public string FileLV_2 { get; set; }

        public string FileLV_3 { get; set; }

        public string Message { get; set; }

        public bool reWrite { get; set; }

        public DataClass(bool reWrite, string Cat_Type, string FileLV_1, string FileLV_2, string FileLV_3, string checkFilePath)
        {
            //파일패스 만들어줘야함
            this.Cat_Type = Cat_Type;
            this.FileLV_1 = FileLV_1;
            this.FileLV_2 = FileLV_2;
            this.FileLV_3 = FileLV_3;
            this.reWrite = reWrite;
            //파일경로를 만들어줌
            this.FilePath = checkFilePath + "/" + Cat_Type + "/" + FileLV_1 + "/" + FileLV_2 + "/" + FileLV_3 + ".mp4";
        }
    }
}
