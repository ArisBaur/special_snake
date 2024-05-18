using UnityEngine;
using UnityEngine.AI;

public class ZombieBehaviour : MonoBehaviour
{

    private float speed = -3f;

    void Start()
    {
       
    }

    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
}