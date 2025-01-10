using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ꜱꜱᴏ.ᴜᴛɪʟꜱ;

namespace ꜱꜱᴏ.ʜᴏᴍᴇ
{
    internal class ᴍᴏᴅᴜʟᴇ
    {
        internal static class ᴀᴅᴅʀᴇꜱꜱᴇ
        {
            internal static string ꜰʟʏ { get; set; }
            internal static string ꜱᴘᴇᴇᴅ { get; set; }
            internal static string ᴅᴏᴜʙʟᴇꜱᴘᴇᴇᴅ { get; set; }
            internal static string ɴᴏꜰᴀʟʟ { get; set; }
            internal static string ɴᴏʀᴇꜱᴇᴛ { get; set; }
            internal static string ꜰᴜʟʟQᴜᴇꜱᴛ { get; set; }
            internal static string ᴇɴᴅʟᴇꜱꜱQᴜᴇꜱᴛ { get; set; }
            internal static string ꜱᴋɪᴘQᴜᴇꜱᴛ { get; set; }
            internal static string ɪɴꜱᴛᴀɴᴛᴅɪᴀʟᴏɢ { get; set; }

            internal static string ᴘxꜱᴄʀɪᴘᴛ { get; set; }
            internal static string ᴄᴏᴏʀᴅɪɴᴀᴛᴇꜱ { get; set; }
            internal static string ᴅᴜᴘᴇɪᴛᴇᴍ { get; set; }
            internal static string ɪᴛᴇᴍᴄʜᴇᴀᴛ { get; set; }
        }

        internal static class ᴠᴀʟᴜᴇꜱ
        {
            internal static int ꜰʟʏ_ᴋᴇʏ = 32;
            internal static int ꜱᴘᴇᴇᴅ_ᴋᴇʏ = 16;

            internal static int ᴀᴍᴏᴜɴᴛ_ᴅᴜᴘᴇɪᴛᴇᴍ = 99;
            internal static int ᴀᴍᴏᴜɴᴛ_ᴋᴇʏ = 1;

            internal static int ᴠᴀʟᴜᴇ_ꜱᴛᴀʀᴄᴏɪɴꜱ = 0;
            internal static int ᴠᴀʟᴜᴇ_ʜᴏʀꜱᴇɪᴅ = 0;
            internal static int ᴠᴀʟᴜᴇ_ʜᴏʀꜱᴇꜱʜᴏᴘɪᴅ = 0;

            internal static string ᴠᴀʟᴜᴇ_ᴄᴜꜱᴛᴏᴍꜱᴄʀɪᴘᴛꜱ = "global/..";

            internal static string ᴠᴀʟᴜᴇ_ᴘʟᴀʏᴇʀɴᴀᴍᴇ = "by Jan";
            internal static string ᴠᴀʟᴜᴇ_ʜᴏʀꜱᴇɴᴀᴍᴇ = "by Jan";

            internal static int ᴀᴍᴏᴜɴᴛ_ɪᴛᴇᴍ = 1;
            internal static int ɪᴅ_ɪᴛᴇᴍ = 0;

            internal static float ꜱᴘᴇᴇᴅ_ᴀɴɪᴍᴀᴛɪᴏɴ = 1.25f;

            internal static string ᴏʙᴊᴇᴄᴛᴍᴀɴᴀɢᴇʀ_ᴏʙᴊᴇᴄᴛ = "FO_FlagJorvik.pxo";

