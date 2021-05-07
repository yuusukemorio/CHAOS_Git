using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click_me : MonoBehaviour
{
    public string click_judge = "no";
    float weittime = 0;

    Animator AnimaR;

    public void tokeizikake_me()
    {
        click_judge = "yes";
        AnimaR = GetComponent<Animator>();
        AnimaR.SetInteger("hatuga", 0);
    }
    void Update()
    {
        if (click_judge == "yes")
        {
            AnimaR.SetInteger("hatuga", 1);
            weittime += Time.deltaTime;
            if (weittime >= 22)
            {
                AnimaR.SetInteger("hatuga", 2);
            }
        }
    }
}