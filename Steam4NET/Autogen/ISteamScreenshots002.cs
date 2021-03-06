// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("STEAMSCREENSHOTS_INTERFACE_VERSION002")]
	public interface ISteamScreenshots002
	{
		[VTableSlot(0)]
		UInt32 WriteScreenshot(Byte[] pubRGB, UInt32 cubRGB, Int32 nWidth, Int32 nHeight);
		[VTableSlot(1)]
		UInt32 AddScreenshotToLibrary(string pchJpegOrTGAFilename, string pchJpegOrTGAThumbFilename, Int32 nWidth, Int32 nHeight);
		[VTableSlot(2)]
		void TriggerScreenshot();
		[VTableSlot(3)]
		void HookScreenshots(bool bHook);
		[VTableSlot(4)]
		bool SetLocation(UInt32 hScreenshot, string pchLocation);
		[VTableSlot(5)]
		bool TagUser(UInt32 hScreenshot, CSteamID steamID);
		[VTableSlot(6)]
		bool TagPublishedFile(UInt32 hScreenshot, UInt64 unPublishedFileId);
	};
}
