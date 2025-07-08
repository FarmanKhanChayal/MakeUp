using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeddingTexts : MonoBehaviour
{
    private int currentIndex;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClick()
    {

        ChildDestroy();

        currentIndex = (currentIndex + 1)%transform.childCount;
        transform.GetChild(currentIndex).gameObject.SetActive(true);   
    }

    private void ChildDestroy()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
        
    }
}
