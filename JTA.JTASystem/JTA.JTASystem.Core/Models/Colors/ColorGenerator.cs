namespace JTA.JTASystem.Core
{
    // <summary>
    /// Helper functions for <see cref="Color"/>
    /// </summary>
    public static class ColorGenerator
    {

        public static string Generate(this Color color)
        {
            switch (color)
            {
                case Color.Red: return "E3342F";
                case Color.RedLight: return "EF5753";
                case Color.RedDark: return "CC1F1A";
                case Color.Green: return "38C172";
                case Color.Orange: return "F6993F";
                case Color.Blue: return "3490DC";
                case Color.Teal: return "4DC0B5";
                case Color.Purple: return "9561E2";

                default: return "FFFFFF";
            }
        }
    }
}
