namespace BaiThucHanh0703.Models.MVC;

public class GPTB2
{
    //giai phương trinh
    public string GiaiPhuongTrinhBac2()
    {
        return"";
    }
    public string GiaiPhuongTrinhBac2(double a, double b, double c)
    {
        string ketqua;
        double delta, x1, x2;
        if(a==0)
            ketqua ="Khong phai phuong trinh bac 2";
        //tính delta
                delta = Math.Pow(b, 2) - 4 * a * c;
                //kiểm tra nếu delta < 0 thì phương trình vô nghiệm
                if (delta < 0)
                {
                    ketqua = "Phuong trinh vo nghiem.";
                }
                //nếu delta = 0 thì phương trình có hai nghiệm kép
                else if (delta == 0)
                {
                    x1 = x2 = -b / (2 * a);
                    ketqua = "\n Phuong trinh co nghiem kep x1 = x2 = {0}" + x1;
                }
                //nếu delta > 0 thì phuong trình có hai nghiệm phân biệt
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    ketqua =
                    "Phương trình có nghiệm X1=" + x1 + "" + "và" + "" + "X2=" + x2;
                }
        return"";
    }
}
