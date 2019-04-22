using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    class Teacher
    {
        static void Main(String[] args)
        {
            //=====================������ �ҽ� �ڵ�========================
            Console.WriteLine("\n������ �ҽ��ڵ�\n");
            // Assign�ϴ� ���� �������� �����Ͽ� Ÿ���� ���ǵǴ� Ű����. 
            // ���� �����θ� ��� �����ϸ� �޼��� �ȿ����� Ű����� ��޴��ϴ� ��ǥ���� Context Keyword�̴�.
            // ������ ������ Ÿ���� �����Ͽ� �ش� Data Type���� �ٲ�ġ�� �ȴ�.
            var number = 100;
            // number = "100"; 

            // �� Data Type �� GetType()�޼ҵ� ��� �� Ÿ���� ��� ��µǴ��� ����Ѵ�.
            var lotto = 10000000000L;
            var str = "�ȳ��ϼ���";
            var this_double = 3.141592;
            var this_float = 3.14F;
            var this_bool = true;
            var this_char = 'H';

            Console.WriteLine("number: " + number.GetType());
            Console.WriteLine("lotto: " + lotto.GetType());
            Console.WriteLine("str: " + str.GetType());
            Console.WriteLine("this_double: " + this_double.GetType());
            Console.WriteLine("this_float: " + this_float.GetType());
            Console.WriteLine("this_bool: " + this_bool.GetType());
            Console.WriteLine("this_char: " + this_char.GetType());

            // �� �ڷ��� �� �ִ�, �ּ� �� ���.
            // int���� long���� �ִ񰪰� �ּڰ��� ������ ���ڰ� �ٸ��� �����Ѵ�.
            // float�� double�� �ִ�, �ּڰ��� ���ڰ� ��ȣ�� ���� ����.

            Console.WriteLine("int�� �ִ�" + int.MaxValue);
            Console.WriteLine("int�� �ּ�" + int.MinValue);
            Console.WriteLine("long�� �ִ�" + long.MaxValue);
            Console.WriteLine("long�� �ּ�" + long.MinValue);
            Console.WriteLine("float�� �ִ�" + float.MaxValue);
            Console.WriteLine("float�� �ּ�" + float.MinValue);
            Console.WriteLine("double�� �ִ�" + double.MaxValue);
            Console.WriteLine("double�� �ּ�" + double.MinValue);
            Console.WriteLine("char�� �ִ�" + char.MaxValue);
            Console.WriteLine("char�� �ּ�" + char.MinValue);

            // Literal ���ͷ� 
            // ���ͷ��� �⺻������ �������� int��, �Ǽ��� double������ ��޵ȴ�.
            // float�̳� long������ ����ϰ� �ʹٸ� F�� L�� ���ͷ� ���� �ٿ��� �˷���� �Ѵ�.
            int i_int = 100;
            long i_lng = 100L;
            double i_dbl = 100.0;
            float i_flt = 100.0F;
            char i_chr = 'A';

            // �ڷ����� ǥ�� ũ�� (�Ϲ��� ����ȯ ����) Type Casting
            // Data Type�� ũ��� Data Type�� ǥ�� ������ ���� ������ �ٸ���. 
            // float�� 4����Ʈ, long�� 8����Ʈ�ӿ��� ǥ�� ������ ���� ������ Ŀ�� long�� float�� ���� �� �ִ�.
            i_dbl = i_flt = i_lng = i_int = i_chr;

            // string -> �ش�Ÿ�� ��ȯ�� �ش� Ÿ�Կ� �´� �ùٸ� ���ڿ��� �־��־�߸� ��ȯ�� �ȴ�.
            // ������ ������ ���� ������ System.FormatException�� �߻��Ѵ�.
            // ���� ū ���ܴ� System.Exception ���� ó���� �� �ִ�.
            // try, catch ������ �ڹٿ� �����ϴ�.
            string strInt = "50";
            string strLong = "20000000000"; // 200��. 
            string strDouble = "50.0";
            string strFloat = "50.0";
            string strString = "ABCDE";

            try
            {
                Console.WriteLine(int.Parse(strInt));
                Console.WriteLine(long.Parse(strLong));
                Console.WriteLine(double.Parse(strDouble));
                Console.WriteLine(float.Parse(strFloat));
                Console.WriteLine(int.Parse(strString)); // ���� ���� �߻���
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("���� ���� �߻�!");
                Console.WriteLine(e.Message);
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Data Type�� bool�̰� ����Ǵ� ���� true �Ǵ� false�̴�. (�ҹ��ڿ� ����)
            // �̸� ����ϸ� True �Ǵ� False�� ��µȴ�.
            bool trueOrFalse = true;
            Console.WriteLine(trueOrFalse.ToString());

            // ���ڿ��� �����ϰ� �����Ϸ��� "" + ���� �� ���� ����ϸ� �ȴ�. 
            int a = 1999;
            Console.WriteLine("" + a);

            // character���� string ���յ� �� ��µȴ�.
            char c = 'a';
            string c2 = "" + c;
            Console.WriteLine(c2);

            // �߰��� �κ�! 
            // ������(int, long) �ڷ����� 2�� ����� ����ŭ ǥ���� ���� �ִµ�, 0�� �ֱ� ������
            // ����� ���� �� �ϳ��� ���ڰ� �۾��� �� �ۿ� ����. �׷��� ������ ������� ���� �ϳ� �� ����.
            // int���� ��� �ִ� 2147483647, �ּڰ� -2147483648 �� ������ �ϳ� �� ����.
            // �̷��⿡ �ּڰ��� -1�� ���� ��� int������ ǥ���� ���� ���ԵǴ� ������ �����.
            // C#�� ��� �̷� ��� �׳� �ּڰ��� ����ϵ��� �Ǿ��ִ�. 
            // ���� ����� 2147483648�� ��µǰ� �ϰ� �ʹٸ� long�� ���� �� ū �ڷ����� ����ؾ� �Ѵ�.
            // �׷��� long�� ����? float�̳� double�� ����ؼ� ǥ���� ������ ���̴�. ������ �� ���
            // float�̳� double�� Ư���� �Ҽ��� Ư�� �ڸ� �� ���� ���� �ְ�Ǿ� ��¦ �ٸ� ���� ������ �Ǵ� ������ �ִ�.
            int minInt = int.MaxValue;
            Console.WriteLine(minInt);
            Console.WriteLine(-minInt);
            minInt = int.MinValue;
            Console.WriteLine(minInt);
            Console.WriteLine(-minInt);  // ����: ������� 2147483648�� ��� ���� ������ ����
            Console.WriteLine(minInt * -1);  // ����: ������� 2147483648�� ��� ���� ������ ����
            Console.WriteLine(minInt * -1L);  // long������ �ٲ��ָ� �ذ�(���ͷ��� long������)
            Console.WriteLine((int)minInt * -1);  // long������ �ٲ��ָ� �ذ�(������ long����)
            Console.WriteLine(-2147483648);
            //Console.WriteLine(-(-2147483648)); // ���� ���� ����ϸ� ���� �߻�,������ �ȵ�
            //Console.WriteLine(-1 * (-2147483648)); // ���� ����
            Console.WriteLine(-1L * (-2147483648)); // long������ �ٲ��ָ� �ذ�(���ͷ��� long������)
            Console.WriteLine((long)-1 * (-2147483648)); // long������ �ٲ��ָ� �ذ�(������ long����)

            // long�� ���
            long minLong = long.MinValue;
            Console.WriteLine(minLong); // -9223372036854775808
            Console.WriteLine(-1 * minLong); // -1�� ���ص� ���� ����. long�� 9223372036854775808 ���� ǥ���� �� ���� ����.
            Console.WriteLine(-1F * minLong); // float���� �� ���. 9.223372E+18 �� �Ҽ��� Ư�� �ڸ��� ���� ���� �ְ�Ǿ���.
            Console.WriteLine(-1.0 * minLong); // double�� ������ ���. 9.22337203685478E+18 �� �� �� ���������� ������ ���� ������ �ټ� ���̰� �ִ�.
        }
    }
}
