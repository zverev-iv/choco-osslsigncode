public class PackageInfo
{
    public string PackageVersion { get; set; }
    public string Package32Url { get; set; }
    public string Package64Url { get; set; }

    #region BuildFolders

    public string BinDir { get => "bin"; }
    public string TempDir { get => "temp"; }

    #endregion

    #region PackageSettings

    public ChocolateyPackSettings PackageSettings
    {
        get => new ChocolateyPackSettings
        {
            //PACKAGE SPECIFIC SECTION
            Id = "osslsigncode",
            Version = "2.2.0",
            PackageSourceUrl = new Uri("https://github.com/zverev-iv/choco-osslsigncode"),
            Owners = new[] {
                "zverev-iv"
                },
            //SOFTWARE SPECIFIC SECTION
            Title = "Osslsigncode",
            Authors = new[] {
                "Michał Trojnara"
                },
            Copyright = "2005-2014 Per Allansson, 2018-2019 Michał Trojnara",
            ProjectUrl = new Uri("https://github.com/mtrojnar/osslsigncode"),
            DocsUrl = new Uri("https://github.com/mtrojnar/osslsigncode#readme"),
            BugTrackerUrl = new Uri("https://github.com/mtrojnar/osslsigncode/issues"),
            LicenseUrl = new Uri("https://raw.githubusercontent.com/mtrojnar/osslsigncode/master/LICENSE.txt"),
            RequireLicenseAcceptance = false,
            Summary = "osslsigncode is a small tool that implements authenticode signing and timestamping",
            Description = @"## WHAT IS IT?

osslsigncode is a small tool that implements part of the functionality
of the Microsoft tool signtool.exe - more exactly the Authenticode
signing and timestamping. But osslsigncode is based on OpenSSL and cURL,
and thus should be able to compile on most platforms where these exist.

## WHY?

Why not use signtool.exe? Because I don't want to go to a Windows
machine every time I need to sign a binary - I can compile and build
the binaries using Wine on my Linux machine, but I can't sign them
since the signtool.exe makes good use of the CryptoAPI in Windows, and
these APIs aren't (yet?) fully implemented in Wine, so the signtool.exe
tool  would fail. And, so, osslsigncode was born.

## WHAT CAN IT DO?

It can sign and timestamp PE (EXE/SYS/DLL/etc), CAB, CAT and MSI files.
It supports the equivalent of signtool.exe's ""-j javasign.dll -jp low"",
i.e. add a valid signature for a CAB file containing Java files.
It supports getting the timestamp through a proxy as well. It also
supports signature verification, removal and extraction.
",
            ReleaseNotes = new[] {
                "https://github.com/mtrojnar/osslsigncode/releases/"
                },
            Files = new[] {
                new ChocolateyNuSpecContent {
                    Source = new DirectoryPath(BinDir).Combine("**").ToString(),
                    Target = "tools"
                    }
                },
            Tags = new[] {
                "OpenSSL",
                "signtool",
                "Authenticode",
                "signing",
                "timestamp",
                "PE",
                "EXE",
                "SYS",
                "DLL",
                "CAB",
                "MSI"
                },

        };
    }

    #endregion
}