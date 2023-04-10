using Azure;
using Azure.Messaging.EventGrid;
using CustomEventGridTopicEventPublisher;
using System.Text.Json;

var customTopicEndpoint = new Uri("https://customeventgridtopic.eastus-1.eventgrid.azure.net/api/events");
var accessKeyCred = new AzureKeyCredential("jQJUmJGBSoRvxnkaTetJx/JzphzpAALVOHb1GYfzi+M=");


EventGridPublisherClient publisherClient = new EventGridPublisherClient(customTopicEndpoint, accessKeyCred);

var order = new Order()
{
    OrderId= 1,
    Quality = 10,
    UnitPrice = 9.8M
};

List<EventGridEvent> eventGridEvents = new List<EventGridEvent>()
{
    new EventGridEvent("Posting a New Order", "app.neworder", "1.0", JsonSerializer.Serialize(order))
};


publisherClient.SendEvents(eventGridEvents);

Console.WriteLine("Events Sent to Custom Topic");
