# C# 基础系统笔记（第1周 D4~D6）

## 一、变量、数据类型、运算符
### 1.1 变量与6种常用类型
### 1.2 声明、赋值、命名规范
### 1.3 运算符（算术 / 比较 / 逻辑 / 三元）
### 1.4 整数除法与强制类型转换

## 二、流程控制：条件与循环
### 2.1 if / else if / else
### 2.2 switch（注意break）
### 2.3 while 与 do-while
### 2.4 for 与 foreach
### 2.5 break 与 continue

## 三、数组
### 3.1 声明、初始化、下标、Length
### 3.2 遍历（for/foreach）与越界
### 3.3 键盘输入存数组、string.Join

## 四、方法
### 4.1 方法四件套、定义与调用
### 4.2 参数、返回值、return、卫语句
### 4.3 值类型传参是副本（重点坑）

## 五、第一个算法
### 5.1 冒泡排序（相邻比较交换）
### 5.2 打擂台求最大/最小值


## 一、变量、数据类型、运算符

### 1.1 变量与6种常用类型
- 变量＝装数据的"盒子"，必须先声明类型再使用
- int：整数，如 int level = 5;
- float：小数，字面量后面必须加 f，如 float speed = 5f;
- double：精度更高的小数（写小数默认就是它）
- bool：布尔，只有 true（真）/ false（假）两个值
- string：字符串/文字，用双引号，如 string name = "小明";
- char：单个字符，用单引号，如 char c = 'A';
> 我的例子：
    int avg = 21 ;
    float height = 1.6f;
    double PI = 3.1415926535;
    bool isAttack = true ;
    string grade = "BOSS";
    char littleMonster = 'A';
### 1.2 声明、赋值、命名规范
- 先声明再赋值：int a;  a = 3;
- 声明同时赋值：int a = 3;
- 同类型可一起声明：int a = 1, b = 2;
- 命名用小驼峰：第一个单词小写、后面单词首字母大写，如 playerName、moveSpeed
- 名字要见名知意，不要用 a、b、x（循环变量 i/j 除外）
> 我的例子：
    int eliteMonsterHp = 1000000;int weaponDamage = 250 ;

### 1.3 运算符
- 算术：+  -  *  /  %（% 是取余数，如 7%3=1）
- 比较：== != > < >= <=，比较结果是 bool（true/false）
- 逻辑：&&（并且）、||（或者）、!（取反）
- 三元运算符：条件 ? 成立时的值 : 不成立时的值
  例：int max = a > b ? a : b;   // a大取a，否则取b
- 字符串和别的内容拼接也用 +
> 我的例子：
    int num = 5;
    boll isEven = num % 2 == 0 ? true : false;

### 1.4 整数除法与强制类型转换  ⚠️重点
- int ÷ int 结果还是 int，小数部分直接丢掉：5 / 2 = 2
- 想得到 2.5，要让其中一个数变成小数：(double)5 / 2 = 2.5 或 5.0 / 2
- (double)x 这种写法叫"强制类型转换"；求平均值时最常用
> 我的例子：
    int a = 5 ; 
    int b = 2 ;
    folat c = a / b ; //c = 2 
          c = (float)a / b ;//c=2.5

## 二、流程控制：条件与循环

### 2.1 if / else if / else
- if (条件) { }：条件为 true 才执行，条件必须是 bool
- else if：多个分支时从上往下判断，命中一个就结束，不再往下
- else：以上都不满足时兜底执行
> 我的例子：（写成绩评级：>=90优秀，>=60及格，否则不及格）
    int score = 75;
     if 
     {(score >= 90) Console.Writeline("成绩优秀")；}
     else if 
     {(score >= 60) Console.Writeline("成绩及格")；}
     else { 
     Console.Writeline("成绩不及格")；}

### 2.2 switch
- 结构：switch(变量){ case 值: 语句; break; default: 语句; break; }
- ⚠️每个 case 末尾必须有 break，否则会"穿透"继续执行下一个case
- 适合"一个变量去匹配多个固定值"的场景
> 我的例子：（1→"攻击"，2→"防御"，3→"逃跑"，default提示输入有误）
int input = 2;
switch(input){
    case 1 :
    Console.Writeline("攻击")；
    break;
    case 2 :Console.Writeline("防御")；
    break;
    case 3 : 
    Console.Writeline("逃跑");
    break;
    default : 
    Console.Writeline("输入有误");
    break;

}
### 2.3 while 与 do-while
- while(条件){ }：先判断再执行，条件一开始就假就一次都不执行
- do { } while(条件);：先执行一次再判断，所以至少执行一次（⚠️末尾有分号）
- 循环里必须有让条件最终变假的动作（如 i++），否则死循环
> 我的例子：（用while把1~5累加；再写个do-while体会"至少一次"）
    int i = 0;
    int num = 0;
    while(i<=5)
    {
        num = num + i ;
        i++ ;
    }
    Console.WriteLine(sum);

