using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Comments
{
    public interface ICommentService
    {
        Task<IList<Comment>> GetCommentsAsync();
        Task<IList<Comment>> GetCommentsByPhotoAsync(int photoId);
    }
}
