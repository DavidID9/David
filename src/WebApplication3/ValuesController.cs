using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure; // Namespace for CloudConfigurationManager
using Microsoft.WindowsAzure.Storage; // Namespace for CloudStorageAccount
using Microsoft.WindowsAzure.Storage.Blob; // Namespace for Blob storage types
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3
{
    public class ValuesController
    {
        [Route("api/[controller]")]

        private readonly CloudBlobClient blobClient;
        public ValuesController(IConfigurationRoot config)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
    CloudConfigurationManager.GetSetting("StorageConnectionString"));


            // Create the blob client.
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

        }
        // GET api/values
        [HttpGet]
        public async static Task ListBlobsSegmentedInFlatListing(CloudBlobContainer container)
        {
            // Retrieve reference to a previously created container.
            CloudBlobContainer container = blobClient.GetContainerReference("mycontainer");

        }



    }
}
