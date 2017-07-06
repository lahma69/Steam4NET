// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	public enum ESteamControllerPad : int
	{
		k_ESteamControllerPad_Left = 0,
		k_ESteamControllerPad_Right = 1,
	};
	
	public enum EControllerActionOrigin : int
	{
		k_EControllerActionOrigin_None = 0,
		k_EControllerActionOrigin_A = 1,
		k_EControllerActionOrigin_B = 2,
		k_EControllerActionOrigin_X = 3,
		k_EControllerActionOrigin_Y = 4,
		k_EControllerActionOrigin_LeftBumper = 5,
		k_EControllerActionOrigin_RightBumper = 6,
		k_EControllerActionOrigin_LeftGrip = 7,
		k_EControllerActionOrigin_RightGrip = 8,
		k_EControllerActionOrigin_Start = 9,
		k_EControllerActionOrigin_Back = 10,
		k_EControllerActionOrigin_LeftPad_Touch = 11,
		k_EControllerActionOrigin_LeftPad_Swipe = 12,
		k_EControllerActionOrigin_LeftPad_Click = 13,
		k_EControllerActionOrigin_LeftPad_DPadNorth = 14,
		k_EControllerActionOrigin_LeftPad_DPadSouth = 15,
		k_EControllerActionOrigin_LeftPad_DPadWest = 16,
		k_EControllerActionOrigin_LeftPad_DPadEast = 17,
		k_EControllerActionOrigin_RightPad_Touch = 18,
		k_EControllerActionOrigin_RightPad_Swipe = 19,
		k_EControllerActionOrigin_RightPad_Click = 20,
		k_EControllerActionOrigin_RightPad_DPadNorth = 21,
		k_EControllerActionOrigin_RightPad_DPadSouth = 22,
		k_EControllerActionOrigin_RightPad_DPadWest = 23,
		k_EControllerActionOrigin_RightPad_DPadEast = 24,
		k_EControllerActionOrigin_LeftTrigger_Pull = 25,
		k_EControllerActionOrigin_LeftTrigger_Click = 26,
		k_EControllerActionOrigin_RightTrigger_Pull = 27,
		k_EControllerActionOrigin_RightTrigger_Click = 28,
		k_EControllerActionOrigin_LeftStick_Move = 29,
		k_EControllerActionOrigin_LeftStick_Click = 30,
		k_EControllerActionOrigin_LeftStick_DPadNorth = 31,
		k_EControllerActionOrigin_LeftStick_DPadSouth = 32,
		k_EControllerActionOrigin_LeftStick_DPadWest = 33,
		k_EControllerActionOrigin_LeftStick_DPadEast = 34,
		k_EControllerActionOrigin_Gyro_Move = 35,
		k_EControllerActionOrigin_Gyro_Pitch = 36,
		k_EControllerActionOrigin_Gyro_Yaw = 37,
		k_EControllerActionOrigin_Gyro_Roll = 38,
		k_EControllerActionOrigin_PS4_X = 39,
		k_EControllerActionOrigin_PS4_Circle = 40,
		k_EControllerActionOrigin_PS4_Triangle = 41,
		k_EControllerActionOrigin_PS4_Square = 42,
		k_EControllerActionOrigin_PS4_LeftBumper = 43,
		k_EControllerActionOrigin_PS4_RightBumper = 44,
		k_EControllerActionOrigin_PS4_Options = 45,
		k_EControllerActionOrigin_PS4_Share = 46,
		k_EControllerActionOrigin_PS4_LeftPad_Touch = 47,
		k_EControllerActionOrigin_PS4_LeftPad_Swipe = 48,
		k_EControllerActionOrigin_PS4_LeftPad_Click = 49,
		k_EControllerActionOrigin_PS4_LeftPad_DPadNorth = 50,
		k_EControllerActionOrigin_PS4_LeftPad_DPadSouth = 51,
		k_EControllerActionOrigin_PS4_LeftPad_DPadWest = 52,
		k_EControllerActionOrigin_PS4_LeftPad_DPadEast = 53,
		k_EControllerActionOrigin_PS4_RightPad_Touch = 54,
		k_EControllerActionOrigin_PS4_RightPad_Swipe = 55,
		k_EControllerActionOrigin_PS4_RightPad_Click = 56,
		k_EControllerActionOrigin_PS4_RightPad_DPadNorth = 57,
		k_EControllerActionOrigin_PS4_RightPad_DPadSouth = 58,
		k_EControllerActionOrigin_PS4_RightPad_DPadWest = 59,
		k_EControllerActionOrigin_PS4_RightPad_DPadEast = 60,
		k_EControllerActionOrigin_PS4_CenterPad_Touch = 61,
		k_EControllerActionOrigin_PS4_CenterPad_Swipe = 62,
		k_EControllerActionOrigin_PS4_CenterPad_Click = 63,
		k_EControllerActionOrigin_PS4_CenterPad_DPadNorth = 64,
		k_EControllerActionOrigin_PS4_CenterPad_DPadSouth = 65,
		k_EControllerActionOrigin_PS4_CenterPad_DPadWest = 66,
		k_EControllerActionOrigin_PS4_CenterPad_DPadEast = 67,
		k_EControllerActionOrigin_PS4_LeftTrigger_Pull = 68,
		k_EControllerActionOrigin_PS4_LeftTrigger_Click = 69,
		k_EControllerActionOrigin_PS4_RightTrigger_Pull = 70,
		k_EControllerActionOrigin_PS4_RightTrigger_Click = 71,
		k_EControllerActionOrigin_PS4_LeftStick_Move = 72,
		k_EControllerActionOrigin_PS4_LeftStick_Click = 73,
		k_EControllerActionOrigin_PS4_LeftStick_DPadNorth = 74,
		k_EControllerActionOrigin_PS4_LeftStick_DPadSouth = 75,
		k_EControllerActionOrigin_PS4_LeftStick_DPadWest = 76,
		k_EControllerActionOrigin_PS4_LeftStick_DPadEast = 77,
		k_EControllerActionOrigin_PS4_RightStick_Move = 78,
		k_EControllerActionOrigin_PS4_RightStick_Click = 79,
		k_EControllerActionOrigin_PS4_RightStick_DPadNorth = 80,
		k_EControllerActionOrigin_PS4_RightStick_DPadSouth = 81,
		k_EControllerActionOrigin_PS4_RightStick_DPadWest = 82,
		k_EControllerActionOrigin_PS4_RightStick_DPadEast = 83,
		k_EControllerActionOrigin_PS4_DPad_North = 84,
		k_EControllerActionOrigin_PS4_DPad_South = 85,
		k_EControllerActionOrigin_PS4_DPad_West = 86,
		k_EControllerActionOrigin_PS4_DPad_East = 87,
		k_EControllerActionOrigin_PS4_Gyro_Move = 88,
		k_EControllerActionOrigin_PS4_Gyro_Pitch = 89,
		k_EControllerActionOrigin_PS4_Gyro_Yaw = 90,
		k_EControllerActionOrigin_PS4_Gyro_Roll = 91,
		k_EControllerActionOrigin_XBoxOne_A = 92,
		k_EControllerActionOrigin_XBoxOne_B = 93,
		k_EControllerActionOrigin_XBoxOne_X = 94,
		k_EControllerActionOrigin_XBoxOne_Y = 95,
		k_EControllerActionOrigin_XBoxOne_LeftBumper = 96,
		k_EControllerActionOrigin_XBoxOne_RightBumper = 97,
		k_EControllerActionOrigin_XBoxOne_Menu = 98,
		k_EControllerActionOrigin_XBoxOne_View = 99,
		k_EControllerActionOrigin_XBoxOne_LeftTrigger_Pull = 100,
		k_EControllerActionOrigin_XBoxOne_LeftTrigger_Click = 101,
		k_EControllerActionOrigin_XBoxOne_RightTrigger_Pull = 102,
		k_EControllerActionOrigin_XBoxOne_RightTrigger_Click = 103,
		k_EControllerActionOrigin_XBoxOne_LeftStick_Move = 104,
		k_EControllerActionOrigin_XBoxOne_LeftStick_Click = 105,
		k_EControllerActionOrigin_XBoxOne_LeftStick_DPadNorth = 106,
		k_EControllerActionOrigin_XBoxOne_LeftStick_DPadSouth = 107,
		k_EControllerActionOrigin_XBoxOne_LeftStick_DPadWest = 108,
		k_EControllerActionOrigin_XBoxOne_LeftStick_DPadEast = 109,
		k_EControllerActionOrigin_XBoxOne_RightStick_Move = 110,
		k_EControllerActionOrigin_XBoxOne_RightStick_Click = 111,
		k_EControllerActionOrigin_XBoxOne_RightStick_DPadNorth = 112,
		k_EControllerActionOrigin_XBoxOne_RightStick_DPadSouth = 113,
		k_EControllerActionOrigin_XBoxOne_RightStick_DPadWest = 114,
		k_EControllerActionOrigin_XBoxOne_RightStick_DPadEast = 115,
		k_EControllerActionOrigin_XBoxOne_DPad_North = 116,
		k_EControllerActionOrigin_XBoxOne_DPad_South = 117,
		k_EControllerActionOrigin_XBoxOne_DPad_West = 118,
		k_EControllerActionOrigin_XBoxOne_DPad_East = 119,
		k_EControllerActionOrigin_XBox360_A = 120,
		k_EControllerActionOrigin_XBox360_B = 121,
		k_EControllerActionOrigin_XBox360_X = 122,
		k_EControllerActionOrigin_XBox360_Y = 123,
		k_EControllerActionOrigin_XBox360_LeftBumper = 124,
		k_EControllerActionOrigin_XBox360_RightBumper = 125,
		k_EControllerActionOrigin_XBox360_Start = 126,
		k_EControllerActionOrigin_XBox360_Back = 127,
		k_EControllerActionOrigin_XBox360_LeftTrigger_Pull = 128,
		k_EControllerActionOrigin_XBox360_LeftTrigger_Click = 129,
		k_EControllerActionOrigin_XBox360_RightTrigger_Pull = 130,
		k_EControllerActionOrigin_XBox360_RightTrigger_Click = 131,
		k_EControllerActionOrigin_XBox360_LeftStick_Move = 132,
		k_EControllerActionOrigin_XBox360_LeftStick_Click = 133,
		k_EControllerActionOrigin_XBox360_LeftStick_DPadNorth = 134,
		k_EControllerActionOrigin_XBox360_LeftStick_DPadSouth = 135,
		k_EControllerActionOrigin_XBox360_LeftStick_DPadWest = 136,
		k_EControllerActionOrigin_XBox360_LeftStick_DPadEast = 137,
		k_EControllerActionOrigin_XBox360_RightStick_Move = 138,
		k_EControllerActionOrigin_XBox360_RightStick_Click = 139,
		k_EControllerActionOrigin_XBox360_RightStick_DPadNorth = 140,
		k_EControllerActionOrigin_XBox360_RightStick_DPadSouth = 141,
		k_EControllerActionOrigin_XBox360_RightStick_DPadWest = 142,
		k_EControllerActionOrigin_XBox360_RightStick_DPadEast = 143,
		k_EControllerActionOrigin_XBox360_DPad_North = 144,
		k_EControllerActionOrigin_XBox360_DPad_South = 145,
		k_EControllerActionOrigin_XBox360_DPad_West = 146,
		k_EControllerActionOrigin_XBox360_DPad_East = 147,
		k_EControllerActionOrigin_SteamV2_A = 148,
		k_EControllerActionOrigin_SteamV2_B = 149,
		k_EControllerActionOrigin_SteamV2_X = 150,
		k_EControllerActionOrigin_SteamV2_Y = 151,
		k_EControllerActionOrigin_SteamV2_LeftBumper = 152,
		k_EControllerActionOrigin_SteamV2_RightBumper = 153,
		k_EControllerActionOrigin_SteamV2_LeftGrip = 154,
		k_EControllerActionOrigin_SteamV2_RightGrip = 155,
		k_EControllerActionOrigin_SteamV2_Start = 156,
		k_EControllerActionOrigin_SteamV2_Back = 157,
		k_EControllerActionOrigin_SteamV2_LeftPad_Touch = 158,
		k_EControllerActionOrigin_SteamV2_LeftPad_Swipe = 159,
		k_EControllerActionOrigin_SteamV2_LeftPad_Click = 160,
		k_EControllerActionOrigin_SteamV2_LeftPad_DPadNorth = 161,
		k_EControllerActionOrigin_SteamV2_LeftPad_DPadSouth = 162,
		k_EControllerActionOrigin_SteamV2_LeftPad_DPadWest = 163,
		k_EControllerActionOrigin_SteamV2_LeftPad_DPadEast = 164,
		k_EControllerActionOrigin_SteamV2_RightPad_Touch = 165,
		k_EControllerActionOrigin_SteamV2_RightPad_Swipe = 166,
		k_EControllerActionOrigin_SteamV2_RightPad_Click = 167,
		k_EControllerActionOrigin_SteamV2_RightPad_DPadNorth = 168,
		k_EControllerActionOrigin_SteamV2_RightPad_DPadSouth = 169,
		k_EControllerActionOrigin_SteamV2_RightPad_DPadWest = 170,
		k_EControllerActionOrigin_SteamV2_RightPad_DPadEast = 171,
		k_EControllerActionOrigin_SteamV2_LeftTrigger_Pull = 172,
		k_EControllerActionOrigin_SteamV2_LeftTrigger_Click = 173,
		k_EControllerActionOrigin_SteamV2_RightTrigger_Pull = 174,
		k_EControllerActionOrigin_SteamV2_RightTrigger_Click = 175,
		k_EControllerActionOrigin_SteamV2_LeftStick_Move = 176,
		k_EControllerActionOrigin_SteamV2_LeftStick_Click = 177,
		k_EControllerActionOrigin_SteamV2_LeftStick_DPadNorth = 178,
		k_EControllerActionOrigin_SteamV2_LeftStick_DPadSouth = 179,
		k_EControllerActionOrigin_SteamV2_LeftStick_DPadWest = 180,
		k_EControllerActionOrigin_SteamV2_LeftStick_DPadEast = 181,
		k_EControllerActionOrigin_SteamV2_Gyro_Move = 182,
		k_EControllerActionOrigin_SteamV2_Gyro_Pitch = 183,
		k_EControllerActionOrigin_SteamV2_Gyro_Yaw = 184,
		k_EControllerActionOrigin_SteamV2_Gyro_Roll = 185,
		k_EControllerActionOrigin_Count = 186,
	};
	
	public enum EControllerType : int
	{
		k_EControllerTypeController_none = -1,
		k_EControllerTypeController_unknown = 0,
		k_EControllerTypeController_steamcontroller_unknown = 1,
		k_EControllerTypeController_steamcontroller_gordon = 2,
		k_EControllerTypeController_steamcontroller_headcrab = 3,
		k_EControllerTypeController_generic = 30,
		k_EControllerTypeController_xbox360 = 31,
		k_EControllerTypeController_xboxone = 32,
		k_EControllerTypeController_ps3 = 33,
		k_EControllerTypeController_ps4 = 34,
		k_EControllerTypeController_wii = 35,
		k_EControllerTypeController_apple = 36,
	};
	
	public enum EControllerActivationType : int
	{
		k_EControllerActivationTypeNone = 0,
		k_EControllerActivationTypeFull_press = 1,
		k_EControllerActivationTypeSoft_press = 2,
		k_EControllerActivationTypeStart_press = 3,
		k_EControllerActivationTypeRelease = 4,
		k_EControllerActivationTypeLong_press = 5,
		k_EControllerActivationTypeDouble_press = 6,
		k_EControllerActivationTypeAnalog = 7,
	};
	
	public enum EControllerSource : int
	{
		k_EControllerSourceNone = 0,
		k_EControllerSourceLeft_trackpad = 1,
		k_EControllerSourceRight_trackpad = 2,
		k_EControllerSourceJoystick = 3,
		k_EControllerSourceButton_diamond = 4,
		k_EControllerSourceSwitch = 5,
		k_EControllerSourceLeft_trigger = 6,
		k_EControllerSourceRight_trigger = 7,
		k_EControllerSourceGyro = 8,
		k_EControllerSourceCenter_trackpad = 9,
		k_EControllerSourceRight_joystick = 10,
		k_EControllerSourceDpad = 11,
	};
	
	public enum EControllerSourceMode : int
	{
		k_EControllerSourceModeNone = 0,
		k_EControllerSourceModeDpad = 1,
		k_EControllerSourceModeButtons = 2,
		k_EControllerSourceModeFour_buttons = 3,
		k_EControllerSourceModeAbsolute_mouse = 4,
		k_EControllerSourceModeRelative_mouse = 5,
		k_EControllerSourceModeJoystick_move = 6,
		k_EControllerSourceModeJoystick_mouse = 7,
		k_EControllerSourceModeJoystick_camera = 8,
		k_EControllerSourceModeScrollwheel = 9,
		k_EControllerSourceModeTrigger = 10,
		k_EControllerSourceModeTouch_menu = 11,
		k_EControllerSourceModeMouse_joystick = 12,
		k_EControllerSourceModeMouse_region = 13,
		k_EControllerSourceModeRadial_menu = 14,
		k_EControllerSourceModeSingle_button = 15,
		k_EControllerSourceModeSwitches = 16,
	};
	
	public enum EControllerModeInput : int
	{
		k_EControllerModeInputNone = 0,
		k_EControllerModeInputDpad_north = 1,
		k_EControllerModeInputDpad_northeast = 2,
		k_EControllerModeInputDpad_east = 3,
		k_EControllerModeInputDpad_southeast = 4,
		k_EControllerModeInputDpad_south = 5,
		k_EControllerModeInputDpad_southwest = 6,
		k_EControllerModeInputDpad_west = 7,
		k_EControllerModeInputDpad_northwest = 8,
		k_EControllerModeInputButton_y = 9,
		k_EControllerModeInputButton_b = 10,
		k_EControllerModeInputButton_x = 11,
		k_EControllerModeInputButton_a = 12,
		k_EControllerModeInputClick = 13,
		k_EControllerModeInputDoubletap = 14,
		k_EControllerModeInputEdge = 15,
		k_EControllerModeInputScroll_clockwise = 16,
		k_EControllerModeInputScroll_counterclockwise = 17,
		k_EControllerModeInputTrigger_analog = 18,
		k_EControllerModeInputScroll_wheel_list_0 = 19,
		k_EControllerModeInputScroll_wheel_list_1 = 20,
		k_EControllerModeInputScroll_wheel_list_2 = 21,
		k_EControllerModeInputScroll_wheel_list_3 = 22,
		k_EControllerModeInputScroll_wheel_list_4 = 23,
		k_EControllerModeInputScroll_wheel_list_5 = 24,
		k_EControllerModeInputScroll_wheel_list_6 = 25,
		k_EControllerModeInputScroll_wheel_list_7 = 26,
		k_EControllerModeInputScroll_wheel_list_8 = 27,
		k_EControllerModeInputScroll_wheel_list_9 = 28,
		k_EControllerModeInputTouch_menu_button_0 = 29,
		k_EControllerModeInputTouch_menu_button_1 = 30,
		k_EControllerModeInputTouch_menu_button_2 = 31,
		k_EControllerModeInputTouch_menu_button_3 = 32,
		k_EControllerModeInputTouch_menu_button_4 = 33,
		k_EControllerModeInputTouch_menu_button_5 = 34,
		k_EControllerModeInputTouch_menu_button_6 = 35,
		k_EControllerModeInputTouch_menu_button_7 = 36,
		k_EControllerModeInputTouch_menu_button_8 = 37,
		k_EControllerModeInputTouch_menu_button_9 = 38,
		k_EControllerModeInputTouch_menu_button_10 = 39,
		k_EControllerModeInputTouch_menu_button_11 = 40,
		k_EControllerModeInputTouch_menu_button_12 = 41,
		k_EControllerModeInputTouch_menu_button_13 = 42,
		k_EControllerModeInputTouch_menu_button_14 = 43,
		k_EControllerModeInputTouch_menu_button_15 = 44,
		k_EControllerModeInputTouch_menu_button_16 = 45,
		k_EControllerModeInputTouch_menu_button_17 = 46,
		k_EControllerModeInputTouch_menu_button_18 = 47,
		k_EControllerModeInputTouch_menu_button_19 = 48,
		k_EControllerModeInputTouch_menu_button_20 = 49,
		k_EControllerModeInputTouch = 50,
		k_EControllerModeInputButton_menu = 51,
		k_EControllerModeInputButton_escape = 52,
		k_EControllerModeInputLeft_bumper = 53,
		k_EControllerModeInputRight_bumper = 54,
		k_EControllerModeInputButton_back_left = 55,
		k_EControllerModeInputButton_back_right = 56,
		k_EControllerModeInputButton_back_left_upper = 57,
		k_EControllerModeInputButton_back_right_upper = 58,
		k_EControllerModeInputButton_lpad = 59,
		k_EControllerModeInputButton_rpad = 60,
		k_EControllerModeInputButton_ltrigger = 61,
		k_EControllerModeInputButton_rtrigger = 62,
		k_EControllerModeInputButton_ltrigger_threshold = 63,
		k_EControllerModeInputButton_rtrigger_threshold = 64,
		k_EControllerModeInputButton_joystick = 65,
		k_EControllerModeInputButton_steam = 66,
	};
	
	public enum EControllerSetting : int
	{
		k_EControllerSettingLeft_trackpad_mode = 0,
		k_EControllerSettingRight_trackpad_mode = 1,
		k_EControllerSettingTrackpad_trigger_data = 2,
		k_EControllerSettingHaptic_intensity = 3,
		k_EControllerSettingRumble_type = 4,
		k_EControllerSettingRumble_intensity = 5,
		k_EControllerSettingEdge_binding_radius = 6,
		k_EControllerSettingOutput_joystick = 7,
		k_EControllerSettingCurve_exponent = 8,
		k_EControllerSettingCustom_curve_exponent = 9,
		k_EControllerSettingSwipe_duration = 10,
		k_EControllerSettingDeadzone_inner_radius = 11,
		k_EControllerSettingDeadzone_outer_radius = 12,
		k_EControllerSettingDeadzone_shape = 13,
		k_EControllerSettingAdaptive_centering = 14,
		k_EControllerSettingVirtual_cap_size = 15,
		k_EControllerSettingVirtual_stick_throw = 16,
		k_EControllerSettingAnti_deadzone = 17,
		k_EControllerSettingAnti_deadzone_buffer = 18,
		k_EControllerSettingEdge_binding_invert = 19,
		k_EControllerSettingOutput_axis = 20,
		k_EControllerSettingRequires_click = 21,
		k_EControllerSettingDeadzone = 22,
		k_EControllerSettingLayout = 23,
		k_EControllerSettingHold_repeats = 24,
		k_EControllerSettingHold_repeat_inverval = 25,
		k_EControllerSettingAnalog_emulation_duty_cycle_pct = 26,
		k_EControllerSettingAnalog_emulation_period = 27,
		k_EControllerSettingSensitivity = 28,
		k_EControllerSettingSensitivity_vert_scale = 29,
		k_EControllerSettingSensitivity_horiz_scale = 30,
		k_EControllerSettingTrackball = 31,
		k_EControllerSettingFriction = 32,
		k_EControllerSettingFriction_vert_scale = 33,
		k_EControllerSettingAcceleration = 34,
		k_EControllerSettingDoubletap = 35,
		k_EControllerSettingDoubletap_beep = 36,
		k_EControllerSettingEdge_spin_radius = 37,
		k_EControllerSettingEdge_spin_velocity = 38,
		k_EControllerSettingInvert_x = 39,
		k_EControllerSettingInvert_y = 40,
		k_EControllerSettingMouse_smoothing = 41,
		k_EControllerSettingMouse_move_threshold = 42,
		k_EControllerSettingRotation = 43,
		k_EControllerSettingDoubetap_max_dist = 44,
		k_EControllerSettingDoubetap_min_duration = 45,
		k_EControllerSettingDoubetap_max_duration = 46,
		k_EControllerSettingMousejoystick_deadzone_x = 48,
		k_EControllerSettingMousejoystick_deadzone_y = 49,
		k_EControllerSettingScroll_angle = 50,
		k_EControllerSettingScroll_wrap = 51,
		k_EControllerSettingScroll_type = 52,
		k_EControllerSettingScroll_invert = 53,
		k_EControllerSettingScroll_friction = 54,
		k_EControllerSettingOutput_trigger = 55,
		k_EControllerSettingAdaptive_threshold = 56,
		k_EControllerSettingButton_size = 57,
		k_EControllerSettingButton_dist = 58,
		k_EControllerSettingGyro_mode = 59,
		k_EControllerSettingJoystick_smoothing = 60,
		k_EControllerSettingGyro_axis = 61,
		k_EControllerSettingGyro_button = 62,
		k_EControllerSettingGyro_neutral = 63,
		k_EControllerSettingGyro_lock_extents = 64,
		k_EControllerSettingGyro_pointer_mode = 65,
		k_EControllerSettingGyro_button_invert = 66,
		k_EControllerSettingVirtual_mode = 67,
		k_EControllerSettingTouch_menu_button_count = 68,
		k_EControllerSettingTouch_menu_opacity = 69,
		k_EControllerSettingTouch_menu_position_x = 70,
		k_EControllerSettingTouch_menu_position_y = 71,
		k_EControllerSettingTouch_menu_scale = 72,
		k_EControllerSettingMouse_dampening_trigger = 73,
		k_EControllerSettingMouse_trigger_clamp_amount = 74,
		k_EControllerSettingTouch_menu_show_labels = 75,
		k_EControllerSettingGyro_sensitivity_scale = 76,
		k_EControllerSettingScale = 77,
		k_EControllerSettingPosition_x = 78,
		k_EControllerSettingPosition_y = 79,
		k_EControllerSettingTeleport_start = 80,
		k_EControllerSettingTeleport_stop = 81,
		k_EControllerSettingTouchmenu_button_fire_type = 82,
		k_EControllerSettingTest_param_0 = 83,
		k_EControllerSettingTest_param_1 = 84,
		k_EControllerSettingTest_param_2 = 85,
		k_EControllerSettingTest_param_3 = 86,
		k_EControllerSettingTest_param_4 = 87,
		k_EControllerSettingTest_param_5 = 88,
		k_EControllerSettingTest_param_6 = 89,
		k_EControllerSettingTest_param_7 = 90,
		k_EControllerSettingTest_param_8 = 91,
		k_EControllerSettingTest_param_9 = 92,
		k_EControllerSettingAction_set_trigger_cursor_show = 93,
		k_EControllerSettingAction_set_trigger_cursor_hide = 94,
		k_EControllerSettingDelay_start = 95,
		k_EControllerSettingDelay_end = 96,
		k_EControllerSettingCycle = 97,
		k_EControllerSettingToggle = 98,
		k_EControllerSettingRepeat_rate = 99,
		k_EControllerSettingDouble_tap_time = 100,
		k_EControllerSettingLong_press_time = 101,
		k_EControllerSettingActivation_threshold = 102,
		k_EControllerSettingMouse_warp_x = 103,
		k_EControllerSettingMouse_warp_y = 104,
		k_EControllerSettingAnalog_value = 105,
		k_EControllerSettingInterruptable = 106,
		k_EControllerSettingSoft_press_sytle = 107,
		k_EControllerSettingActivator_output_axis = 108,
	};
	
	public enum EControllerConfigFeature : int
	{
		k_EControllerConfigFeatureFeature_none = 0,
		k_EControllerConfigFeatureFeature_gamepad = 1,
		k_EControllerConfigFeatureFeature_keboard = 2,
		k_EControllerConfigFeatureFeature_mouse = 3,
		k_EControllerConfigFeatureFeature_mouseregion = 4,
		k_EControllerConfigFeatureFeature_gyro = 5,
		k_EControllerConfigFeatureFeature_radialmenu = 6,
		k_EControllerConfigFeatureFeature_modeshift = 8,
		k_EControllerConfigFeatureFeature_actionset = 9,
		k_EControllerConfigFeatureFeature_activator = 10,
		k_EControllerConfigFeatureFeature_LEDColors = 11,
		k_EControllerConfigFeatureController_native = 12,
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct SteamControllerState_t
	{
		public UInt32 unPacketNum;
		public UInt64 ulButtons;
		public Int16 sLeftPadX;
		public Int16 sLeftPadY;
		public Int16 sRightPadX;
		public Int16 sRightPadY;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct ControllerDigitalActionData_t
	{
		public Byte m_bState;
		public Byte m_bActive;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct ControllerAnalogActionData_t
	{
		public EControllerSourceMode m_eMode;
		public float m_fX;
		public float m_fY;
		public Byte m_bActive;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct ControllerMotionData_t
	{
		public float m_fRotQuatX;
		public float m_fRotQuatY;
		public float m_fRotQuatZ;
		public float m_fRotQuatW;
		public float m_fPosAccelX;
		public float m_fPosAccelY;
		public float m_fPosAccelZ;
		public float m_fRotVelX;
		public float m_fRotVelY;
		public float m_fRotVelZ;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(2701)]
	public struct ControllerConnected_t
	{
		public const int k_iCallback = 2701;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(2702)]
	public struct ControllerDisconnected_t
	{
		public const int k_iCallback = 2702;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(2703)]
	public struct LoadControllerConfigResult_t
	{
		public const int k_iCallback = 2703;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(2710)]
	public struct SetControllerOverrideMode_t
	{
		public const int k_iCallback = 2710;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(2712)]
	public struct ControllerWirelessPresence_t
	{
		public const int k_iCallback = 2712;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(2714)]
	public struct ControllerPaired_t
	{
		public const int k_iCallback = 2714;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(2715)]
	public struct ControllerTouchMenuCreate_t
	{
		public const int k_iCallback = 2715;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(2716)]
	public struct ControllerTouchMenuDestroy_t
	{
		public const int k_iCallback = 2716;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(2717)]
	public struct ControllerPacketLossUI_t
	{
		public const int k_iCallback = 2717;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(2718)]
	public struct ControllerShowBindingPanel_t
	{
		public const int k_iCallback = 2718;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(2719)]
	public struct ControllerActionBlockOutdated_t
	{
		public const int k_iCallback = 2719;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(2720)]
	public struct ControllerConfigLoadError_t
	{
		public const int k_iCallback = 2720;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(2722)]
	public struct ControllerDisplayKeyboard_t
	{
		public const int k_iCallback = 2722;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(2723)]
	public struct ReceivedControllerConfigSets_t
	{
		public const int k_iCallback = 2723;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(2724)]
	public struct ReceivedControllerPersonalization_t
	{
		public const int k_iCallback = 2724;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(2725)]
	public struct ControllerAccountsUpdated_t
	{
		public const int k_iCallback = 2725;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(2726)]
	public struct ControllerDongleUpdateStatus_t
	{
		public const int k_iCallback = 2726;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(2727)]
	public struct ReceivedControllerPersonalizationCfg_t
	{
		public const int k_iCallback = 2727;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(2728)]
	public struct ControllerActionSetChanged_t
	{
		public const int k_iCallback = 2728;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(2729)]
	public struct ControllerActionTriggered_t
	{
		public const int k_iCallback = 2729;
	};
	
}
