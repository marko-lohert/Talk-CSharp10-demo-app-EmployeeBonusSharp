using EmployeeBonusSharp.Shared;

namespace EmployeeBonusSharp.Client.Pages
{
    public partial class About
    {
        public string CompleteAboutMessage;

        protected override void OnInitialized()
        {
            AppInfo appInfo = new();
            CompleteAboutMessage = appInfo.GetCompleteAboutMessage();
        }
    }
}