            internal static string selected_rep = "";
            internal static string[] rep = {
    "AAExpedition",
    "AncientOak",
    "ArcheologyDepartment",
    "BaronessRacetrack",
    "BeatrixTrust",
    "BigBonnyMachine_HORSE",
    "BillysFlowers",
    "BobCatGirls",
    "ButtergoodFamily",
    "ChampionshipFortPinta",
    "ChampionshipMoorland",
    "ChampionshipPony",
    "CrescentVillage",
    "Druids",
    "FamilyDew",
    "FamilyGoldspur",
    "FamilyJarlasson",
    "FamilySunfield",
    "ForgottenFieldsStable",
    "FortMaria",
    "FortPinta",
    "GED_JarlaheimOffice",
    "Goldenleafs",
    "JamieOlivetree",
    "JorvikCityCitizen",
    "JorvikFishingClub",
    "JorvikGazette",
    "JorvikRangersDundull",
    "JorvikRangersRedwoodPoint",
    "JorvikStable",
    "MoorlandBridgeBuilders",
    "RickyWinterwell",
    "ShoppingMall",
    "SilvergladeVillage",
    "SilvergladeWinery",
    "SouthHarvestCounties",
    "SouthHoof",
    "SouthHoofHermit",
    "SouthJorvikFishingClub",
    "Stoneground_Expedition",
    "WildwoodsForesters",
    "WildwoodsMystics",
    "WildwoodsWarriors",
    "WinterwellFamily",
    "WolfHellInn",
    "SoulRidingWithRhiannon"
};


            internal static string selected_animations_horse = "";
            internal static string[] animations_horse = {
    "Break",
    "Dance",
    "FastGallop",
    "Feed",
    "Gallop",
    "Groom",
    "HoofPick",
    "Line Dance",
    "Pat",
    "Rearing",
    "SpecialBow",
    "SpecialGait",
    "SpecialIdleCrazy",
    "SpecialKick",
    "SpecialMove",
    "SpecialPiaffe_Loop",
    "SpecialRearing Attack",
    "Tolt",
    "Trot",
    "Walk",
    "WaveLong"
};

            internal static string selected_animations_player = "";
            internal static string[] animations_player = {
    "ActingBow_01",
    "ActingCastingSpell_01",
    "ActingCrying_01",
    "ActingEmoteDying_01",
    "ActingImaginaryHorse_01",
    "ActingLaughing_01",
    "ActingLookAround_01",
    "ActingPraying_01",
    "ActingTalkAngry_01",
    "ActingTalkAuthority_01",
    "ActingTalkDramatic_01",
    "ActingTalkDramatic_02",
    "ActingTalkDramatic_03",
    "ActingTalkEmotional_01",
    "ActingTalkEmotional_02",
    "ActingTalkEmotional_03",
    "ActingTalkSad_01",
    "ActingTalkToSkull_01",
    "ActionMine",
    "ActionPreWand",
    "ActionWand1",
    "ActionWand2",
    "BassIdle",
    "BassPlay",
    "BassPlay_01",
    "BassPlay_02",
    "BassPlay_02",
    "BeachDance",
    "BeachDance_01",
    "BeachDance_02",
    "BeautySalon",
    "BS_Anvil",
    "BS_Water",
    "CleanFloor",
    "Climb1Down",
    "Climb1Up",
    "CraftingDye",
    "Dance1",
    "Drink",
    "Drummer_Play",
    "Drummer_Play_01",
    "Drummer_Play_02",
    "Drummer_Play_03",
    "Drummer_Play_04",
    "EmoteBravo",
    "EmoteGesture",
    "EmoteHappy",
    "Emotelaugh",
    "EmoteNo",
    "EmoteQuestion",
    "EmoteRobotDance",
    "EmoteScared",
    "EmoteTalk",
    "EmoteUnunderstand",
    "EmoteWave",
    "FashionPose",
    "FashionPose_01",
    "FashionPose_02",
    "FashionPose_03",
    "FashionPose_04",
    "FeedHay",
    "FightFeed",
    "Fishing",
    "FoalClean",
    "FoalFeed",
    "GmoteGesture",
    "Groom",
    "GroomLow",
    "Guitarist_Play",
    "Guitarist_Play_01",
    "Guitarist_Play_02",
    "Guitarist_Play_03",
    "Guitarist_Play_04",
    "Horse_EmoteTalk",
    "HorseDismoun",
    "HorseEmoteGesture",
    "HorseEmoteLaugh",
    "HorseEmoteNo",
    "Keyboardldle",
    "KeyboardPlay",
    "KeyboardPlay_01",
    "KeyboardPlay_02",
    "Knit",
    "LineDance",
    "Meditation",
    "Mocka",
    "OperateGeneric",
    "OperateGenericLow",
    "OperateHammerLow",
    "PassPlay_01",
    "PatHighReverse",
    "PatReverse",
    "PetCat",
    "PetCatLow",
    "PetCow",
    "PetFox",
    "PetPig",
    "PetSheep",
    "PushUp",
    "SFDance1",
    "SFDance2",
    "SFDance3",
    "Sit",
    "SitBeach",
    "SitBeach_01",
    "SitBeach_02",
    "SitCafe",
    "SitClubClub1",
    "SitClubClub2",
    "SitClubGood",
    "SitClubNo",
    "SitEat",
    "SitEat_01",
    "SitEat_02",
    "SitSunChair",
    "SlepInPlace",
    "SpecialJump",
    "Sprinkle",
    "Talk",
    "TashionPose_03",
    "Throw",
    "UrbanDance",
    "Vocalist_Angry_01",
    "Vocalist_Cheering",
    "Vocalist_Cheering_01",
    "Vocalist_Cheering_02",
    "Vocalist_Cheering_03",
    "Vocalist_Happy_01",
    "Vocalist_ldle",
    "Vocalist_MicDrop",
    "Vocalist_Play_01",
    "Vocalist_Play_02",
    "Vocalist_Play_03",
    "Vocalist_Play_04",
    "Wardrobe",
    "Wardrobe_Face",
    "Wash",
    "Water",
    "WipeTable"
};

