using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// Allow drag'n'drop on card image.
/// When dropped, try to place a unit on dropped tile
/// </summary>
public class DragCard : MonoBehaviour, IDragHandler, IDropHandler
{
    [SerializeField] private GameObject m_UnitPrefab;
    [SerializeField] private UnitPositioner m_UnitPositioner;
    [SerializeField] private UnitPlacementInfoSO m_UnitPlacementInfoSO;

    private Vector3 m_RootPosition;
    private bool m_FirstDrag = true;

    private void Awake()
    {
        m_RootPosition = transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (m_FirstDrag)
        {
            m_UnitPlacementInfoSO.m_UnitPrefab = m_UnitPrefab;
            m_FirstDrag = false;
        }
        transform.position = eventData.position;
    }

    public void OnDrop(PointerEventData eventData)
    {
        m_UnitPositioner.PlaceUnit();
        transform.position = m_RootPosition;
        m_FirstDrag = true;
    }
}
