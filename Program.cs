internal class Program
{
    /// <summary>
    /// Hàm tính tổng
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("CT cộng hai số:");

        int so1, so2, tong, hieu, tich;

        Console.Write("Nhập số thứ nhất: ");
        so1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        so2 = Convert.ToInt32(Console.ReadLine());

        tong = so1 + so2;
        hieu = so1 - so2;
        tich = so1 * so2;



        
        Console.WriteLine($"Tổng của hai số là: {tong}");
        Console.WriteLine($"Hiệu của hai số là: {hieu}");
        Console.WriteLine($"Tích của hai số là: {tich}");

        double thuong;
        try
        {
            thuong = so1 / so2;
            Console.WriteLine($"Thương của hai số là: {thuong}");

        }
        catch 
        {
            Console.WriteLine("Không thể chia cho số 0!");
        }


    }
}