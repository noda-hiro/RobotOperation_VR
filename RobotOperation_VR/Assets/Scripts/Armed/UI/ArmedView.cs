using UnityEngine;
using TMPro;

public class ArmedView : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro currentBulletValueText;
    private SubscribeValue<int,int> bulletValueSubscriber;

    void Awake()
    {
        bulletValueSubscriber = new SubscribeValue<int, int>();
        bulletValueSubscriber.Subscribe +=UpdateBulletValueText;
    }

    private void UpdateBulletValueText(int bulletValue,int maxValue)
    {
        currentBulletValueText.text = "[" + bulletValue + "/" + maxValue + "]";
    }
}
