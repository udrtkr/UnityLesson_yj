using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Transform tr; // Transform ÄÄÆ÷³ÍÆ® °¡Á®¿È
    public float moveSpeed;

    private void Awake()
    {
        tr = GetComponent<Transform>(); // À§Ä¡ ÁÂÇ¥ °¡Á®¿È??
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        tr.position += new Vector3(h * moveSpeed, 0, 0) * Time.deltaTime;
    }
}
