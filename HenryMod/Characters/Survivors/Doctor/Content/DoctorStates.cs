using DoctorMedE.Survivors.Henry.SkillStates;

namespace DoctorMedE.Survivors.Doctor
{
    public static class DoctorStates
    {
        public static void Init()
        {
            Modules.Content.AddEntityState(typeof(SlashCombo));

            Modules.Content.AddEntityState(typeof(Shoot));

            Modules.Content.AddEntityState(typeof(Roll));

            Modules.Content.AddEntityState(typeof(ThrowBomb));
        }
    }
}