### 2.4 for 与 foreach
- for(初始化; 条件; 每轮后动作){ }：适合"明确知道循环几次"
- foreach(类型 变量 in 数组){ }：依次取出每个元素，拿不到下标、不能改元素
> 我的例子：（for打印1到5；foreach遍历一个int数组）
  for (int i = 1;i <= 5;i++)
  {
    Console.Write(i + " ");
  }
  int[] arr = {5 ,6 , 7, 8 ,9};
  foreach(int s in arr)
  {
    Console.Write(s + " ");
  }

### 2.5 break 与 continue
- break：立刻结束、跳出**整个**循环
- continue：跳过**本轮**剩余语句，直接进入下一轮
> 我的例子：（打印1~5，遇到3用continue跳过它；再演示找到目标用break停下）
    for(int i = 1 ;i <= 5 ;i++)
    {
        if(i == 3){
            continue;
        }
        Console.Write(i + " ");
    }

## 三、数组

### 3.1 声明、初始化、下标、Length
- 数组：一串同类型数据排成一排，用一个名字管理
- 三种声明：
  int[] a = new int[5];          // 开5个空格子，默认都是0
  int[] b = new int[] { 1, 2, 3 };
  int[] c = { 1, 2, 3 };         // 最常用的简写
- 下标从 0 开始：c[0] 是第一个，最后一个是 c[c.Length - 1]
- Length：数组里元素的个数
> 我的例子：（声明一个数组，分别取出第一个、最后一个，并打印 Length）
    int[] arr = { 1, 2, 3, 4, 5};
    Console.WriteLine(arr[0]);
    Console.WriteLine(arr[arr.Length]);
    Console.WriteLine(arr.Length);

### 3.2 遍历（for / foreach）与越界  ⚠️
- for 遍历（能拿到下标 i）：
  for (int i = 0; i < arr.Length; i++) { ... arr[i] ... }
- foreach 遍历（只拿元素、拿不到下标、不能改元素）：
  foreach (int x in arr) { ... x ... }
- 越界：访问到 arr[arr.Length] 会报 IndexOutOfRangeException
  （所以条件是 i < Length，不是 <=）
> 我的例子：（分别用 for 和 foreach 遍历同一个数组并打印；口头说明写成 <= 会怎样）
    int[] arr = { 1, 2, 3, 4};
    for (int i = 0;i < arr.Length; i++)
    {
        Console.Write(arr[i] + "");
    }
    foreach (int s in arr)
    {
        Console.Write(s + " ");
    }
    //写成<=会取到arr[arr.Length]会报错

### 3.3 键盘输入存数组、string.Join
- 先 new 开空格子，再在 for 里把输入逐个存进去：
  int[] s = new int[3];
  s[i] = int.Parse(Console.ReadLine());   // ReadLine得到字符串，要Parse成整数
