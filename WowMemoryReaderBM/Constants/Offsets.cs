﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WowMemoryReaderBM.Constants {
    class Offsets {
        internal enum ObjectManager : uint {
            CurMgrPointer = 0x9BE7E0,
            CurMgrOffset = 0x463C,
            NextObject = 0x3C,
            FirstObject = 0xC0,
            LocalGUID = 0xC8
        }
        internal enum descriptors : uint {
            Level = 0xB0,
            Health = 0x58,
            MaxHealth = 0x70,
            Mana = 0x5C,
            MaxMana = 0x74,
            TargetGuid64 = 0x40,
            Agility = 0x130,

        }
        internal enum buffs : uint {
            nextbuff = 0x8,

        }
        internal enum gear : uint {
            weaponmain = 0x6c4,
            weaponranged = 0x6d4,
            weaponoffhand = 0xd74,
            helmet = 0xcf4,
            neck = 0x654,
            shoulder = 0xd04,
            back = 0xd64,
            chest = 0xd14,
            shirt = 0x664,
            tabard = 0xd84,
            wrist = 0xd34,
            gloves = 0x694,
            waist = 0x674,
            leggings =0xd24,
            boots = 0x684,
            ring1 = 0xd44,
            ring2 = 0x6a4,
            trinket1 = 0x6b4,
            trinket2 = 0xd54,

        }
        internal enum Globals : uint {
            PlayerName = 0x9BE820,
            CurrentRealm = 0x9BE9AE,
            CurrentTargetGUID = 0xAD7448,
            LastTargetGUID = 0xAD7450,
            FocusTargetGUID = 0xAD7468,
            MouseOverGUID = 0xAD7438,
            PetGUID = 0xB43B60,
            FollowGUID = 0x9D61D8,
            ComboPoint = 0xAD74F1,
            LootWindow = 0xB45230,
            Timestamp = 0x9C0C7C,
            BuildNumber = 0xAB4214,
            GetMinimapZoneText = 0xAD7414,
            GetZoneText = 0xAD741C,
            GetSubZoneText = 0xAD7418,
            GetZoneID = 0xAD74B0,
            IsInGame = 0xAD7426,
            ContinentID = 0x8A2710,
            LastErrorMessage = 0xAD6828,
            IsLoadingOrConnecting = 0xABB9AC,
            GetCurrencyInfo = 0x914F48,
            GetHomeBindAreaId = 0x9D4D7C,
            PetSpellBookNumSpells = 0xB33CA4,
            PetSpellBookNumSpellsPtr = 0xB33CA8,
            SpellIsTargetting = 0xACD654,
            SpellIsPending = 0xACD770,
            ScriptGetLocale = 0x9732FC,
            CursorType = 0x93D250,
            MirrorTimer = 0xAD78D0,
            GetNumInstalledAddons = 0x93A74C,
            BaseAddons = 0x93A750,
            TotalGuildMembers = 0xB35ECC,
            GuildRosterInfoBase = 0xB35F64
        }
       
    }
}
