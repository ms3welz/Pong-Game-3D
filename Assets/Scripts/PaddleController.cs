using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speedPaddle;
    private Rigidbody rig;

    [Header("Key Code")]
    public KeyCode leftKey;
    public KeyCode rightKey;
    public KeyCode forwardKey;
    public KeyCode backKey;
    

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 movement = GetInput();
        MoveObject(GetInput());
    }

    private Vector3 GetInput()
    {
        // Input Kiri dan Kanan untuk player 1 dan 2
        if(Input.GetKey(leftKey))
        {
            return Vector3.left * speedPaddle;
        }

        if (Input.GetKey(rightKey))
        {
            return Vector3.right * speedPaddle;
        }
        
        // Input atas dan bawah untuk player 3 dan 4
        if (Input.GetKey(forwardKey))
        {
            return Vector3.forward * speedPaddle;
        }

        if (Input.GetKey(backKey))
        {
            return Vector3.back * speedPaddle;
        }

        return Vector3.zero;
    }

    private void MoveObject(Vector3 movement)
    {
        rig.position += movement*Time.deltaTime;
    }
}
