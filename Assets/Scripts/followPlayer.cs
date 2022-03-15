using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        //transform.position = FindObjectOfType<Transform>().position + offset;
        //Debug.Log(transform.position.ToString());
        //Debug.Log(offset);
        //Debug.Log(FindObjectOfType<GameObject>().name);
        transform.position = player.position + offset;
    }
}
