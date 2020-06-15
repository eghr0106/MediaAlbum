using Service.Comments;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Photos
{
    public class PhotoDto
    {      
        public string title { get; set; }
        public string url { get; set; }
        public string thumbnailUrl { get; set; }
        public IList<CommentDto> Comments { get; set; }
    }
}
