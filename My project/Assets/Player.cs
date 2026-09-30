using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{    
public float speed = 4;
private int scoreVal = 0;
public TextMeshProUGUI scoreBox;
public int score = 0;
 //  update is called once per frame 
    void Update()
    {
       

        //traveling up
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(transform.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-transform.up * speed * Time.deltaTime);


        }
        transform.position = new Vector3(transform.position.x, 
                     Mathf.Clamp(transform.position.y, -3.5f, 3.5f), transform.position.z);
                     }
private void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.gameObject.tag == "Projectile")
    {
        if(collision.GetComponent<ProjectileMove>() != null)
            {
                scoreVal += collision.GetComponent<ProjectileMove>().points;
                scoreBox.text = "Score: " + scoreVal;
            }
        Destroy(collision.gameObject);
    }
    
        }
}

