using System.Collections.Generic;

namespace InvvardDev.Examples.PluginApp.Models
{
    public interface IKeyboardModel
    {
        /// <summary>
        /// Gets or sets the keyboard model name.
        /// </summary>
        string ModelName { get; set; }

        /// <summary>
        /// Gets or sets the keyboard list of keys.
        /// </summary>
        List<string> Keys { get; set; }

        /// <summary>
        /// Loads the layout from data.
        /// </summary>
        /// <param name="data">Data from settings repository</param>
        /// <returns><c>True</c> if loading is successful.</returns>
        bool LoadLayout(string data);
    }
}