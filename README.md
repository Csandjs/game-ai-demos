# 游戏 AI 演示

从零开始学习 Unity 游戏开发与游戏 AI，记录所有练习 Demo 和学习笔记。

## 当前作品：MiniLevel 小游戏（W3）

第三人称 3D 小游戏：在场景中收集金币、躲避并击杀巡逻的敌人，包含完整的主菜单、暂停、设置、胜负结算和本地存档。

### 玩法

- **目标**：收集金币并消灭所有敌人
- **胜利条件**：消灭全部敌人
- **失败条件**：玩家血量归零

### 操作

| 按键 | 功能 |
|------|------|
| W A S D | 移动 |
| 空格 | 跳跃 |
| K | 攻击身边敌人 |
| Esc | 暂停 / 关闭设置面板 |

### 敌人 AI（有限状态机 FSM）

敌人用有限状态机实现三种状态，按与玩家的距离自动切换：

- **Patrol 巡逻**：在出生点附近两个巡逻点之间来回走；
- **Chase 追击**：玩家进入侦测范围（5 米）后转身追击；
- **Attack 攻击**：贴脸（1.5 米）后站住，每隔 1 秒造成 10 点伤害。

每帧流程：计算与玩家距离 → 三选一互斥切换状态 → switch 分发到对应行为。

## 目录结构

```
game-ai-demos/
├─ DailyPractice/                 # 每日 C# 控制台练习 + LeetCode
│  ├─ LeetCode/                   # 力扣（21 合并有序链表）
│  ├─ Day14_Exam/                 # D14 闭卷自测：四件套角色系统
│  └─ Day14_Examples/             # D14 换皮练习：static / enum / 单例
├─ FristScene/                    # Unity 主项目（文件夹名沿用最初拼写）
│  └─ Assets/
│     ├─ Scenes/
│     │  ├─ MenuScene             # 主菜单（Build 0）
│     │  └─ MiniLevel             # 关卡（Build 1）
│     ├─ Scripts/
│     │  ├─ Player/               # 玩家移动、血量
│     │  ├─ Enemy/                # 敌人 AI、生成器
│     │  ├─ Items/                # 金币、陷阱
│     │  ├─ UI/                   # 菜单、血条、结算
│     │  └─ Game/                 # GameManager、AudioManager
│     ├─ Audio/                   # 音效素材
│     └─ Materials/               # 材质
├─ Helloworld/                    # C# 控制台 HelloWorld 入门项目
├─ selfintro/                     # 自我介绍练习
├─ notes/                          # 学习笔记与打卡记录
│  ├─ checkin.md                  # 每日打卡表
│  ├─ StudyNotes.md               # 每日学习笔记
│  ├─ cheatsheets.md              # 速查表
│  ├─ CSharp_Basics.md            # C# 基础笔记
│  ├─ week1.md                    # 第 1 周总结
│  └─ week2.md                    # 第 2 周总结
├─ .gitignore
└─ README.md
```

## 阶段作品

- **MiniLevel（W3 整合作品）**：完整可玩小游戏。主菜单 → 关卡，WASD 移动 / 空格跳跃（Animator 动画），吃金币加分（事件驱动 UI），敌人 AI 三态（巡逻 / 追击 / 攻击），K 键反击，AudioManager 音效，胜负结算，音量 + 最高分 PlayerPrefs 存档。
- **MiniLevel（W2 里程碑）**：第一个完整可玩小关，镜头跟随、WASD 移动、空格跳跃（射线地面检测防空跳）、吃金币加分、终点弹胜利文字并锁定操作，全局由 GameManager 单例统一管理。
- **Practice_Rebuild**：空场景脱稿训练场，不看教程独立搭出刚体移动 + 触发检测。
- **Day14_Exam**：W2 闭卷自测，脱稿写出 Character 基类 + Player/Enemy 子类 + IDamageable 接口的回合制对战系统，一次跑通。

## 学习进度

### 第 1 周（W1）：C# 基础 + Unity 入门

- ✅ D1（9/3）：环境搭建 + GitHub 仓库 + C# HelloWorld
- ✅ D2（9/4）：Unity 安装 + 第一个场景 + 角色移动脚本
- ✅ D3（9/5）：简历骨架 + 打卡表 + 仓库整理
- ✅ D4（9/6）：C# 变量 / 类型 / 运算符 + Unity Transform 实操
- ✅ D5（9/8）：C# 条件 / 循环 + Unity 刚体物理移动与跳跃
- ✅ D6（9/9）：C# 数组 / 方法 + Unity 预制体 / 输入控制
- ✅ D7（9/10）：第一周复盘

### 第 2 周（W2）：面向对象 + 物理 + 可玩小关

- ✅ D8（9/11）：C# 面向对象 + 物理碰撞
- ✅ D9（9/12）：C# 继承 + 多态 + Unity 角色移动优化
- ✅ D10（9/13）：C# 多态 + 抽象类 + Unity 触发器 / 吃金币
- ✅ D11（9/14）：C# 接口 interface + Unity 接口实现
- ✅ D12（9/15）：封装 / 继承 / 多态 / 接口四件套整合 + 简单工厂
- ✅ D13（9/16）：C# 查漏（static / enum / namespace）+ 单例 + 可玩小关
- ✅ D14（9/17）：W2 复盘 + 闭卷自测（四件套 / static / enum / 单例）

### 第 3 周（W3）：委托事件 + 集合 + 动画 + UI + 整合

- ✅ D15（9/19）：委托 delegate / 事件 event / Action / Func + Unity 事件驱动
- ✅ D16（9/21）：Lambda + List 泛型集合 + Unity 批量生成管理
- ✅ D17（9/23）：Dictionary 字典 + Animator 动画 + 静态配置表
- ✅ D18（10/12）：Unity UI 系统（菜单 / 按钮 / Slider / 场景切换 / 暂停）
- ✅ D19（10/13）：状态机完善 + 主菜单设置 + PlayerPrefs 存档 + 事件解耦
- ✅ D20（10/14）：W3 整合，敌人 AI 状态机 + 玩家攻击 + 音效系统 + 完整流程

## 技术栈

- **语言**：C#
  - 面向对象：封装 / 继承 / 多态 / 接口 / 抽象类
  - 核心语法：流程控制、数组、方法、属性、static、enum、namespace、单例
  - 进阶：委托与事件、Lambda、List\<T>、Dictionary\<K,V>
- **引擎**：Unity（团结引擎 Tuanjie 1.10.2 / 编辑器 2022.3.62t14）
  - 物理：Rigidbody、Collider、OnCollision / OnTrigger、Raycast
  - UI：UGUI（Canvas、Button、Text、Slider、Panel）
  - 动画：Animator 状态机
  - 音频：AudioSource、AudioListener、AudioManager
  - 其他：SceneManager 场景切换、PlayerPrefs 本地存档
- **版本控制**：Git / GitHub
- **开发工具**：VS Code

## 后续计划

- 游戏 AI：状态机（已入门）→ 行为树、寻路算法（A*、NavMesh）
- 继续：2D / 3D 小游戏 Demo 开发
