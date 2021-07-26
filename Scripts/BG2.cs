using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG2 : MonoBehaviour
{
    public float speed;
    private MeshRenderer m_renderer;
    private Vector2 save_offset;
    void Awake()
    {
        m_renderer = GetComponent<MeshRenderer>();
    }
    private void Update()
    {
        float x = Time.time * speed;
        Vector2 offset = new Vector2(x, 0);
        m_renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
    private void OnDisable()
    {
        m_renderer.sharedMaterial.SetTextureOffset("_MainTex", save_offset);

    }
}
