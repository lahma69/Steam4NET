// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("STEAMINVENTORY_INTERFACE_V001")]
	public interface ISteamInventory001
	{
		[VTableSlot(0)]
		EResult GetResultStatus(Int32 resultHandle);
		[VTableSlot(1)]
		bool GetResultItems(Int32 resultHandle, ref SteamItemDetails_t pOutItemsArray, ref UInt32 punOutItemsArraySize);
		[VTableSlot(2)]
		UInt32 GetResultTimestamp(Int32 resultHandle);
		[VTableSlot(3)]
		bool CheckResultSteamID(Int32 resultHandle, CSteamID steamIDExpected);
		[VTableSlot(4)]
		void DestroyResult(Int32 resultHandle);
		[VTableSlot(5)]
		bool GetAllItems(ref Int32 pResultHandle);
		[VTableSlot(6)]
		bool GetItemsByID(ref Int32 pResultHandle, ref UInt64 pInstanceIDs, UInt32 unCountInstanceIDs);
		[VTableSlot(7)]
		bool SerializeResult(Int32 resultHandle, Byte[] pOutBuffer, ref UInt32 punOutBufferSize);
		[VTableSlot(8)]
		bool DeserializeResult(ref Int32 pOutResultHandle, Byte[] pBuffer, UInt32 unBufferSize, bool bRESERVED_MUST_BE_FALSE);
		[VTableSlot(9)]
		bool GenerateItems(ref Int32 pResultHandle, ref Int32 pArrayItemDefs, ref UInt32 punArrayQuantity, UInt32 unArrayLength);
		[VTableSlot(10)]
		bool GrantPromoItems(ref Int32 pResultHandle);
		[VTableSlot(11)]
		bool AddPromoItem(ref Int32 pResultHandle, Int32 itemDef);
		[VTableSlot(12)]
		bool AddPromoItems(ref Int32 pResultHandle, ref Int32 pArrayItemDefs, UInt32 unArrayLength);
		[VTableSlot(13)]
		bool ConsumeItem(ref Int32 pResultHandle, UInt64 itemConsume, UInt32 unQuantity);
		[VTableSlot(14)]
		bool ExchangeItems(ref Int32 pResultHandle, ref Int32 pArrayGenerate, ref UInt32 punArrayGenerateQuantity, UInt32 unArrayGenerateLength, ref UInt64 pArrayDestroy, ref UInt32 punArrayDestroyQuantity, UInt32 unArrayDestroyLength);
		[VTableSlot(15)]
		bool TransferItemQuantity(ref Int32 pResultHandle, UInt64 itemIdSource, UInt32 unQuantity, UInt64 itemIdDest);
		[VTableSlot(16)]
		void SendItemDropHeartbeat();
		[VTableSlot(17)]
		bool TriggerItemDrop(ref Int32 pResultHandle, Int32 dropListDefinition);
		[VTableSlot(18)]
		bool TradeItems(ref Int32 pResultHandle, CSteamID steamIDTradePartner, ref UInt64 pArrayGive, ref UInt32 pArrayGiveQuantity, UInt32 nArrayGiveLength, ref UInt64 pArrayGet, ref UInt32 pArrayGetQuantity, UInt32 nArrayGetLength);
		[VTableSlot(19)]
		bool LoadItemDefinitions();
		[VTableSlot(20)]
		bool GetItemDefinitionIDs(ref Int32 pItemDefIDs, ref UInt32 punItemDefIDsArraySize);
		[VTableSlot(21)]
		bool GetItemDefinitionProperty(Int32 iDefinition, string pchPropertyName, StringBuilder pchValueBuffer, ref UInt32 punValueBufferSize);
		[VTableSlot(22)]
		UInt64 RequestEligiblePromoItemDefinitionsIDs(CSteamID arg0);
		[VTableSlot(23)]
		bool GetEligiblePromoItemDefinitionIDs(CSteamID arg0, ref Int32 arg1, ref UInt32 arg2);
	};
}
