using AzureBlobStorageManager.Models;

namespace AzureBlobStorageManager.Services.Contracts
{
    public interface IBlobService
    {
        Task<string> GetBlob(string name, string containerName);
        Task<List<string>> GetAllBlobsByContainerName(string containerName);
        Task<List<Blob>> GetAllBlobsWithUri(string containerName);
        Task<bool> UploadBlob(string name, IFormFile file, string containerName, Blob blob);
        Task<bool> DeleteBlob(string name, string containerName);
    }
}