            internal static string selected_shop = "";
            internal static string[] shops = {
    "BaronessRacetrackShopKeeperClothersGear /*another baroness shop*/",
    "BaronessRacetrackShopKeeperReputation /*baroness shop*/",
    "BeachFestival_TokenVendor /*summer token shop*/",
    "BeachPartyShop /*summer beach shop*/",
    "BillysGardenStore /*winery garden shop*/",
    "BirthdayCakeShop /*cake*/",
    "BirthdayCakeShop_Horse /*horse cake*/",
    "CloudKingdom_ExplorerShop /* */",
    "EasterShop /*easter clothes*/",
    "EasterShop2 /*easter masks*/",
    "EquestrianFestival_Premium_Balloon /* */",
    "EquestrianFestival_Premium_RP_Pets /*carrots, care pack, apples*/",
    "EquestrianFestival_TokenVendor_Balloon /* */",
    "EquestrianFestival_TokenVendor_BobcatsSet /* */",
    "EquestrianFestival_TokenVendor_GoldenBaroqueSet /* */",
    "EquestrianFestival_TokenVendor_RP_Pets /*foal care*/",
    "EquestrianFestival_TokenVendor_TrailRideSet /*trail ride*/",
    "GenericHorseUtilitiesShop /*food etc*/",
    "GovernorFall_LuxuaryGear /*governor fall*/",
    "Halloween_TokenVendor /*token*/",
    "HalloweenFest_VintageShop /*vintage*/",
    "HalloweenMakeupShop /*makeup*/",
    "HalloweenMaskShop /*masks*/",
    "HalloweenPetShop /*pets*/",
    "HalloweenShop /*new*/",
    "IcebergAfloatPetShop /*seals*/",
    "JojoSiwaShop /*jojo siwa*/",
    "JSOH_Shop /* */",
    "MagicChristmasMarketShop_A /*crisp collection boutique*/",
    "MagicChristmasMarketShop_ChristmasSweaters /*winter sweaters*/",
    "MagicChristmasMarketShop_Costumes /*xmas old accessories, ginger stuff*/",
    "MagicChristmasMarketShop_FleaMarket /*old winter stuff*/",
    "MagicPetShopBeeper01 /*deep-sea gull*/",
    "MagicPetShopBunny01 /*happy-go-lucky bunny*/",
    "MagicPetShopBunny02 /*bunny of darkness*/",
    "MagicPetShopDruidUnicornFox01 /*cruncher*/",
    "MagicPetShopDruidUnicornFox02 /*truffles*/",
    "MagicPetShopFishCat01 /*captain finny*/",
    "MagicPetShopFishCat02 /*admiral stripes*/",
    "MagicPetShopManta01 /*pearly pink manta*/",
    "MagicPetShopManta02 /*pink manta*/",
    "MagicPetShopOwl01 /*dreamy dawn owl*/",
    "MagicPetShopSpider01 /*bitey the birch spider*/",
    "MagicPetShopSpider02 /*cherry the chomper*/",
    "MagigPetSHopCat /*ember enchantment cat*/",
    "MagigPetSHopFox /*moonlit magic fox*/",
    "MallCostumeShop_Costumes /*costume clothes*/",
    "MallCostumeShop_HorseGear /*costume gear*/",
    "MegaClothesShop /*clothes*/",
    "MegaGearShop /*gear*/",
    "MegaHorseDecorationShop /*leg wraps, bows*/",
    "MegaPetShop /*pets*/",
    "MidsummerShop /*midsummer, in global*/",
    "MiscreantsShop /*miscreants*/",
    "NewLifetimeShop /*lifetime shop*/",
    "NewYearShop /*old shop, dresses, fireworks*/",
    "QC2123_FashionWeekQuest /*fashion week*/",
    "RainbowFest_Shopkeeper_PrideShop /*pride ribbons*/",
    "Shopkeeper_DressWarm /*crisp collection boutique*/",
    "Shopkeeper_WinterOutdoors /*winter village shop*/",
    "Shopkeeper_WinterToken /*winter token shop*/",
    "SkyeClothingShop /*skye clothing shop*/",
    "SpiritHorseShop /*spirit clothes*/",
    "StarRiderBeautySaloonHair1 /*Granny Hairs*/",
    "StarStableBirthdayGearShop /*10th, 11th bday*/",
    "StarStableBirthdayShop /*fireworks*/",
    "Travelling_DruidClothes /*travelling druid*/",
    "TravellingMarketGear2 /*clothes, great*/",
    "TravellingSalesmanPetFrogShop /*frogs*/",
    "TravellingSalesmanPetPigShop /*pigs*/",
    "ValentinesDayShop2018 /*valentines 2018*/",
    "Winter_JamesScheme /*snow tickets*/",
    "WinterVillage_ChineseLanternShop /*chinese fireworks*/",
    "WinterVillage_Pets /*winter village pets*/"
};
        }

