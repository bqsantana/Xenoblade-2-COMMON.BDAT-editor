using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xenoblade_2_COMMON.BDAT_editor.Utils;

namespace Xenoblade_2_COMMON.BDAT_editor
{
    public class CHR_BL
    {
        public int ID { get; set; }
        public int Name { get; set; }
        public string DebugName { get; set; }
        public int Race { get; set; }
        public int RotateLimitPitch { get; set; }
        public int RotateLimitRoll { get; set; }
        public int Gender { get; set; }
        public int QuestRace { get; set; }
        public string Model { get; set; }
        public string Motion { get; set; }
        public string AddMotion { get; set; }
        public int? Condition { get; set; }
        public string Model2 { get; set; }
        public string Motion2 { get; set; }
        public int? Still { get; set; }
        public string Voice { get; set; }
        public string ClipEvent { get; set; }
        public string Com_SE { get; set; }
        public string SePack { get; set; }
        public string Com_Eff { get; set; }
        public string Com_Vo { get; set; }
        public int OffsetID { get; set; }
        public int EyeRot { get; set; }
        public int ChestHeight { get; set; }
        public int LandingHeight { get; set; }
        public int FootStep { get; set; }
        public int FootStepEffect { get; set; }
        public int WeaponType { get; set; }
        public int Scale { get; set; }
        public int WpnScale { get; set; }
        public int Flag { get; set; }
        public int? PrivateWpnR { get; set; }
        public int? PrivateWpnL { get; set; }
        public int? PrivateWpnR_Driver { get; set; }
        public int? PrivateWpnL_Driver { get; set; }
        public string WpnrOut { get; set; }
        public string WpnlOut { get; set; }
        public int OrbNum { get; set; }
        public int Atr { get; set; }
        public int? Personality { get; set; }
        public int CoolTime { get; set; }
        public int DefWeapon { get; set; }
        public int BArts1 { get; set; }
        public int BArts2 { get; set; }
        public int BArts3 { get; set; }
        public int BartsEx { get; set; }
        public int BartsEx2 { get; set; }
        public int NArts1 { get; set; }
        public int NArtsRecastRev1 { get; set; }
        public int NArts2 { get; set; }
        public int NArtsRecastRev2 { get; set; }
        public int NArts3 { get; set; }
        public int NArtsRecastRev3 { get; set; }
        public int BSkill1 { get; set; }
        public int BSkill2 { get; set; }
        public int BSkill3 { get; set; }
        public int PArmor { get; set; }
        public int EArmor { get; set; }
        public int HpMaxRev { get; set; }
        public int StrengthRev { get; set; }
        public int PowEtherRev { get; set; }
        public int DexRev { get; set; }
        public int AgilityRev { get; set; }
        public int LuckRev { get; set; }
        public int BKLSet { get; set; }
        public int FSkill1 { get; set; }
        public int FSkill2 { get; set; }
        public int FSkill3 { get; set; }
        public int? ArtsAchievement1 { get; set; }
        public int? ArtsAchievement2 { get; set; }
        public int? ArtsAchievement3 { get; set; }
        public int? SkillAchievement1 { get; set; }
        public int? SkillAchievement2 { get; set; }
        public int? SkillAchievement3 { get; set; }
        public int? FskillAchivement1 { get; set; }
        public int? FskillAchivement2 { get; set; }
        public int? FskillAchivement3 { get; set; }
        public int? KeyAchievement { get; set; }
        public int IdeaBlue { get; set; }
        public int IdeaRed { get; set; }
        public int IdeaWhite { get; set; }
        public int IdeaBlack { get; set; }
        public int FavoriteCategory1 { get; set; }
        public int FavoriteItem1 { get; set; }
        public int FavoriteCategory2 { get; set; }
        public int FavoriteItem2 { get; set; }
        public int CreateEventID { get; set; }
        public int NormalTalk { get; set; }
        public int CollisionId { get; set; }
        public int BladeSize { get; set; }
        public int MemorySlot { get; set; }
        public int EventAsset { get; set; }
        public string CenterBone { get; set; }
        public string CamBone { get; set; }
        public int MerceName { get; set; }
        public int ReleaseLock { get; set; }
        public int CreateInfo { get; set; }
        public int ExtraParts1 { get; set; }
        public int ExtraParts2 { get; set; }
        public int ExtraParts3 { get; set; }
        public int ExtraParts4 { get; set; }
        public int MnuCastName { get; set; }
        public int MnuIlustName { get; set; }
        public string MnuVoice1 { get; set; }
        public string MnuVoice2 { get; set; }
        public string MnuVoice3 { get; set; }
        public int sortJP { get; set; }
        public int sortGE { get; set; }
        public int sortFR { get; set; }
        public int sortSP { get; set; }
        public int sortIT { get; set; }
        public int sortGB { get; set; }
        public int sortCN { get; set; }
        public int sortTW { get; set; }
        public bool OnlyWpn { get; set; }
        public bool NoBuildWpn { get; set; }
        public bool OnlyChBtl { get; set; }
        public bool FreeEngage { get; set; }
        public bool NoMapRev { get; set; }

