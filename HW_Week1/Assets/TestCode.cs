using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestCode : MonoBehaviour
{
    public Text myText;
    public Image imagePrefab;
    public List<string> itemList = new List<string>();
    public List<Sprite> images = new List<Sprite>();
    public Sprite banana;
    public Sprite apple;
    public Sprite strawberry;
    public Sprite carrot;
    public Sprite orage;

    // Start is called before the first frame update
    void Start()
    {
        images.Add(banana);
        images.Add(apple);
        images.Add(strawberry);
        images.Add(carrot);
        images.Add(orage);

        itemList.Add("Banana");
        itemList.Add("Apple");
        itemList.Add("Strawberry");
        itemList.Add("Carrot");
        itemList.Add("Orage");
        myText.text = itemList[0] + "\n" + itemList[1] + "\n" + itemList[2] + "\n" + itemList[3] + "\n" + itemList[4];
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Return))
        {
            //myText.text = itemList[0];
                imagePrefab.GetComponent<Image>().sprite = images[0];
                itemList.RemoveAt(0);
                images.RemoveAt(0);
                itemList.Add("");

                

        }
         foreach (string str in itemList)
        {
            myText.GetComponent<Text>().text = itemList[0] + "\n" + itemList[1] + "\n" + itemList[2] + "\n" + itemList[3] + "\n" + itemList[4];

        }
    }

    
}
