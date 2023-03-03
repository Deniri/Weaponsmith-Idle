using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class tooltipButtonBuyWeapon : MonoBehaviour
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
        playerManager._tooltipButtonBuyWeapon = this;
        gameObject.SetActive(false);
    }




    public void TooltipSize(int num)
    {
        number = num;

        textName.text = $"Upgrade weapon";

        textProp.text = $"Level {playerManager.levelWeapon[num]}{playerManager.Sign(playerManager.levelWeapon[num], playerManager.levelWeapon[num] + playerManager.XBuyWeapon[num])}{playerManager.levelWeapon[num] + playerManager.XBuyWeapon[num]}<#FFFFFF>";
        textProp.text += $"\nIncome {playerManager.Reduction_0(playerManager.incomeWeapon[num])}{playerManager.Sign(playerManager.incomeWeapon[num], playerManager.incomeWeaponUp[num])}{playerManager.Reduction_0(playerManager.incomeWeaponUp[num])}<#FFFFFF>";
        textProp.text += $"\nSpeed {playerManager.Reduction_2(playerManager.SpeedWeapon[num])}{playerManager.Sign(playerManager.SpeedWeapon[num], playerManager.SpeedWeaponUp[num])}{playerManager.Reduction_2(playerManager.SpeedWeaponUp[num])}<#FFFFFF>";
        textProp.text += $"\nBar {playerManager.Reduction_2(playerManager.BarMaxWeapon[num])}{playerManager.Sign2(playerManager.BarMaxWeapon[num], playerManager.BarMaxWeaponUp[num])}{playerManager.Reduction_2(playerManager.BarMaxWeaponUp[num])}<#FFFFFF>";

        textProp.text += $"\n\nCost: <sprite=2><#83776D>{playerManager.Reduction_0(playerManager.CostWeapon[num])}";
        

        Invoke("TooltipSizePause", 0.05f);
    }

    public void TooltipSizePause()
    {
        rtName.transform.localPosition = new Vector3(0f, rtProp.transform.localPosition.y + rtProp.sizeDelta.y + 10f, 0f);
        rtBackground2.sizeDelta = new Vector2(254f, rtName.sizeDelta.y + rtProp.sizeDelta.y + 4f + 18f);
        rtBackground.sizeDelta = new Vector2(258f, rtName.sizeDelta.y + rtProp.sizeDelta.y + 8f + 18f);
    }
}
