﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GovITHub.Auth.Common.Services.DeviceDetection.DataContracts
{
    public class DeviceInfo
    {
        public string UserAgent { get; set; }

        public string OperatingSystem { get; set; }

        public string MobileDevice { get; set; }

        public string Browser { get; set; }
    }
}
