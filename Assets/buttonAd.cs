using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class buttonAd : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject panel;
    private void FixedUpdate()
    {
        if (playerManager.adSpeedTimer > 0f)
        {
            playerManager.adSpeedTimer -= Time.deltaTime;
            text.text = $"{playerManager.Timer00(playerManager.adSpeedTimer)}";
        }
                 
        else
        {
            text.text = $"WATCH";
            playerManager.adSpeedTimer = 0f;
        }
            


        
    }

    private void OnMouseUpAsButton()
    {
        if (playerManager.adSpeedTimer <= 0f)
        {
            panel.SetActive(true);
        }
    }
}
