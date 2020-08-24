' Moves the current window to the left of the monitor and moves the next window to the right of the current monitor.

Imports System
Imports System.Drawing

Public Class DisplayFusionFunction
	Public Shared Sub Run(ByVal windowHandle As IntPtr)
		BFS.Window.MoveToLeftMonitorHalf(windowHandle)
		BFS.Input.SendKeys("%({VK_9})")
		BFS.General.ThreadWait(500)
		windowHandle = BFS.Window.GetFocusedWindow()
		BFS.Window.MoveToRightMonitorHalf(windowHandle)
	End Sub
End Class