using CompetitionSystem.Model.BasesTable;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompetitionSystem.Model.ExamsTable
{
    /// <summary>
    /// 名称：试卷表
    /// 内容：拥有题目等试卷的相关属性
    /// </summary>
    public class TestPaper : BaseEntity
    {
        /// <summary>
        /// 名称：试卷名称
        /// 要求：非空、最大长度80、类型为nvarchar
        /// </summary>
        [Required, StringLength(80), Column(TypeName = "nvarchar")]
        public string TestName { get; set; }

        /// <summary>
        /// 名称：出卷人Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid UserId { get; set; }

        /// <summary>
        /// 名称：出卷人姓名
        /// 要求：、最大长度20、类型为nvarchar
        /// </summary>
        [Required, StringLength(20), Column(TypeName = "nvarchar")]
        public string UserName { get; set; }

        /// <summary>
        /// 名称：试卷总分
        /// 要求：非空
        /// </summary>
        [Required]
        public int TotalGrade { get; set; }

        /// <summary>
        /// 名称：试卷总题目数
        /// 要求：非空
        /// </summary>
        [Required]
        public int TotalNum { get; set; }

        /// <summary>
        /// 名称：单选题分数
        /// 要求：非空
        /// </summary>
        [Required]
        public int OneChoiceGrade { get; set; }

        /// <summary>
        /// 名称：单选题题目数
        /// 要求：非空
        /// </summary>
        [Required]
        public int OneChoiceNum { get; set; }

        /// <summary>
        /// 名称：多选题分数
        /// 要求：非空
        /// </summary>
        [Required]
        public int ManyChoiceGrade { get; set; }

        /// <summary>
        /// 名称：多选题题目数
        /// 要求：非空
        /// </summary>
        [Required]
        public int ManyChoiceNum { get; set; }

        /// <summary>
        /// 名称：填空题分数
        /// 要求：f非空
        /// </summary>
        [Required]
        public int CompletionGrade { get; set; }

        /// <summary>
        /// 名称：填空题题目数
        /// 要求：非空
        /// </summary>
        [Required]
        public int CompletionNum { get; set; }

        /// <summary>
        /// 名称：判断题分数
        /// 要求：非空
        /// </summary>
        [Required]
        public int JudgeGrade { get; set; }

        /// <summary>
        /// 名称：判断题题目数
        /// 要求：非空
        /// </summary>
        [Required]
        public int JudgeNum { get; set; }

        /// <summary>
        /// 名称：判断题题目数
        /// 要求：最大长度400、类型为nvarchar
        /// </summary>
        [StringLength(400), Column(TypeName = "nvarchar")]
        public string Explain { get; set; }
    }
}
