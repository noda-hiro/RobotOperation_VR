using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmedPresenter : MonoBehaviour
{
    [SerializeField]
    private ArmedView armedView;
    private ArmedModel armedModel;

    private void Awake()
    {
        armedModel = new ArmedModel();
        
    }
}
