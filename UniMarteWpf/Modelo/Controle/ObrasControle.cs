using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

namespace UniMarteWpf.Modelo.Controle
{
    internal class ObrasControle
    {
        private BlobServiceClient blobServiceClient;
        private List<string> _imagens;
        private int _indiceAtual;

        public ObrasControle(string connectionString, string containerName)
        {
            blobServiceClient = new BlobServiceClient(connectionString);
            _imagens = new List<string>();
            _indiceAtual = 0;
        }

        // Carrega as imagens do container Blob
        public async Task CarregarImagensDoBlob(string containerName)
        {
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
            await foreach (BlobItem blobItem in containerClient.GetBlobsAsync())
            {
                string blobUrl = $"{containerClient.Uri}/{blobItem.Name}";
                _imagens.Add(blobUrl);
            }
        }

        public string ObterImagemAtual()
        {
            if (_imagens.Count > 0)
            {
                return _imagens[_indiceAtual];
            }
            return null;
        }

        public string ObterImagemAnterior()
        {
            if (TemImagemAnterior())
            {
                return _imagens[_indiceAtual - 1];
            }
            return null;
        }

        public string ObterImagemPosterior()
        {
            if (TemImagemPosterior())
            {
                return _imagens[_indiceAtual + 1];
            }
            return null;
        }

        public void AvancarImagem()
        {
            if (_indiceAtual < _imagens.Count - 1)
            {
                _indiceAtual++;
            }
        }

        public void RetrocederImagem()
        {
            if (_indiceAtual > 0)
            {
                _indiceAtual--;
            }
        }

        public bool TemImagemAnterior() => _indiceAtual > 0;
        public bool TemImagemPosterior() => _indiceAtual < _imagens.Count - 1;
    }
}
