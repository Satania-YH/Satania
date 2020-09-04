using CompetitionSystem.Model.BasesTable;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompetitionSystem.Model.CommunsTable
{
    /// <summary>
    /// 名称：公告表
    /// 内容：拥有公告的相关属性
    /// </summary>
    public class Journalism : BaseEntity
    {
        /// <summary>
        /// 名称：公告标题
        /// 要求：非空、最大长度40、类型为nvarchar
        /// </summary>
        [Required, StringLength(40), Column(TypeName = "nvarchar")]
        public string Title { get; set; }

        /// <summary>
        /// 名称：公告内容
        /// 要求：非空、类型为ntext
        /// </summary>
        [Required, Column(TypeName = "ntext")]
        public string Content { get; set; }
    }
}
