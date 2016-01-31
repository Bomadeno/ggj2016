using UnityEngine;

public class OnClickScript : MonoBehaviour {

	public void OnClick(string name)
    {
        GameManager.Incoming = name;
        UnityEngine.SceneManagement.SceneManager.LoadScene("FirstTest");
    }
}
