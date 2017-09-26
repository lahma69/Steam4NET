// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("CLIENTVIDEO_INTERFACE_VERSION001")]
	public interface IClientVideo
	{
		[VTableSlot(0)]
		bool BGetUserVideoFolder(StringBuilder arg0, Int32 arg1);
		[VTableSlot(1)]
		void UnlockH264();
		[VTableSlot(2)]
		Int32 EGetBroadcastReady();
		[VTableSlot(3)]
		void BeginBroadcastSession();
		[VTableSlot(4)]
		void EndBroadcastSession();
		[VTableSlot(5)]
		bool IsBroadcasting(ref Int32 pnNumViewers);
		[VTableSlot(6)]
		bool BIsUploadingThumbnails();
		[VTableSlot(7)]
		UInt64 GetBroadcastSessionID();
		[VTableSlot(8)]
		bool ReceiveBroadcastChat(CSteamID arg0, UInt64 arg1, bool arg2);
		[VTableSlot(9)]
		bool PostBroadcastChat(UInt64 arg0, string arg1);
		[VTableSlot(10)]
		bool MuteBroadcastChatUser(UInt64 arg0, CSteamID arg1);
		[VTableSlot(11)]
		bool InitBroadcastVideo(Int32 arg0, Int32 arg1, Int32 iWidth, Int32 iHeight, Byte[] arg4, Int32 arg5, Byte[] arg6, Int32 arg7);
		[VTableSlot(12)]
		bool InitBroadcastAudio(Int32 arg0, Int32 arg1, Int32 arg2, Int32 arg3, Int32 arg4, Byte[] arg5, Int32 arg6);
		[VTableSlot(13)]
		bool UploadBroadcastFrame(bool arg0, bool arg1, UInt32 arg2, Int64 arg3, Int64 arg4, Byte[] pubFrame, Int32 iFrameSize);
		[VTableSlot(14)]
		bool UploadBroadcastScreenshot(Int32 iWidth, Int32 iHeight, Byte[] pubRGBData, Int32 iRGBDataSize);
		[VTableSlot(15)]
		void DroppedVideoFrames(Int32 arg0);
		[VTableSlot(16)]
		void SetCurrentVideoEncodingRate(Int32 arg0);
		[VTableSlot(17)]
		void SetMicrophoneState(bool arg0, bool arg1);
		[VTableSlot(18)]
		void SetVideoSource(bool arg0);
		[VTableSlot(19)]
		void BroadcastRecorderError(EBroadcastRecorderResult arg0);
		[VTableSlot(20)]
		void LoadBroadcastSettings();
		[VTableSlot(21)]
		void SetBroadcastPermissions(EBroadcastPermission arg0);
		[VTableSlot(22)]
		EBroadcastPermission GetBroadcastPermissions();
		[VTableSlot(23)]
		Int32 GetBroadcastMaxKbps();
		[VTableSlot(24)]
		Int32 GetBroadcastDelaySeconds();
		[VTableSlot(25)]
		bool BGetBroadcastDimensions(ref Int32 iWidth, ref Int32 iHeight);
		[VTableSlot(26)]
		bool GetBroadcastIncludeDesktop();
		[VTableSlot(27)]
		bool GetBroadcastRecordSystemAudio();
		[VTableSlot(28)]
		bool GetBroadcastRecordMic();
		[VTableSlot(29)]
		EBroadcastChatCorner GetBroadcastShowChatCorner();
		[VTableSlot(30)]
		bool GetBroadcastShowDebugInfo();
		[VTableSlot(31)]
		bool GetBroadcastShowReminderBanner();
		[VTableSlot(32)]
		Int32 GetBroadcastEncoderSetting();
		[VTableSlot(33)]
		void InviteToBroadcast(CSteamID arg0, bool arg1);
		[VTableSlot(34)]
		void IgnoreApprovalRequest(CSteamID arg0);
		[VTableSlot(35)]
		void BroadcastFirstTimeComplete();
		[VTableSlot(36)]
		void SetInHomeStreamState(bool arg0);
		[VTableSlot(37)]
		void WatchBroadcast(CSteamID arg0);
		[VTableSlot(38)]
		Int32 GetWatchBroadcastMPD(CSteamID arg0);
		[VTableSlot(39)]
		Int32 GetApprovalRequestCount();
		[VTableSlot(40)]
		Int32 GetApprovalRequests(ref CSteamID arg0, UInt32 arg1);
		[VTableSlot(41)]
		void GetVideoURL(UInt32 appId);
		[VTableSlot(42)]
		void GetOPFSettings(UInt32 appId);
		[VTableSlot(43)]
		bool GetOPFStringForApp(UInt32 appId, StringBuilder pchBuffer, Int32 iUnk, ref Int32 pnBufferSize);
	};
}