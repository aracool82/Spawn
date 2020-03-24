using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] GameObject _container;
    [SerializeField] int _countSpawnObject;

    private List<GameObject> _pool = new List<GameObject>();

    protected void Init(GameObject prefab)
    {
        for (int i = 0; i < _countSpawnObject; i++)
        {
            GameObject spawned = Instantiate(prefab, _container.transform);
            spawned.SetActive(false);
            _pool.Add(spawned);
        }
    }

    protected bool TryGetObject(out GameObject result)
    {
        result = _pool.LastOrDefault(p=>p.activeSelf==false);
        return result!=null;
    }
 
}
