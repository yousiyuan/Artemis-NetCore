using System;
using System.Collections.Generic;
using System.Text;

namespace OSeage.XTKJ.API.Message.Request.User
{
    public class AddExtendDataRequest<T> : RequestMessage where T : class
    {
        public long Id { get; set; }
        public T Info { get; set; }
    }
}
