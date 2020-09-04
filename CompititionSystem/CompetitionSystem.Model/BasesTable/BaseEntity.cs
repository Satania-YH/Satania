using System;
using System.ComponentModel.DataAnnotations;

namespace CompetitionSystem.Model.BasesTable
{
    /// <summary>
    /// 名称：基础表
    /// 内容：拥有Id、时间等所有表通用的属性
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// 名称：Id
        /// 要求：主键、默认为创建时自动生成
        /// </summary>
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// 名称：生成时间
        /// 要求：默认为当前时间
        /// </summary>
        public DateTime CreateTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 名称：最后修改时间
        /// </summary>
        public DateTime EditTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 名称：是否删除
        /// 要求：默认为false
        /// </summary>
        public bool IsRemoved { get; set; } = false;
    }
}
