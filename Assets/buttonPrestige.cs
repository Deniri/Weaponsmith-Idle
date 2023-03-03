using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPrestige : MonoBehaviour
{

    public float timer;
    public GameObject bar;
    public bool IsPressed = false;

    public GameObject panel;
    

    private void Update()
    {
        if (IsPressed == true)
        {
            timer += 1f * Time.deltaTime;
            if (timer > 3f)
            {
                timer = 0;
                //ResetWorld();
            }
        }
        bar.transform.localScale = new Vector3(1f / 3f * timer, 1f, 1f);
    }




    private void OnMouseDown()
    {
        IsPressed = true;
    }

    private void OnMouseUp()
    {
        timer = 0;
        IsPressed = false;
    }

    private void OnMouseExit()
    {
        timer = 0;
        IsPressed = false;
    }
}