        internal static class ʙᴏᴏʟᴇᴀɴ
        {
            internal static bool ꜰʟʏ = false;
            internal static bool ꜱᴘᴇᴇᴅ = false;
            internal static bool ᴅᴏᴜʙʟᴇꜱᴘᴇᴇᴅ = false;
            internal static bool ɴᴏꜰᴀʟʟ = false;
            internal static bool ɴᴏʀᴇꜱᴇᴛ = false;
            internal static bool ꜰᴜʟʟQᴜᴇꜱᴛ = false;
            internal static bool ᴇɴᴅʟᴇꜱꜱQᴜᴇꜱᴛ = false;
            internal static bool ɪɴꜱᴛᴀɴᴛᴅɪᴀʟᴏɢ = false;

            internal static bool ᴍᴏᴅᴅɪɴɢ = false;
        }

        public static bool ɪꜱᴅʟʟʟᴏᴀᴅᴇᴅ(Process process, string dllName, out IntPtr addr)
        {
            foreach (ProcessModule module in process.Modules)
            {
                if (module.ModuleName.Equals(dllName, StringComparison.OrdinalIgnoreCase))
                {
                    addr = module.BaseAddress;
                    return true;
                }
            }

            addr = default;
            return false;
        }

        internal enum ɪɴɪᴛɪᴀʟɪᴢᴇʀᴇꜱᴜʟᴛ
        {
            ᴍᴏᴅᴜʟᴇ_ꜱᴜᴄᴄᴇꜱꜱꜰᴜʟʟʏ,
            ᴍᴏᴅᴜʟᴇ_ꜰᴀɪʟᴇᴅ
        }

