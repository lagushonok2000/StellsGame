using UnityEngine;

public class FinishPointsTrigger : MonoBehaviour
{
    [SerializeField] private ChekPoints _checkPointsClass;
    [SerializeField] private int _nextLevel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _checkPointsClass.ChangeLevel(_nextLevel);
    }
}
