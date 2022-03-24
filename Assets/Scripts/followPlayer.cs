using UnityEngine;

public class followPlayer : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private Transform player;

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
