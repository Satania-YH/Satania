using CompetitionSystem.Model.BasesTable;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompetitionSystem.Model.CommunsTable
{
    /// <summary>
    /// 名称：通知表
    /// 内容：拥有通知的相关属性
    /// </summary>
    public class Notice : BaseEntity
    {
        /// <summary>
        /// 名称：发出通知的用户Id
        /// 约束：空代表管理员，非空代表用户
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// 名称：通知内容
        /// 要求：非空、最大长度800、类型为nvarchar
        /// </summary>
        [Required, StringLength(800), Column(TypeName = "nvarchar")]
        public string Content { get; set; }

        /// <summary>
        /// 名称：头像
        /// 要求：非空、最大长度400、类型为nvarchar
        /// </summary>
        [StringLength(400), Column(TypeName = "nvarchar")]
        public string ImagePath { get; set; }

        /// <summary>
        /// 名称：昵称
        /// 要求：非空、最大长度40、类型为nvarchar
        /// </summary>
        [StringLength(40), Column(TypeName = "nvarchar")]
        public string NickName { get; set; }
    }
}
