using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMovingSetFalse : MonoBehaviour
{
    public int nodeNumber;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            other.GetComponent<MenuNodeMovement>().moving = false;
        }
    }
}
