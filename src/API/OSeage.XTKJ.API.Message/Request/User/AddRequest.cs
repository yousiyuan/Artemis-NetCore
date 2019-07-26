﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OSeage.XTKJ.API.Message.Request.User
{
    public class AddRequest : RequestMessage
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Pwd { get; set; }
    }
}
