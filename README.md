\# Spiral Architecture - Starter Kit (ASP.NET Core MVC × TypeScript)



このリポジトリは、\*\*「スパイラルアーキテクチャ」\*\*が提唱する、堅牢かつ柔軟なDX基盤構築のためのスターターキットです。

ASP.NET Core MVC (C#) のバックエンド信頼性と、TypeScriptによるフロントエンドの型安全性を高度に融合させています。



\## 🏛 設計思想：Separation of Concerns (関心の分離)



本プロジェクトでは、ビジネスの成長を阻害しない「進化し続けるアーキテクチャ」を実現するため、以下の分離を徹底しています。



\- \*\*Business Logic \& Algorithm (C# / .NET Core):\*\*

&nbsp;   - データの整合性、計算ロジック、セキュリティを担保。

&nbsp;   - GUIから完全に独立させることで、将来的なマルチデバイス展開（モバイルアプリ等）にも耐えうる「資産」としてのコードを構築します。

\- \*\*Modern GUI Control (TypeScript):\*\*

&nbsp;   - JavaScriptのスーパーセットであるTypeScriptを採用。

&nbsp;   - 静的型付けにより、画面側のランタイムエラーを未然に防ぎ、保守コストを劇的に低減します。







\## 🛠 技術スタック



\- \*\*Backend:\*\* ASP.NET Core MVC (.NET 8/9+)

\- \*\*Frontend:\*\* TypeScript (ESNext)

\- \*\*Build Tool:\*\* npm / tsc (integrated with MSBuild)

\- \*\*Styling:\*\* Tailwind CSS (推奨)



\## 🚀 セットアップ手順



1\. \*\*リポジトリをクローン\*\*

&nbsp;  ```bash

&nbsp;  git clone \[https://github.com/your-username/spiral-starter-kit.git](https://github.com/your-username/spiral-starter-kit.git)

