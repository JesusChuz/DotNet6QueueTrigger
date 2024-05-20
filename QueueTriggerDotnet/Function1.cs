using System;
using System.Threading.Tasks;
using Azure.Identity;
using Azure.Storage.Queues;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace QueueTriggerDotnet
{
    public class Function1
  //  public static class Function1
    {
        [FunctionName("Function1")]
        public void Run([QueueTrigger("myqueue", Connection = "QueueConnStr")] string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
        //[FunctionName("Function1")]
        //public static async Task Run(
        //[QueueTrigger("myqueue", Connection = "QueueConnStr")] string myQueueItem,
        //ILogger log)
        //{
        //    log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");

        //    // Get the environment variables
        //    string userAssignedClientId = Environment.GetEnvironmentVariable("QueueConnStr__clientId");
        //    string storageAccountName = "sajesumequeuemsi";

        //    // Create a DefaultAzureCredential with user-assigned managed identity
        //    var credential = new DefaultAzureCredential(new DefaultAzureCredentialOptions
        //    {
        //        ManagedIdentityClientId = userAssignedClientId
        //    });

        //    // Create a QueueClient with the managed identity credential
        //    string queueName = "myqueue";
        //    string storageAccountUrl = Environment.GetEnvironmentVariable("QueueConnStr__queueServiceUri");

        //    QueueClient queueClient = new QueueClient(new Uri($"{storageAccountUrl}/{queueName}"), credential);

        //    // Perform queue operations as needed
        //    await queueClient.SendMessageAsync("Hello from user managed identity");
        //}
    }
}
