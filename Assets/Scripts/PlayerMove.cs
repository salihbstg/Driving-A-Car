using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMove : MonoBehaviour
{
    public float hiz = 3f,donmeHizi=3f;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    private void FixedUpdate()
    {
        float hori = Input.GetAxis("Horizontal")*donmeHizi;
        float verti = Input.GetAxis("Vertical")*hiz;
        if (transform.position.y < 1f && verti>0)
        {
            rb.velocity = transform.forward * verti;
            Quaternion donme = Quaternion.AngleAxis(hori, Vector3.up);
            transform.rotation *= donme;
        }
        if (transform.position.y < 0.35f && verti < 0)
        {
            rb.velocity = transform.forward * verti;
            Quaternion donme = Quaternion.AngleAxis(hori*-1, Vector3.up);
            transform.rotation *= donme;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
              transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
            
        
        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y<0.31f)
        {
            rb.velocity += new Vector3(0f, 15f, 0f);
            
        }
        


    }
}
