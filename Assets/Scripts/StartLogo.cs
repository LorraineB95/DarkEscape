using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLogo : MonoBehaviour
{
    public GameObject Sounds;
    public GameObject FadeFromBlack;
    public GameObject Logo;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadGameStart());
    }

    IEnumerator LoadGameStart()
    {
        yield return new WaitForSeconds(8);
        Logo.SetActive(false);
        Sounds.SetActive(true);
        FadeFromBlack.SetActive(true);

    }
}