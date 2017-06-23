namespace GitMasterGui.Git.Merge.AnalyzeRefactors
{
    public class DeletedConflictCandidates
    {
        Panel CreateContentErrorPanel(string message)
        {
            StackPanel result = new StackPanel();

            TextBlock titleTextBlock = WebControlBuilder.CreateTitle(
                GitMasterLocalization.GetString(
                    GitMasterLocalization.Name.WaitingLicensePanelErrorTitle));
            titleTextBlock.Margin = new Thickness(0, 40, 0, 15);

            WebErrorPanel errorPanel = new WebErrorPanel();
            errorPanel.ShowError(message);

            mTeamInvitationCodeTextBox = WebControlBuilder.CreateTextBox(
                GitMasterLocalization.GetString(
                    GitMasterLocalization.Name.WaitingLicensePanelTeamInvitationCodeWatermark));

            mGetLicenseButton = WebControlBuilder.CreateMainActionButton(
                GitMasterLocalization.GetString(
                    GitMasterLocalization.Name.GetLicenseButtonUppercase));
            mGetLicenseButton.Click += GetLicenseButton_Click;

            WebEntriesPacker.AddRelatedComponents(
                result,
                titleTextBlock,
                errorPanel,
                mTeamInvitationCodeTextBox,
                mGetLicenseButton);

            return result;
        }
    }
}