        internal static async Task<ɪɴɪᴛɪᴀʟɪᴢᴇʀᴇꜱᴜʟᴛ> ɪɴɪᴛɪᴀʟɪᴢᴇ()
        {
            try
            {
                if (ɪꜱᴅʟʟʟᴏᴀᴅᴇᴅ(Process.GetProcessesByName(ᴀʙᴏᴜᴛ.ᴘʀᴏᴄᴇꜱꜱɴᴀᴍᴇ)[0], ᴀʙᴏᴜᴛ.ᴘʀᴏᴄᴇꜱꜱɴᴀᴍᴇᴇxᴇ, out IntPtr ɢᴀᴍᴇʙᴀꜱᴇᴀᴅᴅʀᴇꜱꜱᴇ))
                {
                    ᴀᴅᴅʀᴇꜱꜱᴇ.ꜰʟʏ = await ᴍᴇᴍᴏʀʏ.ꜱʏɴᴄᴀᴏʙꜱᴄᴀɴ(ɢᴀᴍᴇʙᴀꜱᴇᴀᴅᴅʀᴇꜱꜱᴇ.ToInt64(), ɢᴀᴍᴇʙᴀꜱᴇᴀᴅᴅʀᴇꜱꜱᴇ.ToInt64() + 0xFFFFFF, "F3 0F 10 40 04 F3 0F 58 81 84 00 00 00", 0);
                    ᴀᴅᴅʀᴇꜱꜱᴇ.ꜱᴘᴇᴇᴅ = await ᴍᴇᴍᴏʀʏ.ꜱʏɴᴄᴀᴏʙꜱᴄᴀɴ(ɢᴀᴍᴇʙᴀꜱᴇᴀᴅᴅʀᴇꜱꜱᴇ.ToInt64(), ɢᴀᴍᴇʙᴀꜱᴇᴀᴅᴅʀᴇꜱꜱᴇ.ToInt64() + 0xFFFFFF, "0F 57 C6 F3 0F 11 40 04 8B", 0);
                    ᴀᴅᴅʀᴇꜱꜱᴇ.ᴅᴏᴜʙʟᴇꜱᴘᴇᴇᴅ = await ᴍᴇᴍᴏʀʏ.ꜱʏɴᴄᴀᴏʙꜱᴄᴀɴ(ɢᴀᴍᴇʙᴀꜱᴇᴀᴅᴅʀᴇꜱꜱᴇ.ToInt64(), ɢᴀᴍᴇʙᴀꜱᴇᴀᴅᴅʀᴇꜱꜱᴇ.ToInt64() + 0xFFFFFF, "3B EF 75 38 80 BB ?? ?? ?? ?? ??", 0);
                    ᴀᴅᴅʀᴇꜱꜱᴇ.ɴᴏꜰᴀʟʟ = await ᴍᴇᴍᴏʀʏ.ꜱʏɴᴄᴀᴏʙꜱᴄᴀɴ(ɢᴀᴍᴇʙᴀꜱᴇᴀᴅᴅʀᴇꜱꜱᴇ.ToInt64(), ɢᴀᴍᴇʙᴀꜱᴇᴀᴅᴅʀᴇꜱꜱᴇ.ToInt64() + 0xFFFFFF, "F3 44 0F 11 ?? ?? 03 00 00 44", -0x18);
                    ᴀᴅᴅʀᴇꜱꜱᴇ.ɴᴏʀᴇꜱᴇᴛ = await ᴍᴇᴍᴏʀʏ.ꜱʏɴᴄᴀᴏʙꜱᴄᴀɴ(ɢᴀᴍᴇʙᴀꜱᴇᴀᴅᴅʀᴇꜱꜱᴇ.ToInt64(), ɢᴀᴍᴇʙᴀꜱᴇᴀᴅᴅʀᴇꜱꜱᴇ.ToInt64() + 0xFFFFFF, "74 22 F3 0F 10 5A 08", 0);
                    ᴀᴅᴅʀᴇꜱꜱᴇ.ꜰᴜʟʟQᴜᴇꜱᴛ = await ᴍᴇᴍᴏʀʏ.ꜱʏɴᴄᴀᴏʙꜱᴄᴀɴ(ɢᴀᴍᴇʙᴀꜱᴇᴀᴅᴅʀᴇꜱꜱᴇ.ToInt64(), ɢᴀᴍᴇʙᴀꜱᴇᴀᴅᴅʀᴇꜱꜱᴇ.ToInt64() + 0xFFFFFF, "B2 02 48 8B CF E8 ?? ?? 00 00 B0 01", 0);
                    ᴀᴅᴅʀᴇꜱꜱᴇ.ᴇɴᴅʟᴇꜱꜱQᴜᴇꜱᴛ = await ᴍᴇᴍᴏʀʏ.ꜱʏɴᴄᴀᴏʙꜱᴄᴀɴ(ɢᴀᴍᴇʙᴀꜱᴇᴀᴅᴅʀᴇꜱꜱᴇ.ToInt64(), ɢᴀᴍᴇʙᴀꜱᴇᴀᴅᴅʀᴇꜱꜱᴇ.ToInt64() + 0xFFFFFF, "B2 05 48 8B ?? E8 ?? FD", 0);
                    ᴀᴅᴅʀᴇꜱꜱᴇ.ꜱᴋɪᴘQᴜᴇꜱᴛ = await ᴍᴇᴍᴏʀʏ.ꜱʏɴᴄᴀᴏʙꜱᴄᴀɴ(ɢᴀᴍᴇʙᴀꜱᴇᴀᴅᴅʀᴇꜱꜱᴇ.ToInt64(), ɢᴀᴍᴇʙᴀꜱᴇᴀᴅᴅʀᴇꜱꜱᴇ.ToInt64() + 0xFFFFFF, "B2 01 E8 ?? ?? FF FF E9", 0);
                    ᴀᴅᴅʀᴇꜱꜱᴇ.ɪɴꜱᴛᴀɴᴛᴅɪᴀʟᴏɢ = await ᴍᴇᴍᴏʀʏ.ꜱʏɴᴄᴀᴏʙꜱᴄᴀɴ(ɢᴀᴍᴇʙᴀꜱᴇᴀᴅᴅʀᴇꜱꜱᴇ.ToInt64(), ɢᴀᴍᴇʙᴀꜱᴇᴀᴅᴅʀᴇꜱꜱᴇ.ToInt64() + 0xFFFFFF, "40 84 F6 74 16 89", 0);

                    return ɪɴɪᴛɪᴀʟɪᴢᴇʀᴇꜱᴜʟᴛ.ᴍᴏᴅᴜʟᴇ_ꜱᴜᴄᴄᴇꜱꜱꜰᴜʟʟʏ;
                }

                return ɪɴɪᴛɪᴀʟɪᴢᴇʀᴇꜱᴜʟᴛ.ᴍᴏᴅᴜʟᴇ_ꜰᴀɪʟᴇᴅ;
            }
            catch
            {
                return ɪɴɪᴛɪᴀʟɪᴢᴇʀᴇꜱᴜʟᴛ.ᴍᴏᴅᴜʟᴇ_ꜰᴀɪʟᴇᴅ;
            }
        }

