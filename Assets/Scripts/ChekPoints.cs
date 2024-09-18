using UnityEngine;
using UnityEngine.UI;
using static Cinemachine.DocumentationSortingAttribute;

public class ChekPoints : MonoBehaviour
{
    [SerializeField] private Transform[] _startLevels;
    [SerializeField] private Transform[] _finishLevels;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _defeatPanel;
    [SerializeField] private Button _restartButton;
    [SerializeField] private PlayerMovement _playerMov;

    private int _currentLevel;

    private void Start()
    {
        _restartButton.onClick.AddListener(RestartLevel);
    }

    public void ChangeLevel(int level)
    {
        _playerTransform.position = _startLevels[level].position;
        _currentLevel = level;
    }

    public void RestartLevel()
    {
        _defeatPanel.SetActive(false);
        _playerMov.enabled = true;
        _playerTransform.position = _startLevels[_currentLevel].position;

    }
}
