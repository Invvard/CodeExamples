using System.Collections.Generic;
using System.Composition;
using InvvardDev.Examples.PluginApp.Models;

namespace InvvardDev.Plugin.PlanckEz
{
    [Export(typeof(IKeyboardModel))]
    public class PlanckEz : IKeyboardModel
    {
        public string ModelName { get; }
        public List<string> Keys { get; }

        public PlanckEz()
        {
            ModelName = "Planck EZ";
        }

        public bool LoadLayout()
        {
            throw new System.NotImplementedException();
        }

        public object GetKeyboardView()
        {
            return new List<string>();
        }
    }
}
