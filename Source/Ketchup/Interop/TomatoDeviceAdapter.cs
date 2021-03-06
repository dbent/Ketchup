﻿using Ketchup.Api.v0;
using Tomato.Hardware;

namespace Ketchup.Interop
{
    internal sealed class TomatoDeviceAdapter : Device
    {
        private readonly IDevice _device;

        public override string FriendlyName
        {
            get { return _device.FriendlyName; }
        }

        public override uint ManufacturerID
        {
            get { return _device.ManufacturerId; }
        }

        public override uint DeviceID
        {
            get { return _device.DeviceId; }
        }

        public override ushort Version
        {
            get { return _device.Version; }
        }

        public TomatoDeviceAdapter(IDevice device)
        {
            _device = device;
        }

        public override int HandleInterrupt()
        {
            return _device.OnInterrupt();
        }

        public override void Reset()
        {
            // This would only be called if Tomato.DCPU.Reset() was called, which Ketchup never does.
        }
    }
}
