﻿using System.Collections.Generic;
using EQueue.Common;

namespace EQueue.Clients.Consumers
{
    public interface IConsumer
    {
        string GroupName { get; }
        MessageModel MessageModel { get; }
        IEnumerable<string> SubscriptionTopics { get; }
        void Start();
        void Subscribe(string topic);
        void Shutdown();
        void Rebalance();
        void PersistOffset();
        void PullMessage(PullRequest pullRequest);
        void UpdateTopicSubscribeInfo(string topic, IEnumerable<MessageQueue> messageQueues);
        bool IsSubscribeTopicNeedUpdate(string topic);
    }
}