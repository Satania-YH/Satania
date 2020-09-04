using CompetitionSystem.Model.BasesTable;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompetitionSystem.Model.UsersTable
{
    /// <summary>
    /// 名称：学生表
    /// 内容：拥有学号姓名等学生用户的属性
    /// </summary>
    public class Student : BaseEntity
    {
        /// <summary>
        /// 名称：用户Id
        /// 要求：非空、来自用户表的外键
        /// </summary>
        [Required, ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public User User { get; set; }

        /// <summary>
        /// 名称：真实姓名
        /// 要求：最大长度20、类型为nvarchar
        /// </summary>
        [StringLength(20), Column(TypeName = "nvarchar")]
        public string TrueName { get; set; }

        /// <summary>
        /// 名称：性别
        /// 约束：true-男 false-女
        /// </summary>
        public bool Sex { get; set; }

        /// <summary>
        /// 名称：学校
        /// 要求：最大长度40、类型为nvarchar
        /// </summary>
        [StringLength(40), Column(TypeName = "nvarchar")]
        public string School { get; set; }

        /// <summary>
        /// 名称：学院
        /// 要求：最大长度40、类型为nvarchar
        /// </summary>
        [StringLength(40), Column(TypeName = "nvarchar")]
        public string Academy { get; set; }

        /// <summary>
        /// 名称：班级
        /// 要求：最大长度40、类型为nvarchar
        /// </summary>
        [StringLength(40), Column(TypeName = "nvarchar")]
        public string Class { get; set; }


        /// <summary>
        /// 名称：学号
        /// 要求：最大长度40、类型为nvarchar
        /// </summary>
        [StringLength(40), Column(TypeName = "nvarchar")]
        public string StudentID { get; set; }

        /// <summary>
        /// 名称：联系方式
        /// 要求：最大长度200、类型为nvarchar
        /// </summary>
        [StringLength(200), Column(TypeName = "nvarchar")]
        public string Contact { get; set; }

        /// <summary>
        /// 名称：个人简介
        /// 要求：最大长度400、类型为nvarchar
        /// </summary>
        [StringLength(400), Column(TypeName = "nvarchar")]
        public string Profile { get; set; }
    }
}
