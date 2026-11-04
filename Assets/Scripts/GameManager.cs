using System;
using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]private GameObject introText;
    [SerializeField]private GameObject magnet;

    private void Start()
    {
        StartCoroutine(IntroText());
        magnet.SetActive(false);
    }

    public void ActivateMagnet()
    {
        magnet.SetActive(true);


    
    }
    IEnumerator IntroText()
    {
        introText.SetActive(true);
        yield return new WaitForSeconds(3f);
        introText.SetActive(false);

    }
}


