using UnityEngine;
using UnityEngine.UI;

public class HPView : MonoBehaviour
{
    public delegate void OnHPUpdateHander();
    public event OnHPUpdateHander hpUpdateHander;

    private void Start()
    {
        hpUpdateHander?.Invoke();
    }
}
