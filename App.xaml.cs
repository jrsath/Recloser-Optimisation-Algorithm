protected override async void OnStartup(
    StartupEventArgs e)
{
    base.OnStartup(e);

    await UpdateService.CheckForUpdates();
}
