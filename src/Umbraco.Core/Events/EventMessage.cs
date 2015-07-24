namespace Umbraco.Core.Events
{
    /// <summary>
    /// An event message
    /// </summary>
    public sealed class EventMessage
    {        
        /// <summary>
        /// Initializes a new instance of the <see cref="EventMessage"/> class.
        /// </summary>
        public EventMessage(string category, string message, EventMessageType messageType = EventMessageType.Default)
        {
            Category = category;
            Message = message;
            MessageType = messageType;
        }

        public string Category { get; private set; }
        public string Message { get; private set; }
        public EventMessageType MessageType { get; private set; }
    }
}