        public CHR_BL mapCHR_BL(Stream str, int initialOffset, int initialBdatOffset, int[] resourceCapacity)
        {
            GetByteValue getByteValue = new GetByteValue();
            GetFlag getFlag = new GetFlag();
            CHR_BL cHR_BL = new CHR_BL();

            cHR_BL.Name = getByteValue.ExtractByteToInt(str, initialOffset, 2);
            cHR_BL.DebugName = getByteValue.ExtractResource(str, initialOffset + 2, initialBdatOffset, 4, resourceCapacity[0]);
            cHR_BL.Race = getByteValue.ExtractByteToInt(str, initialOffset + 6, 1);
            cHR_BL.RotateLimitPitch = getByteValue.ExtractByteToInt(str, initialOffset + 7, 1);
            cHR_BL.RotateLimitRoll = getByteValue.ExtractByteToInt(str, initialOffset + 8, 1);
            cHR_BL.Gender = getByteValue.ExtractByteToInt(str, initialOffset + 9, 1);
            cHR_BL.QuestRace = getByteValue.ExtractByteToInt(str, initialOffset + 10, 1);
            cHR_BL.Model = getByteValue.ExtractResource(str, initialOffset + 11, initialBdatOffset, 4, resourceCapacity[1]);
            cHR_BL.Motion = getByteValue.ExtractResource(str, initialOffset + 15, initialBdatOffset, 4, resourceCapacity[1]);
            cHR_BL.AddMotion = getByteValue.ExtractResource(str, initialOffset + 19, initialBdatOffset, 4, resourceCapacity[2]);
            cHR_BL.Condition = getByteValue.ExtractByteToInt(str, initialOffset + 23, 2);
            cHR_BL.Model2 = getByteValue.ExtractResource(str, initialOffset + 25, initialBdatOffset, 4, resourceCapacity[3]);
            cHR_BL.Motion2 = getByteValue.ExtractResource(str, initialOffset + 29, initialBdatOffset, 4, resourceCapacity[3]);
            cHR_BL.Still = getByteValue.ExtractByteToInt(str, initialOffset + 33, 2);
            cHR_BL.Voice = getByteValue.ExtractResource(str, initialOffset + 35, initialBdatOffset, 4, resourceCapacity[4]);
            cHR_BL.ClipEvent = getByteValue.ExtractResource(str, initialOffset + 39, initialBdatOffset, 4, resourceCapacity[5]);
            cHR_BL.Com_SE = getByteValue.ExtractResource(str, initialOffset + 43, initialBdatOffset, 4, resourceCapacity[5]);
            cHR_BL.SePack = getByteValue.ExtractResource(str, initialOffset + 47, initialBdatOffset, 4, resourceCapacity[6]);
            cHR_BL.Com_Eff = getByteValue.ExtractResource(str, initialOffset + 51, initialBdatOffset, 4, resourceCapacity[7]);
            cHR_BL.Com_Vo = getByteValue.ExtractResource(str, initialOffset + 55, initialBdatOffset, 4, resourceCapacity[8]);
            cHR_BL.OffsetID = getByteValue.ExtractByteToInt(str, initialOffset + 59, 2);
            cHR_BL.EyeRot = getByteValue.ExtractByteToInt(str, initialOffset + 61, 1);
            cHR_BL.ChestHeight = getByteValue.ExtractByteToInt(str, initialOffset + 62, 2);
            cHR_BL.LandingHeight = getByteValue.ExtractByteToInt(str, initialOffset + 64, 2);
            cHR_BL.FootStep = getByteValue.ExtractByteToInt(str, initialOffset + 66, 1);
            cHR_BL.FootStepEffect = getByteValue.ExtractByteToInt(str, initialOffset + 67, 1);
            cHR_BL.WeaponType = getByteValue.ExtractByteToInt(str, initialOffset + 68, 1);
            cHR_BL.Scale = getByteValue.ExtractByteToInt(str, initialOffset + 69, 2);
            cHR_BL.WpnScale = getByteValue.ExtractByteToInt(str, initialOffset + 71, 2);
            cHR_BL.Flag = getByteValue.ExtractByteToInt(str, initialOffset + 73, 1);
            cHR_BL.PrivateWpnR = getByteValue.ExtractByteToInt(str, initialOffset + 74, 2);
            cHR_BL.PrivateWpnL = getByteValue.ExtractByteToInt(str, initialOffset + 76, 2);
            cHR_BL.PrivateWpnL_Driver = getByteValue.ExtractByteToInt(str, initialOffset + 78, 2);
            cHR_BL.PrivateWpnR_Driver = getByteValue.ExtractByteToInt(str, initialOffset + 80, 2);
            cHR_BL.WpnrOut = getByteValue.ExtractResource(str, initialOffset + 82, initialBdatOffset, 4, resourceCapacity[9]);
            cHR_BL.WpnlOut = getByteValue.ExtractResource(str, initialOffset + 86, initialBdatOffset, 4, resourceCapacity[10]);
            cHR_BL.OrbNum = getByteValue.ExtractByteToInt(str, initialOffset + 90, 1);
            cHR_BL.Atr = getByteValue.ExtractByteToInt(str, initialOffset + 91, 1);
            cHR_BL.Personality = getByteValue.ExtractByteToInt(str, initialOffset + 92, 1);
            cHR_BL.CoolTime = getByteValue.ExtractByteToInt(str, initialOffset + 93, 2);
            cHR_BL.DefWeapon = getByteValue.ExtractByteToInt(str, initialOffset + 95, 2);
            cHR_BL.BArts1 = getByteValue.ExtractByteToInt(str, initialOffset + 97, 2);
            cHR_BL.BArts2 = getByteValue.ExtractByteToInt(str, initialOffset + 99, 2);
            cHR_BL.BArts3 = getByteValue.ExtractByteToInt(str, initialOffset + 101, 2);
            cHR_BL.BartsEx = getByteValue.ExtractByteToInt(str, initialOffset + 103, 2);
            cHR_BL.BartsEx2 = getByteValue.ExtractByteToInt(str, initialOffset + 105, 2);
            cHR_BL.NArts1 = getByteValue.ExtractByteToInt(str, initialOffset + 107, 1);
            cHR_BL.NArtsRecastRev1 = getByteValue.ExtractByteToInt(str, initialOffset + 108, 1);
            cHR_BL.NArts2 = getByteValue.ExtractByteToInt(str, initialOffset + 109, 1);
            cHR_BL.NArtsRecastRev2 = getByteValue.ExtractByteToInt(str, initialOffset + 110, 1);
            cHR_BL.NArts3 = getByteValue.ExtractByteToInt(str, initialOffset + 111, 1);
            cHR_BL.NArtsRecastRev3 = getByteValue.ExtractByteToInt(str, initialOffset + 112, 1);
            cHR_BL.BSkill1 = getByteValue.ExtractByteToInt(str, initialOffset + 113, 2);
            cHR_BL.BSkill2 = getByteValue.ExtractByteToInt(str, initialOffset + 115, 2);
            cHR_BL.BSkill3 = getByteValue.ExtractByteToInt(str, initialOffset + 117, 2);
            cHR_BL.PArmor = getByteValue.ExtractByteToInt(str, initialOffset + 119, 1);
            cHR_BL.EArmor = getByteValue.ExtractByteToInt(str, initialOffset + 120, 1);
            cHR_BL.HpMaxRev = getByteValue.ExtractByteToInt(str, initialOffset + 121, 1);
            cHR_BL.StrengthRev = getByteValue.ExtractByteToInt(str, initialOffset + 122, 1);
            cHR_BL.PowEtherRev = getByteValue.ExtractByteToInt(str, initialOffset + 123, 1);
            cHR_BL.DexRev = getByteValue.ExtractByteToInt(str, initialOffset + 124, 1);
            cHR_BL.AgilityRev = getByteValue.ExtractByteToInt(str, initialOffset + 125, 1);
            cHR_BL.LuckRev = getByteValue.ExtractByteToInt(str, initialOffset + 126, 1);
            cHR_BL.BKLSet = getByteValue.ExtractByteToInt(str, initialOffset + 127, 2);
            cHR_BL.FSkill1 = getByteValue.ExtractByteToInt(str, initialOffset + 129, 2);
            cHR_BL.FSkill2 = getByteValue.ExtractByteToInt(str, initialOffset + 131, 2);
            cHR_BL.FSkill3 = getByteValue.ExtractByteToInt(str, initialOffset + 133, 2);
            cHR_BL.ArtsAchievement1 = getByteValue.ExtractByteToInt(str, initialOffset + 135, 2);
            cHR_BL.ArtsAchievement2 = getByteValue.ExtractByteToInt(str, initialOffset + 137, 2);
            cHR_BL.ArtsAchievement3 = getByteValue.ExtractByteToInt(str, initialOffset + 139, 2);
            cHR_BL.SkillAchievement1 = getByteValue.ExtractByteToInt(str, initialOffset + 141, 2);
            cHR_BL.SkillAchievement2 = getByteValue.ExtractByteToInt(str, initialOffset + 143, 2);
            cHR_BL.SkillAchievement3 = getByteValue.ExtractByteToInt(str, initialOffset + 145, 2);
            cHR_BL.FskillAchivement1 = getByteValue.ExtractByteToInt(str, initialOffset + 147, 2);
            cHR_BL.FskillAchivement2 = getByteValue.ExtractByteToInt(str, initialOffset + 149, 2);
            cHR_BL.FskillAchivement3 = getByteValue.ExtractByteToInt(str, initialOffset + 151, 2);
            cHR_BL.KeyAchievement = getByteValue.ExtractByteToInt(str, initialOffset + 153, 2);
            cHR_BL.IdeaBlue = getByteValue.ExtractByteToInt(str, initialOffset + 155, 1);
            cHR_BL.IdeaRed = getByteValue.ExtractByteToInt(str, initialOffset + 156, 1);
            cHR_BL.IdeaWhite = getByteValue.ExtractByteToInt(str, initialOffset + 157, 1);
            cHR_BL.IdeaBlack = getByteValue.ExtractByteToInt(str, initialOffset + 158, 1);
            cHR_BL.FavoriteCategory1 = getByteValue.ExtractByteToInt(str, initialOffset + 159, 2);
            cHR_BL.FavoriteItem1 = getByteValue.ExtractByteToInt(str, initialOffset + 161, 2);
            cHR_BL.FavoriteCategory2 = getByteValue.ExtractByteToInt(str, initialOffset + 163, 2);
            cHR_BL.FavoriteItem2 = getByteValue.ExtractByteToInt(str, initialOffset + 165, 2);
            cHR_BL.CreateEventID = getByteValue.ExtractByteToInt(str, initialOffset + 167, 2);
            cHR_BL.NormalTalk         = getByteValue.ExtractByteToInt(str, initialOffset + 169, 2);
            cHR_BL.CollisionId        = getByteValue.ExtractByteToInt(str, initialOffset + 171, 2);
            cHR_BL.BladeSize          = getByteValue.ExtractByteToInt(str, initialOffset + 173, 1);
            cHR_BL.MemorySlot         = getByteValue.ExtractByteToInt(str, initialOffset + 174, 1);
            cHR_BL.EventAsset         = getByteValue.ExtractByteToInt(str, initialOffset + 175, 2);
            cHR_BL.CenterBone         = getByteValue.ExtractResource(str, initialOffset  + 177, initialBdatOffset, 4, resourceCapacity[11]);
            cHR_BL.CamBone            = getByteValue.ExtractResource(str, initialOffset  + 181, initialBdatOffset, 4, resourceCapacity[12]);
            cHR_BL.MerceName          = getByteValue.ExtractByteToInt(str, initialOffset + 185, 2);
            cHR_BL.ReleaseLock        = getByteValue.ExtractByteToInt(str, initialOffset + 187, 1);
            cHR_BL.CreateInfo         = getByteValue.ExtractByteToInt(str, initialOffset + 188, 2);
            cHR_BL.ExtraParts1        = getByteValue.ExtractByteToInt(str, initialOffset + 190, 1);
            cHR_BL.ExtraParts2        = getByteValue.ExtractByteToInt(str, initialOffset + 191, 1);
            cHR_BL.ExtraParts3        = getByteValue.ExtractByteToInt(str, initialOffset + 192, 1);
            cHR_BL.ExtraParts4        = getByteValue.ExtractByteToInt(str, initialOffset + 193, 1);
            cHR_BL.MnuCastName        = getByteValue.ExtractByteToInt(str, initialOffset + 194, 2);
            cHR_BL.MnuIlustName       = getByteValue.ExtractByteToInt(str, initialOffset + 196, 2);
            cHR_BL.MnuVoice1          = getByteValue.ExtractResource(str, initialOffset  + 198, initialBdatOffset, 4, resourceCapacity[13]);
            cHR_BL.MnuVoice2          = getByteValue.ExtractResource(str, initialOffset  + 202, initialBdatOffset, 4, resourceCapacity[13]);
            cHR_BL.MnuVoice3          = getByteValue.ExtractResource(str, initialOffset  + 206, initialBdatOffset, 4, resourceCapacity[13]);
            cHR_BL.sortJP             = getByteValue.ExtractByteToInt(str, initialOffset + 210, 4);
            cHR_BL.sortGE             = getByteValue.ExtractByteToInt(str, initialOffset + 214, 4);
            cHR_BL.sortFR             = getByteValue.ExtractByteToInt(str, initialOffset + 218, 4);
            cHR_BL.sortSP             = getByteValue.ExtractByteToInt(str, initialOffset + 222, 4);
            cHR_BL.sortIT             = getByteValue.ExtractByteToInt(str, initialOffset + 228, 4);
            cHR_BL.sortGB             = getByteValue.ExtractByteToInt(str, initialOffset + 232, 4);                                                            
            cHR_BL.sortTW             = getByteValue.ExtractByteToInt(str, initialOffset + 236, 4);
            cHR_BL.OnlyWpn = getFlag.GetFlagFromInt(cHR_BL.Flag, 0);
            cHR_BL.NoBuildWpn = getFlag.GetFlagFromInt(cHR_BL.Flag, 1);
            cHR_BL.OnlyChBtl = getFlag.GetFlagFromInt(cHR_BL.Flag, 2);
            cHR_BL.FreeEngage = getFlag.GetFlagFromInt(cHR_BL.Flag, 3);
            cHR_BL.NoMapRev = getFlag.GetFlagFromInt(cHR_BL.Flag, 4);

            return cHR_BL;
        }

