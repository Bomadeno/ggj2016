using UnityEngine;
using System.Collections;

public class BackOnBackOrEsc : MonoBehaviour {
    public string SceneToGoBackTo;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(SceneToGoBackTo);
        }
	}
}
