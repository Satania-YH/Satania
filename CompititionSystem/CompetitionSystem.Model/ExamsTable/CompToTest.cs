using CompetitionSystem.Model.BasesTable;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompetitionSystem.Model.ExamsTable
{
    /// <summary>
    /// 名称：竞赛试卷关系表
    /// 内容：拥有竞赛与试卷之间的关系属性
    /// </summary>
    public class CompToTest : BaseEntity
    {
        /// <summary>
        /// 名称：竞赛Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid CompetitionId { get; set; }

        /// <summary>
        /// 名称：试卷Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid TestPaperId { get; set; }

        /// <summary>
        /// 名称：考试开始时间
        /// 要求：非空
        /// </summary>
        [Required]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 名称：考试持续时间
        /// 要求：非空
        /// </summary>
        [Required]
        public DateTime Duration { get; set; }
    }
}
