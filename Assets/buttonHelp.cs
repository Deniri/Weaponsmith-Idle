using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonHelp : MonoBehaviour
{
    public GameObject _panel;
    private void OnMouseUpAsButton()
    {
        _panel.SetActive(true);
    }
}
