using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MenuNodeMovement : MonoBehaviour
{
    public List<GameObject> nodes;
    public int nodeIndex;
    public float speed;
    public bool moving,inspect;
    public GameObject UIManager;
    void Start()
    {
        transform.position = nodes[0].transform.position;
        nodeIndex = 0;
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E) && moving != true)
        {
            inspect = !inspect;
            moving = true;
        }

        if (!inspect)
        {
            if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)))
            {
                if (nodeIndex + 1 < nodes.Count)
                {
                    nodeIndex += 1;
                    moving = true;
                }
            }
            else if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)))
            {
                if (nodeIndex - 1 >= 0)
                {
                    nodeIndex -= 1;
                    moving = true;
                }
            }

            if (moving)
            {
                Vector3 targetPosition = nodes[nodeIndex].transform.position;
                Vector3 direction = targetPosition - this.transform.position;
                direction = direction.normalized;

                this.transform.position += direction * speed * Time.deltaTime;
            }

        }
        else
        {
            if(UIManager.GetComponent<UIScript>().UIPanel.activeSelf == false) UIManager.GetComponent<UIScript>().EnablePanel();
        }
    }
    public void InspectClose()
    {
        inspect = false;
        moving = false;
    }
}
