using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{[SerializeField]
    public float playerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovementOfPlayer(playerSpeed);
    }

    private void MovementOfPlayer(float speedOfPlayer)
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x >= -10.0f)
            transform.Translate(-speedOfPlayer, 0, 0);
        else if(Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x <= 10.0f)
            transform.Translate(speedOfPlayer, 0, 0);
        else if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y <= 4.0f)
            transform.Translate(0,speedOfPlayer,0);
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y >= -4.0f)
                transform.Translate(0,-speedOfPlayer, 0);
        }
}
