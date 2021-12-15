using System;

namespace MQTTnet.Server
{
    public interface IMqttServerOptions
    {
        /// <summary>
        /// Gets the client identifier.
        /// Hint: This identifier needs to be unique over all used clients / devices on the broker to avoid connection issues.
        /// </summary>
        string ClientId { get; }

        bool EnablePersistentSessions { get; }

        int MaxPendingMessagesPerClient { get; }
        MqttPendingMessagesOverflowStrategy PendingMessagesOverflowStrategy { get; }

        TimeSpan DefaultCommunicationTimeout { get; }
        TimeSpan KeepAliveMonitorInterval { get; }

        IMqttServerConnectionValidator ConnectionValidator { get; }
        IMqttServerSubscriptionInterceptor SubscriptionInterceptor { get; }
        IMqttServerUnsubscriptionInterceptor UnsubscriptionInterceptor { get; }
        IMqttServerApplicationMessageInterceptor ApplicationMessageInterceptor { get; }
        IMqttServerClientMessageQueueInterceptor ClientMessageQueueInterceptor { get; }
        IMqttServerApplicationMessageInterceptor UndeliveredMessageInterceptor { get; }
        ISuccessfulSendHandler SuccessfulSendHandler { get; }
        IUnSuccessfulSendHandler UnSuccessfulSendHandler { get; }
        IBeforeSendInterceptor BeforeSendInterceptor { get; set; }
        MqttServerTcpEndpointOptions DefaultEndpointOptions { get; }
        MqttServerTlsTcpEndpointOptions TlsEndpointOptions { get; }

        IMqttServerStorage Storage { get; }

        IMqttRetainedMessagesManager RetainedMessagesManager { get; }
    }
}