        public MemoryStream injectCHR_BL(MemoryStream memoryStream, CHR_BL cHR_BL, int initialOffset, int initialBdatOffset)
        {
            SetByteValue setByteValue = new SetByteValue();

            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.Name, initialOffset, 2);
            memoryStream = setByteValue.InjectResource(memoryStream, cHR_BL.DebugName, initialOffset + 2, initialBdatOffset, 4, 9);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.Race, initialOffset + 6, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.RotateLimitPitch, initialOffset + 7, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.RotateLimitRoll, initialOffset + 8, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.Gender, initialOffset + 9, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.QuestRace, initialOffset + 10, 1);
            //memoryStream = setByteValue.InjectResource(memoryStream, cHR_BL.Model, initialOffset + 11, initialBdatOffset, 4, 11);
            //memoryStream = setByteValue.InjectResource(memoryStream, cHR_BL.Motion, initialOffset + 15, initialBdatOffset, 4, 11);
            //memoryStream = setByteValue.InjectResource(memoryStream, cHR_BL.AddMotion, initialOffset + 19, initialBdatOffset, 4, 11);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.Condition ?? 0, initialOffset + 23, 2);
            //memoryStream = setByteValue.InjectResource(memoryStream, cHR_BL.Model2, initialOffset + 25, initialBdatOffset, 4, 11);
            //memoryStream = setByteValue.InjectResource(memoryStream, cHR_BL.Motion2, initialOffset + 29, initialBdatOffset, 4, 11);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.Still ?? 0, initialOffset + 33, 2);
            //memoryStream = setByteValue.InjectResource(memoryStream, cHR_BL.Voice, initialOffset + 35, initialBdatOffset, 4, 3);
            //memoryStream = setByteValue.InjectResource(memoryStream, cHR_BL.ClipEvent, initialOffset + 39, initialBdatOffset, 4, 2);
            //memoryStream = setByteValue.InjectResource(memoryStream, cHR_BL.Com_SE, initialOffset + 43, initialBdatOffset, 4, 2);
            //memoryStream = setByteValue.InjectResource(memoryStream, cHR_BL.SePack, initialOffset + 47, initialBdatOffset, 4, 16);
            //memoryStream = setByteValue.InjectResource(memoryStream, cHR_BL.Com_Eff, initialOffset + 51, initialBdatOffset, 4, 11);
            //memoryStream = setByteValue.InjectResource(memoryStream, cHR_BL.Com_Vo, initialOffset + 55, initialBdatOffset, 4, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.OffsetID, initialOffset + 59, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.EyeRot, initialOffset + 61, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.ChestHeight, initialOffset + 62, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.LandingHeight, initialOffset + 64, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.FootStep, initialOffset + 66, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.FootStepEffect, initialOffset + 67, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.WeaponType, initialOffset + 68, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.Scale, initialOffset + 69, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.WpnScale, initialOffset + 71, 2);

