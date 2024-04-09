News Project
Overview

This project is a simple ASP.NET Web Forms application that retrieves news feed items from Google News and displays them on a webpage.


Project Structure

DAL (Data Access Layer)

    RssFeedReader.cs: This class retrieves news feed items from a URL using XML parsing.
    RssFeedItem.cs: This class represents a single news feed item with properties for Title, Link, and Description.

Web Components

    WebFormNews1.aspx: The main webpage that displays the news feed items.
    WebFormNews1.aspx.cs: Code behind for the webpage. Handles fetching news feed items and binding them to the repeater control.

Scripts

    news.js: JavaScript code that handles toggling the visibility of news item descriptions when the title is clicked.

Styles

    StyleNews.css: Stylesheet for the webpage layout.

Dependencies

    This project requires ASP.NET Web Forms to be set up and running.
    jQuery library is included in the project (Scripts/jquery.min.js).

Instructions

    Clone the project repository.
    Open the project in Visual Studio or your preferred ASP.NET development environment.
    Ensure you have ASP.NET Web Forms configured and running.
    Run the project (WebFormNews1.aspx).
    The webpage should display a list of news headlines retrieved from Google News. Clicking a headline will toggle the visibility of the corresponding news description.

Notes

    The RssFeedReader.cs class caches the retrieved news feed items for 10 minutes to improve performance. You can adjust the cache duration as needed.
    The Google News feed URL used in the project can be modified to retrieve news from a different source.
![image](https://github.com/rachelifeld/News_Project/assets/92298907/2de6ec7b-5c9e-47ee-b097-45974d4ecd09)

Clicking on the link opens:

![image](https://github.com/rachelifeld/News_Project/assets/92298907/9ab1a814-5b61-43d4-8a75-e6e7f72becc0)

