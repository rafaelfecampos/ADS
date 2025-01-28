class Sort
{   
    
    public void Sorte(int[] a)
    {
        Sort1(0, a);
    }
    private void Sort1(int i, int[] a)
    {
        int j, t;
        if (i < (a.Length - 1))
        {
            j = i;
            Min(i + 1, a, ref j);
            t = a[i];
            a[i] = a[j];
            a[j] = t;
            Sort1(i + 1, a);
        }
    }
    private void Min(int k, int[] a, ref int j)
    {
        if (k < a.Length)
        {
            if (a[k] < a[j])
                j = k;
            Min(k + 1, a, ref j);
        }
    }
}