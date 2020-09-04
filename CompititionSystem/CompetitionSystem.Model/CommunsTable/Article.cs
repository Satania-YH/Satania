using CompetitionSystem.Model.BasesTable;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompetitionSystem.Model.CommunsTable
{
    /// <summary>
    /// 名称：文章表
    /// 内容：拥有标题、内容等文章的属性
    /// </summary>
    public class Article : BaseEntity
    {
        /// <summary>
        /// 名称：文章标题
        /// 要求：非空、最大长度40、类型为nvarchar
        /// </summary>
        [Required, StringLength(40), Column(TypeName = "nvarchar")]
        public string Title { get; set; }

        /// <summary>
        /// 名称：文章内容
        /// 要求：非空、类型为ntext
        /// </summary>
        [Required, Column(TypeName = "ntext")]
        public string Content { get; set; }

        /// <summary>
        /// 名称：是否公开
        /// 要求：非空、默认为true
        /// </summary>
        [Required]
        public bool IsPublic { get; set; } = true;

        /// <summary>
        /// 名称：作者
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid UserId { get; set; }

        /// <summary>
        /// 名称：阅读数
        /// 要求：非空、初始为0
        /// </summary>
        [Required]
        public int ReadsNum { get; set; } = 0;

        /// <summary>
        /// 名称：点赞数
        /// 要求：非空、初始为0
        /// </summary>
        [Required]
        public int LikesNum { get; set; } = 0;

        /// <summary>
        /// 名称：评论数
        /// 要求：非空、初始为0
        /// </summary>
        [Required]
        public int CommentsNum { get; set; } = 0;

        /// <summary>
        /// 名称：收藏数
        /// 要求：非空、类型为int
        /// </summary>
        [Required]
        public int CollectionsNum { get; set; } = 0;
    }
}
