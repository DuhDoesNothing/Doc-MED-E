using RoR2;
using DoctorMedE.Modules.Achievements;

namespace DoctorMedE.Survivors.Henry.Achievements
{
    //automatically creates language tokens "ACHIEVMENT_{identifier.ToUpper()}_NAME" and "ACHIEVMENT_{identifier.ToUpper()}_DESCRIPTION" 
    [RegisterAchievement(identifier, unlockableIdentifier, null, 10, null)]
    public class DoctorMasteryAchievement : BaseMasteryAchievement
    {
        public const string identifier = Doctor.DOCTOR_PREFIX + "masteryAchievement";
        public const string unlockableIdentifier = Doctor.Doctor_PREFIX + "masteryUnlockable";

        public override string RequiredCharacterBody => Doctor.instance.bodyName;

        //difficulty coeff 3 is monsoon. 3.5 is typhoon for grandmastery skins
        public override float RequiredDifficultyCoefficient => 3;
    }
}