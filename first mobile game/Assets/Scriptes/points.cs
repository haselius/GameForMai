using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{
    public Text pointValue;
    void Awake()
    {
        Character.points= 0;
    }

    
    void Update()
    {
        pointValue.text = Character.points.ToString();
    }
}
