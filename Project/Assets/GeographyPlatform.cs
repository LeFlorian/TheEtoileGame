using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeographyPlatform : MonoBehaviour
{
    public bool isActive = true;
    private Collider2D collider;
    private Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        // R�cup�rer les composants n�cessaires
        collider = GetComponent<Collider2D>();
        renderer = GetComponent<Renderer>();

        SetPlatformActive(isActive);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SetPlatformActive(bool isActive)
    {
        // Activer ou d�sactiver le Collider2D
        if (collider != null)
        {
            collider.enabled = isActive;
        }

        // Activer ou d�sactiver le Renderer
        if (renderer != null)
        {
            renderer.enabled = isActive;
        }
    }
}
