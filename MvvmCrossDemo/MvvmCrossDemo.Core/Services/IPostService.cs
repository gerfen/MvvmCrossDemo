﻿using MvvmCrossDemo.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCrossDemo.Core.Services
{
    public interface IPostService
    {
        Task<ResponseMessage<List<Post>>> GetPosts();
        Task<ResponseMessage<Post>> GetPost(int id);
        Task<ResponseMessage<List<Comment>>> GetComments(int postId);

    }
}
