using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    public GameObject UIPanel;
    public TextMeshProUGUI text;
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
        UIPanel.SetActive(false);
    }
}
