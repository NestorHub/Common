using System;
using System.Threading.Tasks;

namespace NestorHub.Common.Api.Interfaces
{
    public interface IPackageRunner
    {
        bool IsRunning(Guid instanceId);
        void RunAllInstances();
        void RunAllInstancesOnServerStart();
        Task<bool> StopPackage(string packageId);
        Task<bool> StopAllInstances();
        Task<bool> StopInstance(Guid instanceId);
        Task<bool> RunInstance(Guid instanceId);
    }
}