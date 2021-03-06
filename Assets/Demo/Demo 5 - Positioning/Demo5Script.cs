﻿using UnityEngine;
using UnityTileMap;

public class Demo5Script : MonoBehaviour
{
    public int TileX = 0;
    public int TileY = 0;

    private TileMapBehaviour m_tileMap;

    // Use this for initialization
    private void Start()
    {
        m_tileMap = GameObject.Find("TileMap").GetComponent<TileMapBehaviour>();
        if (m_tileMap == null)
            Debug.LogError("TileMapBehaviour not found");
    }

    // Update is called once per frame
    private void Update()
    {
        if (m_tileMap != null)
        {
            // Update position
            var tileBounds = m_tileMap.GetTileBoundsWorld(TileX, TileY);
            transform.position = new Vector3(tileBounds.xMin, tileBounds.yMin, 0.0f);
        }
    }
}
