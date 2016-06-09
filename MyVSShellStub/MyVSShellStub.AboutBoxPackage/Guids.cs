// Guids.cs
// MUST match guids.h
using System;

namespace MyVSShellStub.AboutBoxPackage
{
    static class GuidList
    {
        public const string guidAboutBoxPackagePkgString = "84798676-a03d-42cf-bbcd-67fdcb1659b9";
        public const string guidAboutBoxPackageCmdSetString = "eda3c9b6-8817-46ed-a4ec-dfa50666b3f3";

        public static readonly Guid guidAboutBoxPackageCmdSet = new Guid(guidAboutBoxPackageCmdSetString);
    };
}