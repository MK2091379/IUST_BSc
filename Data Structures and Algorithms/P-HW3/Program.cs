using System;
class GFG
{
	public static void findLongestPalindromicString(String text)
	{
		int N = text.Length;
		if (N == 0)
			return;
		N = 2 * N + 1;
		int[] L = new int[N];
		L[0] = 0;
		L[1] = 1;
		int C = 1;
		int R = 2;
		int i = 0;
		int iMirror;
		int expand = -1;
		int diff = -1;
		int maxLPSLength = 0;
		int maxLPSCenterPosition = 0;
		int start = -1;
		int end = -1;
		for (i = 2; i < N; i++)
		{ 
			iMirror = 2 * C - i;
			expand = 0;
			diff = R - i;
			if (diff >= 0)
			{
				if (L[iMirror] < diff)
					L[i] = L[iMirror];
				else if (L[iMirror] == diff && R == N - 1)
					L[i] = L[iMirror];
				else if (L[iMirror] == diff && R < N - 1)
				{
					L[i] = L[iMirror];
					expand = 1;
				}
				else if (L[iMirror] > diff)
				{
					L[i] = diff;
					expand = 1;
				}
			}
			else
			{
				L[i] = 0;
				expand = 1;
			}
			if (expand == 1)
			{
				try
				{
					while (((i + L[i]) < N &&
							(i - L[i]) > 0) &&
						(((i + L[i] + 1) % 2 == 0) ||
						(text[(i + L[i] + 1) / 2] ==
							text[(i - L[i] - 1) / 2])))
					{
						L[i]++;
					}
				}
				catch (Exception e)
				{
					continue;
				}
			}
			if (L[i] > maxLPSLength)
			{
				maxLPSLength = L[i];
				maxLPSCenterPosition = i;
			}
			if (i + L[i] > R)
			{
				C = i;
				R = i + L[i];
			}
		}
		start = (maxLPSCenterPosition -
				maxLPSLength) / 2;
		end = start + maxLPSLength - 1;
		int counter = 0;
		for (i = start; i <= end; i++)
			counter++;
		Console.WriteLine(counter);
	}
	public static void Main(string[] args)
	{
		String text1 = Console.ReadLine();
		findLongestPalindromicString(text1);
	}
}
