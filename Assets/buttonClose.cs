using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonClose : MonoBehaviour
{

    public GameObject panel;

    private void OnMouseDown()
    {
        panel.SetActive(false);
    }
}
