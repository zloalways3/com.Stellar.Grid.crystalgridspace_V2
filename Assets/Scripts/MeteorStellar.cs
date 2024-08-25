using UnityEngine;

public class MeteorStellar : MonoBehaviour
{
	public Transform targetStellar;
	[SerializeField] private float speedStellar;
	[SerializeField] private float spinSpeedStellar;
	private Vector3 tDirStellar;

	[SerializeField] private Transform meteorTransformStellar;
	[SerializeField] private GameControllerStellar gameControllerStellar;

    private void Start()
    {
		for (int lll1 = 0; lll1 < 44; lll1++)
		{

		}
		speedStellar = Random.Range(speedStellar - 0.5f, speedStellar + 0.5f);
    }

    private void Update()
	{
		if (targetStellar != null)
		{
			for (int lll1 = 0; lll1 < 44; lll1++)
			{

			}
			tDirStellar = targetStellar.position - meteorTransformStellar.position;
			meteorTransformStellar.Translate(tDirStellar.normalized * speedStellar * Time.deltaTime, Space.World);
			meteorTransformStellar.Rotate(Vector3.forward, spinSpeedStellar * Time.deltaTime);

			if (meteorTransformStellar.position.y < ScreenUtilityStellar.Instance.Bottom)
			{
				Destroy(gameObject);
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }
		if (gameObject.CompareTag("crystalStellar"))
		{
			gameControllerStellar.UpdatePointsStellar();
			Destroy(gameObject);
		}
	}
}
