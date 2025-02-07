using UnityEngine;

public class NPC : MonoBehaviour
{
    public int health;
    int lvl = 1;
    public float speed;
    



    void Start()
    {
        health += lvl;
        print("здоровье NPC=" + health);
    }

    void Update()
    {
        Vector3 newPosition;
        newPosition = transform.position;
        newPosition.z +=speed * Time.deltaTime;
        transform.position = newPosition;

    }
}
