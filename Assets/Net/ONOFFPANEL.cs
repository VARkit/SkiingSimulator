using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ONOFFPANEL : MonoBehaviour
{
    public GameObject counter;
    public GameObject panel;
    public Start Start;
    public void Update()
    {
        if (Start.Prev == 2)
        {
            counter.SetActive(true);
            panel.SetActive(false);
        }


    }

}
