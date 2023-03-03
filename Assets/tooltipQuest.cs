using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class tooltipQuest : MonoBehaviour
{
    private int number;

    public RectTransform rtBackground;
    public RectTransform rtBackground2;
    public RectTransform rtName;
    public RectTransform rtProp;

    public TextMeshProUGUI textName;
    public TextMeshProUGUI textProp;

    private Vector3 posCur;

    void Awake()
    {
        playerManager._tooltipQuest = this;
        gameObject.SetActive(false);
    }




    public void TooltipSize(int num)
    {
        number = num;

        textName.text = allTextManager.questName[playerManager.questSlot[num]];

        textProp.text = $"Level {playerManager.questLevel[playerManager.questSlot[num]]}";

        if(playerManager.questProp[playerManager.questSlot[num]] > 0)
        {
            textProp.text += $"\n\n{allTextManager.questProp[playerManager.questSlot[num]]}";
            textProp.text += $" {playerManager.questProp[playerManager.questSlot[num]]}{allTextManager.questProp2[playerManager.questSlot[num]]}";
        }
        else
        {
            textProp.text += $"\n\n{allTextManager.questProp[playerManager.questSlot[num]]}";
        }

        textProp.text += $"\n\nProgress\n{playerManager.Reduction_0(playerManager.questProgress[playerManager.questSlot[num]])}/{playerManager.Reduction_0(playerManager.questProgressNeed[playerManager.questSlot[num]])}";


        textProp.text += allTextManager.questReward[playerManager.questSlot[num]];


        Invoke("TooltipSizePause", 0.05f);
    }

    public void TooltipSizePause()
    {
        rtName.transform.localPosition = new Vector3(0f, rtProp.transform.localPosition.y + rtProp.sizeDelta.y + 10f, 0f);
        rtBackground2.sizeDelta = new Vector2(254f, rtName.sizeDelta.y + rtProp.sizeDelta.y + 4f + 18f);
        rtBackground.sizeDelta = new Vector2(258f, rtName.sizeDelta.y + rtProp.sizeDelta.y + 8f + 18f);
    }
}
