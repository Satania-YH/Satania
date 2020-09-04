using CompetitionSystem.Model.BasesTable;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompetitionSystem.Model.ExamsTable
{
    /// <summary>
    /// 名称：学生题目联系表
    /// 内容：拥有学生答题情况的相关属性
    /// </summary>
    public class StudentToQues : BaseEntity
    {
        /// <summary>
        /// 名称：学生Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid UserId { get; set; }

        /// <summary>
        /// 名称：题目Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid QuestionId { get; set; }

        /// <summary>
        /// 名称：试卷Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid TestPaperId { get; set; }

        /// <summary>
        /// 名称：学生答案
        /// 要求：非空、最大长度400、类型为nvarchar
        /// </summary>
        [Required, StringLength(400), Column(TypeName = "nvarchar")]
        public string YourAnswer { get; set; }

        /// <summary>
        /// 名称：正确答案
        /// 要求：非空、最大长度400、类型为nvarchar
        /// </summary>
        [Required, StringLength(400), Column(TypeName = "nvarchar")]
        public string TrueAnswer { get; set; }

        /// <summary>
        /// 名称：是否正确
        /// </summary>
        public bool IsTrue { get; set; }
    }
}
