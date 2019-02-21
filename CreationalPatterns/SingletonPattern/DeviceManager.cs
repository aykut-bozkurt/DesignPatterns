using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.SingletonPattern
{
	class DeviceManager
	{
		//private static DeviceManager deviceManager = new DeviceManager(); => eager initialization if I initialize the static instance here
		private static DeviceManager deviceManager = null;

		private DeviceManager() {}

		public static DeviceManager GetInstance()
		{
			// lazy initialization
			if (deviceManager == null)
			{
				deviceManager = new DeviceManager();
			}

			return deviceManager;
		}
	}
}
