using CompetitionSystem.Model.BasesTable;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompetitionSystem.Model.CommunsTable
{
    /// <summary>
    /// 名称：标签表
    /// 内容：拥有名称等标签含有的属性
    /// </summary>
    public class Tag : BaseEntity
    {
        /// <summary>
        /// 名称：标签名称
        /// 要求：非空、最大长度40、类型为nvarchar
        /// </summary>
        [Required, StringLength(40), Column(TypeName = "nvarchar")]
        public string TagName { get; set; }

        /// <summary>
        /// 名称：标签类型
        /// 约束：1-文章标签 2-试卷标签
        /// </summary>
        [Required]
        public int TagType { get; set; }

        /// <summary>
        /// 名称：父标签Id
        /// </summary>
        public Guid ParentTagId { get; set; }
    }
}
