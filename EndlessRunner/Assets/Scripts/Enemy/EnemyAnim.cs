using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyAnim : MonoBehaviour
{
    
    private void Start()
    {
        int randomSign = 0;
        while(randomSign == 0)
        {
            randomSign = Random.Range(-1, 2);
        }
        Tween tween = transform.DORotate(new Vector3(0, 0, randomSign * 360), Random.Range(5, 15), RotateMode.FastBeyond360);
        tween.SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
    }
}
