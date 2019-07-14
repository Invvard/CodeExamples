using InvvardDev.Examples.PluginApp.Models;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace InvvardDev.Plugin.ErgoDoxEz
{
    [Export(typeof(IKeyboardModel))]
    public class ErgoDoxEz : IKeyboardModel
    {
        public string ModelName { get; private set; }
        public List<string> Keys { get; private set; }

        public ErgoDoxEz()
        {
            ModelName = "ErgoDox EZ";
        }

        public bool LoadLayout()
        {
            Keys = new List<string> {
                                        "A", "B", "C", "D", "E", "F", "G"
                                    };

            return true;
        }
    }
}