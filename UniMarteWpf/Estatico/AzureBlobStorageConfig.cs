using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniMarteWpf.Estatico
{
    public static class AzureBlobStorageConfig
    {
        public const string ConnectionString =
            "DefaultEndpointsProtocol=https;" +
            "AccountName=unimarteimages;" +
            "AccountKey=08I9cMkTZvsvwe2pUUhQNTt0+ExS13zBYflqHpEqGQecVRBnyv3CkJCQ4EUauspdIygIBjdcCu0e+AStd7GRVA==;" +
            "EndpointSuffix=core.windows.net";

        public const string ContainerName = "unimarteimages";
    }

}
