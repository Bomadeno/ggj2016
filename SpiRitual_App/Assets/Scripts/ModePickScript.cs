using UnityEngine;
using System.Collections;

public class ModePickScript : MonoBehaviour {

    public string SceneToLoadOnClick;

	public void LoadScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneToLoadOnClick);
    }
}
