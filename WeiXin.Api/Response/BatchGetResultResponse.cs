﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    public class BatchGetResultResponse : WeiXinResponse
    {
        /// <summary>
        /// 任务状态，整型，1表示任务开始，2表示任务进行中，3表示任务已完成
        /// </summary>
        [DataMember(Name = "status")]
        public int Status { get; set; }
        /// <summary>
        /// 操作类型，字节串，目前分别有：1. sync_user(增量更新成员) 2. replace_user(全量覆盖成员)3. replace_party(全量覆盖部门)
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; set; }
        /// <summary>
        /// 任务运行总条数
        /// </summary>
        [DataMember(Name = "total")]
        public int Total { get; set; }
        /// <summary>
        /// 目前运行百分比，当任务完成时为100
        /// </summary>
        [DataMember(Name = "percentage")]
        public int Percentage { get; set; }
    }
}
