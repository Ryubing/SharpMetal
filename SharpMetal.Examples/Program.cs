using System.Runtime.Versioning;
using SharpMetal.ObjectiveC;

namespace SharpMetal.Examples
{
    [SupportedOSPlatform("macos")]
    public class Program
    {
        public static void Main(string[] args)
        {
            ObjectiveCRuntime.dlopen("/System/Library/Frameworks/Metal.framework/Metal", 0);
            var device = MTLDevice.MTLCreateSystemDefaultDevice();

            var descriptor = new MTLRenderPipelineDescriptor();
            descriptor.Label = new NSString("Simple Pipeline");
            descriptor.VertexFunction = new MTLFunction();
            descriptor.FragmentFunction = new MTLFunction();

            Console.WriteLine(descriptor.Label);
            // descriptor.colorAttachments[0].PixelFormat = MTLPixelFormat.MTLPixelFormatStencil8;
        }
    }
}