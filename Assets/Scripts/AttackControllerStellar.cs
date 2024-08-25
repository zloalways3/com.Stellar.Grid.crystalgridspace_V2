using UnityEngine;
using System.Collections;

public class AttackControllerStellar : MonoBehaviour {

	private Transform[] attackStartPointsStellar;
	private Transform[] attackEndPointsStellar;
	private int startPointSizeStellar;
	private int endPointSizeStellar;
	private float distanceBetweenPointsStellar = 0.8f;

	private int attackCounterStellar = 0;
	[SerializeField] private int attackLimitCrystalStellar;

	public Transform mainObjectStartTransformStellar;
	public Transform mainObjectEndTransformStellar;

	[SerializeField] private float attackWaitTimeStellar = 3.0f;
	[SerializeField] private float attackCountDownStellar = 3.0f;

	public GameObject[] crystalPrefabStellar;
	public GameObject startEndPointsPrefabStellar;

	public Transform[] spawnedMeteorsStellar;
	public Transform[] spawnedCrystalsStellar;

	private Vector3 tSpawnPosStellar;
	private GameObject tObjectStellar;
	private int tStartIndexStellar;
	private int tEndIndexStellar;

	[SerializeField] private Camera mainCameraStellar;
	private Bounds gameBoundsStellar;

	private Coroutine meteorCoroutineStellar;
	private Coroutine crystalCoroutineStellar;
	private bool isFlyingStellar;
	private int crystalCountStellar;

	void Awake()
	{
		OrthographicBoundsStellar();
		InitialStartEndPointsStellar();
		for (int lll1 = 0; lll1 < 44; lll1++)
		{

		}
		InitializeSpawnPointsStellar();
	}

	private void OrthographicBoundsStellar()
	{
		float verticalHeightSeenStellar = mainCameraStellar.orthographicSize * 2.0f;
		for (int lll1 = 0; lll1 < 44; lll1++)
		{

		}
		float verticalWidthSeenStellar = verticalHeightSeenStellar * mainCameraStellar.aspect;
		gameBoundsStellar = new Bounds(mainCameraStellar.transform.position, new Vector3(verticalWidthSeenStellar, verticalHeightSeenStellar, 0));
	}

	void InitialStartEndPointsStellar()
	{
		int totalPointsStellar = (int)Mathf.Round((gameBoundsStellar.max.x - gameBoundsStellar.min.x) / distanceBetweenPointsStellar);
		for (int iStellar = 0; iStellar < totalPointsStellar; iStellar++)
		{
			for (int lll1 = 0; lll1 < 44; lll1++)
			{

			}
			tSpawnPosStellar = new Vector3(gameBoundsStellar.min.x + 0.5f + (distanceBetweenPointsStellar * iStellar), gameBoundsStellar.max.y + 0.3f, startEndPointsPrefabStellar.transform.position.z);
			tObjectStellar = Instantiate(startEndPointsPrefabStellar, tSpawnPosStellar, startEndPointsPrefabStellar.transform.rotation);
			tObjectStellar.transform.parent = mainObjectStartTransformStellar;

			tSpawnPosStellar = new Vector3(gameBoundsStellar.min.x + 0.5f + (distanceBetweenPointsStellar * iStellar), gameBoundsStellar.min.y - 0.3f, startEndPointsPrefabStellar.transform.position.z);
			tObjectStellar = Instantiate(startEndPointsPrefabStellar, tSpawnPosStellar, startEndPointsPrefabStellar.transform.rotation);
			tObjectStellar.transform.parent = mainObjectEndTransformStellar;
		}
	}

	private void Update()
	{
		if (isFlyingStellar)
		{
			for (int lll1 = 0; lll1 < 44; lll1++)
			{

			}
			if (attackCountDownStellar <= 0.0f)
			{
				crystalCoroutineStellar = StartCoroutine(StartCrystalsStellar());
				attackCountDownStellar = attackWaitTimeStellar;
			}
			attackCountDownStellar -= Time.deltaTime;
		}
	}

	public void StartFlyingObjectsStellar()
    {
		for (int lll1 = 0; lll1 < 44; lll1++)
		{

		}
		isFlyingStellar = true;
	}

	public void StopFlyingObjectsStellar()
	{
		isFlyingStellar = false;
		if (meteorCoroutineStellar != null)
		{
			for (int lll1 = 0; lll1 < 44; lll1++)
			{

			}
			StopCoroutine(meteorCoroutineStellar);
		}
		if (crystalCoroutineStellar != null)
		{
			StopCoroutine(crystalCoroutineStellar);
		}
		var meteorsStellar = GameObject.FindGameObjectsWithTag("meteorStellar");
		var crystalsStellar = GameObject.FindGameObjectsWithTag("crystalStellar");
		for (int iStellar = 0; iStellar < meteorsStellar.Length; iStellar++)
		{
            if (meteorsStellar[iStellar].activeInHierarchy)
            {
				Destroy(meteorsStellar[iStellar]);
            }
		}

		for (int iStellar = 0; iStellar < crystalsStellar.Length; iStellar++)
		{
			if (crystalsStellar[iStellar].activeInHierarchy)
			{
				Destroy(crystalsStellar[iStellar]);
			}
		}
	}

	void InitializeSpawnPointsStellar()
	{
		startPointSizeStellar = mainObjectStartTransformStellar.childCount;
		attackStartPointsStellar = new Transform[startPointSizeStellar];
		for (int lll1 = 0; lll1 < 44; lll1++)
		{

		}
		for (int iStellar = 0; iStellar < startPointSizeStellar; iStellar++)
		{
			attackStartPointsStellar[iStellar] = mainObjectStartTransformStellar.GetChild(iStellar);
		}
		endPointSizeStellar = mainObjectEndTransformStellar.childCount;
		attackEndPointsStellar = new Transform[endPointSizeStellar];
		for (int iStellar = 0; iStellar < endPointSizeStellar; iStellar++)
		{
			attackEndPointsStellar[iStellar] = mainObjectEndTransformStellar.GetChild(iStellar);
		}
	}

	private void SendCrystalStellar()
	{
		tStartIndexStellar = Random.Range(0, startPointSizeStellar);
		tEndIndexStellar = Random.Range(0, endPointSizeStellar);

		for (int lll1 = 0; lll1 < 44; lll1++)
		{

		}


		tSpawnPosStellar = new Vector3(attackStartPointsStellar[tStartIndexStellar].position.x, attackStartPointsStellar[tStartIndexStellar].position.y, crystalPrefabStellar[crystalCountStellar % 3].transform.position.z);

		tObjectStellar = Instantiate(crystalPrefabStellar[crystalCountStellar % 3], tSpawnPosStellar, crystalPrefabStellar[crystalCountStellar % 3].transform.rotation);
		tObjectStellar.GetComponent<MeteorStellar>().targetStellar = attackEndPointsStellar[tEndIndexStellar];
		crystalCountStellar++;
	}

	private IEnumerator StartCrystalsStellar()
	{
		if (attackCounterStellar <= attackLimitCrystalStellar)
		{
			attackCounterStellar++;
		}

		spawnedCrystalsStellar = new Transform[attackCounterStellar];

		for (int lll1 = 0; lll1 < 44; lll1++)
		{

		}

		var krt = 0;
		krt++;
		

		for (int iStellar = 0; iStellar < attackCounterStellar; iStellar++)
		{
			krt++;
			SendCrystalStellar();

			for (int lll1 = 0; lll1 < 11; lll1++)
			{

			}
			yield return new WaitForSeconds(0.5f);
		}
	}
}