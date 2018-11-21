using netvmomi.Model;
using System.Collections.Generic;
using Xunit;

namespace netvmomi.Test {
    public class AccessApiTest {

        public TestSetup _testSetup = new TestSetup();

        [Fact]
        public void ApplianceAccessConsolecliGet() {
            throw new System.NotImplementedException();
        }

        [Theory]
        [MemberData("TestData", MemberType = typeof(ApplianceAccessConsolecliPutDataSources))]
        public void ApplianceAccessConsolecliPut(ConsoleCLIDisableRequest body) {
            throw new System.NotImplementedException();
        }

        [Fact]
        public void ApplianceAccessDcuiGet() {
            throw new System.NotImplementedException();
        }

        [Theory]
        [MemberData("TestData", MemberType = typeof(ApplianceAccessDcuiPutDataSources))]
        public void ApplianceAccessDcuiPut(DCUIDisableRequest body) {
            throw new System.NotImplementedException();
        }

        [Fact]
        public void ApplianceAccessShellGet() {
            throw new System.NotImplementedException();
        }

        [Theory]
        [MemberData("TestData", MemberType = typeof(ApplianceAccessShellPutDataSources))]
        public void ApplianceAccessShellPut(ShellDisableRequest body) {
            throw new System.NotImplementedException();
        }

        [Fact]
        public void ApplianceAccessSshGet() {
            throw new System.NotImplementedException();
        }

        [Theory]
        [MemberData("TestData", MemberType = typeof(ApplianceAccessSshPutDataSources))]
        public void ApplianceAccessSshPut(SSHDisableRequest body) {
            throw new System.NotImplementedException();
        }
    }

    public static class ApplianceAccessConsolecliPutDataSources {
        private static readonly List<object[]> _data =
            new List<object[]> {
                new object[] {new ConsoleCLIDisableRequest()},
            };
        public static IEnumerable<object[]> TestData => _data;
    }

    public static class ApplianceAccessDcuiPutDataSources {
        private static readonly List<object[]> _data =
            new List<object[]> {
                new object[] {new DCUIDisableRequest()},
            };
        public static IEnumerable<object[]> TestData => _data;
    }

    public static class ApplianceAccessShellPutDataSources {
        private static readonly List<object[]> _data =
            new List<object[]> {
                new object[] {new ShellDisableRequest()},
            };
        public static IEnumerable<object[]> TestData => _data;
    }

    public static class ApplianceAccessSshPutDataSources {
        private static readonly List<object[]> _data =
            new List<object[]> {
                new object[] {new SSHDisableRequest()},
            };
        public static IEnumerable<object[]> TestData => _data;
    }
}
