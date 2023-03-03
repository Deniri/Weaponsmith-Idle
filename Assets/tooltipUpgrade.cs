using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class tooltipUpgrade : MonoBehaviour
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
        playerManager._tooltipUpgrade = this;
        gameObject.SetActive(false);
    }




    public void TooltipSize(int num)
    {
        number = num;

        textName.text = allTextManager.upgradeName[playerManager.upgradeSlot[num]];

        textProp.text = $"Level {playerManager.upgradeLevel[playerManager.upgradeSlot[num]]}";
        textProp.text += $"\n\n{allTextManager.upgradeProp[playerManager.upgradeSlot[num]]}";
        
        textProp.text += $"\n\nCost: <sprite=0><#EBC800>{playerManager.Reduction_0(playerManager.upgradeCost[playerManager.upgradeSlot[num]])}";


        Invoke("TooltipSizePause", 0.05f);
    }

    public void TooltipSizePause()
    {
        rtName.transform.localPosition = new Vector3(0f, rtProp.transform.localPosition.y + rtProp.sizeDelta.y + 10f, 0f);
        rtBackground2.sizeDelta = new Vector2(254f, rtName.sizeDelta.y + rtProp.sizeDelta.y + 4f + 18f);
        rtBackground.sizeDelta = new Vector2(258f, rtName.sizeDelta.y + rtProp.sizeDelta.y + 8f + 18f);
    }
}
