using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmedModel 
{
    private int currentBulletValue;
    public SubscribeValue<int> OnCurrentBulletHandler;

    public void Init()
    {
        OnCurrentBulletHandler = new SubscribeValue<int>();
    }

    private int UpdateBulletValue
    {
        get => currentBulletValue;
    }

    public void InitBulletValue(ArmedParameter armedParameter)
    {
        currentBulletValue = armedParameter.GetBulletValue;
    }

}
