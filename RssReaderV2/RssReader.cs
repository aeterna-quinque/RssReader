using System;
using System.Xml;
using System.Text.RegularExpressions;

namespace RssReader
{
    class RssReader
    {
        private Items[] articles;
        private ChannelClass _channel = new ChannelClass();
        private int count;

        public void GetNewArticles(string fileSource)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileSource);

            XmlNodeList nodeList;
            XmlNode root = doc.DocumentElement;
            articles = new Items[root.SelectNodes("channel/item").Count];
            nodeList = root.ChildNodes;
            count = 0;

            foreach (XmlNode channel in nodeList)
            {
                foreach (XmlNode channel_item in channel)
                {
                    if (channel_item.Name == "title") _channel.title = channel_item.InnerText;
                    if (channel_item.Name == "description") _channel.description = channel_item.InnerText;
                    if (channel_item.Name == "pubDate") _channel.pubDate = channel_item.InnerText;
                    if (channel_item.Name == "link") _channel.link = channel_item.InnerText;

                    if (channel_item.Name == "item")
                    {
                        XmlNodeList itemsList = channel_item.ChildNodes;
                        articles[count] = new Items();

                        foreach (XmlNode item in itemsList)
                        {
                            if (item.Name == "title") articles[count].title = item.InnerText;
                            if (item.Name == "link") articles[count].link = item.InnerText;
                            if (item.Name == "description") articles[count].description = item.InnerText;
                            if (item.Name == "pubDate") articles[count].pubDate = item.InnerText;
                        }
                        count++;
                    }
                }
            }
        }

        public string[] GetArticle(Items item)
        {
            string[] result = new string[5];
            result[0] = "\n\n\n";
            result[1] = $"{item.title}";
            result[2] = $"{item.pubDate}";
            result[3] = $"{item.description}";
            result[3] = Regex.Replace(result[3], "<[^>]+>", string.Empty);
            result[3] = result[3].Replace(" &rarr;", ":");
            result[4] = $"{item.link}";
            return result;
        }

        public string[] GetText()
        {
            string[] result = new string[count*5+5];
            result[0] = $"Последнее обновление страницы: {DateTime.Now}\n";
            result[1] = $"{_channel.title}";
            result[2] = $"{_channel.description}";
            result[2] = Regex.Replace(result[1], "<[^>]+>", string.Empty);
            result[3] = $"{_channel.link}";
            result[4] = $"{_channel.pubDate}";
            string[] article_text = new string[5];
            int counter = 5;
            foreach (Items item in articles)
            {
                article_text = GetArticle(item);
                for (int j = 0; j < 5; j++)
                    result[j + counter] = article_text[j];
                counter += 5;
            }
            return result;
        }

        public string GetSiteName()
        {
            return _channel.title;
        }
    }
}
