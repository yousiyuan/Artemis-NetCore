using System;
using System.Collections.Generic;
using System.Text;

namespace OSeage.XTKJ.API.Message.Response.User
{
    public class GetUserInfoResponse<T, F>
    {
        public T User { get; set; }
        public F ExtendData { get; set; }
    }
}
