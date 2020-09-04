using CompetitionSystem.Model.BasesTable;
using System;
using System.ComponentModel.DataAnnotations;

namespace CompetitionSystem.Model.CommunsTable
{
    /// <summary>
    /// 名称：文章标签联系表
    /// 内容：连接文章与标签的关系属性
    /// </summary>
    public class ArticleToTag : BaseEntity
    {
        /// <summary>
        /// 名称：文章Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid ArticleId { get; set; }

        /// <summary>
        /// 名称：标签Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid TagId { get; set; }
    }
}
