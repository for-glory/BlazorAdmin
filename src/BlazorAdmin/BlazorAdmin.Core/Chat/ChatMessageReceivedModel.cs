﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAdmin.Core.Chat
{
    public class ChatMessageReceivedModel
    {
        /// <summary>
        /// 频道（指定频道发送时）
        /// </summary>
        public int ChannelId { get; set; }

        /// <summary>
        /// 发送人
        /// </summary>
        public int SenderId { get; set; }

        /// <summary>
        /// 发送内容
        /// </summary>
        public string? Content { get; set; }
    }
}
