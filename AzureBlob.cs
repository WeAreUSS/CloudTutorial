using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace CloudTutorial
{
    public class AzureBlob
    {
        private static string storageconnstring = "access key"; //ToDo: figure this out....
        
        private static string containerName = "container";  
        private static string filename = "birthdayphoto.jpg";  
        private static string filepath = "C:\\Nirankari\\birthdayphoto.jpg";  
        private static string downloadpath = "C:\\Nirankari\\Azure\\birthdayphoto.jpg";  

        //public string GetBlob(string containerName, string fileName)
        //{
        //    //ToDo: figure out connection string for this....
        //    string connectionString = $"yourconnectionstring";
 
        //    // Setup the connection to the storage account
        //    CloudStorageAccount storageAccount = CloudStorageAccount.Parse(connectionString);
 
        //    // Connect to the blob storage
        //    CloudBlobClient serviceClient = storageAccount.CreateCloudBlobClient();
        //    // Connect to the blob container
        //    CloudBlobContainer container = serviceClient.GetContainerReference($"{containerName}");
        //    // Connect to the blob file
        //    CloudBlockBlob blob = container.GetBlockBlobReference($"{fileName}");
        //    // Get the blob file as text
        //    string contents = blob.DownloadTextAsync().Result;
 
        //    return contents;
        //}

        //public  async Task CreateAndSaveAzureBlob() 
        //{  
        //    BlobServiceClient blobServiceClient = new BlobServiceClient(storageconnstring);  
        //    BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);  
        //    BlobClient blobClient = containerClient.GetBlobClient(filename);  
        //    using FileStream uploadFileStream = File.OpenRead(filepath);  
        //    await blobClient.UploadAsync(uploadFileStream, true);  
        //    uploadFileStream.Close();  
        //}

        //public async Task GetImageBlob(string downloadpath)
        //{
        //    BlobServiceClient blobServiceClient = new BlobServiceClient(storageconnstring);
        //    BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
        //    BlobClient blob = containerClient.GetBlobClient(filename);
        //    BlobDownloadInfo blobdata = await blob.DownloadAsync();
        //    using (FileStream downloadFileStream = File.OpenWrite(downloadpath))
        //    {
        //        await blobdata.Content.CopyToAsync(downloadFileStream);
        //        downloadFileStream.Close();
        //    }
        //}

    }
}
