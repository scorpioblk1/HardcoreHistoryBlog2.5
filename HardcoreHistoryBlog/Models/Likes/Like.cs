﻿using HardcoreHistoryBlog.Data;
using HardcoreHistoryBlog.Models.Blog_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardcoreHistoryBlog.Models.Likes
{
    public class Like
    {
        public int Id { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
