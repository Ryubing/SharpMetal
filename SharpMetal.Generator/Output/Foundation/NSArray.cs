using System.Runtime.Versioning;
using SharpMetal.ObjectiveC;

namespace SharpMetal
{
    [SupportedOSPlatform("macos")]
    public struct NSArray
    {
        public readonly IntPtr NativePtr;
        public static implicit operator IntPtr(NSArray obj) => obj.NativePtr;
        public NSArray(IntPtr ptr) => NativePtr = ptr;

        public NSArray()
        {
            var cls = new ObjectiveCClass("NSArray");
            NativePtr = cls.AllocInit();
        }

        public NSArray Array => new(ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, sel_array));

        public ulong Count => ObjectiveCRuntime.ulong_objc_msgSend(NativePtr, sel_count);

        private static readonly Selector sel_array = "array";
        private static readonly Selector sel_arrayWithObject = "arrayWithObject:";
        private static readonly Selector sel_arrayWithObjectscount = "arrayWithObjects:count:";
        private static readonly Selector sel_initWithObjectscount = "initWithObjects:count:";
        private static readonly Selector sel_initWithCoder = "initWithCoder:";
        private static readonly Selector sel_count = "count";
        private static readonly Selector sel_objectAtIndex = "objectAtIndex:";
    }
}
