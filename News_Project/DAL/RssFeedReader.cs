using System;
using System.Collections.Generic;
using System.Web;
using System.Xml;

namespace News_Project.DAL
{
    public class RssFeedReader
    {
        private string url = "http://news.google.com/news?pz=1&cf=all&ned=en_il&hl=en&output=rss";
        private const string CacheKey = "GoogleNewsFeed";

        public List<RssFeedItem> GetFeedItems()
        {
            var items = HttpContext.Current.Cache[CacheKey] as List<RssFeedItem>;

            if (items == null)
            {
                items = FetchFeedFromUrl();
                HttpContext.Current.Cache.Insert(CacheKey, items, null, DateTime.Now.AddMinutes(10), TimeSpan.Zero);
                // Cache for 10 minutes, adjust the duration as needed
            }

            return items;
        }

        private List<RssFeedItem> FetchFeedFromUrl()
        {
            var feedItems = new List<RssFeedItem>();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(url);

            XmlNodeList nodes = xmlDoc.SelectNodes("rss/channel/item");

            foreach (XmlNode node in nodes)
            {
                string title = node.SelectSingleNode("title").InnerText;
                string link = node.SelectSingleNode("link").InnerText;
                string description = node.SelectSingleNode("description").InnerText;

                feedItems.Add(new RssFeedItem { Title = title, Link = link, Description = description });
            }

            return feedItems;
        }
    }

    public class RssFeedItem
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
    }
}
