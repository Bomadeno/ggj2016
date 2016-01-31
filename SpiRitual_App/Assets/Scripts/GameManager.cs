
public class GameManager
{

    private static GameManager instance;

    public static string Incoming; 

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
                instance = new GameManager();
            return instance;
        }
    }
}
