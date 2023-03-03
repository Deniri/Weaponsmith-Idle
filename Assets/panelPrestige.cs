using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class panelPrestige : MonoBehaviour
{
    public int number;

    public TextMeshProUGUI textCurrentPrestige;
    public TextMeshProUGUI textInProgressPrestige;

    private void Awake()
    {
        transform.localPosition = new Vector3(357f, -50f, 0f);
        playerManager._pP = this;
        gameObject.SetActive(false);
    }


    void FixedUpdate()
    {
        if (playerManager.numberPanelMain != number)
        {
            gameObject.SetActive(false);
        }

        textCurrentPrestige.text = $"Current bonus income from <sprite=0><color=#00B382> prestige points</color> : {playerManager.Reduction_0(playerManager.prestigePointsCurrent)}%";
        textInProgressPrestige.text = $"<sprite=0><color=#00B382> prestige points</color> gained after reset : {playerManager.Reduction_0(playerManager.prestigePointsInProgress)}";
    }
}
