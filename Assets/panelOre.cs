using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class panelOre : MonoBehaviour
{
    public int number;

    public TextMeshProUGUI textIncome;
    public TextMeshProUGUI textLevel;
    public TextMeshProUGUI textCost;

    public GameObject bar;
    public panelChangeOre _pCO;

    public OreOnIncomePanel _OOIP;

    private Vector3 scaleBar = new Vector3(1f, 1f, 1f);


    private void Awake()
    {
        if (number >= playerManager.oreAmount)
            gameObject.SetActive(false);
    }

    void FixedUpdate()
    {

        //level display
        textIncome.text = $"<sprite=1>{playerManager.Reduction_0(playerManager.incomeOre[number])}";
        textLevel.text = $"Level: {playerManager.levelOre[number]}";

        textCost.text = $"<sprite=0>{playerManager.Reduction_0(playerManager.CostOre[number])}";

        //bar display
        scaleBar.x = (float)(1d / playerManager.BarMaxOre[number] * playerManager.BarOre[number]);
        if (scaleBar.x > 1f)
            scaleBar.x = 1f;
        bar.transform.localScale = scaleBar;
    }



    public void UpdateOre()
    {
        _OOIP.UpdateOre(number);
    }



    private void OnMouseUpAsButton()
    {
        panelChangeOre.OreOn = number;
        _pCO.gameObject.SetActive(true);
        _pCO.UpdatePanel();
        _pCO.UpdateOre();
    }
}
