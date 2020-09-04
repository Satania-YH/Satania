using CompetitionSystem.Model.BasesTable;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompetitionSystem.Model.ExamsTable
{
    /// <summary>
    /// 名称：题目表
    /// 内容：拥有选项、答案等题目的相关属性
    /// </summary>
    public class Question : BaseEntity
    {
        /// <summary>
        /// 名称：题目内容
        /// 要求：非空、类型为ntext
        /// </summary>
        [Required, Column(TypeName = "ntext")]
        public string Content { get; set; }

        /// <summary>
        /// 名称：题目答案
        /// 要求：非空、最大长度400、类型为nvarchar
        /// </summary>
        [Required, StringLength(400), Column(TypeName = "nvarchar")]
        public string Answer { get; set; }

        /// <summary>
        /// 名称：题目类型
        /// 约束：1-单选题 2-多选题 3-判断题 4-填空题
        /// 要求：非空
        /// </summary>
        [Required]
        public int QuestionType { get; set; }

        /// <summary>
        /// 名称：题目难度
        /// 约束：1-5 ：1-5星
        /// 要求：非空
        /// </summary>
        [Required]
        public int Difficulty { get; set; }

        /// <summary>
        /// 名称：选项A
        /// 要求：最大长度200、类型为nvarchar
        /// </summary>
        [StringLength(200), Column(TypeName = "nvarchar")]
        public string A_Option { get; set; }

        /// <summary>
        /// 名称：选项B
        /// 要求：最大长度200、类型为nvarchar
        /// </summary>
        [StringLength(200), Column(TypeName = "nvarchar")]
        public string B_Option { get; set; }

        /// <summary>
        /// 名称：选项C
        /// 要求：最大长度200、类型为nvarchar
        /// </summary>
        [StringLength(200), Column(TypeName = "nvarchar")]
        public string C_Option { get; set; }

        /// <summary>
        /// 名称：选项D
        /// 要求：最大长度200、类型为nvarchar
        /// </summary>
        [StringLength(200), Column(TypeName = "nvarchar")]
        public string D_Option { get; set; }

        /// <summary>
        /// 名称：答案解析
        /// 要求：类型为ntext
        /// </summary>
        [Column(TypeName = "ntext")]
        public string Analysis { get; set; }
    }
}
