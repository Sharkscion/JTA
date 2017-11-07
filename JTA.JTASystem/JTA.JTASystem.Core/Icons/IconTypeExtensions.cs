namespace JTA.JTASystem.Core
{
    // <summary>
    /// Helper functions for <see cref="IconType"/>
    /// </summary>
    public static class IconTypeExtensions
    {

        public static string ToFontAwesome(this IconType type)
        {
            // Return a FontAwesome string based on the icon type
            switch (type)
            {
                case IconType.Dashboard:
                    return "\uf0e4";

                case IconType.Files:
                    return "\uf0c5";

                case IconType.Cubes:
                    return "\uf1b3";

                case IconType.Group:
                    return "\uf0c0";

                case IconType.Money:
                    return "\uf0c0";

                case IconType.PieChart:
                    return "\uf200";

                // If none found, return null
                default:
                    return null;
            }
        }
    }
}
