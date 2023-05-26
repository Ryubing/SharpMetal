using System.Runtime.Versioning;

namespace SharpMetal
{
    [SupportedOSPlatform("macos")]
    public struct MTLRenderCommandEncoder
    {
        public readonly IntPtr NativePtr;
        public MTLRenderCommandEncoder(IntPtr ptr) => NativePtr = ptr;
    }
}