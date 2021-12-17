using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Savedata : MonoBehaviour
{
    public InputField textBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickSave()
    {
        PlayerPrefs.SetString("username", textBox.text);
        SceneManager.LoadScene("SecondScene");
    }
}
