using Raylib_cs;
using static Raylib_cs.Raylib;//for images to work



public class ImageService
{
    // ADD IMAGES
    public static Image goblinImage = LoadImage("Images/goblin.png"); 
    public static Image orcImage = LoadImage("Images/orc.png");




    // ADD TEXTURES
    public static Texture2D goblinTexture = LoadTextureFromImage(goblinImage);
    public static Texture2D orcTexture = LoadTextureFromImage(orcImage);




    public static int FrameLength = 16;

    private static readonly List<Image> allImages = new();
    private static readonly List<Texture2D> allTextures = new();


    /*---METHODS---*/
    public static Texture2D GetTexture(Texture2D textureToReturn)
    {
        return textureToReturn;
    }
    public static void LoadInTexture(Image image)
    {
        Texture2D textureToLoad = LoadTextureFromImage(image);
    }

    public static void UnloadImageFile(Image imageToUnload)
    {
        UnloadImage(imageToUnload);
    }

    public static void UnloadTextureFile(Texture2D textureToUnload)
    {
        UnloadTexture(textureToUnload);
    }

    

    /*---LISTS---*/


    public static List<Image> LoadAllImages()
    {
        allImages.Add(goblinImage);
        allImages.Add(orcImage);
        // Add Images here

        

        


        return allImages;
    }

    public static List<Texture2D> LoadAllTextures()
    {
        allTextures.Add(goblinTexture);
        allTextures.Add(orcTexture);

        // add textures here



        return allTextures;
    }

    public static void UnloadAllImages()
    {
        UnloadImage(goblinImage);
        UnloadImage(orcImage);
        // Add all the Images here

    

        // Director.unloadCheck = true;
    }

    public static void UnloadAllTextures()
    {
        UnloadTexture(goblinTexture);
        UnloadTexture(orcTexture);
        // Add all the textures here
      

        // Director.unloadCheck = true;
    }
}