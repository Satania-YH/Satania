using CompetitionSystem.Model.BasesTable;
using System;
using System.ComponentModel.DataAnnotations;

namespace CompetitionSystem.Model.ExamsTable
{
    public class QuesToCate : BaseEntity
    {
        /// <summary>
        /// 名称：试卷Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid QuestionId { get; set; }

        /// <summary>
        /// 名称：分类Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid CategoryId { get; set; }
    }
}
