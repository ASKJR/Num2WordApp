using Num2WordApp.Core;
do
{
    try
    {
        App.Run();
        if (App.Exit())
        {
            break;
        }
        
    }
    catch (Exception)
    {
        App.Run();
        if (App.Exit())
        {
            break;
        }
    }
    
} while (true);

