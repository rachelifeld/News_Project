using News_Project.DAL;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace News_Project
{
    public partial class WebFormNews1 : System.Web.UI.Page
    {
        RssFeedReader rss = new RssFeedReader();
        List<string> listTitle = new List<string>();
        List<string> listLink = new List<string>();
        List<string> listDescription = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadFeedItems();
            }
        }

        protected void LoadFeedItems()
        {
            List<RssFeedItem> items = rss.GetFeedItems();

            foreach (RssFeedItem item in items)
            {
                listTitle.Add(item.Title);
                listDescription.Add(item.Description);
                listLink.Add(item.Link);
            }

            // Bind the lists to the repeater control
            Repeater1.DataSource = items;
            Repeater1.DataBind();
        }
    }
}
