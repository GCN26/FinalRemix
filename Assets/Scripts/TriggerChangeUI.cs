using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TriggerChangeUI : MonoBehaviour
{
    public enum Paragraph
    {
        _1,_2,_3,_4,_5,_6
    }
    public TextMeshProUGUI text;
    public Paragraph para;
    public GameObject UI;

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerMovement>().canInspect = true;
            if (para == Paragraph._1)
            {
                text.text = UI.GetComponent<UIScript>().para1;
                //also change narration and nar time
            }
            else if (para == Paragraph._2)
            {
                text.text = UI.GetComponent<UIScript>().para2;
            }
            else if (para == Paragraph._3)
            {
                text.text = UI.GetComponent<UIScript>().para3;
            }
            else if (para == Paragraph._4)
            {
                text.text = UI.GetComponent<UIScript>().para4;
            }
            else if (para == Paragraph._5)
            {
                text.text = UI.GetComponent<UIScript>().para5;
            }
            else if (para == Paragraph._6)
            {
                text.text = UI.GetComponent<UIScript>().para6;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerMovement>().canInspect = false;
            UI.GetComponent<UIScript>().InteractPop.SetActive(false);
        }
    }
}
