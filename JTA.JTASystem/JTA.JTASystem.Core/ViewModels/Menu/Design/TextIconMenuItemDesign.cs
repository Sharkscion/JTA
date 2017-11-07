
namespace JTA.JTASystem.Core
{
    public class TextIconMenuItemDesign : TextIconMenuViewModel
    {
        public static TextIconMenuItemDesign Instance => new TextIconMenuItemDesign();

        public TextIconMenuItemDesign()
        {
            Icon = IconType.Dashboard;
            Label = "Dashboard";
        }
    }
}
