using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene9CheckScript : MonoBehaviour
{
    public InputField InputNumber;

    public void Check()
    {
        if (InputNumber.text == "4")
        {
            this.gameObject.GetComponent<StoryScriptGeneric>().Win();
            this.gameObject.GetComponent<StoryScriptGeneric>().LoadNextScene();
        }
        else
        {
            this.gameObject.GetComponent<StoryScriptGeneric>().Lose();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
