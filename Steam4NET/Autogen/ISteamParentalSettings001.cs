// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("STEAMPARENTALSETTINGS_INTERFACE_VERSION001")]
	public interface ISteamParentalSettings001
	{
		[VTableSlot(0)]
		bool BIsParentalLockEnabled();
		[VTableSlot(1)]
		bool BIsParentalLockLocked();
		[VTableSlot(2)]
		bool BIsAppBlocked(UInt32 unAppID);
		[VTableSlot(3)]
		bool BIsAppInBlockList(UInt32 unAppID);
		[VTableSlot(4)]
		bool BIsFeatureBlocked(EParentalFeature eParentalFeature);
		[VTableSlot(5)]
		bool BIsFeatureInBlockList(EParentalFeature eParentalFeature);
	};
}
