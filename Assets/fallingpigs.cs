using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//I wanted pigs to appear on button click. havent finished
public class fallingpigs : MonoBehaviour
{
    public Button yourButton;
    public GameObject pig;


    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }




private void TaskOnClick()
{



    Debug.Log("You have clicked the button!");
}

}
