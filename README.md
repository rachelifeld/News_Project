Project Structure
The project is organized into several folders for better maintainability:

DAL (Data Access Layer):
RssFeedReader.cs: This class retrieves news feed items from a URL using XML parsing.
RssFeedItem.cs: This class represents a single news item with properties for Title, Link, and Description.
Web Components:
WebFormNews1.aspx: The main webpage that displays the news feed items.
WebFormNews1.aspx.cs: Code behind for the webpage. Handles fetching news feed items and binding them to the repeater control.
Scripts:
news.js: JavaScript code that handles toggling the visibility of news item descriptions when the title is clicked.
Styles:
StyleNews.css: Stylesheet for the webpage layout.
Dependencies
ASP.NET Web Forms: This project requires a development environment with ASP.NET Web Forms set up and running.
jQuery library: The project includes the jQuery library (Scripts\jquery.min.js) for enhanced interactivity.
Instructions
Clone or download the project repository.
Open the project in Visual Studio or your preferred ASP.NET development environment.
Ensure you have ASP.NET Web Forms configured and running on your development machine.
Run the project by opening WebFormNews1.aspx.
The webpage should display a list of news headlines retrieved from Google News. Clicking a headline will toggle the visibility of the corresponding news description.
Notes
The RssFeedReader.cs class caches the retrieved news feed items for 10 minutes to improve performance. You can adjust the cache duration as needed within the code.
The Google News feed URL used in the project can be modified to retrieve news from a different source. This allows you to customize the project to display news relevant to your interests.
![image](https://github.com/rachelifeld/News_Project/assets/92298907/2de6ec7b-5c9e-47ee-b097-45974d4ecd09)

