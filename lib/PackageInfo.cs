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
            Id = "template",
            Version = "0.0.1",
            PackageSourceUrl = new Uri("https://github.com/user/choco-template/"),
            Owners = new[] {
                "Contoso"
                },
            //SOFTWARE SPECIFIC SECTION
            Title = "Template",
            Authors = new[] {
                "Authors"
                },
            Copyright = "year, Company",
            ProjectUrl = new Uri("https://template.com"),
            ProjectSourceUrl = new Uri("https://github.com/user/template/"),
            IconUrl = new Uri("http://cdn.rawgit.com/user/template/master/icons/template.png"),
            DocsUrl = new Uri("https://github.com/user/template/blob/master/README.md"),
            BugTrackerUrl = new Uri("https://github.com/user/template/"),
            MailingListUrl = new Uri("https://github.com/user/template/"),
            LicenseUrl = new Uri("https://github.com/user/template/blob/master/LICENSE.md"),
            RequireLicenseAcceptance = false,
            Summary = "Excellent summary of what the package does",
            Description = "The description of the package",
            ReleaseNotes = new[] {
                "https://github.com/user/template/releases"
                },
            Files = new[] {
                new ChocolateyNuSpecContent {
                    Source = new DirectoryPath(BinDir).Combine("**").ToString(),
                    Target = "tools"
                    }
                },
            Tags = new[] {
                "Cake",
                "Script",
                "Build"
                },

            //Cake internal settings
            //Debug = false,
            //Verbose = false,
            //Force = false,
            //Noop = false,
            //LimitOutput = false,
            //ExecutionTimeout = 13,
            //CacheLocation = @"C:\temp",
            //AllowUnofficial = false

        };
    }

    #endregion
}