using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoraemonScript : MonoBehaviour
{
    [SerializeField]
    float speedX = 1;
    float cameraWidth, positionX, positionY, positionZ;

    // Start is called before the first frame update
    void Start()
    {
        positionY = transform.position.y;
        positionZ = transform.position.z;
        float gOWidthX = gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        cameraWidth = Camera.main.orthographicSize * Camera.main.aspect - gOWidthX;
    }   

    // Update is called once per frame
    void Update()
    {
        positionX = transform.position.x + speedX * Time.deltaTime;

        if(positionX > cameraWidth || positionX < -cameraWidth)
        {
            gameObject.transform.localScale = new Vector3(-transform.localScale.x,transform.localScale.y,transform.localScale.z);
            speedX *= -1;
            positionX = transform.position.x + speedX * Time.deltaTime;
        }
        transform.position = new Vector3(positionX, positionY, positionZ);
    }
}
