using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using InvvardDev.Examples.PluginApp.Models;
using InvvardDev.Plugin.PlanckEz.View;
using InvvardDev.Plugin.PlanckEz.ViewModel;

namespace InvvardDev.Plugin.PlanckEz
{
    [ Export(typeof(IKeyboardModel)) ]
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
            return new PlanckEzControl {
                                           DataContext = new PlanckEzViewModel()
                                       };
        }
    }
}