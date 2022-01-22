using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// When Tile is being hovered by mouse, give UnitPlacementInfoSO its Transform in case card drag ends on it
/// </summary>
public class TileHover : MonoBehaviour
{
    [SerializeField] private Transform m_TileTransform;
    [SerializeField] private UnitPlacementInfoSO m_UnitPlacementInfoSO;


    private void OnMouseEnter()
    {
        m_UnitPlacementInfoSO.m_TileTransform = m_TileTransform;
    }

    private void OnMouseExit()
    {
        m_UnitPlacementInfoSO.m_TileTransform = null;
    }
}
