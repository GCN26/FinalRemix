using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public GameObject UIPanel;
    public TextMeshProUGUI text;
    public Scrollbar Scrollbar;

    public string para1, para2,para3,para4,para5,para6;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EnablePanel()
    {
       UIPanel.SetActive(true);
    }
    public void ButtonClose()
    {
        Scrollbar.value = 1;
        UIPanel.SetActive(false);
        
    }
}
