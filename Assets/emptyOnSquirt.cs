﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class emptyOnSquirt : MonoBehaviour
{
    Image img;
    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
        PlayerActions.subscribe_Spritz(empty);
    }

    void empty(int totalNumberEmpties)
    {
        img.fillAmount -= 1.0f / 3;
    }


}
