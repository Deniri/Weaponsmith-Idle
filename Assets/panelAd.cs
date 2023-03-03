using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelAd : MonoBehaviour
{
    private void Awake()
    {
        transform.localPosition = new Vector3(0f, 0f, 0f);
        gameObject.SetActive(false);
    }
}
