using System.Collections.Generic;

namespace InvvardDev.Examples.PluginApp.MainApp.Tools
{
    public interface IPluginLoader<T>
    {
        IEnumerable<T> Plugins { get; set; }

        void Dispose();
    }
}