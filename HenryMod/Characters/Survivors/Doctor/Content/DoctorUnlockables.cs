using DoctorMedE.Survivors.Doctor.Achievements;
using RoR2;
using UnityEngine;

namespace DoctorMedE.Survivors.Doctor
{
    public static class DoctorUnlockables
    {
        public static UnlockableDef characterUnlockableDef = null;
        public static UnlockableDef masterySkinUnlockableDef = null;

        public static void Init()
        {
            masterySkinUnlockableDef = Modules.Content.CreateAndAddUnlockbleDef(
                DoctorMasteryAchievement.unlockableIdentifier,
                Modules.Tokens.GetAchievementNameToken(DoctorMasteryAchievement.identifier),
                DoctorMedE.instance.assetBundle.LoadAsset<Sprite>("texMasteryAchievement"));
        }
    }
}
