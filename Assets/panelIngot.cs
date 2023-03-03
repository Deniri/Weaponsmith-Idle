using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class panelIngot : MonoBehaviour
{
    public int number;

    public TextMeshProUGUI textIncome;
    public TextMeshProUGUI textLevel;
    public TextMeshProUGUI textCost;

    public GameObject bar;
    public panelChangeIngot _pCI;

    public ingotOnIncomePanel _IOIP;

    private Vector3 scaleBar = new Vector3(1f, 1f, 1f);

    private void Awake()
    {
        if (number >= playerManager.IngotAmount)
            gameObject.SetActive(false);
    }


    void FixedUpdate()
    {

        //отоброжение уровня
        textIncome.text = $"<sprite=2>{playerManager.Reduction_0(playerManager.incomeIngot[number])}";
        textLevel.text = $"Level: {playerManager.levelIngot[number]}";

        textCost.text = $"<sprite=1>{playerManager.Reduction_0(playerManager.CostIngot[number])}";

        //отображение бара
        scaleBar.x = (float)(1d / playerManager.BarMaxIngot[number] * playerManager.BarIngot[number]);
        if (scaleBar.x > 1f)
            scaleBar.x = 1f;
        bar.transform.localScale = scaleBar;
    }



    public void UpdateIngot()
    {
        _IOIP.UpdateIngot(number);
    }



    private void OnMouseUpAsButton()
    {
        panelChangeIngot.IngotOn = number;
        _pCI.gameObject.SetActive(true);
        _pCI.UpdatePanel();
        _pCI.UpdateIngot();
    }
}
