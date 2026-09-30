using System; using System.Collections.Generic; using System.Globalization; using Jellyfin.Plugin.TrickplayComplete.Configuration; using MediaBrowser.Common.Configuration; using MediaBrowser.Common.Plugins; using MediaBrowser.Model.Plugins; using MediaBrowser.Model.Serialization;
namespace Jellyfin.Plugin.TrickplayComplete;
public sealed class Plugin : BasePlugin<PluginConfiguration>, IHasWebPages
{
 public static Plugin? Instance { get; private set; }
 public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) : base(applicationPaths, xmlSerializer) => Instance = this;
 public override string Name => "Trickplay Complete";
 public override Guid Id => Guid.Parse("9c6d8d88-2f0f-4c18-a4f2-4a3df31fb1be");
 public IEnumerable<PluginPageInfo> GetPages() => new[] { new PluginPageInfo { Name = Name, EmbeddedResourcePath = string.Format(CultureInfo.InvariantCulture, "{0}.Web.configPage.html", GetType().Namespace) } };
}