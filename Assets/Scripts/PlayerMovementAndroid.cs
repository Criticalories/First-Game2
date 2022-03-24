using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementAndroid : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float forwardForce;
    [SerializeField] private float sidewaysForce;
    [SerializeField] private float maxSpeed;

    public Joystick joystick;
    private Vector3 horizontally;
    public Vector3 m_myPosition;
    public RectTransform m_NewTransform;

    void Start()
    {
        maxSpeed = 2f;
        double width = Screen.width - (Mathf.Sqrt(Screen.width / 434)) * 115;
        double height = 120 + (4* Mathf.Exp(Screen.width / 494));
        m_myPosition.x = (float)width;
        m_myPosition.y = (float)height;
        m_NewTransform.position = m_myPosition;
        
        
    }
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        horizontally.x = joystick.Horizontal * maxSpeed;
        
        rb.AddForce(horizontally.x, 0, 0, ForceMode.VelocityChange);
       

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
