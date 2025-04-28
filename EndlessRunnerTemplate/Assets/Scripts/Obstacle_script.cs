using Unity.VisualScripting;
using UnityEngine;

public class Obstacle_script : MonoBehaviour
{

    public Obstacle_generator_script obstacleGenerator;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * obstacleGenerator.CurrentSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.CompareTag("nextLine")){
        obstacleGenerator.GenereateNextObstacleWithGap();
       }

       if(collision.gameObject.CompareTag("finishLine")){
            Destroy(this.gameObject);
       }
    }
}
