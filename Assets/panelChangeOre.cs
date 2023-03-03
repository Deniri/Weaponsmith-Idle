using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class panelChangeOre : MonoBehaviour
{
    public static int OreOn;

    public TextMeshProUGUI textName;
    public TextMeshProUGUI textProp;

    public ore _ore;

    public panelOre[] _panelOre;



    private void Awake()
    {
        transform.localPosition = new Vector3(0f, 0f, 0f);
        gameObject.SetActive(false);
    }

    public void UpdatePanel()
    {

        playerManager.UpdateOre();
        _panelOre[OreOn].UpdateOre();
    }

    public void UpdateOre()
    {
        _ore.UpdateOre();
        playerManager.UpdateOre();
        _panelOre[OreOn].UpdateOre();


        textName.text = allTextManager.oreName[playerManager.oreUsed[OreOn]];
        textProp.text = $"Increased income: <#21CB1E>x{playerManager.Reduction_2(1d + playerManager.oreUsedIncome[OreOn])}";
    }
}
