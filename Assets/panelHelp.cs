using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelHelp : MonoBehaviour
{
    public int stage = 0;
    public GameObject text1;
    public GameObject text2;

    private void Awake()
    {
        transform.localPosition = new Vector3(12.5f, -17f, 0f);
    }
    private void OnMouseUpAsButton()
    {
        if (stage == 0)
        {
            stage = 1;
            text1.SetActive(false);
            text2.SetActive(true);
        }
        else if (stage == 1)
        {
            stage = 0;
            text1.SetActive(true);
            text2.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
