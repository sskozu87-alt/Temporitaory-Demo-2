using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
   public float speed = 6;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-transform.up * speed * Time.deltaTime);
    }
}
