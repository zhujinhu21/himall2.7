//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Himall.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TopicInfo:BaseModel
    {
        public TopicInfo()
        {
            this.TopicModuleInfo = new HashSet<TopicModuleInfo>();
            this.Himall_MobileHomeTopics = new HashSet<MobileHomeTopicsInfo>();
        }
    
        long _id;
        public new long Id { get{ return _id; } set{ _id=value; base.Id = value; } }
        public string Name { get; set; }
        private string topImage { get; set; }
        private string backgroundImage { get; set; }
        public string frontCoverImage { get; set; }
        public string Tags { get; set; }
        public Himall.Core.PlatformType PlatForm { get; set; }
        public long ShopId { get; set; }
        public bool IsRecommend { get; set; }
        public string SelfDefineText { get; set; }
    
        public virtual ICollection<TopicModuleInfo> TopicModuleInfo { get; set; }
        public virtual ICollection<MobileHomeTopicsInfo> Himall_MobileHomeTopics { get; set; }
    }
}