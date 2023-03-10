using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Transient.Bridge {
    public static class EnvAccess  {
        public static VersionEntry AppEntry;
        public static NetworkHttpBatch NetClient;
        public static AccountHelper Account;
        public static IAPHelper IAP;
        public static TrackingHelper DataTracking;
    }
}