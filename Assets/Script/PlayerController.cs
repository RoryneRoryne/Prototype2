using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10f;
    public float xRange = 10f;
    int lives = 3;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        //agar player dapat menerima input dan dapat bergerak ke kiri dan ke kanan.
        //an input to make object move left to right.
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //an input to make object move front to back
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime *speed);
        
        //agar player tidak keluar dari arena, player akan tersangkut ketika akan melewati titik tertentu.
        //to make an object doesn't go out of certain range.
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //untuk meluncurk projectile saat tombol spasi dipencet.
        //to summon projectile whenever hit space button.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Instantiate membuat copy dari sebuah objek.
            //Instantiate can copy certain object.
            //jadi Instantiate disin akan digunakan untuk memunculkan copy dari projectile.
            //thats why Instantiate being use to make a copy of projectile.
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }

    //whenever collider hit something, it will destroy the object
    private void OnTriggerEnter(Collider other)
    {
        //hanya menghancurkan object yang tidak bertag projectile
        //only destroy gameObject if it's not tag projectile
        if (other.gameObject.tag != "Projectile")
        {
            lives --;
            if (lives < 3)
            {
                Debug.Log("lives =" + lives);
            }
            if (lives < 1)
            {
                Destroy(gameObject);
                Debug.Log("Game Over!");
            }  
        }

    }
}
