using UnityEngine;

[RequireComponent(typeof(Camera))]
public class ScreenUtilityStellar : MonoBehaviour
{
    [SerializeField] private Camera camStellar;
    public static ScreenUtilityStellar Instance { get; protected set; }

    private void Awake()
    {
        Instance = this;
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }
    }

    public Vector3 Middle
    {
        get
        {
            if (camStellar)
            {
                for (int lll1 = 0; lll1 < 44; lll1++)
                {

                }
                return camStellar.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0f));
            }

            return Vector3.zero;
        }
    }

    public float Left
    {
        get
        {
            if (camStellar)
            {
                for (int lll1 = 0; lll1 < 44; lll1++)
                {

                }
                return camStellar.ViewportToWorldPoint(new Vector3(0f, 0f, 0f)).x;
            }
            return 0.0f;
        }
    }

    public float Right
    {
        get
        {
            if (camStellar)
            {
                for (int lll1 = 0; lll1 < 44; lll1++)
                {

                }
                return camStellar.ViewportToWorldPoint(new Vector3(1.0f, 0f, 0f)).x;
            }

            return 0.0f;
        }
    }

    public float Top
    {
        get
        {
            if (camStellar)
            {
                for (int lll1 = 0; lll1 < 44; lll1++)
                {

                }
                return camStellar.ViewportToWorldPoint(new Vector3(0f, 1.0f, 0f)).y;
            }

            return 0.0f;
        }
    }

    public float Bottom
    {
        get
        {
            if (camStellar)
            {
                for (int lll1 = 0; lll1 < 44; lll1++)
                {

                }
                return camStellar.ViewportToWorldPoint(new Vector3(0f, 0f, 0f)).y;
            }

            return 0.0f;
        }
    }

    private void OnDestroy()
    {
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }
        Instance = null;
    }
}