using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(FinishPanel))]
public class NextLevelLoader : MonoBehaviour
{
    [SerializeField] private string _nextLevel;

    private FinishPanel _finishPanel;

    private void Awake()
    {
        _finishPanel = GetComponent<FinishPanel>();
    }

    private void OnEnable()
    {
        _finishPanel.ButtonClicked += OnButtonClicked;
    }

    private void OnDisable()
    {
        _finishPanel.ButtonClicked -= OnButtonClicked;
    }

    private void OnButtonClicked()
    {
        Scene loadedScene = SceneManager.GetSceneByName(_nextLevel);

        if (loadedScene.buildIndex != -1)
            SceneManager.LoadScene(loadedScene.buildIndex);
        else
            throw new System.Exception("Scene name incorrect");
    }
}