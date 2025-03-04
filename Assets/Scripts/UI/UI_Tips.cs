using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class UI_Tips : MonoBehaviour
{
    public Transform pnl_Rumour;
    public float speed;
    public float duration;

    private Vector2 pnlPos_OffStage = new Vector2(1328, 284);
    private Vector2 pnlPos_OnStage = new Vector2(628, 284);

    public void Init()
    {
        Hide();
    }

    Sequence sq;
    public void AnimShow()
    {
        Show();

        sq = DOTween.Sequence()
            .Append(pnl_Rumour.DOLocalMoveX(pnlPos_OnStage.x, speed))
            .AppendInterval(duration)
            .Append(pnl_Rumour.DOLocalMoveX(pnlPos_OffStage.x, speed))
            ;
    }
    public void Show()
    {
        pnl_Rumour.localPosition = pnlPos_OffStage;
        gameObject.SetActive(true);
    }
    public void Hide()
    {
        pnl_Rumour.localPosition = pnlPos_OffStage;
        gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
