// Copyright © .NET Foundation and Contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace PInvoke
{
    /// <content>
    /// Contains the <see cref="HiddAttributes"/> nested type.
    /// </content>
    public static partial class Hid
    {
        /// <summary>
        /// The HIDD_ATTRIBUTES structure contains vendor information about a HIDClass device.
        /// </summary>
        public struct HiddAttributes
        {
            /// <summary>
            /// Specifies the size, in bytes, of a HIDD_ATTRIBUTES structure.
            /// </summary>
            public int Size;

            /// <summary>
            /// Specifies a HID device's vendor ID.
            /// </summary>
            public ushort VendorId;

            /// <summary>
            /// Specifies a HID device's product ID.
            /// </summary>
            public ushort ProductId;

            /// <summary>
            /// Specifies the manufacturer's revision number for a HIDClass device.
            /// </summary>
            public ushort VersionNumber;

            /// <summary>
            /// Initializes a new instance of the <see cref="HiddAttributes"/> struct
            /// with the <see cref="Size"/> field initialized.
            /// </summary>
            /// <returns>The newly initialized struct.</returns>
            public static unsafe HiddAttributes Create() => new HiddAttributes { Size = sizeof(HiddAttributes) };
        }
    }
}
