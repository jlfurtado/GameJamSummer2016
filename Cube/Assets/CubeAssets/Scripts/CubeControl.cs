using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
public class CubeControl : MonoBehaviour {

    Vector3 m_previousPos;
    Vector3 m_up;
    Vector3 m_heading;
    Vector3 m_right;

    [SerializeField]
    private GameObject m_objWithScoreManager;

    Rigidbody m_rigidBody;
    private Transform m_GroundCheck;
    [SerializeField] private float m_moveSpeed = 10;
    [SerializeField]
    private float m_rotateSpeed = 10;
    [SerializeField]
    private float m_jumpSpeed = 10;
    [SerializeField]
    private float m_groundDetectRadius = .10f;
    [SerializeField]
    private LayerMask m_WhatIsGround;
    ScoreManager m_scoreManager;
    

    private int m_colliderListLen = 0;

    private bool m_collided = false;
    private bool onGround = false;
    // Use this for initialization
    void Start () {
        m_up = new Vector3(0, 1.0f, 0);
        m_heading = new Vector3(0, 0, 1.0f);
        m_rigidBody = GetComponent<Rigidbody>();
        m_previousPos = transform.position;
        m_right = Vector3.Cross(m_up, m_heading);
        m_scoreManager = m_objWithScoreManager.GetComponent<ScoreManager>();
        m_GroundCheck = transform.Find("GroundCheck");
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == m_WhatIsGround)
        {
            m_rigidBody.AddForce(-m_heading * m_moveSpeed);
            
        }
       
        if(other.CompareTag("Collectible"))
        {
            Destroy(other.gameObject);
            m_scoreManager.AddScore(9001);
            //Debug.Log("Score: " + m_score + "\n");
        }

    }

    void FixedUpdate()
    {
        onGround = false;
        Collider[] colliders = Physics.OverlapSphere(m_GroundCheck.position, m_groundDetectRadius, m_WhatIsGround);
        for (int i = 0; i < colliders.Length; i++)
        {
            m_colliderListLen = colliders.Length;
            if (colliders[i].gameObject != gameObject)
            {
         
                onGround = true;
            }

        }

        transform.Rotate(m_up, CrossPlatformInputManager.GetAxis("Horizontal") * m_rotateSpeed * Time.deltaTime);
        m_heading =  Quaternion.Euler(0, CrossPlatformInputManager.GetAxis("Horizontal") * m_rotateSpeed * Time.deltaTime, 0) * m_heading;
        m_right = Quaternion.Euler(0, CrossPlatformInputManager.GetAxis("Horizontal") * m_rotateSpeed * Time.deltaTime, 0) * m_right;

        if (onGround)
        {
            m_rigidBody.AddForce(CrossPlatformInputManager.GetAxis("Vertical") * m_heading * m_moveSpeed);

            m_rigidBody.AddForce(CrossPlatformInputManager.GetAxis("Strafe") * m_right * m_moveSpeed);
        }
        if (onGround && CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            m_rigidBody.AddForce(m_up * m_jumpSpeed);
        }


    }


    // Update is called once per frame
    void Update () {

       
    }
}
