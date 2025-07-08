using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolManager : MonoBehaviour
{
    public List<ToolObject> toolObjects;
    public Transform sidePanelContent;

  


    private Dictionary <string, ToolType> toolTypeDictionary;
    private Dictionary<ToolType,ToolObject> toolDictionary;

    private ToolType currentTool = ToolType.Hair;

    void Start()
    {
        BuildTooldictionary();
        BuildToolTypeDictionary();
    }

    void BuildTooldictionary()
    {
        toolDictionary = new Dictionary<ToolType, ToolObject>();
        foreach(ToolObject item in toolObjects)
        {
            toolDictionary.Add(item.toolType, item);
        }
    }

    void BuildToolTypeDictionary()
    {
        toolTypeDictionary = new Dictionary<string, ToolType>();

        toolTypeDictionary.Add("Bindi", ToolType.Bindi);
        toolTypeDictionary.Add("Earring",ToolType.Earring);
        toolTypeDictionary.Add("Eyelash",ToolType.Eyelash);
        toolTypeDictionary.Add("Eyeball",ToolType.Eyeball);
        toolTypeDictionary.Add("Eyeshadow",ToolType.Eyeshadow);
        toolTypeDictionary.Add("Hair",ToolType.Hair);
        toolTypeDictionary.Add("Lips", ToolType.Lips);
        toolTypeDictionary.Add("Necklace",ToolType.Necklace);
        toolTypeDictionary.Add("Nosering",ToolType.Nosering);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnToolClick(string toolName)
    {
        ToolType toolType = toolTypeDictionary[toolName];
        ToolObject toolObject = toolDictionary[toolType];

        for(int i = 0; i < sidePanelContent.childCount; i++)
        {
            Transform thumb = sidePanelContent.GetChild(i);
            thumb.GetComponent<Image>().sprite = toolObject.thumbSprites[i];
            thumb.GetComponent<Image>().SetNativeSize();

        }

        currentTool = toolType;






    }

    public void OnThumbClick(int index)
    {
       ToolObject toolObject = toolDictionary[currentTool];
       Sprite useSprite = toolObject.useSprites[index];
       toolObject.useTransform.GetComponent<Image>().sprite = useSprite;
    }


}
