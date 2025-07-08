using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int childIndex = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void ObButtonClick()
    {
        ChildDestroy();
        childIndex = (childIndex + 1) % transform.childCount;
        transform.GetChild(childIndex).gameObject.SetActive(true);

    }

    void ChildDestroy()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
    }
}
