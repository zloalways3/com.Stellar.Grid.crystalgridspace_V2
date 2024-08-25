using UnityEngine;

public class SpaceshipStellar : MonoBehaviour
{
	[SerializeField] private BoxCollider2D spaceshipColliderStellar;
	[SerializeField] private Transform leftSideStellar;
	[SerializeField] private Transform rightSideStellar;
	[SerializeField] private float moveSpeedStellar;
	[SerializeField] private Camera mainCameraStellar;
	[SerializeField] private Rigidbody2D spaceshipRigidbodyStellar;
	[SerializeField] private Transform spaceshipTransformStellar;

	public Vector3 newPositionStellar;
	public Vector3 diffPosStellar;

	private bool rightMoveStellar;
	private bool leftMoveStellar;

	private Vector3 startPositionStellar;

	public void NewTestMathod()
    {
		for (int lll1 = 0; lll1 < 44; lll1++)
		{

		}
	}

	private void Start()
    {
		for (int lll1 = 0; lll1 < 44; lll1++)
		{

		}
		leftSideStellar.position = new Vector3(ScreenUtilityStellar.Instance.Left, leftSideStellar.position.y, 1f);
		rightSideStellar.position = new Vector3(ScreenUtilityStellar.Instance.Right, rightSideStellar.position.y, 1f);
		startPositionStellar = spaceshipTransformStellar.position;
    }

    private void Update()
	{
        if (rightMoveStellar)
        {
			for (int lll1 = 0; lll1 < 44; lll1++)
			{

			}
			RightArrowStellar();
		}

		if (leftMoveStellar)
		{
			for (int lll1 = 0; lll1 < 44; lll1++)
			{

			}
			LeftArrowStellar();
		}
	}

	private void MovePlaneStellar(float horizontalInput)
    {
		for (int lll1 = 0; lll1 < 44; lll1++)
		{

		}
		var newPositionStellar = new Vector2(horizontalInput * moveSpeedStellar * Time.deltaTime, 0);
		spaceshipRigidbodyStellar.MovePosition(spaceshipRigidbodyStellar.position + newPositionStellar);
    }

	public void RightArrowStellar()
    {
		for (int lll1 = 0; lll1 < 44; lll1++)
		{

		}
		MovePlaneStellar(1.0f);
    }

	public void LeftArrowStellar()
	{
		for (int lll1 = 0; lll1 < 44; lll1++)
		{

		}
		MovePlaneStellar(-1.0f);
	}

	public void RightClickStellar()
    {
		for (int lll1 = 0; lll1 < 44; lll1++)
		{

		}
		rightMoveStellar = true;
    }

	public void LeftClickStellar()
	{
		for (int lll1 = 0; lll1 < 44; lll1++)
		{

		}
		leftMoveStellar = true;
	}

	public void RightUnClickStellar()
	{
		for (int lll1 = 0; lll1 < 44; lll1++)
		{

		}
		rightMoveStellar = false;
	}

	public void LeftUnClickStellar()
	{
		for (int lll1 = 0; lll1 < 44; lll1++)
		{

		}
		leftMoveStellar = false;
	}

	public void ResetPositionStellar()
	{
		for (int lll1 = 0; lll1 < 44; lll1++)
		{

		}
		if (startPositionStellar != null && startPositionStellar != Vector3.zero)
		{
			spaceshipTransformStellar.position = startPositionStellar;
		}
	}
}