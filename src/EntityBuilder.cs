// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityBuilder.cs" company="pzcast">
//   (C) 2015 pzcast. All rights reserved.
// </copyright>
// <summary>
//   The entity builder.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EntityTemplate
{
    using System;
    using EntityTemplate.Attributes;
    
    /// <summary>
    /// 企业信息表.
    /// </summary>
    [Table("Corporation")]
    public class Corporation
    {
        #region Public Properties
        
        /// <summary>
        /// 获取或设置主键编号.
        /// </summary>
        [PrimaryKey(false)]
        public Guid Id { get; set; }

        /// <summary>
        /// 获取或设置网页地址.
        /// </summary>
        [NotNull]
        public string WebAddress { get; set; }

        /// <summary>
        /// 获取或设置企业名称.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 获取或设置企业性质（1：外商独资，2：股份制企业，3：合资，4：国企，5：民营，6：上市公司，7：代表处，8：事业单位，9：国家机关，10：非营利机构，11：其它）.
        /// </summary>
        public byte? Trait { get; set; }

        /// <summary>
        /// 获取或设置企业规模（1：小于50，2：50-150，3：150-500，4：500-1000，5：1000-5000，6：5000-10000，7：大于10000）.
        /// </summary>
        public byte? Scale { get; set; }

        /// <summary>
        /// 获取或设置官方网站.
        /// </summary>
        public string WebSite { get; set; }

        /// <summary>
        /// 获取或设置企业介绍.
        /// </summary>
        public string Introduce { get; set; }

        /// <summary>
        /// 获取或设置企业详细地址.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 获取或设置爬取时间.
        /// </summary>
        [NotNull]
        public DateTime CrawlTime { get; set; }
        
        #endregion
    }

    /// <summary>
    /// 职位信息表.
    /// </summary>
    [Table("Job")]
    public class Job
    {
        #region Public Properties
        
        /// <summary>
        /// 获取或设置主键编号.
        /// </summary>
        [PrimaryKey(true)]
        public long Id { get; private set; }

        /// <summary>
        /// 获取或设置公司编号.
        /// </summary>
        [NotNull]
        public Guid CorporationId { get; set; }

        /// <summary>
        /// 获取或设置网页地址.
        /// </summary>
        [NotNull]
        public string WebAddress { get; set; }

        /// <summary>
        /// 获取或设置职位名称.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 获取或设置职位性质（1：全职，2：兼职，3：实习）.
        /// </summary>
        public byte? Trait { get; set; }

        /// <summary>
        /// 获取或设置职位类别.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// 获取或设置最低学历（1：高中，2：中专，3：大专，4：本科，5：硕士，6：博士及以上，7：不限）.
        /// </summary>
        public byte? Degree { get; set; }

        /// <summary>
        /// 获取或设置工作地点.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// 获取或设置工作经验（1：在读学生，2：应届毕业生，3：一年以下，4：1-3年，5：3-5年，6：5-10年，7：10年以上，8：不限）.
        /// </summary>
        public byte? Experience { get; set; }

        /// <summary>
        /// 获取或设置招聘人数.
        /// </summary>
        public int? Number { get; set; }

        /// <summary>
        /// 获取或设置支付方式（1：月薪，2：年薪）.
        /// </summary>
        public byte? PaymentMethod { get; set; }

        /// <summary>
        /// 获取或设置薪资.
        /// </summary>
        public string Wages { get; set; }

        /// <summary>
        /// 获取或设置职位描述.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 获取或设置职位详细地址.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 获取或设置发布时间.
        /// </summary>
        public DateTime? PublishTime { get; set; }

        /// <summary>
        /// 获取或设置爬取时间.
        /// </summary>
        [NotNull]
        public DateTime CrawlTime { get; set; }
        
        #endregion
    }
}
