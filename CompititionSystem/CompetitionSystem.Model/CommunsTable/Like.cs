using CompetitionSystem.Model.BasesTable;
using System;
using System.ComponentModel.DataAnnotations;

namespace CompetitionSystem.Model.CommunsTable
{
    /// <summary>
    /// 名称：用户点赞表
    /// 内容：拥有用户点赞的相关属性
    /// </summary>
    public class Like : BaseEntity
    {
        /// <summary>
        /// 名称：点赞用户Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid UserId { get; set; }

        /// <summary>
        /// 名称：点赞目标Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid TargetId { get; set; }

        /// <summary>
        /// 名称：点赞目标用户Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid TargetUserId { get; set; }

        /// <summary>
        /// 名称：点赞的目标类型
        /// 要求：1-文章 2-评论 3-回复
        /// </summary>
        [Required]
        public int TargetType { get; set; }

        /// <summary>
        /// 名称：是否已读
        /// 要求：非空、默认为false
        /// </summary>
        [Required]
        public bool IsRead { get; set; } = false;
    }
}
