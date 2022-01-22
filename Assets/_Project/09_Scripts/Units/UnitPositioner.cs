using UnityEngine;

/// <summary>
/// Allows units to be placed on specific tiles
/// </summary>
public class UnitPositioner : MonoBehaviour
{
	[SerializeField] private UnitPlacementInfoSO m_UnitPlacementSO;


	public void PlaceUnit()
	{
		if (m_UnitPlacementSO.m_TileTransform != null)
		{
			InstantiateUnit(m_UnitPlacementSO.m_UnitPrefab, m_UnitPlacementSO.m_TileTransform);
		}

		m_UnitPlacementSO.m_UnitPrefab = null;
	}

	private void InstantiateUnit(GameObject _unitPrefab, Transform _tileTransform)
	{
		GameObject instantiatedUnit = Instantiate(_unitPrefab, _tileTransform);
	}
}
