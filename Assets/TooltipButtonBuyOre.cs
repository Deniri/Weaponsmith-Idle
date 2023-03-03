using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TooltipButtonBuyOre : MonoBehaviour
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
        playerManager._tooltipButtonBuyOre = this;
        gameObject.SetActive(false);
    }




    public void TooltipSize(int num)
    {
        number = num;

        textName.text = $"Upgrade mine";

        textProp.text = $"Level {playerManager.levelOre[num]}{playerManager.Sign(playerManager.levelOre[num], playerManager.levelOre[num] + playerManager.XBuyOre[num])}{playerManager.levelOre[num] + playerManager.XBuyOre[num]}<#FFFFFF>";
        textProp.text += $"\nIncome {playerManager.Reduction_0(playerManager.incomeOre[num])}{playerManager.Sign(playerManager.incomeOre[num], playerManager.incomeOreUp[num])}{playerManager.Reduction_0(playerManager.incomeOreUp[num])}<#FFFFFF>";
        textProp.text += $"\nSpeed {playerManager.Reduction_2(playerManager.SpeedOre[num])}{playerManager.Sign(playerManager.SpeedOre[num], playerManager.SpeedOreUp[num])}{playerManager.Reduction_2(playerManager.SpeedOreUp[num])}<#FFFFFF>";
        textProp.text += $"\nBar {playerManager.Reduction_2(playerManager.BarMaxOre[num])}{playerManager.Sign2(playerManager.BarMaxOre[num], playerManager.BarMaxOreUp[num])}{playerManager.Reduction_2(playerManager.BarMaxOreUp[num])}<#FFFFFF>";

        textProp.text += $"\n\nCost: <sprite=0><#EBC800>{playerManager.Reduction_0(playerManager.CostOre[num])}";


        Invoke("TooltipSizePause", 0.05f);
    }

    public void TooltipSizePause()
    {
        rtName.transform.localPosition = new Vector3(0f, rtProp.transform.localPosition.y + rtProp.sizeDelta.y + 10f, 0f);
        rtBackground2.sizeDelta = new Vector2(254f, rtName.sizeDelta.y + rtProp.sizeDelta.y + 4f + 18f);
        rtBackground.sizeDelta = new Vector2(258f, rtName.sizeDelta.y + rtProp.sizeDelta.y + 8f + 18f);
    }
}
