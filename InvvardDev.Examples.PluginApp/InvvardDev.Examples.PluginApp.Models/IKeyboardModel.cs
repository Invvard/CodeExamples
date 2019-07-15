using System.Collections.Generic;

namespace InvvardDev.Examples.PluginApp.Models
{
    public interface IKeyboardModel
    {
        /// <summary>
        /// Gets or sets the keyboard model name.
        /// </summary>
        string ModelName { get; }

        /// <summary>
        /// Gets or sets the keyboard list of keys.
        /// </summary>
        List<string> Keys { get; }

        /// <summary>
        /// Loads the layout.
        /// </summary>
        /// <returns><c>True</c> if loading is successful.</returns>
        bool LoadLayout();

        /// <summary>
        /// Gets the keyboard view.
        /// </summary>
        /// <returns>The user control to be displayed.</returns>
        object GetKeyboardView();
    }
}