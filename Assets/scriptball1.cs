using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptball1 : MonoBehaviour
{
    public int speed = 30;
    public Rigidbody2D sebuah;
    // Start is called before the first frame update
    void Start()
    {
        sebuah.velocity = new Vector2(-1, -1) * speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.name=="DindingKanan" || other.collider.name=="DindingKiri"){
            StartCoroutine(jeda());
        }
    }
    IEnumerator jeda(){
        sebuah.velocity = new Vector2(0,0)*speed;
        GetComponent<Transform>().position = new Vector2(8,0);
        yield return new WaitForSeconds(1);
        sebuah.velocity = new Vector2(-1, -1) * speed;

        
        
}
}
