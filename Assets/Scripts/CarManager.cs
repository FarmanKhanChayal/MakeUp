using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarManager : MonoBehaviour
{
    public List<Sprite> sprites;
    private int currentIndex;
    // Start is called before the first frame update
    
    public void OnButtonClick()
    {
        currentIndex = (currentIndex + 1) % sprites.Count;
        GetComponent<Image>().sprite = sprites[currentIndex];
    }
}
