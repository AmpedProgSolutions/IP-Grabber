using System;
using System.Net;
using System.Security.Principal;

class UserInfo
{
    static void Main()
    {
        // Get the current user's Windows identity
        WindowsIdentity identity = WindowsIdentity.GetCurrent();

        // Get the user's name and login status
        string userName = identity.Name;
        bool isAuthenticated = identity.IsAuthenticated;

        // Display the user's name and login status
        Console.WriteLine("User: {0}", userName);
        Console.WriteLine("Authenticated: {0}", isAuthenticated);

        // Get the IP address of the local machine
        IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());

        foreach (IPAddress ip in localIPs)
        {
            // Only display IPv4 addresses
            if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
            {
                Console.WriteLine("IP Address: {0}", ip.ToString());
            }
        }
    }
}
