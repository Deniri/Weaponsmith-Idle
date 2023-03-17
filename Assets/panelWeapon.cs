using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class panelWeapon : MonoBehaviour
{

    public int number;

    public TextMeshProUGUI textIncome;
    public TextMeshProUGUI textLevel;
    public TextMeshProUGUI textCost;

    public GameObject bar;
    public panelChangeWeapon _pCW;

    public weaponOnIncomePanel _wOIP;

    private Vector3 scaleBar = new Vector3(1f,1f,1f);

    private void Awake()
    {
        if (number >= playerManager.weaponAmount)
            gameObject.SetActive(false);
    }

    void FixedUpdate()
    {

        //level display
        textIncome.text = $"<sprite=0>{playerManager.Reduction_0(playerManager.incomeWeapon[number])}";
        textLevel.text = $"Level: {playerManager.levelWeapon[number]}";

        textCost.text = $"<sprite=2>{playerManager.Reduction_0(playerManager.CostWeapon[number])}";

        //bar display
        scaleBar.x = (float)(1d / playerManager.BarMaxWeapon[number] * playerManager.BarWeapon[number]);
        if (scaleBar.x > 1f)
            scaleBar.x = 1f;
        bar.transform.localScale = scaleBar;
    }



    public void UpdateWeapon()
    {
        _wOIP.UpdateWeapon();
    }



    private void OnMouseUpAsButton()
    {
        panelChangeWeapon.weaponOn = number;
        _pCW.gameObject.SetActive(true);
        _pCW.UpdatePanel();
        _pCW.UpdateWeapon();
    }


}
