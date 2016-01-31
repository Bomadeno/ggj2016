using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Clicker : MonoBehaviour {

    public void OnClickLoad()
    {
        SceneManager.LoadScene("CharSelection");
    }
}
