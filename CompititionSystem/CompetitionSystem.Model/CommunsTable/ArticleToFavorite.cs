using CompetitionSystem.Model.BasesTable;
using System;
using System.ComponentModel.DataAnnotations;

namespace CompetitionSystem.Model.CommunsTable
{
    /// <summary>
    /// 名称：用户收藏表
    /// 内容：拥有用户收藏相关的属性
    /// </summary>
    public class ArticleToFavorite : BaseEntity
    {
        /// <summary>
        /// 名称：收藏的用户Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid UserId { get; set; }

        /// <summary>
        /// 名称：收藏夹Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid FavoriteId { get; set; }

        /// <summary>
        /// 名称：收藏的目标Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid TargetId { get; set; }

        /// <summary>
        /// 名称：收藏的类型
        /// 约束：1-文章
        /// </summary>
        [Required]
        public int TargetType { get; set; }
    }
}
