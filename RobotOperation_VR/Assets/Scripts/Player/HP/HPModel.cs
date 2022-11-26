using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPModel 
{
    private float currentHP;
    
    public float SetUpHP(HPParameter hpParam)
    {
        currentHP = hpParam.GetMaxHPValue;
        return currentHP;
    }
}
