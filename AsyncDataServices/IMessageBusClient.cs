using WebApplication2.Dtos;

namespace WebApplication2.AsyncDataServices
{
    public interface IMessageBusClient
    {
        void PublishNewPlatform(PublishedDto platformPublishedDto);
    }
}