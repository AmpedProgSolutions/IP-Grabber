using System;
using System.Net;
using System.Security.Principal;

class FileDownloader
{
    static void Main()
    {
        // URL of file to download
        string fileUrl = "https://itch.io/index.html";

        // Local file path to save downloaded file to
        string filePath = "C:\\downloads\\itch-index.html";

        // Create a web client to download the file
        WebClient webClient = new WebClient();

        try
        {
            // Download the file and save it to the specified path
            webClient.DownloadFile(fileUrl, filePath);

            // Output success message
            System.Console.WriteLine("File downloaded successfully to {0}", filePath);
        }
        catch (WebException ex)
        {
            // Output error message
            System.Console.WriteLine("Error downloading file: {0}", ex.Message);
        }
        finally
        {
            // Dispose of web client resources
            webClient.Dispose();
        }
    }
}

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
