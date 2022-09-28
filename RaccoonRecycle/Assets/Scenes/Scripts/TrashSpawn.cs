using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawn : MonoBehaviour
{
    
    public float speed = 8f;
    private Rigidbody2D rbody;
    private Vector2 screenBounds;

    void Start()
    {
        rbody = this.GetComponent<Rigidbody2D>();
        rbody.velocity = new Vector2(-speed,0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z)); 
    }
 
   void Update()
   {
        if(transform.position.x < screenBounds.x)
        {
            Destroy(this.gameObject);
        }
   }

}