        public static void ꜰʟʏᴍᴏᴅᴜʟᴇ(bool toggle)
        {
            if (toggle)
            {
                if (ɪɴᴘᴜᴛ.isKeyPress(ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.ꜰʟʏ_ᴋᴇʏ))
                {
                    ᴍᴇᴍᴏʀʏ.ᴡʀɪᴛᴇᴍᴇᴍᴏʀʏ(ᴀᴅᴅʀᴇꜱꜱᴇ.ꜰʟʏ, "bytes", "F3 0F 10 48 04");
                }
                else
                {
                    ᴍᴇᴍᴏʀʏ.ᴡʀɪᴛᴇᴍᴇᴍᴏʀʏ(ᴀᴅᴅʀᴇꜱꜱᴇ.ꜰʟʏ, "bytes", "F3 0F 10 40 04");
                }
            }
        }

        public static void ꜱᴘᴇᴇᴅᴍᴏᴅᴜʟᴇ(bool toggle)
        {
            if (toggle)
            {
                if (ɪɴᴘᴜᴛ.isKeyPress(ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.ꜱᴘᴇᴇᴅ_ᴋᴇʏ))
                {
                    ᴍᴇᴍᴏʀʏ.ᴡʀɪᴛᴇᴍᴇᴍᴏʀʏ(ᴀᴅᴅʀᴇꜱꜱᴇ.ꜱᴘᴇᴇᴅ, "bytes", "90 90 90");
                }
                else
                {
                    ᴍᴇᴍᴏʀʏ.ᴡʀɪᴛᴇᴍᴇᴍᴏʀʏ(ᴀᴅᴅʀᴇꜱꜱᴇ.ꜱᴘᴇᴇᴅ, "bytes", "0F 57 C6");
                }
            }
        }

