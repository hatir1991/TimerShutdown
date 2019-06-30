using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;

namespace timershutdown
{
  public  class WaitableTimer
    {
      [DllImport("kernel32.dll")]
		private static extern IntPtr CreateWaitableTimer(
			IntPtr lpTimerAttributes,
			bool bManualReset,
			string lpTimerName);
		[DllImport("kernel32.dll")]
		private static extern bool SetWaitableTimer(
			IntPtr hTimer,
			[In] ref long pDueTime,
			int lPeriod,
			IntPtr pfnCompletionRoutine,
			IntPtr lpArgToCompletionRoutine,
			bool fResume);
		[DllImport("kernel32", SetLastError = true, ExactSpelling = true)]
		private static extern Int32 WaitForSingleObject(IntPtr handle, uint milliseconds);

		private static IntPtr handle;
		private static Thread mainwait; // давайте жить дружно
		private static void SetWaitForWakeUpTime(object input)
		{
			long duetime=(long)input;
			input=null;
			handle=CreateWaitableTimer(IntPtr.Zero,true,"LOL_Bot_WaitableTimer");
			SetWaitableTimer(handle,ref duetime,0,IntPtr.Zero,IntPtr.Zero,true);
			uint INFINITE = 0xFFFFFFFF;
			int ret=WaitForSingleObject(handle,INFINITE);
			mainwait=null;
		}
		public static void SetWakeUp(TimeSpan delay)
		{
			mainwait=new Thread(WaitableTimer.SetWaitForWakeUpTime);
			mainwait.Start(-delay.Ticks);
		}
	}
    }

