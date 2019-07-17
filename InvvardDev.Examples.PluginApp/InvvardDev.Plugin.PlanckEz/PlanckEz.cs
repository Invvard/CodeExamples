using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
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
            throw new NotImplementedException();
        }

        public object GetKeyboardView()
        {
            throw new NotImplementedException();
        }
    }
}
