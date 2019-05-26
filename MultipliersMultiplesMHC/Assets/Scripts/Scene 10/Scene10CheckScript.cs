using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene10CheckScript : MonoBehaviour
{
    public InputField First, Second, Third, Fourth;

    public void Check()
    {
        if (First.text == "9" && Second.text == "5"
            && Third.text == "3" && Fourth.text == "3")
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
