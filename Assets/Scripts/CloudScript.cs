using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{
    public float speed;
    private Renderer rend;
    float offset;
    float offset2;
    public float speed2;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        offset += Time.deltaTime * speed;
        offset2 += Time.deltaTime * speed2;
        rend.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
        
    }
}
