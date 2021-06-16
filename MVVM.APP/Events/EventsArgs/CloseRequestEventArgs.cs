using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.APP.Events.EventsArgs
{
    /// <summary>
    /// This is used to send result parameters to a CloseRequest
    /// </summary>
    public class CloseRequestEventArgs : EventArgs
    {
        #region Data
        ///<summary>
        /// Final result for ShowDialog
        ///</summary>
        public bool? Result { get; private set; }
        #endregion

        #region Ctor
        internal CloseRequestEventArgs(bool? result)
        {
            Result = result;
        }
        #endregion
    }
}
