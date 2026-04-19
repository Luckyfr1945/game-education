using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenuManager : MonoBehaviour
{
    [Header("Panels")]
    public CanvasGroup dashboardPanel;
    public CanvasGroup categoryPanel;
    public CanvasGroup levelPanel;

    [Header("Dashboard Buttons")]
    public Button playButton;

    [Header("Category Buttons")]
    public Button mathButton;
    public Button ipaButton;

    private void Start()
    {
        // Set initial screen
        ShowPanel(dashboardPanel);
        HidePanel(categoryPanel);
        HidePanel(levelPanel);

        // Add listeners
        if (playButton != null) playButton.onClick.AddListener(() => Transition(dashboardPanel, categoryPanel));
        if (mathButton != null) mathButton.onClick.AddListener(() => OnCategorySelected("Math"));
        if (ipaButton != null) ipaButton.onClick.AddListener(() => OnCategorySelected("IPA"));
    }

    private void OnCategorySelected(string category)
    {
        Debug.Log("Selected Category: " + category);
        Transition(categoryPanel, levelPanel);
    }

    private void Transition(CanvasGroup from, CanvasGroup to)
    {
        StartCoroutine(SwitchPanel(from, to));
    }

    private IEnumerator SwitchPanel(CanvasGroup from, CanvasGroup to)
    {
        from.interactable = false;
        from.blocksRaycasts = false;

        yield return StartCoroutine(FadeCanvas(from, 1, 0, 0.3f));
        from.gameObject.SetActive(false);
        
        to.gameObject.SetActive(true);
        
        to.interactable = true;
        to.blocksRaycasts = true;

        yield return StartCoroutine(FadeCanvas(to, 0, 1, 0.3f));
    }

    private void ShowPanel(CanvasGroup panel)
    {
        if (panel == null) return;
        panel.alpha = 1;
        panel.interactable = true;
        panel.blocksRaycasts = true;
        panel.gameObject.SetActive(true);
    }

    private void HidePanel(CanvasGroup panel)
    {
        if (panel == null) return;
        panel.alpha = 0;
        panel.interactable = false;
        panel.blocksRaycasts = false;
        panel.gameObject.SetActive(false);
    }

    private IEnumerator FadeCanvas(CanvasGroup canvas, float start, float end, float duration)
    {
        float elapsed = 0f;
        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            canvas.alpha = Mathf.Lerp(start, end, elapsed / duration);
            yield return null;
        }
        canvas.alpha = end;
    }
}
