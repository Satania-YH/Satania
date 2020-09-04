using CompetitionSystem.Model.BasesTable;
using System;
using System.ComponentModel.DataAnnotations;

namespace CompetitionSystem.Model.ExamsTable
{
    /// <summary>
    /// 名称：学生竞赛关系表
    /// 内容：拥有学生与关系的联系属性
    /// </summary>
    public class StudentToComp : BaseEntity
    {
        /// <summary>
        /// 名称：学生Id
        /// 要求：非空
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// 名称：竞赛Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid CompetitionId { get; set; }

        /// <summary>
        /// 名称：报名状态
        /// 要求：非空
        /// </summary>
        [Required]
        public bool IsSigned { get; set; } = false;

        // <summary>
        /// 名称：学生成绩
        /// </summary>
        public int Grade { get; set; }

        /// <summary>
        /// 名称：学生排名
        /// </summary>
        public int Ranking { get; set; }
    }
}
