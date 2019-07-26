using System;
using System.Collections.Generic;
using System.Text;

namespace OSeage.XTKJ.API.Message.Request.User
{
    public class QueryRequest : RequestMessage
    {
        public string UserName { get; set; }
        public int Taken { get; set; } = 10;
    }
}
