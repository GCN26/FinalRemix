using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TriggerChangeUI : MonoBehaviour
{
    public string paragraph;
    public TextMeshProUGUI text;

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            text.text = paragraph;
        }
    }
}