        public static void ᴅᴏᴜʙʟᴇꜱᴘᴇᴇᴅᴍᴏᴅᴜʟᴇ(bool toggle)
        {
            if (toggle)
            {
                ᴍᴇᴍᴏʀʏ.ᴡʀɪᴛᴇᴍᴇᴍᴏʀʏ(ᴀᴅᴅʀᴇꜱꜱᴇ.ᴅᴏᴜʙʟᴇꜱᴘᴇᴇᴅ, "bytes", "90 90");
            }
            else
            {
                ᴍᴇᴍᴏʀʏ.ᴡʀɪᴛᴇᴍᴇᴍᴏʀʏ(ᴀᴅᴅʀᴇꜱꜱᴇ.ᴅᴏᴜʙʟᴇꜱᴘᴇᴇᴅ, "bytes", "3B EF");
            }
        }

        public static void ɴᴏꜰᴀʟʟᴍᴏᴅᴜʟᴇ(bool toggle)
        {
            if (toggle)
            {
                ᴍᴇᴍᴏʀʏ.ᴡʀɪᴛᴇᴍᴇᴍᴏʀʏ(ᴀᴅᴅʀᴇꜱꜱᴇ.ɴᴏꜰᴀʟʟ, "bytes", "75");
            }
            else
            {
                ᴍᴇᴍᴏʀʏ.ᴡʀɪᴛᴇᴍᴇᴍᴏʀʏ(ᴀᴅᴅʀᴇꜱꜱᴇ.ɴᴏꜰᴀʟʟ, "bytes", "74");
            }
        }

        public static void ꜱᴛᴀʀᴄᴏɪɴꜱᴍᴏᴅᴜʟᴇ(int amount)
        {
            // Removed, because Exploit Exposing.
        }

        public static void ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ(string script)
        {
            ᴍᴇᴍᴏʀʏ.ᴡʀɪᴛᴇꜱᴛʀɪɴɢ(ᴀᴅᴅʀᴇꜱꜱᴇ.ᴘxꜱᴄʀɪᴘᴛ, script);
        }

        public static void ᴅᴜᴘᴇᴍᴏᴅᴜʟᴇ(int amount)
        {
            ᴍᴇᴍᴏʀʏ.ᴡʀɪᴛᴇᴍᴇᴍᴏʀʏ(ᴀᴅᴅʀᴇꜱꜱᴇ.ᴅᴜᴘᴇɪᴛᴇᴍ + ",198", "int", amount.ToString());
        }

