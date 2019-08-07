using System.Collections.Generic;

namespace InvvardDev.Examples.PluginApp.MainApp.Tools
{
    public class DesignPluginLoader<T> : IPluginLoader<T>
    {
        public IEnumerable<T> Plugins { get; set; }

        public void Dispose()
        {
        }
    }
}