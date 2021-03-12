using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float PlayerSpeed;
    private float DirX, DirY;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DirX = Input.GetAxis("Horizontal");
        DirY = Input.GetAxis("Vertical");
        if(DirY!=0)
        {
            GetComponent<Animator>().SetInteger("Estado", 1);
        }
        else if (DirX != 0)
        {
            if (DirX > 0)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
            else
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
            GetComponent<Animator>().SetInteger("Estado", 2);
        }
        else
        {
            GetComponent<Animator>().SetInteger("Estado", 0);
        }
        transform.Translate(new Vector2(DirX, DirY) * Time.deltaTime * PlayerSpeed);        // time.deltatime hace que el movimiento este en referencia al tiempo en vez de los fps
    }
}
