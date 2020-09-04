using CompetitionSystem.Model.BasesTable;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompetitionSystem.Model.CommunsTable
{
    /// <summary>
    /// 名称：收藏夹表
    /// 内容：拥有用户创建的收藏夹的属性
    /// </summary>
    public class Favorite : BaseEntity
    {
        /// <summary>
        /// 名称：收藏夹名称
        /// 要求：非空、最大长度40、类型为nvarchar
        /// </summary>
        [Required, StringLength(40), Column(TypeName = "nvarchar")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 名称：创建收藏夹的用户Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid UserId { get; set; }
    }
}
