// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	public interface ISteamMusicRemote001
	{
		[VTableSlot(0)]
		bool RegisterSteamMusicRemote(string pchName);
		[VTableSlot(1)]
		bool DeregisterSteamMusicRemote();
		[VTableSlot(2)]
		bool BIsCurrentMusicRemote();
		[VTableSlot(3)]
		bool BActivationSuccess(bool bValue);
		[VTableSlot(4)]
		bool SetDisplayName(string pchDisplayName);
		[VTableSlot(5)]
		bool SetPNGIcon_64x64(Byte[] pvBuffer, UInt32 cbBufferLength);
		[VTableSlot(6)]
		bool EnablePlayPrevious(bool bValue);
		[VTableSlot(7)]
		bool EnablePlayNext(bool bValue);
		[VTableSlot(8)]
		bool EnableShuffled(bool bValue);
		[VTableSlot(9)]
		bool EnableLooped(bool bValue);
		[VTableSlot(10)]
		bool EnableQueue(bool bValue);
		[VTableSlot(11)]
		bool EnablePlaylists(bool bValue);
		[VTableSlot(12)]
		bool UpdatePlaybackStatus(AudioPlayback_Status nStatus);
		[VTableSlot(13)]
		bool UpdateShuffled(bool bValue);
		[VTableSlot(14)]
		bool UpdateLooped(bool bValue);
		[VTableSlot(15)]
		bool UpdateVolume(float flValue);
		[VTableSlot(16)]
		bool CurrentEntryWillChange();
		[VTableSlot(17)]
		bool CurrentEntryIsAvailable(bool bAvailable);
		[VTableSlot(18)]
		bool UpdateCurrentEntryText(string pchText);
		[VTableSlot(19)]
		bool UpdateCurrentEntryElapsedSeconds(Int32 nValue);
		[VTableSlot(20)]
		bool UpdateCurrentEntryCoverArt(Byte[] pvBuffer, UInt32 cbBufferLength);
		[VTableSlot(21)]
		bool CurrentEntryDidChange();
		[VTableSlot(22)]
		bool QueueWillChange();
		[VTableSlot(23)]
		bool ResetQueueEntries();
		[VTableSlot(24)]
		bool SetQueueEntry(Int32 nID, Int32 nPosition, string pchEntryText);
		[VTableSlot(25)]
		bool SetCurrentQueueEntry(Int32 nID);
		[VTableSlot(26)]
		bool QueueDidChange();
		[VTableSlot(27)]
		bool PlaylistWillChange();
		[VTableSlot(28)]
		bool ResetPlaylistEntries();
		[VTableSlot(29)]
		bool SetPlaylistEntry(Int32 nID, Int32 nPosition, string pchEntryText);
		[VTableSlot(30)]
		bool SetCurrentPlaylistEntry(Int32 nID);
		[VTableSlot(31)]
		bool PlaylistDidChange();
	};
}
