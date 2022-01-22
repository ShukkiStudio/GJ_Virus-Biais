using UnityEngine;

/// <summary>
/// Scriptable Object containing informations for placing units on specific tiles
/// </summary>
[CreateAssetMenu(fileName ="Unit Placement Info", menuName ="Shukki/Units/Unit Placement Info")]
public class UnitPlacementInfoSO : ScriptableObject
{
    public GameObject m_UnitPrefab = null;
    public Transform m_TileTransform = null;
}
