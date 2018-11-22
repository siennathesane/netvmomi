using System;

namespace netvmomi.Test {
    public class TestSetup {
        public readonly string vSphereURL;
        public TestSetup() {
            vSphereURL = Environment.GetEnvironmentVariable("VSPHERE_URL");
            return;
        }
    }
}
