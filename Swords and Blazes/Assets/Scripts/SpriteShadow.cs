using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteShadow : MonoBehaviour
{

    public Vector2 offset = new Vector2(-3, -3);
    public Material shadowMaterial;
    public Color shadowColor;


    private SpriteRenderer sprRndCaster;
    private SpriteRenderer sprRndShadow;

    private Transform transCaster;
    private Transform transShadow;


    // Start is called before the first frame update
    void Start()
    {

        transCaster = transform;
        transShadow = new GameObject().transform;
        transShadow.parent = transCaster;
        transShadow.gameObject.name = "shadow";

        sprRndCaster = GetComponent<SpriteRenderer>();
        sprRndShadow = transShadow.gameObject.AddComponent<SpriteRenderer>();

        sprRndShadow.sortingLayerName = sprRndCaster.sortingLayerName;
        sprRndShadow.sortingOrder = sprRndCaster.sortingOrder - 1;

        sprRndShadow.material = shadowMaterial;
        sprRndShadow.color = shadowColor;



    }

    private void LateUpdate()
    {
        transShadow.position = new Vector2(transCaster.position.x + offset.x, transCaster.position.y + offset.y);
        sprRndShadow.sprite = sprRndCaster.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
