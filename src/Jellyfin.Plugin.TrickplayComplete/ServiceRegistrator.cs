using MediaBrowser.Controller; using MediaBrowser.Controller.Plugins; using MediaBrowser.Model.Tasks; using Microsoft.Extensions.DependencyInjection;
namespace Jellyfin.Plugin.TrickplayComplete;
public sealed class ServiceRegistrator : IPluginServiceRegistrator
{
 public void RegisterServices(IServiceCollection services, IServerApplicationHost applicationHost)
 {
  services.AddSingleton<IScheduledTask, Tasks.CompleteMissingTrickplayTask>();
 }
}