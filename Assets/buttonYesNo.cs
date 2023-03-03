using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CrazyGames;

public class buttonYesNo : MonoBehaviour
{
    public int number;
    public GameObject panel;

    private void OnMouseUpAsButton()
    {
        if (number == 0)
        {
            CrazyAds.Instance.beginAdBreakRewarded(successCallback, errorCallback);
        }
        else
        {
            panel.SetActive(false);
        }
    }

    void successCallback()
    {
        Debug.Log("Video completed - Offer a reward to the player");
        playerManager.adSpeedActive = true;
        playerManager.adSpeedTimer = 180f;
        panel.SetActive(false);
    }

    void errorCallback()
    {
        Debug.Log("Video not completed");
        panel.SetActive(false);

    }
}
