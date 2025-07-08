using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DOTween.Sequence()
           .Append(transform.DOScale(new Vector3(1.420078f, 3.010645f, 1), 1))
           .SetLoops(-1,LoopType.Yoyo);





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
