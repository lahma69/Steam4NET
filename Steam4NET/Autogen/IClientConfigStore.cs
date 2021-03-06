// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("CLIENTCONFIGSTORE_INTERFACE_VERSION001")]
	public interface IClientConfigStore
	{
		[VTableSlot(0)]
		bool IsSet(EConfigStore eConfigStore, string pszKeyNameIn);
		[VTableSlot(1)]
		bool GetBool(EConfigStore eConfigStore, string pszKeyNameIn, bool defaultValue);
		[VTableSlot(2)]
		Int32 GetInt(EConfigStore eConfigStore, string pszKeyName, Int32 defaultValue);
		[VTableSlot(3)]
		UInt64 GetUint64(EConfigStore eConfigStore, string pszKeyName, UInt64 defaultValue);
		[VTableSlot(4)]
		float GetFloat(EConfigStore eConfigStore, string pszKeyName, float defaultValue);
		[VTableSlot(5)]
		string GetString(EConfigStore eConfigStore, string pszKeyName, string defaultValue);
		[VTableSlot(6)]
		UInt32 GetBinary(EConfigStore eConfigStore, string pszKeyName, Byte[] pubBuf, UInt32 cubBuf);
		[VTableSlot(7)]
		UInt32 GetBinary(EConfigStore eConfigStore, string pszKeyName, ref CUtlBuffer pUtlBuf);
		[VTableSlot(8)]
		UInt32 GetBinaryWatermarked(EConfigStore eConfigStore, string pszKeyName, Byte[] pubBuf, UInt32 cubBuf);
		[VTableSlot(9)]
		bool SetBool(EConfigStore eConfigStore, string pszKeyNameIn, bool value);
		[VTableSlot(10)]
		bool SetInt(EConfigStore eConfigStore, string pszKeyNameIn, Int32 nValue);
		[VTableSlot(11)]
		bool SetUint64(EConfigStore eConfigStore, string pszKeyNameIn, UInt64 unValue);
		[VTableSlot(12)]
		bool SetFloat(EConfigStore eConfigStore, string pszKeyNameIn, float flValue);
		[VTableSlot(13)]
		bool SetString(EConfigStore eConfigStore, string pszKeyNameIn, string pszValue);
		[VTableSlot(14)]
		bool SetBinary(EConfigStore eConfigStore, string pszKeyName, Byte[] pubData, UInt32 cubData);
		[VTableSlot(15)]
		bool SetBinaryWatermarked(EConfigStore eConfigStore, string pszKeyName, Byte[] pubData, UInt32 cubData);
		[VTableSlot(16)]
		bool RemoveKey(EConfigStore eConfigStore, string pszKeyName);
		[VTableSlot(17)]
		Int32 GetKeySerialized(EConfigStore eConfigStore, string pszKeyNameIn, Byte[] pchBuffer, Int32 cbBufferMax);
		[VTableSlot(18)]
		bool FlushToDisk(bool bIsShuttingDown);
	};
}
