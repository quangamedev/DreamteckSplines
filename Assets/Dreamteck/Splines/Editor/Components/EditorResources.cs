namespace Dreamteck.Splines.Editor
{
    using UnityEngine;

    internal static class EditorResources
    {
        public static Texture2D LoadIcon(string iconName)
        {
            return Resources.Load<Texture2D>($"dreamteck.splines/Icons/{iconName}");
        }
    }
}