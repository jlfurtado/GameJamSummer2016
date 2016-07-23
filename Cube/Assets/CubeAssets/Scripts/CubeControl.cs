using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
public class CubeControl : MonoBehaviour {

    Vector3 m_previousPos;
    Vector3 m_up;
    Vector3 m_heading;

    Rigidbody m_rigidBody;

    [SerializeField] private float m_moveSpeed = 10;
    [SerializeField]
    private float m_rotateSpeed = 10;
    private bool m_collided;
    // Use this for initialization
    void Start () {
        m_up = new Vector3(0, 1.0f, 0);
        m_heading = new Vector3(0, 0, 1.0f);
        m_rigidBody = GetComponent<Rigidbody>();
        m_previousPos = transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject != this.gameObject)
        {
            m_rigidBody.AddForce(-m_heading * m_moveSpeed);

        }
       
    }

    void FixedUpdate()
    {
        transform.Rotate(m_up, CrossPlatformInputManager.GetAxis("Horizontal") * m_rotateSpeed * Time.deltaTime);
        m_heading =  Quaternion.Euler(0, CrossPlatformInputManager.GetAxis("Horizontal") * m_rotateSpeed * Time.deltaTime, 0) * m_heading;
        m_rigidBody.AddForce(CrossPlatformInputManager.GetAxis("Vertical") *  m_heading * m_moveSpeed);
    }


    // Update is called once per frame
    void Update () {

       
    }
}
