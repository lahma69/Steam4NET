// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("SteamClient016")]
	public interface ISteamClient016
	{
		[VTableSlot(0)]
		Int32 CreateSteamPipe();
		[VTableSlot(1)]
		bool BReleaseSteamPipe(Int32 hSteamPipe);
		[VTableSlot(2)]
		Int32 ConnectToGlobalUser(Int32 hSteamPipe);
		[VTableSlot(3)]
		Int32 CreateLocalUser(ref Int32 phSteamPipe, EAccountType eAccountType);
		[VTableSlot(4)]
		void ReleaseUser(Int32 hSteamPipe, Int32 hUser);
		[VTableSlot(5)]
		TClass GetISteamUser<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(6)]
		TClass GetISteamGameServer<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(7)]
		void SetLocalIPBinding(UInt32 unIP, UInt16 usPort);
		[VTableSlot(8)]
		TClass GetISteamFriends<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(9)]
		TClass GetISteamUtils<TClass>(Int32 hSteamPipe) where TClass : class;
		[VTableSlot(10)]
		TClass GetISteamMatchmaking<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(11)]
		TClass GetISteamMatchmakingServers<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(12)]
		TClass GetISteamGenericInterface<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(13)]
		TClass GetISteamUserStats<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(14)]
		TClass GetISteamGameServerStats<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(15)]
		TClass GetISteamApps<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(16)]
		TClass GetISteamNetworking<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(17)]
		TClass GetISteamRemoteStorage<TClass>(Int32 hSteamuser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(18)]
		TClass GetISteamScreenshots<TClass>(Int32 hSteamuser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(19)]
		void RunFrame();
		[VTableSlot(20)]
		UInt32 GetIPCCallCount();
		[VTableSlot(21)]
		void SetWarningMessageHook(ref IntPtr pFunction);
		[VTableSlot(22)]
		bool BShutdownIfAllPipesClosed();
		[VTableSlot(23)]
		TClass GetISteamHTTP<TClass>(Int32 hSteamuser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(24)]
		TClass GetISteamUnifiedMessages<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(25)]
		TClass GetISteamController<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(26)]
		TClass GetISteamUGC<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(27)]
		TClass GetISteamInventory<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(28)]
		TClass GetISteamVideo<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(29)]
		TClass GetISteamAppList<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(30)]
		TClass GetISteamMusic<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(31)]
		TClass GetISteamMusicRemote<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(32)]
		TClass GetISteamHTMLSurface<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(33)]
		void Set_SteamAPI_CPostAPIResultInProcess(ref IntPtr arg0);
		[VTableSlot(34)]
		void Remove_SteamAPI_CPostAPIResultInProcess(ref IntPtr arg0);
		[VTableSlot(35)]
		void Set_SteamAPI_CCheckCallbackRegisteredInProcess(ref IntPtr arg0);
	};
}
