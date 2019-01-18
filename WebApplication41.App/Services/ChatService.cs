using System;
using System.Collections.Generic;

namespace WebApplication41.App.Services
{
    public class ChatService
    {
        public List<string> Messages { get; set; } = new List<string>();

        public event EventHandler OnMessageReceived;

        public void AddMessage(string message)
        {
            lock (Messages)
            {
                Messages.Add(message);
            }

            OnMessageReceived?.Invoke(this, EventArgs.Empty);
        }
    }
}