﻿#if HAS_UNO_WINUI
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System.Threading;

namespace Microsoft.UI.Dispatching
{
	partial class DispatcherQueueTimer
	{
		private void StartNative(TimeSpan interval)
		{
			throw new NotImplementedException("DispatcherQueueTimer not supported on .net");
		}

		private void StartNative(TimeSpan dueTime, TimeSpan interval)
		{
			throw new NotImplementedException("DispatcherQueueTimer not supported on .net");
		}

		private void StopNative()
		{
			throw new NotImplementedException("DispatcherQueueTimer not supported on .net");
		}
	}
}
#endif
