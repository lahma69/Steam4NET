// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("SteamFriends009")]
	public interface ISteamFriends009
	{
		[VTableSlot(0)]
		string GetPersonaName();
		[VTableSlot(1)]
		void SetPersonaName(string pchPersonaName);
		[VTableSlot(2)]
		EPersonaState GetPersonaState();
		[VTableSlot(3)]
		Int32 GetFriendCount(Int32 iFriendFlags);
		[VTableSlot(4)]
		CSteamID GetFriendByIndex(Int32 iFriend, Int32 iFriendFlags);
		[VTableSlot(5)]
		EFriendRelationship GetFriendRelationship(CSteamID steamIDFriend);
		[VTableSlot(6)]
		EPersonaState GetFriendPersonaState(CSteamID steamIDFriend);
		[VTableSlot(7)]
		string GetFriendPersonaName(CSteamID steamIDFriend);
		[VTableSlot(8)]
		bool GetFriendGamePlayed(CSteamID steamIDFriend, ref FriendGameInfo_t pFriendGameInfo);
		[VTableSlot(9)]
		string GetFriendPersonaNameHistory(CSteamID steamIDFriend, Int32 iPersonaName);
		[VTableSlot(10)]
		bool HasFriend(CSteamID steamIDFriend, Int32 iFriendFlags);
		[VTableSlot(11)]
		Int32 GetClanCount();
		[VTableSlot(12)]
		CSteamID GetClanByIndex(Int32 iClan);
		[VTableSlot(13)]
		string GetClanName(CSteamID steamIDClan);
		[VTableSlot(14)]
		string GetClanTag(CSteamID steamIDClan);
		[VTableSlot(15)]
		Int32 GetFriendCountFromSource(CSteamID steamIDSource);
		[VTableSlot(16)]
		CSteamID GetFriendFromSourceByIndex(CSteamID steamIDSource, Int32 iFriend);
		[VTableSlot(17)]
		bool IsUserInSource(CSteamID steamIDUser, CSteamID steamIDSource);
		[VTableSlot(18)]
		void SetInGameVoiceSpeaking(CSteamID steamIDUser, bool bSpeaking);
		[VTableSlot(19)]
		void ActivateGameOverlay(string pchDialog);
		[VTableSlot(20)]
		void ActivateGameOverlayToUser(string pchDialog, CSteamID steamID);
		[VTableSlot(21)]
		void ActivateGameOverlayToWebPage(string pchURL);
		[VTableSlot(22)]
		void ActivateGameOverlayToStore(UInt32 nAppID);
		[VTableSlot(23)]
		void SetPlayedWith(CSteamID steamIDUserPlayedWith);
		[VTableSlot(24)]
		void ActivateGameOverlayInviteDialog(CSteamID steamIDLobby);
		[VTableSlot(25)]
		Int32 GetSmallFriendAvatar(CSteamID steamIDFriend);
		[VTableSlot(26)]
		Int32 GetMediumFriendAvatar(CSteamID steamIDFriend);
		[VTableSlot(27)]
		Int32 GetLargeFriendAvatar(CSteamID steamIDFriend);
		[VTableSlot(28)]
		bool RequestUserInformation(CSteamID steamIDUser, bool bRequireNameOnly);
		[VTableSlot(29)]
		UInt64 RequestClanOfficerList(CSteamID steamIDClan);
		[VTableSlot(30)]
		CSteamID GetClanOwner(CSteamID steamIDClan);
		[VTableSlot(31)]
		Int32 GetClanOfficerCount(CSteamID steamIDClan);
		[VTableSlot(32)]
		CSteamID GetClanOfficerByIndex(CSteamID steamIDClan, Int32 iOfficer);
		[VTableSlot(33)]
		EUserRestriction GetUserRestrictions();
		[VTableSlot(34)]
		bool SetRichPresence(string pchKey, string pchValue);
		[VTableSlot(35)]
		void ClearRichPresence();
		[VTableSlot(36)]
		string GetFriendRichPresence(CSteamID steamIDFriend, string pchKey);
		[VTableSlot(37)]
		Int32 GetFriendRichPresenceKeyCount(CSteamID steamIDFriend);
		[VTableSlot(38)]
		string GetFriendRichPresenceKeyByIndex(CSteamID steamIDFriend, Int32 iKey);
		[VTableSlot(39)]
		bool InviteUserToGame(CSteamID steamIDFriend, string pchConnectString);
		[VTableSlot(40)]
		Int32 GetCoplayFriendCount();
		[VTableSlot(41)]
		CSteamID GetCoplayFriend(Int32 iCoplayFriend);
		[VTableSlot(42)]
		Int32 GetFriendCoplayTime(CSteamID steamIDFriend);
		[VTableSlot(43)]
		UInt32 GetFriendCoplayGame(CSteamID steamIDFriend);
	};
}