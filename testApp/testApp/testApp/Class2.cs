using System;

public class Class2
{
    private string[] files;
    private int currentIndex = 0;

	public Class2()
	{
	}
    private void initializeImages()
    {
        string[] files = System.IO.Directory.GetFiles("C:/Users/Adnan/Systemvetenskap/Ar-3/C# and .NET/testApp/testApp/testApp/Resources");
        //Grab directories in your images directory
        string appRoot = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        files = System.IO.Directory.GetFiles(appRoot + @"\images");
        Random rnd = new Random();
        files = files.OrderBy(x => rnd.Next()).ToArray();
    }


    private void setImage()
    {
        asss.ImageLocation = files[currentIndex];
        asss.Visibility = Visibility;
    }

    private void previousImage()
    {
        currentIndex = currentIndex > 0 ? currentIndex - 1 : 0;
        setImage();
    }

    private void nextImage()
    {
        currentIndex = currentIndex < files.Length - 1 ? currentIndex + 1 : files.Length - 1;
        setImage();
    }
}
