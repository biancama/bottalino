using Bottalino.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bottalino.service
{
    public class RemoteOperation
    {
        private FtpClient ftpClient;
        private string remoteFolder;

        public RemoteOperation(FtpClient ftpClient, string remoteFolder)
        {
            this.ftpClient = ftpClient;
            this.remoteFolder = remoteFolder;
        }

        public async Task<bool> CheckJobStartAsync(string checkFile)
        {
            
            var tokenSource2 = new CancellationTokenSource();
            CancellationToken ct = tokenSource2.Token;

            bool inputFileIsCreated = await Interval.RT(() => IsStartFilePresentOnTheFTPServer(checkFile), 5, ct);

            return inputFileIsCreated;
        }

        private bool IsStartFilePresentOnTheFTPServer(string checkFile)
        {
            var files = this.ftpClient.directoryListSimple(this.remoteFolder);

            foreach(string file in files)
            {
                if (file == checkFile)
                {                   
                    return true;
                }
            }

            return false;

        }
    }
}
