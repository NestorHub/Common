namespace NestorHub.Common.Api.Interfaces
{
    public interface IHostingConfiguration
    {
        string GetUrlToUse();
        string GetAddressServer();
        int GetPortServer();
        bool GetUseSsl();
    }
}