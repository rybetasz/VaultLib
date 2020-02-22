﻿using VaultLib.Core.Types;

namespace VaultLib.Support.Undercover.VLT
{
    [VLTTypeInfo(nameof(SPCHType_1_EventID))]
    public enum SPCHType_1_EventID
    {
        kSPCH1_EventID_Acknowledge = 0x39,
        kSPCH1_EventID_Spotter = 0x3A,
        kSPCH1_EventID_SpotterReply = 0x3B,
        kSPCH1_EventID_InitPursuit = 0x3D,
        kSPCH1_EventID_PrimaryEngage = 0x3E,
        kSPCH1_EventID_Bullhorn = 0x40,
        kSPCH1_EventID_SelfStrategy = 0x42,
        kSPCH1_EventID_CallForBU = 0x43,
        kSPCH1_EventID_UnitBUReply = 0x44,
        kSPCH1_EventID_DispPursuitEscalation = 0x46,
        kSPCH1_EventID_BUReminder = 0x49,
        kSPCH1_EventID_DispBackupUpdate = 0x4A,
        kSPCH1_EventID_CallForRB = 0x4C,
        kSPCH1_EventID_DispRBReply = 0x4D,
        kSPCH1_EventID_DispRBUpdate = 0x4E,
        kSPCH1_EventID_RBApproach = 0x4F,
        kSPCH1_EventID_RBEngage = 0x50,
        kSPCH1_EventID_InitStrategy = 0x53,
        kSPCH1_EventID_StrategyExecute = 0x59,
        kSPCH1_EventID_AnticipateSuccess = 0x5A,
        kSPCH1_EventID_OutcomeFail = 0x5D,
        kSPCH1_EventID_Arrest = 0x5F,
        kSPCH1_EventID_DispArrestReply = 0x60,
        kSPCH1_EventID_CollisionWorld = 0x62,
        kSPCH1_EventID_PursuitUpdateRep = 0x64,
        kSPCH1_EventID_Disp911Report = 0x66,
        kSPCH1_EventID_Unit911Reply = 0x67,
        kSPCH1_EventID_SuspectUTurn = 0x68,
        kSPCH1_EventID_SuspectOutrun = 0x69,
        kSPCH1_EventID_LostVisual = 0x6A,
        kSPCH1_EventID_RegainVisual = 0x6B,
        kSPCH1_EventID_LostSuspect = 0x6C,
        kSPCH1_EventID_CallForEV = 0x70,
        kSPCH1_EventID_IntentToRam = 0x71,
        kSPCH1_EventID_Bailout = 0x72,
        kSPCH1_EventID_FocusChange = 0x73,
        kSPCH1_EventID_SuspectBehaviour = 0x74,
        kSPCH1_EventID_DriverHistory = 0x76,
        kSPCH1_EventID_PursuitApproaching = 0x77,
        kSPCH1_EventID_RBReminder = 0x91,
        kSPCH1_EventID_BUArrives = 0x96,
        kSPCH1_EventID_RBAverted = 0x98,
        kSPCH1_EventID_Interrupt = 0x99,
        kSPCH1_EventID_AttmptVehStp = 0x9A,
        kSPCH1_EventID_VehicleReport = 0x9B,
        kSPCH1_EventID_LocationReport = 0x9E,
        kSPCH1_EventID_SuspectConfirmed = 0x9F,
        kSPCH1_EventID_ReInitPursuit = 0xA0,
        kSPCH1_EventID_InitialCallForBU = 0xA1,
        kSPCH1_EventID_NegativeBUReply = 0xA2,
        kSPCH1_EventID_NegativeRBReply = 0xA3,
        kSPCH1_EventID_UnitDisabled = 0xA4,
        kSPCH1_EventID_BailoutDeny = 0xA5,
        kSPCH1_EventID_OffroadMoment = 0xA6,
        kSPCH1_EventID_HeliIntentToBail = 0xAA,
        kSPCH1_EventID_SwarmingReply = 0xAB,
        kSPCH1_EventID_AnticipateFail = 0xAD,
        kSPCH1_EventID_DispGoAhead = 0xAE,
        kSPCH1_EventID_HeliBailout = 0xB0,
        kSPCH1_EventID_HeliSwarming = 0xB1,
        kSPCH1_EventID_HeliSpotter = 0xB2,
        kSPCH1_EventID_DispTimeExpired = 0xB4,
        kSPCH1_EventID_DispPursEscGen = 0xB5,
        kSPCH1_EventID_DispBreakAway = 0xB7,
        kSPCH1_EventID_DispBackupReply = 0xB8,
        kSPCH1_EventID_StaticInterrupt = 0xB9,
        kSPCH1_EventID_InterruptRam = 0xBA,
        kSPCH1_EventID_InterruptRamHigh = 0xC6,
        kSPCH1_EventID_RegainVisualInterrupt = 0xC8,
        kSPCH1_EventID_InitialCallForBU_MS = 0xCD,
        kSPCH1_EventID_InterruptRam_RE = 0xCE,
        kSPCH1_EventID_InterruptRam_HO = 0xCF,
        kSPCH1_EventID_InterruptRam_SS = 0xD0,
        kSPCH1_EventID_InterruptRam_TB = 0xD1,
        kSPCH1_EventID_CollWorld_Civi = 0xD2,
        kSPCH1_EventID_CollWorld_Spin = 0xD3,
        kSPCH1_EventID_CollWorld_Air = 0xD4,
        kSPCH1_EventID_CollWorld_Flip = 0xD5,
        kSPCH1_EventID_Spotted = 0xD6,
        kSPCH1_EventID_BullhornPrefix = 0xD7,
        kSPCH1_EventID_SpotterWanted = 0xD8,
        kSPCH1_EventID_SuspectBrake = 0xD9,
        kSPCH1_EventID_CallForRB_sub = 0xDA,
        kSPCH1_EventID_WeatherReport = 0xDB,
        kSPCH1_EventID_HeatJump = 0xDC,
        kSPCH1_EventID_CallForSwarming = 0xDD,
        kSPCH1_EventID_BullhornArrest = 0xDE,
        kSPCH1_EventID_DispEVReply = 0xE0,
        kSPCH1_EventID_DispSubRB = 0xE3,
        kSPCH1_EventID_HeliQuadrent = 0xE6,
        kSPCH1_EventID_HeliQuadrentMoving = 0xE7,
        kSPCH1_EventID_MoreDetails = 0xE8,
        kSPCH1_EventID_DirectionHigh = 0xE9,
        kSPCH1_EventID_SuperPursuitReply = 0xEA,
        kSPCH1_EventID_SwarmingReplyFollow = 0xEB,
        kSPCH1_EventID_QuadrentForming = 0xEC,
        kSPCH1_EventID_SuspectPossiblyGone = 0xED,
        kSPCH1_EventID_QuadrentMoving = 0xEE,
        kSPCH1_EventID_OtherLead = 0xEF,
        kSPCH1_EventID_PossibleSuspect = 0xF0,
        kSPCH1_EventID_WrongSuspect = 0xF1,
        kSPCH1_EventID_SuspectGone = 0xF2,
        kSPCH1_EventID_RBWarning = 0xF3,
        kSPCH1_EventID_RBPosition = 0xF4,
        kSPCH1_EventID_ExtraRBEngage = 0xF5,
        kSPCH1_EventID_ExtraRBAverted = 0xF6,
        kSPCH1_EventID_Disp911NoDescrip = 0x100,
        kSPCH1_EventID_DispVehDescrip = 0x101,
        kSPCH1_EventID_M01 = 0x10A,
        kSPCH1_EventID_M02 = 0x10B,
        kSPCH1_EventID_M03 = 0x10C,
        kSPCH1_EventID_M04 = 0x10D,
        kSPCH1_EventID_M05 = 0x10E,
        kSPCH1_EventID_M06 = 0x10F,
        kSPCH1_EventID_M07 = 0x110,
        kSPCH1_EventID_M08 = 0x111,
        kSPCH1_EventID_M09 = 0x112,
        kSPCH1_EventID_M10 = 0x113,
        kSPCH1_EventID_M11 = 0x114,
        kSPCH1_EventID_M12 = 0x115,
        kSPCH1_EventID_M13 = 0x116,
        kSPCH1_EventID_M14 = 0x117,
        kSPCH1_EventID_M15 = 0x118,
        kSPCH1_EventID_M16 = 0x119,
        kSPCH1_EventID_M17 = 0x11A,
        kSPCH1_EventID_M18 = 0x11B,
        kSPCH1_EventID_M19 = 0x11C,
        kSPCH1_EventID_M20 = 0x11D,
        kSPCH1_EventID_M21 = 0x11E,
        kSPCH1_EventID_M22 = 0x11F,
        kSPCH1_EventID_M23 = 0x120,
        kSPCH1_EventID_M24 = 0x121,
        kSPCH1_EventID_M25 = 0x122,
        kSPCH1_EventID_M26 = 0x123,
        kSPCH1_EventID_M27 = 0x124,
        kSPCH1_EventID_M28 = 0x125,
        kSPCH1_EventID_M29 = 0x126,
        kSPCH1_EventID_M30 = 0x127,
        kSPCH1_EventID_M31 = 0x128,
        kSPCH1_EventID_M32 = 0x129,
        kSPCH1_EventID_M33 = 0x12A,
        kSPCH1_EventID_M34 = 0x12B,
        kSPCH1_EventID_M35 = 0x12C,
        kSPCH1_EventID_M36 = 0x12D,
        kSPCH1_EventID_M37 = 0x12E,
        kSPCH1_EventID_M38 = 0x12F,
        kSPCH1_EventID_M39 = 0x130,
        kSPCH1_EventID_M40 = 0x131,
        kSPCH1_EventID_VO_A = 0x134,
        kSPCH1_EventID_VO_B = 0x135,
        kSPCH1_EventID_VO_C = 0x136,
        kSPCH1_EventID_VO_D = 0x137,
        kSPCH1_EventID_VO_E = 0x138,
        kSPCH1_EventID_VO_F = 0x139,
        kSPCH1_EventID_SD00 = 0x13A,
        kSPCH1_EventID_SD01 = 0x13B,
        kSPCH1_EventID_SD02 = 0x13C,
        kSPCH1_EventID_SD03 = 0x13D,
        kSPCH1_EventID_SD04 = 0x13E,
        kSPCH1_EventID_SD05 = 0x13F,
        kSPCH1_EventID_SD06 = 0x140,
        kSPCH1_EventID_SD07 = 0x141,
        kSPCH1_EventID_SD08 = 0x142,
        kSPCH1_EventID_SD09 = 0x143,
        kSPCH1_EventID_SD10 = 0x145,
        kSPCH1_EventID_SD11 = 0x146,
        kSPCH1_EventID_SD12 = 0x147,
        kSPCH1_EventID_SD13 = 0x148,
        kSPCH1_EventID_SD14 = 0x149,
        kSPCH1_EventID_SD15 = 0x14A,
        kSPCH1_EventID_SD16 = 0x14B,
        kSPCH1_EventID_VehRepNoClr = 0x14E,
        kSPCH1_EventID_StolenCarConfirmed = 0x14F,
        kSPCH1_EventID_PursuitLengthRep = 0x150,
        kSPCH1_EventID_PursuitLength = 0x151,
        kSPCH1_EventID_PursuitBreaker = 0x152,
        kSPCH1_EventID_PlayerTakeOff = 0x153,
        kSPCH1_EventID_PlayerEarlyPullover = 0x154,
        kSPCH1_EventID_PlayerCopSpotted = 0x155,
        kSPCH1_EventID_PlayerCopConfirmed = 0x156,
        kSPCH1_EventID_PartLoose = 0x157,
        kSPCH1_EventID_NegFBIHandoffRep = 0x158,
        kSPCH1_EventID_MultiRBEvadeRep = 0x159,
        kSPCH1_EventID_MultiRBEvade = 0x15A,
        kSPCH1_EventID_LostVisualHeli = 0x15B,
        kSPCH1_EventID_HeliNoFly = 0x15C,
        kSPCH1_EventID_HeliLostRep = 0x15D,
        kSPCH1_EventID_HeliExitNoFly = 0x15E,
        kSPCH1_EventID_FBIPursuitLengthRep = 0x15F,
        kSPCH1_EventID_FBIPursuitLength = 0x160,
        kSPCH1_EventID_FBINoComply = 0x161,
        kSPCH1_EventID_FBIHandoffRep = 0x162,
        kSPCH1_EventID_FBIEngage = 0x163,
        kSPCH1_EventID_FBICollRep = 0x164,
        kSPCH1_EventID_FBICollConcern = 0x165,
        kSPCH1_EventID_ExAutosculpt = 0x166,
        kSPCH1_EventID_DispStlnCar = 0x167,
        kSPCH1_EventID_DispRadioRestored = 0x168,
        kSPCH1_EventID_DispPursLenRep = 0x169,
        kSPCH1_EventID_DispPurBreakerRep = 0x16A,
        kSPCH1_EventID_DispPurBreaker = 0x16B,
        kSPCH1_EventID_DispNoFlyRep = 0x16C,
        kSPCH1_EventID_DispNegHandoffRep = 0x16D,
        kSPCH1_EventID_DispLocalNoComply = 0x16E,
        kSPCH1_EventID_DispLocalLvl = 0x16F,
        kSPCH1_EventID_DispFBIPursLenRep = 0x170,
        kSPCH1_EventID_DispFBIHandoff = 0x171,
        kSPCH1_EventID_DispExAutosculpt = 0x172,
        kSPCH1_EventID_DispDamagedCar = 0x173,
        kSPCH1_EventID_Disp911StlnCar = 0x174,
        kSPCH1_EventID_DamagedCar = 0x175,
        kSPCH1_EventID_CopCollRep = 0x176,
        kSPCH1_EventID_CopCollConcern = 0x177,
        kSPCH1_EventID_BullhornTraffic = 0x178,
        kSPCH1_EventID_BackOnRoad = 0x179,
        kSPCH1_EventID_DispPursuitUpdate = 0x17B,
        kSPCH1_EventID_StrategyReset = 0x17C,
        kSPCH1_EventID_M00_A = 0x17D,
        kSPCH1_EventID_M00_B = 0x17E,
        kSPCH1_EventID_M00_C = 0x17F,
        kSPCH1_EventID_M00_D = 0x180,
        kSPCH1_EventID_M00_E = 0x181,
        kSPCH1_EventID_M00_F = 0x182,
        kSPCH1_EventID_M00_G = 0x184,
        kSPCH1_EventID_M00_H = 0x185,
        kSPCH1_EventID_M00_I = 0x186,
        kSPCH1_EventID_M00_J = 0x187,
        kSPCH1_EventID_M00_K = 0x188,
        kSPCH1_EventID_M00_L = 0x189,
        kSPCH1_EventID_M00_M = 0x18A,
        kSPCH1_EventID_M00_N = 0x18B,
        kSPCH1_EventID_M00_O = 0x18C,
        kSPCH1_EventID_M00_P = 0x18D,
        kSPCH1_EventID_DispNoVehDescrip = 0x18E,
        kSPCH1_EventID_CopOnCop = 0x18F,
        kSPCH1_EventID_DispatchOnCop = 0x190,
        kSPCH1_EventID_OneOff = 0x191,
        kSPCH1_EventID_DispPrstBrkOff = 0x192,
        kSPCH1_EventID_Disp911WW = 0x193,
        kSPCH1_EventID_WrongWay = 0x194,
        kSPCH1_EventID_WrongWayStill = 0x195,
        kSPCH1_EventID_PrstBrkOff = 0x196,
        kSPCH1_EventID_MaxEventID = 0x197,
    }
}
