using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatScript : MonoBehaviour
{
    public int Like = 0;
    public int Dislike = 0;

    public Button positiveResponseButton;
    public bool interactable;


    public void OnButtonClick1()
    {
        Like++;
    }

    public void OnButtonClick2()
    {
        Dislike++;
    }

    public void SetActive()
    {
        if(Like > 0)
        {
            positiveResponseButton.interactable = true;
        }
    }
    
}
