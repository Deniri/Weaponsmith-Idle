using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OreOnIncomePanel : MonoBehaviour
{
    public Image _image;

    public Sprite[] _iconOre;
    public void UpdateOre(int number)
    {

        _image.sprite = _iconOre[playerManager.oreUsed[number]];

        _image.SetNativeSize();
    }
}
