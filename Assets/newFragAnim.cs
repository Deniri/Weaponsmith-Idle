using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class newFragAnim : MonoBehaviour
{

    private int state = 0;
    private Vector3 scaleF = new Vector3(1f,1f,1f);


    void Update()
    {
        if (state == 0)
        {
            scaleF.y -= 1f * Time.deltaTime;
            scaleF.x -= 1f * Time.deltaTime;
            if (scaleF.y <= 0.3f)
            {
                scaleF.y = 0.3f;
                state = 1;
            }
            transform.localScale = scaleF;
        }
        if (state == 1)
        {
            scaleF.y += 1f * Time.deltaTime;
            scaleF.x += 1f * Time.deltaTime;
            if (scaleF.y >= 1f)
            {
                scaleF.y = 1f;
                state = 0;
            }
            transform.localScale = scaleF;
        }
    }
}
