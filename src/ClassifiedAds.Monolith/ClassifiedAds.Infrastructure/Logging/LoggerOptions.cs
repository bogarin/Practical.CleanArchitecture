namespace ClassifiedAds.Infrastructure.Logging
{
    public class LoggerOptions
    {
        public FileOptions File { get; set; }

        public ElasticsearchOptions Elasticsearch { get; set; }

        public EventLogOptions EventLog { get; set; }
    }
}
