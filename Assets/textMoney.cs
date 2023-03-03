using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textMoney : MonoBehaviour
{
    public TextMeshProUGUI _textMoney;
    public TextMeshProUGUI _textOre;
    public TextMeshProUGUI _textIngot;
    public TextMeshProUGUI _textPrestige;


    void Update()
    {
        _textOre.text = $"<sprite=1>{playerManager.Reduction_0(playerManager.ore)}";
        _textIngot.text = $"<sprite=2>{playerManager.Reduction_0(playerManager.ingot)}";
        _textMoney.text = $"<sprite=0>{playerManager.Reduction_0(playerManager.money)}";
        _textPrestige.text = $"<sprite=0>{playerManager.Reduction_0(playerManager.prestigePointsCurrent)}";
    }
}