- string.Join("分隔符", 数组)：把整个数组拼成一串文字，方便一次打印
> 我的例子：（循环输入3个成绩存进数组，最后用 string.Join 一次性打印出来）
    int[] arr = new int[3];
    Console.WriteLine("请输入三个学生成绩");
    for (int i = 0; i <arr.Length; i++)
    {
        arr[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("三个学生成绩为:" + string.Join(" ",arr));

## 四、方法

### 4.1 方法四件套、定义与调用
- 方法＝把一段功能封装、起名字，可重复调用，避免重复写代码
- 四件套：返回类型 + 方法名 + 参数列表 + 方法体
- 定义位置：写在 class 里面、Main 外面，要加 static
- 结构：
  static 返回类型 方法名(参数列表)
  {
      方法体;
      return 返回值;
  }
- 调用：方法名(参数)；方法之间可以互相调用（如 GetAvg 里调 GetSum）
> 我的例子：（写 GetSum(int[] arr) 返回数组总和，并在 Main 里调用打印）
    static int GetSum(int[] arr)
{
    int sum = 0;
    for ( int i = 0; i < arr.Length; i++)
    {
        sum = sum + arr[i];
    }
    return sum;
} 
    static void Main(string[] args)
    {
        int[] a = { 1, 2, 3};
        Console.WriteLine(GetSum(a));
    }

### 4.2 参数、返回值、return、卫语句
- 参数：方法括号里"接收外部传进来的值"
- 返回值：方法算完交回的结果，类型要对上；不返回任何东西用 void
- return 两个作用：①把结果交回去 ②立刻结束整个方法
- 卫语句：方法开头先拦截非法情况、提前 return，让正常逻辑更平
> 我的例子：（写 GetLevel(int score)：<0或>100提前返回"非法"，>=90优秀，>=60及格，否则不及格）
    static string GetLevel(int score)
    {
        if(score <0 || score > 100)
        {
            return "非法";
        }
        if (score >= 90)
        {
            return "优秀";
        } 
        if (score >= 60)
        {
            return "及格";
        } 
        else return "不及格";
    }

### 4.3 值类型传参是副本  ⚠️重点坑
- int/double/bool/char 等值类型，传进方法时传的是"副本"
- 方法里改的是副本，不影响外面的原变量（这就是 Exchange 交换不了数组的原因）
- 现阶段对策：要改数组元素就在原地写，或让方法 return 结果回来（ref 以后学）
> 我的例子：（写 Change(int x){ x = 100; }，Main里 int n=1; Change(n); 再打印n，验证 n 还是1而不是100）
    static void Change(int x)
{
    x = 100;   // 方法里把副本改成100
}

static void Main(string[] args)
{
    int n = 1;
    Change(n);              
    Console.WriteLine(n);   
}


## 五、第一个算法

### 5.1 冒泡排序
- 思路：相邻两个两两比较，左边比右边大就交换；每走一轮，当前最大的"冒"到最右边归位
- 外层循环走 Length-1 轮
- 内层 j 从0到 Length-1-i（末尾已归位的不用再比）
- 用 temp 三行交换相邻的 arr[j] 和 arr[j+1]
- ⚠️因为用到 j+1，j 最多到倒数第二个，否则越界
> 我的例子：（对 {5,3,8,1,9,2} 冒泡，尽量默写，并打印每一轮结束后的数组）
        int[] num = { 5, 3, 8, 1, 9, 2};
        Console.WriteLine("排序前：" + string.Join(" ",num));
        for ( int i = 0; i < num.Length - 1; i++)
        {
            for ( int j = 0; j < num.Length - 1  -i ; j++)
            {
                if (num[j] > num[j + 1])
                {
                    int temp = num[j];
                    num[j] = num[j + 1];
                    num[j + 1] = temp;
                }
            }
            Console.WriteLine("第" + (i + 1) + "次交换后：" + string.Join(" ", num));
        }
        Console.WriteLine("排序后：" + string.Join(" " , num));

### 5.2 打擂台求最大 / 最小值
- 先假设第一个元素就是擂主：int max = arr[0];
  ⚠️初始用 arr[0]，不能用0，否则全负数数组会出错
- 从 i=1 开始遍历，谁比 max 大就更新 max
- 循环结束 return max;（求最小同理，用 < 比较）
> 我的例子：（写 Max(int[] arr) 方法并调用，用 {3,9,1,7} 和 {-3,-9,-1} 两组分别测）
    static int Max(int[] arr)
    {
        int max = arr[0] ;
        for (int i = 0; i < arr.Length;i++)
        {
            if(arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }

## 六、本周易错避坑清单（都是自己踩过的）

### 书写规范
1. 符号一律用英文：分号 ;  括号 () {}  引号 "" ''，别用中文全角
2. C# 区分大小写：Console.WriteLine（W、L大写）、GetComponent（C大写）
3. Console.ReadLine()/WriteLine() 前面的 Console. 不能丢
4. 变量先声明再用；同一作用域同名变量只声明一次，之后改值不再写类型
5. float 数值要加 f（5f）；char 用单引号'a'，string 用双引号"abc"

### 运算与流程
6. 整数除法丢小数：5/2=2；要 2.5 得 (double)5/2 或 5.0/2
7. 判断相等用 ==，单个 = 是赋值，别混
8. switch 每个 case 末尾必须 break，否则穿透
9. while 条件别写反，循环体里必须有让条件变假的动作（如 i++），否则死循环

### 数组与方法
10. 数组声明 int[] arr={...}，方括号里不写长度；下标从0、最后是 Length-1
11. 遍历条件 i<Length（不是<=）；i 是"下标"，arr[i] 才是"元素值"
12. 方法写在 Main 外、class 内，要 static；返回类型要和 return 的值对上
13. 值类型传进方法是"副本"，方法里改不到外面（交换数组元素要原地写）
14. 打擂台：擂主初始用 arr[0]，不要用0（全负数会错）
15. 冒泡：用到 j+1 就要保证不越界，交换用 temp 三行
16. string.Join("分隔符", 数组) 是两个参数，中间用逗号

