namespace EmployeeBonusSharp.Shared
{
    public struct AppSettings
    {
        public AppSettings()
        {
            DisplayColumnDateOfEmployment = false;
            DisplayColumnCertificates = true;
        }

        public AppSettings(bool displayColumnDateOfEmployment, bool displayColumnCertificates)
        {
            DisplayColumnDateOfEmployment = displayColumnDateOfEmployment;
            DisplayColumnCertificates     = displayColumnCertificates;
        }

        public bool DisplayColumnDateOfEmployment { get; init; }
        public bool DisplayColumnCertificates { get; init; }
    }
}
