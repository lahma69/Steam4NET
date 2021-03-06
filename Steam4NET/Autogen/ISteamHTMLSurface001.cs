// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	public interface ISteamHTMLSurface001
	{
		[VTableSlot(0)]
		void __virtualDestructorForISteamHTMLSurface();
		[VTableSlot(1)]
		bool Init();
		[VTableSlot(2)]
		bool Shutdown();
		[VTableSlot(3)]
		UInt64 CreateBrowser(string pchUserAgent, string pchUserCSS);
		[VTableSlot(4)]
		void RemoveBrowser(UInt32 hBrowser);
		[VTableSlot(5)]
		void LoadURL(UInt32 hBrowser, string pchURL, string pchPostData);
		[VTableSlot(6)]
		void SetSize(UInt32 hBrowser, UInt32 width, UInt32 height);
		[VTableSlot(7)]
		void StopLoad(UInt32 hBrowser);
		[VTableSlot(8)]
		void Reload(UInt32 hBrowser);
		[VTableSlot(9)]
		void GoBack(UInt32 hBrowser);
		[VTableSlot(10)]
		void GoForward(UInt32 hBrowser);
		[VTableSlot(11)]
		void AddHeader(UInt32 hBrowser, string pchKey, string pchValue);
		[VTableSlot(12)]
		void ExecuteJavascript(UInt32 hBrowser, string pchJs);
		[VTableSlot(13)]
		void MouseUp(UInt32 hBrowser, EHTMLMouseButton eMButton);
		[VTableSlot(14)]
		void MouseDown(UInt32 hBrowser, EHTMLMouseButton eMButton);
		[VTableSlot(15)]
		void MouseDoubleClick(UInt32 hBrowser, EHTMLMouseButton eMButton);
		[VTableSlot(16)]
		void MouseMove(UInt32 hBrowser, Int32 x, Int32 y);
		[VTableSlot(17)]
		void MouseWheel(UInt32 hBrowser, Int32 delta);
		[VTableSlot(18)]
		void KeyDown(UInt32 hBrowser, UInt32 key, EHTMLKeyModifiers eKeyMod);
		[VTableSlot(19)]
		void KeyUp(UInt32 hBrowser, UInt32 key, EHTMLKeyModifiers eKeyMod);
		[VTableSlot(20)]
		void KeyChar(UInt32 hBrowser, UInt32 key, EHTMLKeyModifiers eKeyMod);
		[VTableSlot(21)]
		void SetHorizontalScroll(UInt32 hBrowser, UInt32 nAbsScrollPx);
		[VTableSlot(22)]
		void SetVerticalScroll(UInt32 hBrowser, UInt32 nAbsScrollPx);
		[VTableSlot(23)]
		void SetKeyFocus(UInt32 hBrowser, bool hasFocus);
		[VTableSlot(24)]
		void ViewSource(UInt32 hBrowser);
		[VTableSlot(25)]
		void CopyToClipboard(UInt32 hBrowser);
		[VTableSlot(26)]
		void PasteFromClipboard(UInt32 hBrowser);
		[VTableSlot(27)]
		void Find(UInt32 hBrowser, string search, bool currentlyInFind, bool reverse);
		[VTableSlot(28)]
		void StopFind(UInt32 hBrowser);
		[VTableSlot(29)]
		void GetLinkAtPosition(UInt32 hBrowser, Int32 x, Int32 y);
		[VTableSlot(30)]
		void AllowStartRequest(UInt32 hBrowser, bool allowed);
		[VTableSlot(31)]
		void JSDialogResponse(UInt32 hBrowser, bool result);
		[VTableSlot(32)]
		void FileLoadDialogResponse(UInt32 hBrowser, string selectedFiles);
	};
}
