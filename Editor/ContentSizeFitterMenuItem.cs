using UnityEditor;
using UnityEngine.UI;

namespace Kogane.Internal
{
    internal static class ContentSizeFitterMenuItem
    {
        [MenuItem( "CONTEXT/ContentSizeFitter/Set Preferred Size" )]
        private static void SetPreferredSize( MenuCommand menuCommand )
        {
            const ContentSizeFitter.FitMode fitMode = ContentSizeFitter.FitMode.PreferredSize;

            var fitter = ( ContentSizeFitter )menuCommand.context;

            Undo.RecordObject( fitter, "Set Preferred Size" );

            fitter.horizontalFit = fitMode;
            fitter.verticalFit   = fitMode;
        }
    }
}