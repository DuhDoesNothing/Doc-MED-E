using System;
using DoctorMedE.Modules;
using DoctorMedE.Survivors.Doctor.Achievements;

namespace DoctorMedE.Survivors.Doctor
{
    public static class DoctorTokens
    {
        public static void Init()
        {
            AddDoctorTokens();

            ////uncomment this to spit out a lanuage file with all the above tokens that people can translate
            ////make sure you set Language.usingLanguageFolder and printingEnabled to true
            //Language.PrintOutput("Doctor.txt");
            ////refer to guide on how to build and distribute your mod with the proper folders
        }

        public static void AddDoctorTokens()
        {
            string prefix = Doctor.DOCTOR_PREFIX;

            string desc = "Doctor and MED-E are a powerful duo when working together. Doctor supports MED-E and other allies while MED-E is a tanky brawler.<color=#CCD3E0>" + Environment.NewLine + Environment.NewLine
             + "< ! > Doctor's Syringe Gun is his only self defense option. Use it to fend off enemies while MED-E does other things." + Environment.NewLine + Environment.NewLine
             + "< ! > Doctor's Drones allow him to support his allies from anywhere, use them wisely to lift your allies to new heights or save them from the brink of death." + Environment.NewLine + Environment.NewLine
             + "< ! > Doctor can also command his drones to support him instead. You can use this to save yourself in a pinch, but make sure not to hog your drones." + Environment.NewLine + Environment.NewLine
             + "< ! > Doctor can tell MED-E to do one of four commands. Use them to save MED-E or Yourself, or just wrangle MED-E back to you." + Environment.NewLine + Environment.NewLine;

            string outro = "..and so they left, a broken heart healed.";
            string outroFailure = "..and so they vanished, oaths broken.";

            Language.Add(prefix + "NAME", "Doctor and MED-E");
            Language.Add(prefix + "DESCRIPTION", desc);
            Language.Add(prefix + "SUBTITLE", "PHD and Machine, Together");
            Language.Add(prefix + "LORE", "sample lore");
            Language.Add(prefix + "OUTRO_FLAVOR", outro);
            Language.Add(prefix + "OUTRO_FAILURE", outroFailure);

            #region Skins
            Language.Add(prefix + "MASTERY_SKIN_NAME", "Alternate");
            #endregion

            #region Passive
            Language.Add(prefix + "PASSIVE_NAME", "Henry passive");
            Language.Add(prefix + "PASSIVE_DESCRIPTION", "Sample text.");
            #endregion

            #region Primary
            Language.Add(prefix + "PRIMARY_SLASH_NAME", "Sword");
            Language.Add(prefix + "PRIMARY_SLASH_DESCRIPTION", Tokens.agilePrefix + $"Swing forward for <style=cIsDamage>{100f * HenryStaticValues.swordDamageCoefficient}% damage</style>.");
            #endregion

            #region Secondary
            Language.Add(prefix + "SECONDARY_GUN_NAME", "Handgun");
            Language.Add(prefix + "SECONDARY_GUN_DESCRIPTION", Tokens.agilePrefix + $"Fire a handgun for <style=cIsDamage>{100f * HenryStaticValues.gunDamageCoefficient}% damage</style>.");
            #endregion

            #region Utility
            Language.Add(prefix + "UTILITY_ROLL_NAME", "Roll");
            Language.Add(prefix + "UTILITY_ROLL_DESCRIPTION", "Roll a short distance, gaining <style=cIsUtility>300 armor</style>. <style=cIsUtility>You cannot be hit during the roll.</style>");
            #endregion

            #region Special
            Language.Add(prefix + "SPECIAL_BOMB_NAME", "Bomb");
            Language.Add(prefix + "SPECIAL_BOMB_DESCRIPTION", $"Throw a bomb for <style=cIsDamage>{100f * HenryStaticValues.bombDamageCoefficient}% damage</style>.");
            #endregion

            #region Achievements
            Language.Add(Tokens.GetAchievementNameToken(DoctorMasteryAchievement.identifier), "Henry: Mastery");
            Language.Add(Tokens.GetAchievementDescriptionToken(DoctorMasteryAchievement.identifier), "As Henry, beat the game or obliterate on Monsoon.");
            #endregion
        }
    }
}
