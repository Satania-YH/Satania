using CompetitionSystem.Model.BasesTable;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompetitionSystem.Model.CommunsTable
{
    /// <summary>
    /// 名称：用户评论文章表
    /// 内容：拥有用户对文章进行评论的属性
    /// </summary>
    public class Comment : BaseEntity
    {
        /// <summary>
        /// 名称：文章Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid ArticleId { get; set; }

        /// <summary>
        /// 名称：发出评论的用户Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid UserId { get; set; }

        /// <summary>
        /// 名称：头像
        /// 要求：非空、最大长度400、类型为nvarchar
        /// </summary>
        [Required, StringLength(400), Column(TypeName = "nvarchar")]
        public string ImagePath { get; set; }

        /// <summary>
        /// 名称：昵称
        /// 要求：非空、最大长度40、类型为nvarchar
        /// </summary>
        [Required, StringLength(40), Column(TypeName = "nvarchar")]
        public string NickName { get; set; }

        /// <summary>
        /// 名称：评论内容
        /// 要求：非空、最大长度800、类型为nvarchar
        /// </summary>
        [Required, StringLength(800), Column(TypeName = "nvarchar")]
        public string Content { get; set; }

        /// <summary>
        /// 名称：点赞数
        /// 要求：必填、类型为int、初始为0
        /// </summary>
        [Required]
        public int LikesNum { get; set; } = 0;

        /// <summary>
        /// 名称：是否已读
        /// 要求：非空、默认为false
        /// </summary>
        [Required]
        public bool IsRead { get; set; } = false;
    }
}
