using CompetitionSystem.Model.BasesTable;
using System;
using System.ComponentModel.DataAnnotations;

namespace CompetitionSystem.Model.ExamsTable
{
    /// <summary>
    /// 名称：学生试卷关系表
    /// 内容：拥有学生与关系的联系属性
    /// </summary>
    public class StudentToTest : BaseEntity
    {
        /// <summary>
        /// 名称：学生Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid UserId { get; set; }

        /// <summary>
        /// 名称：考试Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid TestPaperId { get; set; }

        /// <summary>
        /// 名称：学生成绩
        /// </summary>
        public int Grade { get; set; }

        /// <summary>
        /// 名称：学生排名
        /// </summary>
        public int Ranking { get; set; }
    }
}
