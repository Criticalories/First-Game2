using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Vector3 offset;
    public Transform player;

    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
