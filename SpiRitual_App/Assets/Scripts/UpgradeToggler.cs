using UnityEngine;
using System.Linq;

public class UpgradeToggler : MonoBehaviour
{
    private GameObject upgrd;

    void Start()
    {
        upgrd = GetComponentsInChildren<Transform>().Where(x => x.name.Contains("Front")).FirstOrDefault().gameObject;
        if (upgrd == null) 
            Debug.LogError("There is no upgrade button front in " + this);
        upgrd.SetActive(false);
    }

    void OnMouseDown()
    {
        if (upgrd.activeSelf)
            upgrd.SetActive(false);
        else
            upgrd.SetActive(true);
    }


}
