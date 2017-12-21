using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_DB_Collecter
{
    public class Tag
    {
        public int count { get; set; }

        public string tagName { get; set; }

        public Tag(int count, string tagName)
        {
            this.count = count;
            this.tagName = tagName;
        }
    }
}
