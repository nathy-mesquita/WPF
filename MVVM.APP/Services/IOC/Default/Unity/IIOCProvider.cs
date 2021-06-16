using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MVVM.APP.Services.IOC.Default.Unity
{
    public interface IIOCProvider
    {
        /// <summary>
        /// Method that <see cref="ViewModelBase">ViewModelBase</see>
        /// can call to tell container to set its self up. You are expected
        /// to register the following Types in this method
        /// <c>ILogger</c>
        /// <c>IUIVisualizerService</c>
        /// <c>IMessageBoxService</c>
        /// <c>IOpenFileService</c>
        /// <c>ISaveFileService</c>
        /// </summary>
        void SetupContainer();

        /// <summary>
        /// Get service from container
        /// </summary>
        /// <typeparam name="T">Service type</typeparam>
        /// <returns>The service instance</returns>
        T GetTypeFromContainer<T>();
    }
}
