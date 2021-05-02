// ReSharper disable InconsistentNaming
namespace Owlbear.Dto.Remote.Twitter
{
    public class Data
    {
        public string id { get; set; }
        public TweetPublicMetricsDto public_metrics { get; set; }
        public string text { get; set; }
    }
}