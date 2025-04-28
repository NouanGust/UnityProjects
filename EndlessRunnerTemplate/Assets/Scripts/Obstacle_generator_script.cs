using UnityEngine;

public class Obstacle_generator_script : MonoBehaviour
{
    public GameObject obstacle;

    public float MinSpeed;
    public float MaxSpeed;
    public float CurrentSpeed;
    public float speedMultiplier;
    void Awake()
    {
        CurrentSpeed = MinSpeed;
        generateObstacle();
    }

    public void GenereateNextObstacleWithGap(){
        float randomWait = Random.Range(0.1f, 1.2f);
        Invoke("generateObstacle", randomWait);
    }

    public void generateObstacle(){
        GameObject ObstacleIns = Instantiate(obstacle, transform.position, transform.rotation);

        ObstacleIns.GetComponent<Obstacle_script>().obstacleGenerator = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(CurrentSpeed < MaxSpeed){
            CurrentSpeed += speedMultiplier;
        }
        
    }
}
