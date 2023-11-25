namespace Balta.NotificationContext
{
    public sealed class Notification{ // sealed --> não pode ser herdada/extendida
        public Notification(){ }

        public Notification(string property, string message)
        {
            Property = property;
            Message = message;
        }

        public string Property { get; set; }
        public string Message { get; set; }
    }
}