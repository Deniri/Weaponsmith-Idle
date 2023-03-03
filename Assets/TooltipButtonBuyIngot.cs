using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TooltipButtonBuyIngot : MonoBehaviour
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
        playerManager._tooltipButtonBuyIngot = this;
        gameObject.SetActive(false);
    }




    public void TooltipSize(int num)
    {
        number = num;

        textName.text = $"Upgrade furnace";

        textProp.text = $"Level {playerManager.levelIngot[num]}{playerManager.Sign(playerManager.levelIngot[num], playerManager.levelIngot[num] + playerManager.XBuyIngot[num])}{playerManager.levelIngot[num] + playerManager.XBuyIngot[num]}<#FFFFFF>";
        textProp.text += $"\nIncome {playerManager.Reduction_0(playerManager.incomeIngot[num])}{playerManager.Sign(playerManager.incomeIngot[num], playerManager.incomeIngotUp[num])}{playerManager.Reduction_0(playerManager.incomeIngotUp[num])}<#FFFFFF>";
        textProp.text += $"\nSpeed {playerManager.Reduction_2(playerManager.SpeedIngot[num])}{playerManager.Sign(playerManager.SpeedIngot[num], playerManager.SpeedIngotUp[num])}{playerManager.Reduction_2(playerManager.SpeedIngotUp[num])}<#FFFFFF>";
        textProp.text += $"\nBar {playerManager.Reduction_2(playerManager.BarMaxIngot[num])}{playerManager.Sign2(playerManager.BarMaxIngot[num], playerManager.BarMaxIngotUp[num])}{playerManager.Reduction_2(playerManager.BarMaxIngotUp[num])}<#FFFFFF>";

        textProp.text += $"\n\nCost: <sprite=1><#654428>{playerManager.Reduction_0(playerManager.CostIngot[num])}";


        Invoke("TooltipSizePause", 0.05f);
    }

    public void TooltipSizePause()
    {
        rtName.transform.localPosition = new Vector3(0f, rtProp.transform.localPosition.y + rtProp.sizeDelta.y + 10f, 0f);
        rtBackground2.sizeDelta = new Vector2(254f, rtName.sizeDelta.y + rtProp.sizeDelta.y + 4f + 18f);
        rtBackground.sizeDelta = new Vector2(258f, rtName.sizeDelta.y + rtProp.sizeDelta.y + 8f + 18f);
    }
}
