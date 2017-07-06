// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("STEAMVIDEO_INTERFACE_V001")]
	public interface ISteamVideo001
	{
		[VTableSlot(0)]
		void GetVideoURL(UInt32 appId);
		[VTableSlot(1)]
		bool IsBroadcasting(ref Int32 pnNumViewers);
	};
}
