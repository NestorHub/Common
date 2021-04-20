namespace NestorHub.Common.Api
{
    public class Subscription
    {
        public SentinelKey SentinelKey { get; set; }
        public string StateValueSentinelName { get; set; }
        public string StateValuePackageName { get; set; }
        public string StateValueName { get; set; }

        public Subscription()
        {}

        public Subscription(string sentinelKey, string stateValueSentinelName, string stateValuePackageName, string stateValueName)
        {
            SentinelKey = new SentinelKey(sentinelKey);
            StateValueSentinelName = stateValueSentinelName;
            StateValuePackageName = stateValuePackageName;
            StateValueName = stateValueName;
        }
    }
}