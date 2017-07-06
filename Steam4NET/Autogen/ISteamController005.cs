// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("SteamController005")]
	public interface ISteamController005
	{
		[VTableSlot(0)]
		bool Init();
		[VTableSlot(1)]
		bool Shutdown();
		[VTableSlot(2)]
		void RunFrame();
		[VTableSlot(3)]
		Int32 GetConnectedControllers(ref UInt64 hControllers);
		[VTableSlot(4)]
		bool ShowBindingPanel(UInt64 hController);
		[VTableSlot(5)]
		UInt64 GetActionSetHandle(string actionSetName);
		[VTableSlot(6)]
		void ActivateActionSet(UInt64 hController, UInt64 hAction);
		[VTableSlot(7)]
		UInt64 GetCurrentActionSet(UInt64 hController);
		[VTableSlot(8)]
		UInt64 GetDigitalActionHandle(string actionName);
		[VTableSlot(9)]
		ControllerDigitalActionData_t GetDigitalActionData(UInt64 controllerHandle, UInt64 actionHandle);
		[VTableSlot(10)]
		Int32 GetDigitalActionOrigins(UInt64 hController, UInt64 hActionSet, UInt64 hAction, ref EControllerActionOrigin eOrigin);
		[VTableSlot(11)]
		UInt64 GetAnalogActionHandle(string actionName);
		[VTableSlot(12)]
		ControllerAnalogActionData_t GetAnalogActionData(UInt64 controllerHandle, UInt64 actionHandle);
		[VTableSlot(13)]
		Int32 GetAnalogActionOrigins(UInt64 hController, UInt64 hActionSet, UInt64 hAction, ref EControllerActionOrigin eOrigin);
		[VTableSlot(14)]
		void StopAnalogActionMomentum(UInt64 hController, UInt64 hAction);
		[VTableSlot(15)]
		void TriggerHapticPulse(UInt64 hController, ESteamControllerPad eTargetPad, UInt16 usDurationMicroSec);
		[VTableSlot(16)]
		void TriggerRepeatedHapticPulse(UInt64 hController, ESteamControllerPad arg1, UInt16 durationMs, UInt16 offMs, UInt16 repeat, UInt32 flags);
		[VTableSlot(17)]
		void TriggerVibration(UInt64 hController, UInt16 leftSpeed, UInt16 rightSpeed);
		[VTableSlot(18)]
		void SetLEDColor(UInt64 hController, Byte R, Byte G, Byte B, UInt32 flags);
		[VTableSlot(19)]
		Int32 GetGamepadIndexForController(UInt64 hController);
		[VTableSlot(20)]
		UInt64 GetControllerForGamepadIndex(Int32 idx);
		[VTableSlot(21)]
		ControllerMotionData_t GetMotionData(UInt64 controllerHandle);
		[VTableSlot(22)]
		bool ShowDigitalActionOrigins(UInt64 hController, UInt64 hAction, float scale, float XPos, float YPos);
		[VTableSlot(23)]
		bool ShowAnalogActionOrigins(UInt64 hController, UInt64 hAction, float scale, float XPos, float YPos);
		[VTableSlot(24)]
		string GetStringForActionOrigin(EControllerActionOrigin eOrigin);
		[VTableSlot(25)]
		string GetGlyphForActionOrigin(EControllerActionOrigin eOrigin);
		[VTableSlot(26)]
		EControllerType GetControllerTypeForHandle(UInt64 hController);
	};
}