﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Web6.Models.ViewModels
{
    public class ForumAttachmentCreateModel
    {
        public IFormFile FilePath { get; set; }
    }
}
