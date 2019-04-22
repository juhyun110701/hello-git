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
            //변수 아래에 초록색 밑줄 : 변수 선언만 해놓고 사용하지 않았을 때 생김
            var number = 100;
            //number="100";
            var lotto = 10000000000L;
            var str = "안녕하세요";
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

            Console.WriteLine("int형 최대:" + int.MaxValue);//약 21억    2147483647
            Console.WriteLine("int형 최대:" + int.MinValue);//-2147483647
            Console.WriteLine("long형 최대:" + long.MaxValue);//9223372036854775807
            Console.WriteLine("long형 최대:" + long.MinValue);//-9223372036854775807
            Console.WriteLine("float형 최대:" + float.MaxValue);//3.402823E+38
            Console.WriteLine("float형 최대:" + float.MinValue);//-3.402823E+38
            Console.WriteLine("double형 최대:" + double.MaxValue);//1.79769313486232E+308
            Console.WriteLine("double형 최대:" + double.MinValue);//-1.79769313486232E+308
            Console.WriteLine("char형 최대:" + char.MaxValue);//?(\uffff)
            Console.WriteLine("char형 최대:" + char.MinValue);// (\0)

            //Literal 리터럴
            int i_int = 100;
            long i_long = 100L;
            double i_dbl = 100.0;
            float i_flt = 100.0F;
            char i_chr = 'A';

            i_int = i_chr;
            i_dbl = i_int;
            i_dbl = i_long;
            i_flt = i_long;//float이 long보다 큼. 함정 주의
            i_long = i_int;
            //i_long = i_dbl;//에러
            //  i_long = i_flt;//에러

            //★ i_chr<i_int<i_long<i_flt<i_dbl
            //★ i_dbl>i_flt>i_long>i_int>i_chr

            //자료형의 표현 크기(암묵적 형변환 가능) Type Casting
            i_dbl = i_flt = i_long = i_int = i_chr;

            string strInt = "50";
            string strLong = "20000000000L";//200억
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
                Console.WriteLine("형식 에러 발생");
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

            //=====================2019.04.22 추가실습========================
            Console.WriteLine("\n2019.04.22 추가실습\n");
            int amin = int.MinValue;
            Console.WriteLine(amin);
            Console.WriteLine(-1 * amin);

            Console.WriteLine(-2147483648);
            //Console.WriteLine(-1*-2147483648);//컴파일조차 되지 않음
            //해결방법 : Long형으로 바꿔줌
            Console.WriteLine(-1L*-2147483648);

            long b = long.MinValue;
            Console.WriteLine(b);
            Console.WriteLine(-1 * b);//안변함
            //해결방법(Float형 또는 Double형으로 바꿔준다)
            Console.WriteLine(-1F * b);
            Console.WriteLine(-1D * b);
            //float와 double로 형변환 해준 값이 같지 않고 float형으로 형변환 한 것이 더 짧은 이유 : float형의 표현 범위 때문

            
        }//End of Main
    }
}
