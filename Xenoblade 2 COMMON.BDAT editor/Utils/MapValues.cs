using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xenoblade_2_COMMON.BDAT_editor.Utils
{
    internal class MapValues
    {
        public void mapCHR_Bl(List<CHR_BL> cHR_BLs, int index)
        {
            nameID.Value = cHR_BLs[0].Name;
            nameIdBox.SelectedIndex = cHR_BLs[0].Name;
            debugNameBox.Text = cHR_BLs[0].DebugName;
            raceCbx.SelectedIndex = cHR_BLs[0].Race;
            genderCbx.SelectedIndex = cHR_BLs[0].Gender;
            weaponNBox.Value = cHR_BLs[0].WeaponType;
            weaponCbox.SelectedIndex = cHR_BLs[0].WeaponType;
            elementNbox.Value = cHR_BLs[0].Atr;
            elementCbox.SelectedIndex = cHR_BLs[0].Atr;
            coolTimeNbox.Value = cHR_BLs[0].CoolTime;
            stillNbox.Value = cHR_BLs[0].Still ?? 0;
            orbNbox.Value = cHR_BLs[0].OrbNum;
            conditionNbox.Value = cHR_BLs[0].Condition ?? 0;

            pDefNbox.Value = cHR_BLs[0].PArmor;
            eDefNbox.Value = cHR_BLs[0].EArmor;
            mHpNbox.Value = cHR_BLs[0].HpMaxRev;
            sModNbox.Value = cHR_BLs[0].StrengthRev;
            eModNbox.Value = cHR_BLs[0].PowEtherRev;
            dModNbox.Value = cHR_BLs[0].DexRev;
            agModNbox.Value = cHR_BLs[0].AgilityRev;
            lkModNbox.Value = cHR_BLs[0].LuckRev;

            braveryNbox.Value = cHR_BLs[0].IdeaBlue;
            truthNbox.Value = cHR_BLs[0].IdeaRed;
            compassionNbox.Value = cHR_BLs[0].IdeaWhite;
            justiceNbox.Value = cHR_BLs[0].IdeaBlack;

            cat1Nbox.Value = cHR_BLs[0].FavoriteCategory1;
            cat1Cbox.SelectedIndex = cHR_BLs[0].FavoriteCategory1;
            cat2Nbox.Value = cHR_BLs[0].FavoriteCategory2;
            cat2Cbox.SelectedIndex = cHR_BLs[0].FavoriteCategory2;
            item1Nbox.Value = cHR_BLs[0].FavoriteItem1;
            item1Cbox.SelectedIndex = cHR_BLs[0].FavoriteItem1 - 40000;
            item2Nbox.Value = cHR_BLs[0].FavoriteItem2;
            item2Cbox.SelectedIndex = cHR_BLs[0].FavoriteItem2 - 40000;

            art1Cbox.SelectedIndex = cHR_BLs[0].NArts1;
            art2Cbox.SelectedIndex = cHR_BLs[0].NArts2;
            art3Cbox.SelectedIndex = cHR_BLs[0].NArts3;
            art1Nbox.Value = cHR_BLs[0].NArts1;
            art2Nbox.Value = cHR_BLs[0].NArts2;
            art3Nbox.Value = cHR_BLs[0].NArts3;

            bs1Cbox.SelectedIndex = cHR_BLs[0].BSkill1;
            bs2Cbox.SelectedIndex = cHR_BLs[0].BSkill2;
            bs3Cbox.SelectedIndex = cHR_BLs[0].BSkill3;
            bs1Nbox.Value = cHR_BLs[0].BSkill1;
            bs2Nbox.Value = cHR_BLs[0].BSkill2;
            bs3Nbox.Value = cHR_BLs[0].BSkill3;

            fs1Cbox.SelectedIndex = cHR_BLs[0].FSkill1;
            fs2Cbox.SelectedIndex = cHR_BLs[0].FSkill2;
            fs3Cbox.SelectedIndex = cHR_BLs[0].FSkill3;
            fs1Nbox.Value = cHR_BLs[0].FSkill1;
            fs2Nbox.Value = cHR_BLs[0].FSkill2;
            fs3Nbox.Value = cHR_BLs[0].FSkill3;

            sp1Cbox.SelectedIndex = cHR_BLs[0].BArts1;
            sp2Cbox.SelectedIndex = cHR_BLs[0].BArts2;
            sp3Cbox.SelectedIndex = cHR_BLs[0].BArts3;
            sp4Cbox.SelectedIndex = cHR_BLs[0].BartsEx;
            spAlt4Cbox.SelectedIndex = cHR_BLs[0].BartsEx2;
            sp1Nbox.Value = cHR_BLs[0].BArts1;
            sp2Nbox.Value = cHR_BLs[0].BArts2;
            sp3Nbox.Value = cHR_BLs[0].BArts3;
            sp4Nbox.Value = cHR_BLs[0].BartsEx;
            spAlt4Nbox.Value = cHR_BLs[0].BartsEx2;

            modelBox.Text = cHR_BLs[0].Model;
            model2Box.Text = cHR_BLs[0].Model2;
            motionBox.Text = cHR_BLs[0].Motion;
            motion2Box.Text = cHR_BLs[0].Motion2;
            addMotionBox.Text = cHR_BLs[0].AddMotion;
        }
    }
}
