using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using UnityEngine;
using UnityEngine.UI;

public class GajraManager : MonoBehaviour
{
   public List< Sprite > sprites;

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

        currentIndex = (currentIndex + 1) % sprites.Count;
        GetComponent<Image>().sprite = sprites[currentIndex];
    }
}
