using CompetitionSystem.Model.BasesTable;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompetitionSystem.Model.ExamsTable
{
    /// <summary>
    /// 名称：竞赛表
    /// 内容：拥有竞赛的相关属性
    /// </summary>
    public class Competition : BaseEntity
    {
        /// <summary>
        /// 名称：竞赛名称
        /// 要求：非空、最大长度80、类型为nvarchar
        /// </summary>
        [Required, StringLength(80), Column(TypeName = "nvarchar")]
        public string CompetitionName { get; set; }

        /// <summary>
        /// 名称：举办单位
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid UserId { get; set; }

        /// <summary>
        /// 名称：举办单位名称
        /// 要求：必填、最大长度20、类型为nvarchar
        /// </summary>
        [Required, StringLength(20), Column(TypeName = "nvarchar")]
        public string UserName { get; set; }

        /// <summary>
        /// 名称：考试规则
        /// 要求：必填、类型为ntext
        /// </summary>
        [Required, Column(TypeName = "ntext")]
        public string Rule { get; set; }

        /// <summary>
        /// 名称：报名开始时间
        /// 要求：非空
        /// </summary>
        [Required]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 名称：报名结束时间
        /// 要求：非空
        /// </summary>
        [Required]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 名称：人数上限
        /// </summary>
        public int MaxPeople { get; set; }

        /// <summary>
        /// 名称：竞赛封面
        /// 要求：最大长度400、类型为nvarchar
        /// </summary>
        [StringLength(400), Column(TypeName = "nvarchar")]
        public string Cover { get; set; }
    }
}
