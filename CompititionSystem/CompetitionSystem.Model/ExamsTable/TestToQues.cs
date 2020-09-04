using CompetitionSystem.Model.BasesTable;
using System;
using System.ComponentModel.DataAnnotations;

namespace CompetitionSystem.Model.ExamsTable
{
    /// <summary>
    /// 名称；试卷题目关系表
    /// 内容：拥有试卷与题目之间的关系属性
    /// </summary>
    public class TestToQues : BaseEntity
    {
        /// <summary>
        /// 名称：试卷Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid TestPaperId { get; set; }

        /// <summary>
        /// 名称：题目Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid QuestionId { get; set; }
    }
}
