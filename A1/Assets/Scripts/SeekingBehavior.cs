using UnityEngine;

public class SeekBehavior : MonoBehaviour
{
    public GameObject targetPrefab; 
    public GameObject agentPrefab;
    public float speed = 5f;
    private GameObject agent;
    private GameObject target; // Reference to the instantiated target
    private bool isSeeking = false; // Flag to indicate if seeking behavior is active
    public Transform background;

    void Update()
    {
        if (isSeeking)
        {
            if (target != null)
            {

                //Vector3 direction = (target.transform.position - transform.position).normalized;
                Vector3 direction = (target.transform.position - agent.transform.position).normalized;


                //transform.Translate(direction * speed * Time.deltaTime);
                agent.transform.Translate(direction * speed * Time.deltaTime);


                RotateTowardsTarget(direction);
            }
        }
    }

    void RotateTowardsTarget(Vector3 direction)
    {
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * speed);
    }

    public void StartSeeking()
    {
        isSeeking = true;


        Vector3 targetPosition = new Vector3(Random.Range(0f, Screen.width), Random.Range(0f, Screen.height), 0f);
        target = Instantiate(targetPrefab, targetPosition, Quaternion.identity);



        Vector3 agentSpawnPosition = new Vector3(0f, Random.Range(0f, Screen.height), 0f);
        agent = Instantiate(agentPrefab, agentSpawnPosition, Quaternion.identity);


        // Orient the agent towards the target
        //Vector3 direction = targetPosition - transform.position;
        //transform.rotation = Quaternion.LookRotation(Vector3.forward, direction.normalized);
        Vector3 direction = targetPosition - agentSpawnPosition;
        agent.transform.rotation = Quaternion.LookRotation(Vector3.forward, direction.normalized);
    }
}

