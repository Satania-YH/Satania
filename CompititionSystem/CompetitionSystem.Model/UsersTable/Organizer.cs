using CompetitionSystem.Model.BasesTable;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompetitionSystem.Model.UsersTable
{
    /// <summary>
    /// 名称：竞赛组织者表
    /// 内容：拥有地址、认证等竞赛组织者的属性
    /// </summary>
    public class Organizer : BaseEntity
    {
        /// <summary>
        /// 名称：用户Id
        /// 要求：非空、来自用户表的外键
        /// </summary>
        [Required, ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public User User { get; set; }

        /// <summary>
        /// 名称：联系方式
        /// 要求：最大长度200、类型为nvarchar
        /// </summary>
        [StringLength(200), Column(TypeName = "nvarchar")]
        public string Contact { get; set; }

        /// <summary>
        /// 名称：简介
        /// 要求：最大长度400、类型为nvarchar
        /// </summary>
        [StringLength(400), Column(TypeName = "nvarchar")]
        public string Profile { get; set; }

        /// <summary>
        /// 名称：是否经过认证
        /// 要求：必填、默认为false
        /// </summary>
        [Required]
        public bool IsProcess { get; set; } = false;

        /// <summary>
        /// 名称：组织认证名称
        /// 要求：最大长度80、类型为nvarchar
        /// </summary>
        [StringLength(80), Column(TypeName = "nvarchar")]
        public string ProcessingName { get; set; }
    }
}
