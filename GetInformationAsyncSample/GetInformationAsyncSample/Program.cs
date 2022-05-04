using Box.V2;
using Box.V2.Auth;
using Box.V2.Config;
using Box.V2.Models;
using System;
using System.Threading.Tasks;

namespace GetInformationAsyncSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var config = new BoxConfigBuilder("", "").Build();
            var session = new OAuthSession("INSERT YOUR TOKEN HERE", "", 3600, "bearer");
            var client = new BoxClient(config, session);
            BoxFile boxFile = await client.FilesManager.GetInformationAsync(id: "INSERT YOUR FILE ID HERE");
            Console.WriteLine(boxFile.Parent.Id);
        }
    }
}
