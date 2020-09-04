using CompetitionSystem.Model.BasesTable;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompetitionSystem.Model.UsersTable
{
    /// <summary>
    /// 名称：用户表
    /// 内容：拥有账号密码等用户通用的属性
    /// </summary>
    public class User : BaseEntity
    {
        /// <summary>
        /// 名称：账号
        /// 要求：非空、最大长度32、类型为varchar
        /// </summary>
        [Required, StringLength(32), Column(TypeName = "varchar")]
        public string Email { get; set; }

        /// <summary>
        /// 名称：密码
        /// 要求：非空、最大长度32、类型为varchar
        /// </summary>
        [Required, StringLength(32), Column(TypeName = "varchar")]
        public string Password { get; set; }

        /// <summary>
        /// 名称：用户类型
        /// 要求：非空、最大长度40、类型为nvarchar
        /// </summary>
        [Required, StringLength(40), Column(TypeName = "nvarchar")]
        public string UserType { get; set; }

        /// <summary>
        /// 名称：头像
        /// 要求：非空、最大长度400、类型为nvarchar
        /// </summary>
        [Required, StringLength(400), Column(TypeName = "nvarchar")]
        public string ImagePath { get; set; }

        /// <summary>
        /// 名称：昵称
        /// 要求：非空、最大长度40、类型为nvarchar
        /// </summary>
        [Required, StringLength(40), Column(TypeName = "nvarchar")]
        public string NickName { get; set; }

        /// <summary>
        /// 名称：是否处于登录状态
        /// 要求：非空、初始为false
        /// </summary>
        [Required]
        public bool IsLogin { get; set; } = false;
    }
}
