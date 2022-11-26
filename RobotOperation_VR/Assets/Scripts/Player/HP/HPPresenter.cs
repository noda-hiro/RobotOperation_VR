using UnityEngine;

public class HPPresenter : MonoBehaviour
{
    [SerializeField]
    private HPParameter hpParam;
    [SerializeField]
    private HPView hpView;
    private HPModel hpModel;

     // Start is called before the first frame update
    void Awake()
    {
        hpModel = new HPModel();
        hpView.hpUpdateHander += SetHPParam;
    }

    private void SetHPParam()
    {
        float cureHP = hpModel.SetUpHP(hpParam);
    }
}