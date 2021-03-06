﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Qhyhgf.WeiXin.Qy.Api.Attribute;
using Qhyhgf.WeiXin.Qy.Api.Response;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Domain;

namespace Qhyhgf.WeiXin.Qy.Api.Request
{
    /// <summary>
    /// 更新成员
    /// </summary>
    [Serializable]
    [DataContract]
    [HttpMethod(Method = HttpVerb.Post, Url = "https://qyapi.weixin.qq.com/cgi-bin/user/update", Name = "更新成员", IsToken = true, Serialize = SerializeVerb.Json)]
    public class UpdateUserRequest : IWeiXinRequest<UpdateUserResponse>
    {
        public UpdateUserRequest() {
            Enable = 1;
        }
        /// <summary>
        /// 员工UserID。对应管理端的帐号，企业内必须唯一。长度为1~64个字符
        /// </summary>
        [DataMember(Name = "userid", IsRequired = true)]
        public string UserId { get; set; }
        /// <summary>
        /// 成员名称。长度为1~64个字符
        /// </summary>
        [DataMember(Name = "name", IsRequired = true)]
        public string Name { get; set; }
        /// <summary>
        /// 英文名。长度为1-64个字节。
        /// </summary>
        [DataMember(Name = "english_name", IsRequired = true)]
        public string EnglishName { get; set; }
        /// <summary>
        /// 成员所属部门id列表。注意，每个部门的直属员工上限为1000个
        /// </summary>
        [DataMember(Name = "department")]
        public IList<int> Department { get; set; }
        /// <summary>
        /// 部门内的排序值，默认为0。数量必须和department一致，数值越大排序越前面。有效的值范围是[0, 2^32)
        /// </summary>
        [DataMember(Name = "order")]
        public IList<int> order { get; set; }
        /// <summary>
        /// 职位信息。长度为0~64个字符
        /// </summary>
        [DataMember(Name = "position")]
        public string Position { get; set; }
        /// <summary>
        /// 手机号码。企业内必须唯一，mobile/weixinid/email三者不能同时为空
        /// </summary>
        [DataMember(Name = "mobile")]
        public string Mobile { get; set; }
        /// <summary>
        /// 邮箱。长度为0~64个字符。企业内必须唯一
        /// </summary>
        [DataMember(Name = "email")]
        public string Email { get; set; }
        /// <summary>
        /// 性别。1表示男性，2表示女性
        /// </summary>
        [DataMember(Name = "gender")]
        public int gender { get; set; }
        /// <summary>
        /// 座机。长度0-64个字节。
        /// </summary>
        [DataMember(Name = "telephone")]
        public string Telephone { get; set; }
        /// <summary>
        /// 上级字段，标识是否为上级。
        /// </summary>
        [DataMember(Name = "isleader")]
        public int IsLeader { get; set; }
        /// <summary>
        /// 成员头像的mediaid，通过多媒体接口上传图片获得的mediaid
        /// </summary>
        [DataMember(Name = "avatar_mediaid")]
        public string AvatarMediaid { get; set; }
        /// <summary>
        /// 启用/禁用成员。1表示启用成员，0表示禁用成员
        /// </summary>
        [DataMember(Name = "enable")]
        public int Enable { get; set; }
        /// <summary>
        /// 扩展属性。扩展属性需要在WEB管理端创建后才生效，否则忽略未知属性的赋值
        /// </summary>
        [DataMember(Name = "extattr")]
        public Attrs ExtAttr { get; set; }
    }
}