        public static void ᴅᴜᴘᴇᴍᴀxᴍᴏᴅᴜʟᴇ(int amount)
        {
            ᴍᴇᴍᴏʀʏ.ᴡʀɪᴛᴇᴍᴇᴍᴏʀʏ(ᴀᴅᴅʀᴇꜱꜱᴇ.ᴅᴜᴘᴇɪᴛᴇᴍ + ",1D4", "int", amount.ToString());
        }

        public static void ɴᴏʀᴇꜱᴇᴛᴍᴏᴅᴜʟᴇ(bool toggle)
        {
            if (toggle)
            {
                ᴍᴇᴍᴏʀʏ.ᴡʀɪᴛᴇᴍᴇᴍᴏʀʏ(ᴀᴅᴅʀᴇꜱꜱᴇ.ɴᴏʀᴇꜱᴇᴛ, "bytes", "75");
            }
            else
            {
                ᴍᴇᴍᴏʀʏ.ᴡʀɪᴛᴇᴍᴇᴍᴏʀʏ(ᴀᴅᴅʀᴇꜱꜱᴇ.ɴᴏʀᴇꜱᴇᴛ, "bytes", "74");
            }
        }

        public static void ꜰᴜʟʟQᴜᴇꜱᴛᴄᴏᴍᴘʟᴇᴛᴇᴍᴏᴅᴜʟᴇ(bool toggle)
        {
            if (toggle)
            {
                ᴍᴇᴍᴏʀʏ.ᴡʀɪᴛᴇᴍᴇᴍᴏʀʏ(ᴀᴅᴅʀᴇꜱꜱᴇ.ꜰᴜʟʟQᴜᴇꜱᴛ, "bytes", "B2 03");
            }
            else
            {
                ᴍᴇᴍᴏʀʏ.ᴡʀɪᴛᴇᴍᴇᴍᴏʀʏ(ᴀᴅᴅʀᴇꜱꜱᴇ.ꜰᴜʟʟQᴜᴇꜱᴛ, "bytes", "B2 02");
            }
        }

        public static void ᴇɴᴅʟᴇꜱꜱᴍᴏᴅᴜʟᴇ(bool toggle)
        {
            if (toggle)
            {
                ᴍᴇᴍᴏʀʏ.ᴡʀɪᴛᴇᴍᴇᴍᴏʀʏ(ᴀᴅᴅʀᴇꜱꜱᴇ.ᴇɴᴅʟᴇꜱꜱQᴜᴇꜱᴛ, "bytes", "B2 01");
            }
            else
            {
                ᴍᴇᴍᴏʀʏ.ᴡʀɪᴛᴇᴍᴇᴍᴏʀʏ(ᴀᴅᴅʀᴇꜱꜱᴇ.ᴇɴᴅʟᴇꜱꜱQᴜᴇꜱᴛ, "bytes", "B2 05");
            }
        }

        public static void ɪɴꜱᴛᴀɴᴛᴅɪᴀʟᴏɢᴍᴏᴅᴜʟᴇ(bool toggle)
        {
            if (toggle)
            {
                ᴍᴇᴍᴏʀʏ.ᴡʀɪᴛᴇᴍᴇᴍᴏʀʏ(ᴀᴅᴅʀᴇꜱꜱᴇ.ɪɴꜱᴛᴀɴᴛᴅɪᴀʟᴏɢ, "bytes", "40 88");
            }
            else
            {
                ᴍᴇᴍᴏʀʏ.ᴡʀɪᴛᴇᴍᴇᴍᴏʀʏ(ᴀᴅᴅʀᴇꜱꜱᴇ.ɪɴꜱᴛᴀɴᴛᴅɪᴀʟᴏɢ, "bytes", "40 84");
            }
        }
    }
}
