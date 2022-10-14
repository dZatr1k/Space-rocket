using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MenuText : MonoBehaviour
{
    private Sequence _sequence;
    private void Start()
    {
        _sequence = DOTween.Sequence();
        _sequence.Append(transform.DOMoveY(transform.position.y + 0.25f, 3).SetEase(Ease.InOutQuint));
        _sequence.Append(transform.DOMoveY(transform.position.y, 3).SetEase(Ease.InOutQuint));

        _sequence.SetLoops(-1, LoopType.Restart);

    }
}
