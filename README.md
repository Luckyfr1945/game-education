# 🏆 Premium Quiz Game Remake

A high-quality, modern educational quiz game built with **Unity** and **C#**. This project focuses on premium UI/UX design, smooth transitions, and a robust category-based quiz system.

## ✨ Key Features
- **Modern UI Design**: Utilizing TextMeshPro for crisp visuals and neon-accented aesthetics.
- **Smooth Transitions**: Integrated `CanvasGroup` fading system for seamless menu navigation.
- **Category Selection**: Choose between different subjects like Math and IPA (Science).
- **Level System**: Modular level selection prepared for progressive difficulty.
- **ScriptableObject System**: Easily manage questions and answers directly from the Unity Inspector without touching the code.

## 🛠️ Technology Stack
- **Engine**: Unity 2022.3+ / Unity 6
- **Language**: C#
- **UI System**: Unity UI (uGUI) + TextMeshPro
- **Animation**: Coroutine-based Lerp for UI fading

## 📂 Project Structure
- **/Assets/Scripts**: Contains core logic scripts (`MainMenuManager`, `QuizManager`, `QuestionData`).
- **/Assets/Prefabs**: UI templates for buttons and panels.
- **/Assets/Scenes**: The main game scene.

## 🚀 Getting Started
1. **Setup Canvas**: Ensure the `Canvas Scaler` is set to `Scale With Screen Size` (1920x1080).
2. **Managers**: Create an empty GameObject named `Managers` and attach the `MainMenuManager.cs`.
3. **Link UI**: Drag your `DashboardPanel`, `CategoryPanel`, and `LevelPanel` into the inspector slots of the Managers object.
4. **Create Questions**: Right-click in the Project window > `Create > Quiz > Question` to add new questions via ScriptableObjects.

## 📜 Scripts Overview
- **`MainMenuManager.cs`**: Handles the flow from Dashboard -> Category -> Level selection.
- **`QuizManager.cs`**: Manages the gameplay logic, score, and question loading.
- **`QuestionData.cs`**: The data structure for individual questions.

---
*Created with passion for Education and Premium Design.*
*contribution : mbinn-spec, Luckyfr1945*
