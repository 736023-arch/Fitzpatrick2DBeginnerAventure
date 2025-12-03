using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerControllerTutorialUpdates : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    float horizontal;
    float vertical;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
        // Update is called once per frame
        void Update()
        {
             horizontal = Input.GetAxis("Horizontal");
             vertical = Input.GetAxis("Vertical");



            void 
        }
    
}