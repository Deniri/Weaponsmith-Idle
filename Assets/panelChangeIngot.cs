using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class panelChangeIngot : MonoBehaviour
{
    public static int IngotOn;

    public TextMeshProUGUI textName;
    public TextMeshProUGUI textProp;

    public ingot _ingot;

    public panelIngot[] _panelIngot;



    private void Awake()
    {
        transform.localPosition = new Vector3(0f, 0f, 0f);
        gameObject.SetActive(false);
    }

    public void UpdatePanel()
    {

        playerManager.UpdateIngot();
        _panelIngot[IngotOn].UpdateIngot();
    }

    public void UpdateIngot()
    {
        _ingot.UpdateIngot();
        playerManager.UpdateIngot();
        _panelIngot[IngotOn].UpdateIngot();


        textName.text = allTextManager.ingotName[playerManager.IngotUsed[IngotOn]];
        textProp.text = $"Increased income: <#21CB1E>x{playerManager.Reduction_2(1d + playerManager.IngotUsedIncome[IngotOn])}";
    }
}


