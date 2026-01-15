// See https://aka.ms/new-console-template for more information
 int FindMax(int[] nums)
{
    int max = 0;
    if ( nums==null || nums.Length == 0)
    {
        throw new ArgumentException("Array is empty");
    }
    else
    {
        max= nums[0];
        foreach (int num in nums)
        {
            if (num > max)
            {
                max = num;
            }
        }
    }
    return max;
}
int[] chkmax = { 2,3,5,10,-2,25};
int result = FindMax(chkmax);
Console.WriteLine("Maxcimum Number is:"+result);
Console.ReadLine();

