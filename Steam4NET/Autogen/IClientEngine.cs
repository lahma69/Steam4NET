// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{
    // ClientEngineInterface version changed in 2017-12-13 Steam Client update (VERSION004 -> VERSION005)
    [InterfaceVersion("CLIENTENGINE_INTERFACE_VERSION005")]
    public interface IClientEngine
	{
		[VTableSlot(0)]
		Int32 CreateSteamPipe();
		[VTableSlot(1)]
		bool BReleaseSteamPipe(Int32 hSteamPipe);
		[VTableSlot(2)]
		Int32 CreateGlobalUser(ref Int32 phSteamPipe);
		[VTableSlot(3)]
		Int32 ConnectToGlobalUser(Int32 hSteamPipe);
		[VTableSlot(4)]
		Int32 CreateLocalUser(ref Int32 phSteamPipe, EAccountType eAccountType);
		[VTableSlot(5)]
		void CreatePipeToLocalUser(Int32 hSteamUser, ref Int32 phSteamPipe);
		[VTableSlot(6)]
		void ReleaseUser(Int32 hSteamPipe, Int32 hUser);
		[VTableSlot(7)]
		bool IsValidHSteamUserPipe(Int32 hSteamPipe, Int32 hUser);
		[VTableSlot(8)]
		TClass GetIClientUser<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(9)]
		TClass GetIClientGameServer<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(10)]
		void SetLocalIPBinding(UInt32 unIP, UInt16 usPort);
		[VTableSlot(11)]
		string GetUniverseName(EUniverse eUniverse);
		[VTableSlot(12)]
		TClass GetIClientFriends<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(13)]
		TClass GetIClientUtils<TClass>(Int32 hSteamPipe) where TClass : class;
		[VTableSlot(14)]
		TClass GetIClientBilling<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(15)]
		TClass GetIClientMatchmaking<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(16)]
		TClass GetIClientApps<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(17)]
		TClass GetIClientMatchmakingServers<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(18)]
		void RunFrame();
		[VTableSlot(19)]
		UInt32 GetIPCCallCount();
		[VTableSlot(20)]
		TClass GetIClientUserStats<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(21)]
		TClass GetIClientGameServerStats<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(22)]
		TClass GetIClientNetworking<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(23)]
		TClass GetIClientRemoteStorage<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(24)]
		TClass GetIClientScreenshots<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(25)]
		void SetWarningMessageHook(ref IntPtr pFunction);
		[VTableSlot(26)]
		TClass GetIClientGameCoordinator<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(27)]
		void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition);
		[VTableSlot(28)]
		void SetOverlayNotificationInsert(Int32 arg0, Int32 arg1);
		[VTableSlot(29)]
		bool HookScreenshots(bool bHook);
		[VTableSlot(30)]
		bool IsScreenshotsHooked();
		[VTableSlot(31)]
		bool IsOverlayEnabled();
		[VTableSlot(32)]
		bool GetAPICallResult(Int32 hSteamPipe, UInt64 hSteamAPICall, Byte[] pCallback, Int32 cubCallback, Int32 iCallbackExpected, ref bool pbFailed);
		[VTableSlot(33)]
		TClass GetIClientProductBuilder<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(34)]
		TClass GetIClientDepotBuilder<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(35)]
		TClass GetIClientNetworkDeviceManager<TClass>(Int32 hSteamPipe) where TClass : class;
		[VTableSlot(36)]
		void ConCommandInit(ref IntPtr pAccessor);
		[VTableSlot(37)]
		TClass GetIClientAppManager<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(38)]
		TClass GetIClientConfigStore<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(39)]
		bool BOverlayNeedsPresent();
		[VTableSlot(40)]
		TClass GetIClientGameStats<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(41)]
		TClass GetIClientHTTP<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(42)]
		bool BShutdownIfAllPipesClosed();
		[VTableSlot(43)]
		TClass GetIClientAudio<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(44)]
		TClass GetIClientMusic<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(45)]
		TClass GetIClientUnifiedMessages<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(46)]
		TClass GetIClientController<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(47)]
		TClass GetIClientParentalSettings<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(48)]
		TClass GetIClientStreamLauncher<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(49)]
		TClass GetIClientDeviceAuth<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(50)]
		TClass GetIClientRemoteClientManager<TClass>(Int32 hSteamPipe) where TClass : class;
		[VTableSlot(51)]
		TClass GetIClientStreamClient<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(52)]
		TClass GetIClientShortcuts<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(53)]
		TClass GetIClientUGC<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(54)]
		TClass GetIClientInventory<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(55)]
		TClass GetIClientVR<TClass>(Int32 arg0) where TClass : class;
		[VTableSlot(56)]
		TClass GetIClientGameNotifications<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(57)]
		TClass GetIClientHTMLSurface<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(58)]
		TClass GetIClientVideo<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(59)]
		TClass GetIClientControllerSerialized<TClass>(Int32 arg0) where TClass : class;
		[VTableSlot(60)]
		TClass GetIClientAppDisableUpdate<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(61)]
        Int32 Set_ClientAPI_CPostAPIResultInProcess(ref IntPtr arg0); // Alternative name: Set_Client_API_CCheckCallbackRegisteredInProcess
        [VTableSlot(62)]
		TClass GetIClientBluetoothManager<TClass>(Int32 hSteamPipe) where TClass : class;
		[VTableSlot(63)]
		TClass GetIClientSharedConnection<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(64)]
		TClass GetIClientShader<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
        // Added in 2017-12-14 Steam Client update
        [VTableSlot(65)]
        TClass GetIClientNetworkingSocketsSerialized<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
	};
}
