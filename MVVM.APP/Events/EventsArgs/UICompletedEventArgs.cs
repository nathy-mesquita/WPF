using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.APP.Events.EventsArgs
{
    /// <summary>
    /// This is the EventArgs return value for the IUIController.Show completed event.
    /// </summary>
    public class UICompletedEventArgs : EventArgs
    {
        #region Public Properties
        /// <summary>
        /// Data passed to the Show method.
        /// </summary>
        public object State { get; set; }
        /// <summary>
        /// Final result of the UI dialog
        /// </summary>
        public bool? Result { get; set; }
        #endregion
    }
}
