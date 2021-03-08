﻿using System;

namespace Volo.CmsKit.Public.Comments
{
    [Serializable]
    public class CommentDetailedDto
    {
        public Guid Id { get; set; }

        public string EntityType { get; set; }

        public string EntityId { get; set; }

        public string Text { get; set; }

        public Guid? RepliedCommentId { get; set; }

        public Guid CreatorId { get; set; }

        public DateTime CreationTime { get; set; }

        public CmsUserDto Author { get; set; }
    }
}