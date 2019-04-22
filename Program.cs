using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //���� �Ʒ��� �ʷϻ� ���� : ���� ���� �س��� ������� �ʾ��� �� ����
            var number = 100;
            //number="100";
            var lotto = 10000000000L;
            var str = "�ȳ��ϼ���";
            var this_double = 3.141592;
            var this_float = 3.14F;
            var this_bool = true;
            var this_char = 'H';

            Console.WriteLine("number:" + number.GetType());//System.Int32
            Console.WriteLine("lotto:" + lotto.GetType());//System.Int64
            Console.WriteLine("str:" + str.GetType());//System.String
            Console.WriteLine("this_double:" + this_double.GetType());//System.Double
            Console.WriteLine("this_float:" + this_float.GetType());//System.Single
            Console.WriteLine("this_bool:" + this_bool.GetType());//System.Boolean
            Console.WriteLine("this_char:" + this_char.GetType());//System.Char

            Console.WriteLine("int�� �ִ�:" + int.MaxValue);//�� 21��    2147483647
            Console.WriteLine("int�� �ִ�:" + int.MinValue);//-2147483647
            Console.WriteLine("long�� �ִ�:" + long.MaxValue);//9223372036854775807
            Console.WriteLine("long�� �ִ�:" + long.MinValue);//-9223372036854775807
            Console.WriteLine("float�� �ִ�:" + float.MaxValue);//3.402823E+38
            Console.WriteLine("float�� �ִ�:" + float.MinValue);//-3.402823E+38
            Console.WriteLine("double�� �ִ�:" + double.MaxValue);//1.79769313486232E+308
            Console.WriteLine("double�� �ִ�:" + double.MinValue);//-1.79769313486232E+308
            Console.WriteLine("char�� �ִ�:" + char.MaxValue);//?(\uffff)
            Console.WriteLine("char�� �ִ�:" + char.MinValue);// (\0)

            //Literal ���ͷ�
            int i_int = 100;
            long i_long = 100L;
            double i_dbl = 100.0;
            float i_flt = 100.0F;
            char i_chr = 'A';

            i_int = i_chr;
            i_dbl = i_int;
            i_dbl = i_long;
            i_flt = i_long;//float�� long���� ŭ. ���� ����
            i_long = i_int;
            //i_long = i_dbl;//����
            //  i_long = i_flt;//����

            //�� i_chr<i_int<i_long<i_flt<i_dbl
            //�� i_dbl>i_flt>i_long>i_int>i_chr

            //�ڷ����� ǥ�� ũ��(�Ϲ��� ����ȯ ����) Type Casting
            i_dbl = i_flt = i_long = i_int = i_chr;

            string strInt = "50";
            string strLong = "20000000000L";//200��
            string strDouble = "50.0";
            string strFloat = "50.0F";
            string strString = "ABCDE";

            try
            {
                //Console.WriteLine(int.Parse(strInt));
                //Console.WriteLine(int.Parse(strLong));
                //Console.WriteLine(int.Parse(strDouble));
                //Console.WriteLine(int.Parse(strFloat));
                //Console.WriteLine(int.Parse(strString));

                //Console.WriteLine(long.Parse(strInt));
                //Console.WriteLine(long.Parse(strLong));
                //Console.WriteLine(long.Parse(strDouble));
                //Console.WriteLine(long.Parse(strFloat));
                //Console.WriteLine(long.Parse(strString));

                Console.WriteLine(double.Parse(strInt));
                Console.WriteLine(double.Parse(strLong));
                Console.WriteLine(double.Parse(strDouble));
                Console.WriteLine(double.Parse(strFloat));
                Console.WriteLine(double.Parse(strString));
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("���� ���� �߻�");
                Console.WriteLine(e.Message);
            }
            catch(System.Exception e)
            {
                Console.WriteLine(e.Message);
            }

            bool trueOrFalse = true;
            trueOrFalse.ToString();

            int a = 'a';
            Console.WriteLine(a + "");

            //=====================2019.04.22 �߰��ǽ�========================
            Console.WriteLine("\n2019.04.22 �߰��ǽ�\n");
            int amin = int.MinValue;
            Console.WriteLine(amin);
            Console.WriteLine(-1 * amin);

            Console.WriteLine(-2147483648);
            //Console.WriteLine(-1*-2147483648);//���������� ���� ����
            //�ذ��� : Long������ �ٲ���
            Console.WriteLine(-1L*-2147483648);

            long b = long.MinValue;
            Console.WriteLine(b);
            Console.WriteLine(-1 * b);//�Ⱥ���
            //�ذ���(Float�� �Ǵ� Double������ �ٲ��ش�)
            Console.WriteLine(-1F * b);
            Console.WriteLine(-1D * b);
            //float�� double�� ����ȯ ���� ���� ���� �ʰ� float������ ����ȯ �� ���� �� ª�� ���� : float���� ǥ�� ���� ����

            
        }//End of Main
    }
}
