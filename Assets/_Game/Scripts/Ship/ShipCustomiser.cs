using UnityEngine;

public class ShipCustomiser : MonoBehaviour
{
    public ShipAppearanceConfig AppearanceConfig;
    [SerializeField] GameObject ShipAppearance;

    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer _Temp = ShipAppearance.GetComponent<SpriteRenderer>();
        _Temp.sprite = AppearanceConfig.ShipeShape;
        _Temp.color = AppearanceConfig.ShipColor;
    }

    
}
