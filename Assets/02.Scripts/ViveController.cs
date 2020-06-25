using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ViveController : MonoBehaviour
{
    //컨트롤러 정의
    public SteamVR_Input_Sources leftHand;
    public SteamVR_Input_Sources rightHand;
    public SteamVR_Input_Sources any;

    //컨트롤러 입력값 정의
    public SteamVR_Action_Boolean trigger;
   //트랙패드 관련 입력값 정의
    public SteamVR_Action_Boolean trackPadClick = SteamVR_Actions.default_Teleport;
    public SteamVR_Action_Boolean trackPadTouch = SteamVR_Actions.default_TrackPadTouch;
    public SteamVR_Action_Vector2 trackPadPosition = SteamVR_Actions.default_TrackPadPosition;
    void Awake()
    {
        trigger=  SteamVR_Actions.default_InteractUI;
    }
    void Update()
    {
        //왼손컨트롤
        if(SteamVR_Actions.default_InteractUI.GetStateDown(leftHand))
        {
        }  
        //오른손컨트롤
        if(trigger.GetStateUp(rightHand))
        {
        }
        //터치패드 클릭
        if(trackPadClick.GetStateDown(any))
        {
            Debug.Log("TrackPad Click");
        }
        if(trackPadTouch.GetState(any))
        {
            Vector2 pos = trackPadPosition.GetAxis(any);
            Debug.Log($"Touch Pos x={pos.x} /y={pos.y}");
        }
    }
}
