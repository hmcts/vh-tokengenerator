using System;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace TokenGenerator
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length != 4)
            {
                Console.Write("Please use: ADTokenGenerator.exe <authority> <clientId> <clientSecret> <resourceId>");
                return 1;
            }

            var authority = args[0];
            var clientId = args[1];
            var clientSecret = args[2];
            var resource = args[3];

            var authContext = new AuthenticationContext(authority);
            var credential = new ClientCredential(clientId, clientSecret);
            try
            {
                var result = authContext.AcquireTokenAsync(resource, credential).Result;
                Console.Write(result.AccessToken);
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving token: " + ex.Message);
                return 1;
            }
        }
    }
}