using System.Threading.Tasks;

namespace NestorHub.Common.Api.Mef
{
    public interface ISentinel
    {
        Task<bool> Run(string sentinelName, string packageName, string homeControllerUrl, int homeControllerPort, bool useSsl, object parameter);
        Task<bool> Stop();
    }
}
