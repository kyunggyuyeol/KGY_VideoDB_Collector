using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_DB_Collecter
{
    public class MasterTag
    {

        public string clipName { get; set; }

        public string Message { get; set; }

        public string FilePath { get; set; }

        public string mainClip { get; set; }

        public MasterTag(string clipName, string Message, string filepath, string mainClip)
        {
            this.clipName = clipName;
            this.Message = Message;
            this.FilePath = filepath;
            this.mainClip = mainClip;
        }
    }
}
