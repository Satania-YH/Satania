using CompetitionSystem.Model.BasesTable;
using System;
using System.ComponentModel.DataAnnotations;

namespace CompetitionSystem.Model.CommunsTable
{
    /// <summary>
    /// 名称：通知用户关系表
    /// 内容：拥有通知与目标用户的相关联系属性
    /// </summary>
    public class NoticeToUser : BaseEntity
    {
        /// <summary>
        /// 名称：通知id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid NoticeId { get; set; }

        /// <summary>
        /// 名称：通知目标的用户Id
        /// 要求：非空、来自用户表的外键
        /// </summary>
        [Required]
        public Guid UserId { get; set; }

        /// <summary>
        /// 名称：是否阅读
        /// 要求：非空、默认为false
        /// </summary>
        [Required]
        public bool IsRead { get; set; } = false;
    }
}
