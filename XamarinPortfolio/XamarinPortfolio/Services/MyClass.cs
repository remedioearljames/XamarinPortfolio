using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XamarinPortfolio.Services
{
    class MyClass
    {
        public static async Task performBlobOperation()
        {
            // Retrieve storage account from connection string.
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=crossdb;AccountKey=SharedAccessSignature=sv=2018-03-28&ss=bfqt&srt=sco&sp=rwdlacup&st=2020-01-19T23%3A46%3A37Z&se=2020-01-20T23%3A46%3A37Z&sig=F4TuRiDinISYD3ce5CqakJB7GetDnithYtL4ThMnP5I%3D;BlobEndpoint=https://crossdb.blob.core.windows.net/;FileEndpoint=https://crossdb.file.core.windows.net/;QueueEndpoint=https://crossdb.queue.core.windows.net/;TableEndpoint=https://crossdb.table.core.windows.net/;");

            // Create the blob client.
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            // Retrieve reference to a previously created container.
            CloudBlobContainer container = blobClient.GetContainerReference("mycontainer");

            // Create the container if it doesn't already exist.
            await container.CreateIfNotExistsAsync();

            // Retrieve reference to a blob named "myblob".
            CloudBlockBlob blockBlob = container.GetBlockBlobReference("myblob");

            // Create the "myblob" blob with the text "Hello, world!"
            await blockBlob.UploadTextAsync("Hello, world!");

        }
    }
}