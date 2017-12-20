﻿using System.Text;
using WebSockets.Client;
using WebSockets.Common;

namespace WebSocketsClient.Client
{
    class ChatWebSocketClient : WebSocketClient
    {
        public ChatWebSocketClient(bool noDelay, IWebSocketLogger logger) : base(noDelay, logger)
        {
            
        }

        public void Send(string text)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(text);
            Send(WebSocketOpCode.TextFrame, buffer);
        }
    }
}
