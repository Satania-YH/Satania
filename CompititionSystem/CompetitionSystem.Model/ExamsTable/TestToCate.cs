﻿using CompetitionSystem.Model.BasesTable;
using System;
using System.ComponentModel.DataAnnotations;

namespace CompetitionSystem.Model.ExamsTable
{
    /// <summary>
    /// 名称：试卷分类关系表
    /// 内容：拥有试卷与关系的联系属性
    /// </summary>
    public class TestToCate : BaseEntity
    {
        /// <summary>
        /// 名称：试卷Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid TestPaperId { get; set; }

        /// <summary>
        /// 名称：分类Id
        /// 要求：非空
        /// </summary>
        [Required]
        public Guid CategoryId { get; set; }
    }
}
