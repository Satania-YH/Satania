using CompetitionSystem.Model.BasesTable;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompetitionSystem.Model.CommunsTable
{
    /// <summary>
    /// 名称：用户回复评论表
    /// 内容：拥有用户回复评论的属性
    /// </summary>
    public class Reply : BaseEntity
    {
        /// <summary>
        /// 名称：父评论Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid CommentId { get; set; }

        /// <summary>
        /// 名称：目标评论Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid ReplyId { get; set; }

        /// <summary>
        /// 名称：评论类型，是回复父评论还是回复子评论
        /// 约束：1-回复父评论  2-回复子评论
        /// 要求：非空
        /// </summary>
        [Required]
        public int ReplyType { get; set; }

        /// <summary>
        /// 名称：评论内容
        /// 要求：非空、最大长度800、类型为nvarchar
        /// </summary>
        [Required, StringLength(800), Column(TypeName = "nvarchar")]
        public string Content { get; set; }

        /// <summary>
        /// 名称：发出评论的用户Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid FromUserId { get; set; }

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
        /// 名称：回复目标的用户Id
        /// 要求：非空
        /// </summary>
        public Guid ToUserId { get; set; }

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
