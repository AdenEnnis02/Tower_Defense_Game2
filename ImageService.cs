using Raylib_cs;
using static Raylib_cs.Raylib;//for images to work



public class ImageService
{
    // ADD IMAGES
    public static Image goblinImage = LoadImage("images/goblin.png"); 
    public static Image orcImage = LoadImage("Images/orc-5636526_640.png");
    public static Image monsterImage = LoadImages("lovepik-a-laughing-monster-png-image_400957064_wh1200.png");
    public static Image towerImage = LoadImage("Images/istockphoto-166083362.jpg"); 
    public static Image arrowImage = LoadImage("Images/cHJpdmF0ZS9sci9pbWFnZXMvd2Vic2l0ZS8yMDIzLTAzL3JtNjQwLWVsZW1lbnQtMDUxLnBuZw.png.webp"); 

    // ADD TEXTURES
    public static Texture2D goblinTexture = LoadTextureFromImage(goblinImage);
    public static Texture2D orcTexture = LoadTextureFromImage(orcImage);
    public static Texture2D monsterTexture = LoadTextureFromImage(monsterImage);
    public static Texture2D towerTexture = LoadTextureFromImage(towerImage);
    public static Texture2D arrowTexture = LoadTextureFromImage(arrowImage);



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
        allImages.Add(monsterImage);
        allImages.Add(towerImage);
        allImages.Add(arrowImage);

        return allImages;
    }

    public static List<Texture2D> LoadAllTextures()
    {
        allTextures.Add(goblinTexture);
        allTextures.Add(orcTexture);
        allTextures.Add(monsterTexture);
        allTextures.Add(towerTexture);
        allTextures.Add(arrowTexture);

        return allTextures;
    }

    public static void UnloadAllImages()
    {
        UnloadImage(goblinImage);
        UnloadImage(orcImage);
        UnloadImage(monsterImage);
        UnloadImage(towerImage);
        UnloadImage(arrowImage);

        // Director.unloadCheck = true;
    }

    public static void UnloadAllTextures()
    {
        UnloadTexture(goblinTexture);
        UnloadTexture(orcTexture);
        UnloadTexture(monsterTexture);
        UnloadTexture(towerTexture);
        UnloadTexture(arrowTexture);

        // Director.unloadCheck = true;
    }
}