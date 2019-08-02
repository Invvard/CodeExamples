using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using InvvardDev.Examples.PluginApp.Models;
using InvvardDev.Plugin.ErgoDoxEz.View;
using InvvardDev.Plugin.ErgoDoxEz.ViewModel;

namespace InvvardDev.Plugin.ErgoDoxEz
{
    [Export(typeof(IKeyboardModel))]
    public class ErgoDoxInfinite : IKeyboardModel
    {
        public string ModelName { get; private set; }
        public List<string> Keys { get; private set; }

        public ErgoDoxInfinite()
        {
            Console.WriteLine("Loading the ErgoDox Infinite keyboard.");
            ModelName = "ErgoDox Infinite";
        }

        public bool LoadLayout()
        {
            Keys = new List<string> {
                                        "A",
                                        "B",
                                        "C",
                                        "D",
                                        "E",
                                        "F",
                                        "G"
                                    };

            return true;
        }

        public object GetKeyboardView()
        {
            return new ErgoDoxEzControl
                   {
                       DataContext = new ErgoDoxEzViewModel()
                   };
        }
    }
}