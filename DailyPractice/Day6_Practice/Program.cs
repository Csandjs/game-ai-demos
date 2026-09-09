using System ;
class Program
{
    static int GetSum(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum +=arr[i];
        }
        return sum ;
    }
    static double GetAvg(int[] arr)
    {
        int sum = GetSum(arr);
        double avg = (double)sum / arr.Length ;
        return avg ;
    }

    static int GetMax(int[] arr)
    {
        int max = arr[0];
        for (int i = 0 ; i < arr.Length;i++)
        {
        if (max < arr[i])
        max = arr[i];
        }
        return max;
    }
    static int GetMin(int[] arr)
    {
        int min = arr[0];
        for (int i =0;i < arr.Length ;i++)
        {
            if (min > arr[i])
            min = arr[i];
        }
        return min;
    }
    // 返回一段文字(string)：判断成绩等级
    static string GetLevel(int score)
    {
    // 卫语句：开头先拦截"非法数据"，不合法就立刻return结束，后面正常逻辑不再执行
        if (score < 0 || score > 100)   // || 读作"或者"：小于0 或 大于100
        {
            return "成绩非法";
        }

        if (score >= 90)
        {
            return "优秀";    // 命中就立刻返回，方法到此结束
        }
        if (score >= 60)
        {
            return "及格";
        }
        return "不及格";       // 能走到这，说明前面都没命中
    }
    //冒泡排序方法
     static void Exchange(int a ,int b)
    {
        int temp = a ;
        a = b ;
        b = temp;
    }
    //Day6晚作业
    static int Max(int[] arr)
    {
        int mmax = arr[0] ;
        for (int i = 0; i < arr.Length;i++)
        {
            if(arr[i] > mmax)
            {
                mmax = arr[i];
            }
        }
        return mmax;
    }

    static void Main(string[] args)
    {
        // int [] scores = new int[5];
        // for (int i = 0 ;i < scores.Length ; i++)
        // {
        //     Console.WriteLine("请输入第" + (i+1) + "个学生的成绩：");
        //     scores[i] = int.Parse(Console.ReadLine());
        // }
        // for (int i = 0;i < scores.Length;i++)
        // {
        //     Console.WriteLine("第" + (i+1) + "学生的成绩：" + scores[i] + "，评级：" +GetLevel(scores[i]) );
        // }
        // Console.WriteLine("----------汇总---------");
        // Console.WriteLine("总分：" + GetSum(scores));
        // Console.WriteLine("平均分：" + GetAvg(scores));
        // Console.WriteLine("最高分：" + GetMax(scores));
        // Console.WriteLine("最低分：" + GetMin(scores));

        // foreach(int s in scores)
        // {
        //     Console.Write(s + " ");
        // }
        int[] nums = {9,8,7,6,5,4};
        Console.WriteLine("排序前：" + string.Join(" ",nums));

        for(int i = 0 ;i < nums.Length-1 ; i++)
        {
            for (int j = 0;j < nums.Length - 1-i;j++ )
            {
                if (nums[j] > nums[j + 1])
                {
                    int temp = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = temp;
                }
            }
            Console.WriteLine("第" + (i + 1) + "轮交换后：" + string.Join(" " ,nums) );
        }
        Console.WriteLine("排序后：" + string.Join(" ",nums));

        int [] test = { 3, 9,1,7,5};
        Console.WriteLine("最大值是：" + Max(test));
    }
}