using System;

namespace EmployeeBonusSharp.Shared
{
    public record AppInfo
    {
        public const string AppName = "EmployeeBonus#";
        public const string LicenseName = "MIT License";

        public string BasicInfo = $"{AppName} licensed under {LicenseName}";

        public string GetCompleteAboutMessage()
        {
            return BasicInfo = $"  | {AppName} version 2021.1";
        }
    }
}
