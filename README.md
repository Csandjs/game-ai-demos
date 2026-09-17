# game-ai-demos

从零开始学习 Unity 游戏开发与游戏 AI，记录所有练习 Demo 和学习笔记。

## 目录结构

​```
game-ai-demos/
├── DailyPractice/       # 每日 C# 控制台练习（Day4 ~ Day14）
│   ├── Day14_Exam/      # D14 闭卷自测：四件套角色系统
│   └── Day14_Examples/  # D14 换皮练习：static / enum / 单例
├── FristScene/          # Unity 主项目（文件夹名沿用最初拼写）
│   └── Assets/Scenes/
│       ├── SampleScene      # 早期练习场景
│       ├── Practice_Rebuild # 空场景脱稿训练场
│       └── MiniLevel        # ★ 第一个完整可玩小关
├── HelloWord/           # C# 控制台 HelloWorld 入门项目
├── selfintro/           # 自我介绍练习
├── notes/               # 学习笔记与打卡记录
│   ├── checkin.md       # 每日打卡表
│   ├── StudyNotes.md    # 每日学习笔记
│   ├── CSharp_Basics.md # C# 基础笔记
│   ├── week1.md         # 第 1 周总结
│   └── week2.md         # 第 2 周总结
├── .gitignore
└── README.md
```

## 阶段作品

- **MiniLevel（W2 里程碑）**：第一个完整可玩小关。镜头跟随 → WASD 移动 / 空格跳跃（射线地面检测防空跳）→ 吃金币加分（Trigger 触发 + 分数 UI 实时刷新）→ 到终点弹胜利文字并锁定操作；全局由 GameManager 单例统一管理分数与游戏状态（enum 状态机）。已手机录屏存档。

## 学习进度

**第 1 周（W1）：C# 基础 + Unity 入门**

- ✅ D1（9/3）：环境搭建 + GitHub 仓库 + C# HelloWorld
- ✅ D2（9/4）：Unity 安装 + 第一个场景 + 角色移动脚本
- ✅ D3（9/5）：简历骨架 + 打卡表 + 仓库整理
- ✅ D4（9/6）：C# 变量/类型/运算符 + Unity Transform 实操
- ✅ D5（9/8）：C# 条件/循环 + Unity 刚体物理移动与跳跃
- ✅ D6（9/9）：C# 数组/方法 + Unity 预制体/输入控制
- ✅ D7（9/10）：第一周复盘

**第 2 周（W2）：面向对象 + 物理 + 可玩小关**

- ✅ D8（9/11）：C# 面向对象 + 物理碰撞优化
- ✅ D9（9/12）：C# 继承 + Unity 角色跳跃/移动优化
- ✅ D10（9/13）：C# 多态 + Unity 触发器/吃金币
- ✅ D11（9/14）：C# 接口 interface + Unity 接口实现
- ✅ D12（9/15）：封装/继承/多态/接口四件套整合成角色系统
- ✅ D13（9/16）：C# 查漏补缺（静态/枚举/命名空间）+ Unity 可玩小关
- ✅ D14（9/17）：W2 复盘 + 闭卷自测（脱稿四件套 / static / enum / 单例）+ MiniLevel 录屏存档

## 技术栈

- 语言：C#
- 引擎：Unity（团结引擎 Tuanjie 1.10.2 / 编辑器 2022.3.62t14）
- 版本控制：Git / GitHub
- 开发工具：VS Code

## 后续计划

- W3：委托 delegate / 事件 event / Lambda + Unity Animator 动画
- 继续：2D/3D 小游戏 Demo 开发
- 游戏 AI：状态机（enum 状态机已入门）、行为树、寻路算法
