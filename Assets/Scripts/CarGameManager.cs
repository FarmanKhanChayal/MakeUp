using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarGameManager : MonoBehaviour
{
    public List<Sprite> carSprites;
    public List<Sprite> decorSprites;
    public Transform decorTransform;
    public Transform carTransform;

    private int carIndex = 0;
    private int decorIndex = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCarButtonClcik()
    {
        carIndex = (carIndex + 1) % carSprites.Count;
        carTransform.GetComponent<Image>().sprite = carSprites[carIndex];   
    }

    public void OnDecorButtonClick()
    {
        decorIndex = (decorIndex + 1) % decorSprites.Count;
        decorTransform.GetComponent<Image>().sprite=decorSprites[decorIndex];
    }

  
}
