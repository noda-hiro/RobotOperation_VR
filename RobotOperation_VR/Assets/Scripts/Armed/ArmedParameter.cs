using UnityEngine;

[CreateAssetMenu(menuName = "MyParam/ArmedParam",fileName = "paramFile")]
public class ArmedParameter : ScriptableObject
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float damage;
    [SerializeField]
    private float delirei;
    [SerializeField]
    private int bulletValue;

    public float GetSpeedValue {get => speed; private set =>speed = value;}
    public float GetDamageValue {get => damage; private set =>damage = value;}
    public float GetDelireiValue {get => delirei; private set => delirei = value;}
    public int GetBulletValue {get => bulletValue; private set => bulletValue = value;}

}
