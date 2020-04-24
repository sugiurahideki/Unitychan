using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class UnityCharcterController1 : MonoBehaviour
{
    public GameObject player;
    public CharacterController CC;
    private Vector3 move_forward;
    public float movespeed;

    // Start is called before the first frame update
    void Start()
    {
        CC = player.GetComponent<CharacterController>();
        move_forward = new Vector3(0,0,1);//新しい型を使うときはNeWがいる（インスタンスを作る）dd
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
          
            CC.Move(transform.forward*movespeed);
                   
        }
       

            transform.Rotate(0,Input.GetAxis("Horizontal"),0);

       
    }
}
