using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public bool inspect,pauseMenu;
    public GameObject UIManager;
    public Vector3 inputs = Vector3.zero;
    public Vector3 rotation, move;
    private float rotX, rotY, xVelocity, yVelocity;
    public float mouseSensitivity, joyCamSensitivity, snappiness, upDownRange;
    public bool cursorFree,canInspect;
    public CharacterController control;
    public GameObject mainCam;


    void Start()
    {
        canInspect = false;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && canInspect)
        {
            //allow this only near certain objects, and have said objects change the text object of the ui
            inspect = !inspect;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu = !pauseMenu;
        }

        if (!inspect && !pauseMenu)
        {
            PlayerMove();
            UIManager.GetComponent<UIScript>().ButtonClose();
        }
        else if (inspect && !pauseMenu)
        {
            if (UIManager.GetComponent<UIScript>().UIPanel.activeSelf == false) UIManager.GetComponent<UIScript>().EnablePanel();
        }
        else if (pauseMenu)
        {
            UIManager.GetComponent<UIScript>().ButtonClose();
            inspect = false;
        }
    }
    public void InspectClose()
    {
        inspect = false;
    }

    public void PlayerMove()
    {
        //Get movement
        inputs.x = Input.GetAxis("Horizontal");
        inputs.z = Input.GetAxis("Vertical");
        inputs = Vector3.ClampMagnitude(inputs, 1f);

        //Camera controls
        rotX = Input.GetAxis("Mouse X") * mouseSensitivity;
        rotY -= Input.GetAxis("Mouse Y") * mouseSensitivity;

        xVelocity = Mathf.Lerp(xVelocity, rotX, snappiness * Time.deltaTime);
        yVelocity = Mathf.Lerp(yVelocity, rotY, snappiness * Time.deltaTime);

        this.rotation = new Vector3(0, inputs.x * 180 * Time.deltaTime, 0);
        move = new Vector3(0, move.y, inputs.z * speed);

        move = this.transform.TransformDirection(move);
        control.Move(move * Time.deltaTime);
        this.transform.Rotate(this.rotation);
    }
}