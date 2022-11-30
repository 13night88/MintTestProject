using UnityEngine;
using UnityEngine.UI;

public class RefOrientationChanger : MonoBehaviour
{
    [SerializeField]
    private Canvas canvas;

    private CanvasScaler scaler;

    private void Awake()
    {

        scaler = canvas.GetComponent<CanvasScaler>();
    }

    void Update()
    {
        if (Screen.orientation == ScreenOrientation.LandscapeLeft || Screen.orientation == ScreenOrientation.LandscapeRight)
        {
            scaler.referenceResolution = new Vector2(Mint.Constants.LANDSCAPE_HEIGHT_RESOLUTION, Mint.Constants.LANDSCAPE_WIDTH_RESOLUTION);
        }
        else
        {
            scaler.referenceResolution = new Vector2(Mint.Constants.PORTRAIT_HEIGHT_RESOLUTION, Mint.Constants.PORTRAIT_WIDTH_RESOLUTION);
        }
    }
}
