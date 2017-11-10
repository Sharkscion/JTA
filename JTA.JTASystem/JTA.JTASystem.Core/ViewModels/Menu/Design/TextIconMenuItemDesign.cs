
namespace JTA.JTASystem.Core
{
    public class TextIconMenuItemDesign : TextIconEntryVM
    {
        public static TextIconMenuItemDesign Instance => new TextIconMenuItemDesign();

        public TextIconMenuItemDesign()
        {
            Icon = IconType.Dashboard;
            Label = "Dashboard";
        }
    }
}
