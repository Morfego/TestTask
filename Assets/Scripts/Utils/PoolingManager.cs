using System.Collections.Generic;
using UnityEngine;

public class PoolingManager : MonoBehaviour
{
    public static PoolingManager Instance;

    [SerializeField] private Transform m_poolParent;

    private Dictionary<GameObject, List<GameObject>> m_poolObjects = new Dictionary<GameObject, List<GameObject>>();

    public GameObject GetOrCreate(GameObject prefab, Vector3? position = null)
    {
        bool keyAlreadyExists = m_poolObjects.ContainsKey(prefab);

        if (keyAlreadyExists)
        {
            var poolGroup = m_poolObjects[prefab];

            for (int i = 0; i < poolGroup.Count; i++)
            {
                if (poolGroup[i] != null && poolGroup[i].activeSelf == false)
                {
                    if (position != null)
                        poolGroup[i].transform.position = (Vector3)position;

                    poolGroup[i].SetActive(true);
                    return poolGroup[i];
                }
            }
        }

        var spawnedObject = position == null ? Instantiate(prefab) : Instantiate(prefab, (Vector3)position, Quaternion.identity);
        spawnedObject.transform.SetParent(m_poolParent);

        if (!keyAlreadyExists)
            m_poolObjects.Add(prefab, new List<GameObject>());

        m_poolObjects[prefab].Add(spawnedObject);

        return spawnedObject;
    }

    private void Awake()
    {
        if (Instance != null)
            Destroy(gameObject);
        else
            Instance = this;
    }

    private void OnDestroy()
    {
        if (Instance == this)
            Instance = null;
    }
}
