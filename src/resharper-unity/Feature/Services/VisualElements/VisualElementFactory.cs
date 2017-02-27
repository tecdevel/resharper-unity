using JetBrains.ReSharper.Feature.Services.VisualElements;
using JetBrains.ReSharper.Plugins.Unity.Psi.ShaderLab;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Colors;
using JetBrains.ReSharper.Psi.Tree;

namespace JetBrains.ReSharper.Plugins.Unity.Feature.Services.VisualElements
{
    [Language(typeof(ShaderLabLanguage))]
    public class VisualElementFactory : IVisualElementFactory
    {
        // TODO: Add colours!
        public IColorReference GetColorReference(ITreeNode element)
        {
            return null;
        }
    }
}