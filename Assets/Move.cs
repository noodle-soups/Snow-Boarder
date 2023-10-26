using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    [SerializeField] float moveSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float moveInputHorizontal = Input.GetAxis("Horizontal");
        float moveInputVertical = Input.GetAxis("Vertical");

        var moveInputVector = new Vector3(moveInputHorizontal, moveInputVertical, 0);

        // normalize vector if H&V inputs are 1
        if (moveInputVector.sqrMagnitude > 1)
        {
            moveInputVector.Normalize();
        }

        var movement = moveInputVector * moveSpeed * Time.deltaTime;

        transform.Translate(movement);
        
    }
}
