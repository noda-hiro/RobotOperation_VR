using UnityEngine;
using UnityEditor;

[CreateAssetMenu(menuName = "MyParam/CreateParam",fileName = "paramFile")]
public class HPParameter : ScriptableObject
{
    [SerializeField]
    private float maxHP;
    [SerializeField]
    private float minHP;

    public float GetMaxHPValue{get => maxHP ;private set => maxHP = value ;}
    public float GetMinHPValue{get => minHP ;private set => minHP = value ;}

}
