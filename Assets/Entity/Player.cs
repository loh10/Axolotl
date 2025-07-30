using UnityEngine;

public class Player : MonoBehaviour
{
    public EPlayerType playerType;


    #region Skin
    private int _skinBaseIndex;
    private int _skinHatIndex;
    private int _skinAccessoryIndex;

    private SpriteRenderer _skinBaseRenderer;
    private SpriteRenderer _skinHatRenderer;
    private SpriteRenderer _skinAccessoryRenderer;
    #endregion
}
