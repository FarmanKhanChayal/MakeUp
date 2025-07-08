using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DOTween.Sequence()
        .Append(transform.DOScale(new Vector3(2.189671f, 6.25937f, 1.127632f), 1))
        .SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
