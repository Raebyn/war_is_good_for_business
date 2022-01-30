using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputManagement : MonoBehaviour
{
    
[SerializeField] GameObject titleScreen;
    public void StartGame()
    {
       titleScreen.SetActive(false);
    }

    public void DisableText1Button()
    {
        GameObject.Find("Text1Button").SetActive(false);
    }

        public void DisableText2Button()
    {
        GameObject.Find("Text2Button").SetActive(false);
    }

        public void DisableText3Button()
    {
        GameObject.Find("Text3Button").SetActive(false);
    }

        public void DisableText4Buttont()
    {
        GameObject.Find("Text4Button").SetActive(false);
    }
 
        public void DisableText5Buttont()
    {
        GameObject.Find("Text5Button").SetActive(false);
    }
}
