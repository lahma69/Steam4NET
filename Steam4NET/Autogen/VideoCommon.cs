// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	public enum EBroadcastUploadResult : int
	{
		k_EBroadcastUploadResultNone = 0,
		k_EBroadcastUploadResultOK = 1,
		k_EBroadcastUploadResultInitFailed = 2,
		k_EBroadcastUploadResultFrameFailed = 3,
		k_EBroadcastUploadResultTimeout = 4,
		k_EBroadcastUploadResultBandwidthExceeded = 5,
		k_EBroadcastUploadResultLowFPS = 6,
		k_EBroadcastUploadResultMissingKeyFrames = 7,
		k_EBroadcastUploadResultNoConnection = 8,
		k_EBroadcastUploadResultRelayFailed = 9,
		k_EBroadcastUploadResultSettingsChanged = 10,
		k_EBroadcastUploadResultMissingAudio = 11,
		k_EBroadcastUploadResultTooFarBehind = 12,
		k_EBroadcastUploadResultTranscodeBehind = 13,
	};
	
	public enum EBroadcastPermission : int
	{
		k_EBroadcastPermissionBroadcastDisabled = 0,
		k_EBroadcastPermissionByFriendRequest = 1,
		k_EBroadcastPermissionFriends = 2,
		k_EBroadcastPermissionAll = 3,
	};
	
	public enum EBroadcastChatCorner : int
	{
		k_EBroadcastChatCornerNone = 0,
		k_EBroadcastChatCornerTopLeft = 1,
		k_EBroadcastChatCornerTopRight = 2,
		k_EBroadcastChatCornerBottomRight = 3,
		k_EBroadcastChatCornerBottomLeft = 4,
	};
	
	public enum EBroadcastRecorderResult : int
	{
	};
	
	public enum EBroadcastChatMsg : int
	{
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(4601)]
	public struct BeginBroadcastSessionResult_t
	{
		public const int k_iCallback = 4601;
		public EResult m_eResult;
		public UInt64 m_ulBroadcastID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(4602)]
	public struct EndBroadcastSessionResult_t
	{
		public const int k_iCallback = 4602;
		public EResult m_eResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(4604)]
	public struct BroadcastUploadStart_t
	{
		public const int k_iCallback = 4604;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(4605)]
	public struct BroadcastUploadStop_t
	{
		public const int k_iCallback = 4605;
		public EBroadcastUploadResult m_eResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(4608)]
	public struct BroadcastViewerState_t
	{
		public const int k_iCallback = 4608;
		public SteamID_t m_steamID;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bIsWatching;
		public EBroadcastPermission m_ePermission;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(4613)]
	public struct BroadcastSettingsLoaded_t
	{
		public const int k_iCallback = 4613;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(4615)]
	public struct BroadcastStatus_t
	{
		public const int k_iCallback = 4615;
		public UInt64 m_ulBroadcastID;
		public UInt32 m_unNumViewers;
		public UInt32 m_unNumRequests;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bIsBroadcasting;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(4616)]
	public struct BroadcastChatMessage_t
	{
		public const int k_iCallback = 4616;
		public SteamID_t m_steamID;
		public UInt64 m_ulBroadcastID;
		public EBroadcastChatMsg m_eMsgType;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string m_szPersona;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 140)]
		public string m_szMessage;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bInGame;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(4617)]
	public struct BroadcastUploadStatus_t
	{
		public const int k_iCallback = 4617;
		public UInt32 m_unTotalBytesSent;
		public UInt32 m_unVideoBytesDrop;
		public UInt32 m_unTotalBytesPend;
		public UInt32 m_unVideoSendFPS;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(4619)]
	public struct UnlockH264Result_t
	{
		public const int k_iCallback = 4619;
		public EResult m_eResult;
	};
	
}
