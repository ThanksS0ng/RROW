using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class UI_Tips : MonoBehaviour
{
    public Transform pnl_Rumour;
    public Transform pnl_Rumour2;
    public float speed;
    public float duration;

    private Vector2 pnlPos_OffStage = new Vector2(1328, 284);
    private Vector2 pnlPos_OnStage = new Vector2(628, 284);
    private Vector2 pnlPos2_OffStage = new Vector2(1328, 168);
    private Vector2 pnlPos2_OnStage = new Vector2(628, 168);

    public void Init()
    {
        Hide();
    }

    Sequence sq;
    public void AnimShowOne()
    {
        Show();
        pnl_Rumour2.gameObject.SetActive(false);

        sq = DOTween.Sequence()
            .Append(pnl_Rumour.DOLocalMoveX(pnlPos_OnStage.x, speed))
            .AppendInterval(duration)
            .Append(pnl_Rumour.DOLocalMoveX(pnlPos_OffStage.x, speed))
            ;
    }
    Sequence sq2;
    public void AnimShowTwo()
    {
        Show();

        sq = DOTween.Sequence()
            .Append(pnl_Rumour.DOLocalMoveX(pnlPos_OnStage.x, speed))
            .AppendInterval(0.08f)
            .Append(pnl_Rumour2.DOLocalMoveX(pnlPos_OnStage.x, speed))
            .AppendInterval(duration)
            .Append(pnl_Rumour.DOLocalMoveX(pnlPos_OffStage.x, speed))
            .AppendInterval(0.08f)
            .Append(pnl_Rumour2.DOLocalMoveX(pnlPos_OffStage.x, speed))
            ;
    }
    public void Show()
    {
        pnl_Rumour.localPosition = pnlPos_OffStage;
        pnl_Rumour2.localPosition = pnlPos2_OnStage;
        gameObject.SetActive(true);
    }
    public void Hide()
    {
        pnl_Rumour.localPosition = pnlPos_OffStage;
        pnl_Rumour2.localPosition= pnlPos2_OnStage;
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
