using TechTalk.SpecFlow;

namespace BaseCodeAutoSever.WebUi.AcceptanceTests.Hooks;

[Binding]
public class TestsHooks
{
    private static WebUiDockerCompose _compositeService = default!;
    [BeforeTestRun]
    public static void DockerComposeUp()
    {
        _compositeService = WebUiDockerCompose.Up();
    }

    [AfterTestRun]
    public static void DockerComposeDown()
    {
        _compositeService.Dispose();
    }
}