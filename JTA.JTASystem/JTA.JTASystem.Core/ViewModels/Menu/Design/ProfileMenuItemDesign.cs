namespace JTA.JTASystem.Core
{
    public class ProfileMenuItemDesign : ProfileMenuViewModel
    {
        public static ProfileMenuItemDesign Instance => new ProfileMenuItemDesign();

        public ProfileMenuItemDesign()
        {
            InitialContainerRBG = "3490dc";
            Initials = "ST";
            Name = "Shayane";
            Position = "Vice Manager";
        }
    }
}
