using static SplashKitSDK.SplashKit;
OpenWindow("Test window",400,300);
while(! QuitRequested())
{
    FillCircle(RandomColor(),Rnd(400),Rnd(300),Rnd(50));
    RefreshScreen();

    ProcessEvents();
}