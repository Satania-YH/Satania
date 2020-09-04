using CompetitionSystem.Model.BasesTable;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompetitionSystem.Model.CommunsTable
{
    public class Report : BaseEntity
    {
        /// <summary>
        /// 名称：举报用户Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid UserId { get; set; }

        /// <summary>
        /// 名称：举报目标Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid TargetId { get; set; }

        /// <summary>
        /// 名称：举报目标用户Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid TargetUserId { get; set; }

        /// <summary>
        /// 名称：举报理由
        /// 要求：非空、最大长度400、类型为nvarchar
        /// </summary>
        [Required, StringLength(400), Column(TypeName = "nvarchar")]
        public string Reason { get; set; }

        /// <summary>
        /// 名称：是否已读
        /// 要求：非空、默认为false
        /// </summary>
        [Required]
        public bool IsRead { get; set; } = false;
    }
}
