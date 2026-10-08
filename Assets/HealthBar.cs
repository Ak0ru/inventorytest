using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Image bar;
    public float fill;
    public float MaxHp;
    public float health;
    // Start is called before the first frame update
    void Start()
    {
        fill = 1f;
        MaxHp = fill;
        health = MaxHp;
    }

    // Update is called once per frame
    void Update()
    {
        bar.fillAmount = fill;

    }
}