            memoryStream = setByteValue.InjectByteFromInt(memoryStream, new GetFlag().GetIntFromFlags(
                new bool[]{ cHR_BL.OnlyWpn, cHR_BL.NoBuildWpn, cHR_BL.OnlyChBtl, cHR_BL.FreeEngage, cHR_BL.NoMapRev }), 
                initialOffset + 73, 2);

            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.PrivateWpnR ?? 0, initialOffset + 74, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.PrivateWpnL ?? 0, initialOffset + 76, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.PrivateWpnL_Driver ?? 0, initialOffset + 78, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.PrivateWpnR_Driver ?? 0, initialOffset + 80, 2);
            //memoryStream = setByteValue.InjectResource(memoryStream, cHR_BL.WpnrOut, initialOffset + 82, initialBdatOffset, 4, 7);
            //memoryStream = setByteValue.InjectResource(memoryStream, cHR_BL.WpnlOut, initialOffset + 86, initialBdatOffset, 4, 7);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.OrbNum, initialOffset + 90, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.Atr, initialOffset + 91, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.Personality ?? 0, initialOffset + 92, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.CoolTime, initialOffset + 93, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.DefWeapon, initialOffset + 95, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.BArts1, initialOffset + 97, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.BArts2, initialOffset + 99, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.BArts3, initialOffset + 101, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.BartsEx, initialOffset + 103, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.BartsEx2, initialOffset + 105, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.NArts1, initialOffset + 107, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.NArtsRecastRev1, initialOffset + 108, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.NArts2, initialOffset + 109, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.NArtsRecastRev2, initialOffset + 110, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.NArts3, initialOffset + 111, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.NArtsRecastRev3, initialOffset + 112, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.BSkill1, initialOffset + 113, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.BSkill2, initialOffset + 115, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.BSkill3, initialOffset + 117, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.PArmor, initialOffset + 119, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.EArmor, initialOffset + 120, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.HpMaxRev, initialOffset + 121, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.StrengthRev, initialOffset + 122, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.PowEtherRev, initialOffset + 123, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.DexRev, initialOffset + 124, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.AgilityRev, initialOffset + 125, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.LuckRev, initialOffset + 126, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.BKLSet, initialOffset + 127, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.FSkill1, initialOffset + 129, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.FSkill2, initialOffset + 131, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.FSkill3, initialOffset + 133, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.ArtsAchievement1 ?? 00, initialOffset + 135, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.ArtsAchievement2 ?? 00, initialOffset + 137, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.ArtsAchievement3 ?? 00, initialOffset + 139, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.SkillAchievement1 ?? 00, initialOffset + 141, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.SkillAchievement2 ?? 00, initialOffset + 143, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.SkillAchievement3 ?? 00, initialOffset + 145, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.FskillAchivement1 ?? 00, initialOffset + 147, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.FskillAchivement2 ?? 00, initialOffset + 149, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.FskillAchivement3 ?? 00, initialOffset + 151, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.KeyAchievement ?? 00, initialOffset + 153, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.IdeaBlue, initialOffset + 155, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.IdeaRed, initialOffset + 156, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.IdeaWhite, initialOffset + 157, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.IdeaBlack, initialOffset + 158, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.FavoriteCategory1, initialOffset + 159, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.FavoriteItem1, initialOffset + 161, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.FavoriteCategory2, initialOffset + 163, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.FavoriteItem2, initialOffset + 165, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.CreateEventID, initialOffset + 167, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.NormalTalk, initialOffset + 169, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.CollisionId, initialOffset + 171, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.BladeSize, initialOffset + 173, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.MemorySlot, initialOffset + 174, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.EventAsset, initialOffset + 175, 2);
            //memoryStream = setByteValue.InjectResource(memoryStream, cHR_BL.CenterBone, initialOffset + 177, initialBdatOffset, 4, 6);
            //memoryStream = setByteValue.InjectResource(memoryStream, cHR_BL.CamBone, initialOffset + 181, initialBdatOffset, 4, 6);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.MerceName, initialOffset + 185, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.ReleaseLock, initialOffset + 187, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.CreateInfo, initialOffset + 188, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.ExtraParts1, initialOffset + 190, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.ExtraParts2, initialOffset + 191, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.ExtraParts3, initialOffset + 192, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.ExtraParts4, initialOffset + 193, 1);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.MnuCastName, initialOffset + 194, 2);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.MnuIlustName, initialOffset + 196, 2);
            //memoryStream = setByteValue.InjectResource(memoryStream, cHR_BL.MnuVoice1, initialOffset + 198, initialBdatOffset, 4, 8);
            //memoryStream = setByteValue.InjectResource(memoryStream, cHR_BL.MnuVoice2, initialOffset + 202, initialBdatOffset, 4, 8);
            //memoryStream = setByteValue.InjectResource(memoryStream, cHR_BL.MnuVoice3, initialOffset + 206, initialBdatOffset, 4, 8);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.ExtraParts4, initialOffset + 210, 4);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.ExtraParts4, initialOffset + 214, 4);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.ExtraParts4, initialOffset + 218, 4);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.ExtraParts4, initialOffset + 222, 4);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.ExtraParts4, initialOffset + 228, 4);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.ExtraParts4, initialOffset + 232, 4);
            memoryStream = setByteValue.InjectByteFromInt(memoryStream, cHR_BL.ExtraParts4, initialOffset + 236, 4);

            return memoryStream;
        }
    }
}
