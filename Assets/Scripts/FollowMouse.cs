using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public GameObject[] Eyes;
    public GameObject ObjtoLookAt;

   // public Vector3 ScreenPos;
    //public Vector3 WorldPos;
    
    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        Vector3 MousePos = Input.mousePosition;
        //ScreenPos = Input.mousePosition; // input of cursor position on screen (x,y;0)
        MousePos.z = Camera.main.nearClipPlane - 15; //mouse position of a paralel plane to the 'camera lent' 

        Vector3 WorldPos = Camera.main.ScreenToWorldPoint(MousePos);
        //WorldPos = Camera.main.ScreenToWorldPoint(ScreenPos);

        ObjtoLookAt.transform.position = new Vector3(WorldPos.x, WorldPos.y, MousePos.z);





        
        


       foreach (GameObject Eye in Eyes) { 
            Eye.transform.LookAt(ObjtoLookAt.transform.position);
        }

    }
}
