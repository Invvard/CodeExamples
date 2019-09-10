using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace InvvardDev.Examples.PluginApp.MainApp.Tools
{
    public class PluginLoader<T> : IDisposable, IPluginLoader<T>
    {
        private readonly CompositionContainer _container;

        [ImportMany]
        public IEnumerable<T> Plugins { get; set; }

        public PluginLoader(string path)
        {
            var catalog = new DirectoryCatalog(path);

            _container = new CompositionContainer(catalog);
            _container.ComposeParts(this);
        }

        public void Dispose()
        {
            _container.Dispose();
        }
    }
}