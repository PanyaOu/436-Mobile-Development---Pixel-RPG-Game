using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovementJoystick : MonoBehaviour
{
    public GameObject Joystick;
    public GameObject JoystickBG;
    public Vector2 joystickVector;
    private Vector2 joystickTouchPos;
    private Vector2 joystickStartPos;
    private float joystickRadius;
    
    // Start is called before the first frame update
    void Start()
    {
        joystickStartPos = JoystickBG.transform.position;
        joystickRadius = JoystickBG.GetComponent<RectTransform>().sizeDelta.y / 4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PointerDown(){
        JoystickBG.transform.position = Input.mousePosition;
        Joystick.transform.position = Input.mousePosition;
        joystickTouchPos = Input.mousePosition;
    }
    
    public void Drag(BaseEventData baseEventData){
        PointerEventData pointerEventData = baseEventData as PointerEventData;
        Vector2 dragPos = pointerEventData.position;
        joystickVector = (dragPos - joystickTouchPos).normalized;
        float joystickDistance = Vector2.Distance(dragPos, joystickTouchPos);
        if(joystickDistance < joystickRadius){
            Joystick.transform.position = joystickTouchPos + joystickVector * joystickDistance;
        }
        else{
            Joystick.transform.position = joystickTouchPos + joystickVector * joystickRadius;
        }
    }

    public void PointerUp(){
        joystickVector = Vector2.zero;
        Joystick.transform.position = joystickStartPos;
        JoystickBG.transform.position = joystickStartPos;
    }
}
