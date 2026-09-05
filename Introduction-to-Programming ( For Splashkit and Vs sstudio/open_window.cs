using SplashKitSDK;
using static SplashKitSDK.SplashKit;
int width;
WriteLine("Enter width ");
width=Convert.ToInt32(ReadLine());
int height;
WriteLine("Enter height ");
height=Convert.ToInt32(ReadLine());
Window window=OpenWindow("Krish testing window", width,height);
ClearScreen(ColorPurple());
RefreshScreen();
while(!QuitRequested());




