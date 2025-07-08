using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
    public List<Sprite> sprites;

    private int currentIndex;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonclcik()
    {
        currentIndex = (currentIndex + 1)%sprites.Count;

        GetComponent<Image>().sprite = sprites[currentIndex];
    }
}
