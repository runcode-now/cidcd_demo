using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoraemonMovenment : MonoBehaviour
{
    [SerializeField]
    float forceX = 1;

    [SerializeField]
    float forceY = 1;

    Rigidbody2D rigid;

    bool status = true; // true: right
                        // false: left

    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rigid.AddForce(Vector2.right * forceX);
            if(!status)      Flip();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rigid.AddForce(Vector2.left * forceX);
            if (status)     Flip();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rigid.AddForce(Vector2.up * forceY);
        }
    }

    void Flip()
    {
        status = !status;
        gameObject.transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Bat dau va cham " + collision.gameObject.name);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Van dang cham " + collision.gameObject.name);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Tach ra " + collision.gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Cham vao: " + collision.gameObject.name);
    }
} 
