using System;
using System.Collections.Generic;
using System.Text;

namespace OSeage.XTKJ.API.Message.Request.User
{
    public class QueryByPageRequest : Message.QueryByPageRequest
    {
        public string UserName { get; set; }
    }
}
