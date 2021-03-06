// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	public enum ENetworkDeviceState : int
	{
	};
	
	public enum EWirelessSecurityFlags : int
	{
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct WirelessAccessPoint_t
	{
		public Int32 m_iPadding;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct WirelessCredentials_t
	{
		public Int32 m_iPadding;
	};
	
	public enum ENetworkDeviceManagerError : int
	{
	};
	
	[InterfaceVersion("CLIENTNETWORKDEVICEMANAGER_INTERFACE_VERSION001")]
	public interface IClientNetworkDeviceManager
	{
		[VTableSlot(0)]
		bool IsInterfaceValid();
		[VTableSlot(1)]
		void RefreshDevices();
		[VTableSlot(2)]
		Int32 EnumerateNetworkDevices(UInt32 arg0, ref UInt32 arg1);
		[VTableSlot(3)]
		Int32 GetDeviceType(UInt32 arg0);
		[VTableSlot(4)]
		bool IsCurrentDevice(UInt32 arg0);
		[VTableSlot(5)]
		bool IsCurrentlyConnected(UInt32 arg0);
		[VTableSlot(6)]
		Int32 GetDeviceIP4(UInt32 arg0, UInt32 arg1, ref UInt32 arg2);
		[VTableSlot(7)]
		Int32 GetDeviceBroadcastIP4(UInt32 arg0, UInt32 arg1, ref UInt32 arg2);
		[VTableSlot(8)]
		string GetDeviceVendor(UInt32 arg0);
		[VTableSlot(9)]
		string GetDeviceProduct(UInt32 arg0);
		[VTableSlot(10)]
		string GetMacAddress(UInt32 arg0);
		[VTableSlot(11)]
		Int32 GetSubnetMaskBitCount(UInt32 arg0, UInt32 arg1, ref UInt32 arg2);
		[VTableSlot(12)]
		Int32 GetRouterAddressIP4(UInt32 arg0, UInt32 arg1, ref UInt32 arg2);
		[VTableSlot(13)]
		Int32 GetDNSResolversIP4(UInt32 arg0, UInt32 arg1, ref UInt32 arg2);
		[VTableSlot(14)]
		Int32 GetDeviceState(UInt32 arg0);
		[VTableSlot(15)]
		bool GetDevicePluggedState(UInt32 arg0);
		[VTableSlot(16)]
		Int32 EnumerateWirelessEndpoints(UInt32 arg0, UInt32 arg1, ref UInt32 arg2);
		[VTableSlot(17)]
		Int32 GetConnectedWirelessEndpointSSID(UInt32 arg0);
		[VTableSlot(18)]
		Int32 GetWirelessSecurityCapabilities(UInt32 arg0);
		[VTableSlot(19)]
		string GetWirelessEndpointSSIDUserDisplayString(UInt32 arg0, UInt32 arg1);
		[VTableSlot(20)]
		Int32 GetWirelessEndpointStrength(UInt32 arg0, UInt32 arg1);
		[VTableSlot(21)]
		bool IsSecurityRequired(UInt32 arg0, UInt32 arg1);
		[VTableSlot(22)]
		string GetCachedWirelessCredentials(UInt32 arg0, UInt32 arg1);
		[VTableSlot(23)]
		bool DisconnectFromDevice(UInt32 arg0, bool arg1);
		[VTableSlot(24)]
		void SetCustomIPSettings(UInt32 arg0, UInt32 arg1, UInt32 arg2, UInt32 arg3, UInt32 arg4, UInt32 arg5);
		[VTableSlot(25)]
		bool ConnectToDevice(UInt32 arg0, UInt32 arg1, string arg2, string arg3, UInt32 arg4, bool arg5, bool arg6);
		[VTableSlot(26)]
		bool IsWirelessEndpointForgettable(UInt32 arg0, UInt32 arg1);
		[VTableSlot(27)]
		void ForgetWirelessEndpointAutoconnect(UInt32 arg0, UInt32 arg1);
		[VTableSlot(28)]
		bool IsUsingDHCP(UInt32 arg0);
		[VTableSlot(29)]
		bool GetCustomIPSettings(UInt32 arg0, ref UInt32 arg1, ref UInt32 arg2, ref UInt32 arg3, ref UInt32 arg4, ref UInt32 arg5);
	};
}
