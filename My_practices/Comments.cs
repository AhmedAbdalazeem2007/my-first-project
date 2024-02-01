using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace  Comments
    {
        class Search
        {
            public static int linar_search(int[] A, int num)
            {
                int index = -1;
                for (int i = 0; i < A.Length; i++)
                    if (A[i] == num) 
                        return i;
                return index;
            }
            public static bool LinearSearch<T>(T[] A, T a)
            {
                for (int i = 0; i < A.Length; i++)
                    if (A[i].Equals(a))
                        return true;
                return false;
            }

            public static bool binary_search(int[] A, int key)
            {
                return false;
            }

        }
        class Char_1
        {
            public static bool is_small(char x)
            {
                return (x >= 97 && x <= 122);
            }
            public static bool is_capital(char x)
            {
                return (x >= 65 && x <= 90);
            }
            public static bool is_letter(char x)
            {
                return (is_capital(x) || is_small(x));
            }
            public static bool is_vowel(char x)
            {
                Char[] A = { 'a', 'A', 'I', 'i', 'o', 'O', 'U', 'u', 'E', 'e' };
                return A.Contains(x);
            }
            public static bool is_consonant(char x)
            {
                return !is_vowel(x);
            }
            public static void from_a_z()
            {
                for (char i = 'a'; i <= 'z'; i++)
                    Console.WriteLine(i);
            }
            public static void from_A_Z()
            {
                for (char i = 'A'; i <= 'Z'; i++)
                    Console.WriteLine(i);
            }
            public static void from_z_a()
            {
                for (char i = 'z'; i >= 'a'; i--)
                    Console.WriteLine(i);
            }
            public static void from_Z_A()
            {
                for (char i = 'Z'; i >= 'A'; i--)
                    Console.WriteLine(i);
            }
            public static char to_lower(char x)
            {
                if (!is_letter(x))
                    return ' ';
                if (is_small(x))
                    return x;
                int a = (int)x;
                a += 32;
                x = (char)a;
                return x;
            }
            public static char to_upper(char x)
            {
                if (!is_letter(x))
                    return ' ';
                if (is_capital(x))
                    return x;
                int a = (int)x;
                a -= 32;
                x = (char)a;
                return x;
            }
            public static int asci_1(char x)
            {
                int a = (int)x;
                return a;
            }
            public static char asci_2(int num)
            {
                char x = (char)num;
                return x;
            }

            public static void sort_char(char[] A)
            {
                for (int i = 1; i < A.Length; i++)
                {
                    char key = A[i];
                    int j = i - 1;
                    while (j >= 0 && A[j] > key)
                    {
                        A[j + 1] = A[j];
                        j = j - 1;
                    }
                    A[j + 1] = key;
                }
            }

        }
        class Sort_1
        {
            public static void selection_sortt<T>(T[] A,T a)
            {
                int min = 0;
                for (int i = 0; i < A.Length - 1; i++)
                {
                    min = i;
                    for (int j = i + 1; j < A.Length; j++)
                    {
                        if (A[j].Equals(A[min]))
                            min = j;
                    }
                    T swap = A[min];
                    A[min] = A[i];
                    A[i] = swap;
                }
            }
            public static void selection_sort(int[] A)
            {
                int min = 0;
                for (int i = 0; i < A.Length - 1; i++)
                {
                    min = i;
                    for (int j = i + 1; j < A.Length; j++)
                    {
                        if (A[j] < A[min])
                            min = j;
                    }
                    int swap = A[min];
                    A[min] = A[i];
                    A[i] = swap;
                }
            }
            public static int comare_to(int x, int y)
            {
                if (x > y) return 1;
                else if (x < y) return -1;
                return 0;
            }

            public static void insertion_sort(int[] A)
            {
                for (int i = 1; i < A.Length; i++)
                {
                    int key = A[i];
                    int j = i - 1;
                    while (j >= 0 && (comare_to(A[j], key) == 1))
                    {
                        A[j + 1] = A[j];
                        j = j - 1;
                    }
                    swap(ref A[j + 1], ref key);
                }
            }

            public static void swap<T>(ref T x, ref T y)
            {
                T temp = x;
                x = y;
                y = temp;
            }
            public static void merge_sort(int[] A)
            {

            }

            static void quick_sort(int[] A)
            {

            }

            static void shell_sort(int[] A)
            {

            }
        }

        class Array_1
        {
            private const string V = "";

            public static void fill(int[] A)
            {
                for (int i = 0; i < A.Length; i++)
                    A[i] = i + 1;
            }
            public static void enter_unique_numbers(int[] A)
            {
                int count = 0;
                while (count < A.Length)
                {
                    Console.WriteLine("Enter the number");
                    int x = int.Parse(Console.ReadLine());
                    while (A.Contains(x))
                    {
                        Console.WriteLine("Enter another number");
                        x = int.Parse(Console.ReadLine());
                    }
                    A[count++] = x;
                }
            }

            public static void fill(int[] A, int value)
            {
                for (int i = 0; i < A.Length; i++)
                    A[i] = value;
            }

            public static void zeros(int[] A)
            {
                for (int i = 0; i < A.Length; i++)
                    A[i] = 0;
            }

            public static void ones(int[] A)
            {
                for (int i = 0; i < A.Length; i++)
                    A[i] = 1;
            }

            public static int sum(int[] A)
            {
                int sum = 0;
                for (int i = 0; i < A.Length; i++)
                    sum += A[i];
                return sum;
            }

            public static double avg(int[] A)
            {
                int s = sum(A);
                double b = A.Length;
                double a = s / b;
                return a;
            }

            public static int[] merge(int[] A, int[] B)
            {
                int[] C = new int[A.Length + B.Length];
                int count = 0, a_index = 0, b_index = 0;
                while (count < C.Length)
                {
                    if (A[a_index] > B[b_index])
                        C[count++] = B[b_index++];
                    else if (B[b_index] > A[a_index])
                        C[count++] = A[a_index++];
                    if (a_index >= A.Length)
                        for (int i = b_index; i < B.Length; i++)
                            C[count++] = B[i];
                    else
                        for (int i = a_index; i < A.Length; i++)
                            C[count++] = A[i];
                }

                return C;
            }
            public static void replace(int[] A, int v, int num)
            {
                for (int i = 0; i < A.Length; i++)
                    if (A[i] == v)
                        A[i] = num;
            }

            public static bool is_sorted(int[] A)
            {
                for (int i = 1; i < A.Length; i++)
                    if (A[i] < A[i - 1])
                        return false;
                return true;
            }
            public static bool is_symmetric(int[] A)
            {
                int count = A.Length - 1;
                for (int i = 0; i < A.Length / 2; i++)
                    if (A[i] != A[count--])
                        return false;
                return true;
            }

            public static int[] sum_of_certain_series(int[] A, int sum)
            {
                return A;
            }
            public static void display(int[] A)
            {
                for (int i = 0; i < A.Length; i++)
                    Console.WriteLine(A[i]);
            }

            public static void display(char[] A)
            {
                for (int i = 0; i < A.Length; i++)
                    Console.WriteLine(A[i]);
            }

            public static void print_all_possible_numbers(int[] A)
            {

            }
            public static void print_odd(int[] A)
            {
                for (int i = 0; i < A.Length; i++)
                    if (A[i] % 2 != 0)
                        Console.WriteLine(A[i]);
            }
            public static int min(int[] A)
            {
                int m = A[0];
                for (int i = 1; i < A.Length; i++)
                    if (A[i] < m)
                        m = A[i];
                return m;
            }

            public static int max(int[] A)
            {
                int m = A[0];
                for (int i = 1; i < A.Length; i++)
                    if (A[i] > m)
                        m = A[i];
                return m;
            }

            public static void reverse_in_place(int[] A)
            {
                int swap = 0;
                int c = A.Length - 1;
                for (int i = 0; i < A.Length / 2; i++)
                {
                    swap = A[i];
                    A[i] = A[c];
                    A[c] = swap;
                    c--;
                }
            }

            public static int[] reverse(int[] A)
            {
                int[] B = new int[A.Length];
                for (int i = A.Length - 1; i >= 0; i--)
                    B[A.Length - i - 1] = A[i];
                return B;
            }

            public static bool find(int[] A, int x)
            {
                for (int i = 0; i < A.Length; i++)
                    if (A[i] == x)
                        return true;
                return false;
            }

            public static int Occurence(int[] A, int x)
            {
                int count = 0;
                for (int i = 0; i < A.Length; i++)
                    if (A[i] == x)
                        count++;
                return count;

            }

            public static int most_common(int[] A)
            {
                int c = 0, m = 0, n = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    c = Occurence(A, A[i]);
                    if (c > m)
                    {
                        m = c;
                        n = A[i];
                    }
                }
                return n;
            }

            public static bool is_distinct(int[] A)
            {
                for (int i = 0; i < A.Length; i++)
                    if (Occurence(A, A[i]) > 1)
                        return false;
                return true;
            }


            public static String to_string(int[] A)
            {
                String x = "";
                for (int i = 0; i < A.Length; i++)
                    x += A[i].ToString();
                return x;
            }

            public static String to_string(char[] A)
            {
                String x = "";
                for (int i = 0; i < A.Length; i++)
                    x += A[i];
                return x;
            }

            public static int first_index(int[] A, int v)
            {
                int index = -1;
                for (int i = 0; i < A.Length; i++)
                    if (A[i] == v)
                        return i;
                return index;
            }

            public static int last_index(int[] A, int v)
            {
                int index = -1;
                for (int i = 0; i < A.Length; i++)
                    if (A[i] == v)
                        index = i;
                return index;
            }

            public static int get_value(int[] A, int index)
            {
                if (index < A.Length && index >= 0)
                    return A[index];
                Console.WriteLine("invalid index");
                return -1;
            }

            public static void delete_start(int[] A)
            {
                A[0] = 0;
                for (int i = 0; i < A.Length - 1; i++)
                    A[i] = A[i + 1];
                A[A.Length - 1] = 0;
            }


            public static void delete_end(int[] A)
            {
                A[A.Length - 1] = 0;
            }

            public static void delete_index(int[] A, int index)
            {
                if (!(index < A.Length && index >= 0))
                    return;
                A[index] = 0;
                for (int i = index; i < A.Length - 1; i++)
                    A[i] = A[i + 1];
                A[A.Length - 1] = 0;
            }

            public static void delete_first_value(int[] A, int v)
            {
                int index = first_index(A, v);
                if (index == -1)
                    return;
                A[index] = 0;
                for (int i = index; i < A.Length - 1; i++)
                    A[i] = A[i + 1];
                A[A.Length - 1] = 0;
            }

            public static void delete_last_value(int[] A, int v)
            {
                int index = last_index(A, v);
                if (index == -1)
                    return;
                A[index] = 0;
                for (int i = index; i < A.Length - 1; i++)
                    A[i] = A[i + 1];
                A[A.Length - 1] = 0;

            }
            public static int[] large_3_element(int[] A)
            {
                int[] B = new int[3];
                Sort_1.selection_sort(A);
                int c = 0;
                for (int i = A.Length - 3; i < A.Length; i++)
                    B[c++] = A[i];
                return B;
            }

            public static int second_large_element(int[] A)
            {
                Sort_1.selection_sort(A);
                int m = A[A.Length - 1];
                for (int i = A.Length - 1; i >= 0; i--)
                    if (A[i] < m)
                        return A[i];
                return -1;
            }
            public static bool equal(int[] A, int[] B)
            {
                if (A.Length != B.Length)
                    return false;
                for (int i = 0; i < A.Length; i++)
                    if (A[i] != B[i])
                        return false;
                return true;
            }

            public static int count_of_unique_numbers(int[] A)
            {
                int count = 0;
                for (int i = 0; i < A.Length; i++)
                    if (Occurence(A, A[i]) == 1)
                        count++;
                return count;
            }

            public static int[] to_distinict_1(int[] A)
            {
                int[] B;
                int count = 0;
                for (int i = 0; i < A.Length; i++)
                    if (Occurence(A, A[i]) == 1) count++;
                B = new int[count];
                count = 0;
                for (int i = 0; i < A.Length; i++)
                    if (Occurence(A, A[i]) == 1)
                        B[count++] = A[i];
                return B;
            }

            public static int[] to_distinict_2(int[] A)
            {
                return A;
            }
            public static void move_zeros_end(int[] A)
            {
                int c = A.Length - 1;
                for (int i = 0; i < A.Length; i++)
                    if (A[i] == 0)
                    {
                        int swap = A[i];
                        A[i] = A[c];
                        A[c] = swap;
                        c--;
                    }

            }
            public static int[] sum(int[] A, int[] B)
            {
                int[] C = new int[A.Length];
                for (int i = 0; i < A.Length; i++)
                    C[i] = A[i] + B[i];
                return C;
            }
            public static int[] mul(int[] A, int[] B)
            {
                int[] C = new int[A.Length];
                for (int i = 0; i < A.Length; i++)
                    C[i] = A[i] * B[i];
                return C;
            }
        }
        /* class Car:ICloneable,IComparable<Car>
        {
            public Car(int id, string model, double speed)
            {
                this.id = id;
                this.model = model;
                this.speed = speed;
            }
            public Car(int id, string op) : this(id, op, .7)
            {

            }

            private double speed;

            public double  Speed
            {
                get { return speed; }
                set { speed = value; }
            }
            private int id;

            public int ID
            {
                get { return id; }
                set { id = value; }
            }
            string model;
            public string Model
            {
                get { return model; }
                set { model = value; }
            }

            public override string ToString()
            {
                return $"id:{this.id}\n model {this.model}";
            }
            public static void sort(Car[] cars)
            {
                for(int i=0; i<cars.Length; i++)
                {

                }
            }

            public override bool Equals(object? obj)
            {
                Car car = obj as Car;
                return this.id == car.id;
            }

            public object Clone()
            {
                return new Car(this.id, this.model, this.speed);
            }

            public int CompareTo(Car? other)
            {
                Car car = other as Car;
                if (this.id > car.id)
                    return 1;
                else if (this.id < car.id) return -1;
                else return 0;
            }
        }*/
        public class NUmber
        {
            public static void divisor(int num)
            {
                for (int i = 2; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine(i);
                        num /= i;
                        i--;
                    }
                }
            }
            public static bool is_positive(int num)
            {
                return num >= 0;
            }

            public static bool is_negative(int num)
            {
                return num < 0;
            }

            public static bool is_pow_2(int num)
            {
                while (num > 1)
                {
                    if (!is_even(num))
                        return false;
                    num /= 2;

                }
                return true;
            }
            public static int[] find_square_equation(int a, int b, int c)
            {
                int[] A = new int[2];
                double s = b * b - 4 * a * c;
                if (s > 0)
                {
                    s = MathF.Sqrt((float)Convert.ToDouble(s));

                    double p1 = (-b + s) / 2 * a;
                    double p2 = (-b - s) / 2 * a;
                    A[0] = (int)p1;
                    A[1] = (int)p2;
                }
                else if (s == 0)
                {
                    double p = -b / 2 * a;
                    A[0] = A[1] = (int)p;
                    Console.WriteLine("one root");
                }
                else
                    Console.WriteLine("no roots");
                return A;
            }
            public static bool is_even(int num)
            {
                return num % 2 == 0;
            }

            public static int sum_even_n(int num)
            {
                int sum = 0;
                for (int i = 0; i <= num; i += 2)
                    sum += i;
                return sum;
            }

            public int sum_odd_n(int num)
            {
                int sum = 0;
                for (int i = 0; i <= num; i += 2)
                    sum += i;
                return sum;
            }
            public static double pi()
            {
                //            Console.WriteLine(p);
                return Math.PI;
            }
            public static bool is_balance(int num)
            {
                int s = sum_of_digits(num);
                s /= 2;
                int m = max_digit(num);
                return (s == m);
            }
            public static bool is_vampire_number(int x, int y)
            {
                return false;
            }
            public static bool is_magic(int num)
            {
                int a = sum_of_digits(num);
                int s = reverse_num(a);
                return a * s == num;
            }

            public static bool is_palindrome(int num)
            {
                int x = reverse_num(num);
                return num == x;
            }
            public static bool is_abundant(int num)
            {
                return sum_of_divisors(num) > num;

            }

            public static bool is_deficient(int num)
            {
                return sum_of_divisors(num) < num;

            }

            public static bool is_perfect(int num)
            {
                return sum_of_divisors(num) == num;

            }

            public static bool is_disarium(int num)
            {
                num = reverse_num(num);
                int a = num;
                int sum = 0;
                int c = 1;
                while (num != 0)
                {
                    int d = num % 10;
                    d = pow(d, c);
                    sum += d;
                    num /= 10;
                    c++;
                }
                a = reverse_num(a);
                return sum == a;
            }

            public static bool is_happy(int num)
            {
                int b = 0;
                int sum = 0;
                while (sum != 1)
                {
                    sum = 0;
                    while (num != 0)
                    {
                        int d = num % 10;
                        d *= d;
                        sum += d;
                        num /= 10;
                    }
                    num = sum;
                    if (b++ > 100)
                        return false;
                }
                return true;
            }

            public static bool is_harshed(int num)
            {
                if (num < 1)
                    return false;
                int s = sum_of_digits(num);
                return num % s == 0;
            }

            public static bool is_automorphic(int num)
            {
                int x = num * num;
                int a = last_digit(x);
                int b = last_digit(num);
                return a == b;
            }

            public static bool is_duck(int num)
            {
                while (num != 0)
                {
                    int d = num % 10;
                    if (d == 0)
                        return true;
                    num /= 10;
                }
                return false;

            }

            public static bool is_amicable(int x, int y)
            {
                int s1 = sum_of_divisors(x);
                int s2 = sum_of_divisors(y);
                return s1 == y && s2 == x;
            }

            public static bool is_narcissistic(int num)
            {
                int a = num;
                int c = count_of_digits(num);
                int sum = 0;
                while (num != 0)
                {
                    int d = num % 10;
                    d = pow(d, c);
                    num /= 10;
                    sum += d;
                }
                return sum == a;
            }

            public static bool is_armstrong(int num)
            {
                int sum = 0;
                int a = num;
                while (num != 0)
                {
                    int d = num % 10;
                    d = pow(d, 3);
                    sum += d;
                    num /= 10;
                }
                return sum == a;
            }
            public static bool is_start_equal_end(int num)
            {
                int s = first_digit(num);
                int e = last_digit(num);
                return s == e;
            }

            public static int fact(int num)
            {
                int f = 1;
                if (is_negative(num) || num == 0)
                    return f;
                for (int i = 1; i <= num; i++)
                    f *= i;
                return f;
            }
            public static bool is_fact(int num)
            {
                if (num == 0)
                    return false;
                int i = 2;
                while (num != 1)
                {
                    if (num % i != 0)
                        return false;
                    num = num / i;
                    i++;
                }
                return true;
            }
            public static int refact(int num)
            {
                int count = 2;
                int i = 2;
                while (num != 1)
                {
                    num = num / i;
                    i++;
                    count++;
                }
                return --count;
            }
            public static int pow(int num, int x)
            {
                if (x == 0)
                    return 1;

                int a = 1;
                for (int i = 1; i <= x; i++)
                    a *= num;
                return a;
            }

            public static double pow_2(int x)
            {
                int f = 1;
                for (int i = 1; i <= x; i++)
                    f *= 2;
                return f;
            }
            public static int square_root(int num)
            {
                for (int i = 1; i <= num; i++)
                    if (i * i == num)
                        return i;
                return 1;
            }

            public static int n_root(int num, int x)
            {
                int f = 1;
                for (int i = 1; i <= num; i++)
                {
                    f = 1;
                    for (int j = 1; j <= x; j++)
                        f *= i;
                    if (f == num)
                        return i;
                }
                return f;
            }
            public static int reverse_num(int num)
            {
                int a = 0;
                while (num > 0)
                {
                    int x = num % 10;
                    a = a * 10 + x;
                    num /= 10;
                }
                return a;
            }

            public static int max_digit(int num)
            {
                int max = num % 10;
                while (num > 0)
                {
                    int a = num % 10;
                    if (a > max)
                        max = a;
                    num /= 10;
                }
                return max;
            }

            public static int min_digit(int num)
            {
                int min = num % 10;
                while (num > 0)
                {
                    int a = num % 10;
                    if (a < min)
                        min = a;
                    num /= 10;
                }
                return min;
            }

            public static int sum_of_digits(int num)
            {
                int sum = 0;
                while (num != 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                return sum;
            }
            public static int sum_of_divisors(int num)
            {
                int sum = 0;
                for (int i = 2; i < num; i++)
                    if (num % i == 0)
                        sum += i;
                return sum;
            }

            public static int count_of_digits(int num)
            {
                int c = 0;
                while (num != 0)
                {
                    num /= 10;
                    c++;
                }
                return c;
            }

            public static int[] factors(int num)
            {
                int count = 0;
                int y = num;
                int[] A;
                while (num > 1)
                {
                    for (int i = 2; i <= num; i++)
                    {
                        if (num % i == 0)
                        {
                            count++;
                            num /= i;
                            break;
                        }
                    }
                }
                A = new int[count];
                count = 0;
                while (y > 1)
                {
                    for (int i = 2; i <= y; i++)
                    {
                        if (y % i == 0)
                        {
                            A[count++] = i;
                            y /= i;
                            break;
                        }
                    }
                }
                return A;
            }
            public static List<int> count_of_divisor(double num)
            {
                List<int> list = new List<int>();

                if (num < 1)
                    return list;
                else
                {
                    for (int i = 1; i <= num / 2; i++)
                        if (num % i == 0)
                        {
                            Console.WriteLine(i);
                            list.Add(i);
                        }
                }
                return list;
            }

            public static int first_digit(int num)
            {
                int d = num % 10;
                while (num != 0)
                {
                    d = num % 10;
                    num /= 10;
                }
                return d;
            }

            public static int last_digit(int num)
            {
                return num % 10;
            }

            public static int remove_first_digit(int num, int x)
            {
                String y = num.ToString();
                int index = y.IndexOf(x.ToString());
                String b = y.Substring(0, index) + y.Substring(index + 1);
                num = int.Parse(b);
                return num;
            }
            public static int remove_all_digit(int num, int x)
            {
                int a = 0;
                while (num != 0)
                {
                    int d = num % 10;
                    if (d != x)
                    {
                        a = a * 10 + d;
                    }
                    num /= 10;
                }
                a = reverse_num(a);
                return a;
            }


            public static String to_string(int num)
            {
                return "" + num;
            }
            public static void pell_number(int count)
            {

            }
            public static void Fibonacci_numbers(int count)
            {
                Console.Write(0);
                int a = 0;
                int b = 1;
                int c = 0;
                for (int i = 1; i < count - 1; i++)
                {
                    Console.Write("\t" + b);
                    c = b;
                    b = b + a;
                    a = c;
                }
            }
            public static bool is_fibonacci(int num)
            {
                int x = 1; int y = 0;
                int s = 1;
                while (x < num)
                {
                    s = x;
                    x = x + y;
                    y = s;
                    if (x == num)
                        return true;
                }
                return false;
            }
            public static int sort_num(int x)
            {
                int y = 0;
                int d = 1;
                while (x != 0)
                {
                    int m = max_digit(x);
                    x = remove_first_digit(x, m);
                    m *= d;
                    y += m;
                    d *= 10;

                }
                return y;
            }
            public static int sort_num_2(int x)
            {
                String y = x.ToString();
                y = STring.sort_str(y);
                x = int.Parse(y);
                return x;
            }
            public static bool find(int num, int x)
            {
                while (num != 0)
                {
                    int d = num % 10;
                    if (d == x)
                        return true;
                    num /= 10;
                }
                return false;
            }
            public static int occure_digit(int num, int x)
            {
                int count = 0;
                while (num != 0)
                {
                    int d = num % 10;
                    if (d == x)
                        count++;
                    num /= 10;
                }
                return count;
            }

            public static double value_E()
            {
                double e = 2;
                for (int i = 2; i <= 100; i++)
                {
                    double s = fact(i);
                    s = 1 / s;
                    e += s;
                }
                return e;
            }
            public static int gcd(int x, int y)
            {
                int z = 0;
                while (y != 0)
                {
                    z = y;
                    y = x % y;
                    x = z;
                }
                return x;
            }
            public static int lcd(int x, int y)
            {
                int z = 0;


                return z;
            }

            public static int even_odd(int num)
            {
                int a = 0;
                int b = num;
                while (num != 0)
                {
                    int d = num % 10;
                    if (d % 2 != 0)
                    {
                        num /= 10;
                        continue;
                    }
                    else
                        a = a * 10 + d;
                    num /= 10;
                }
                while (b != 0)
                {
                    int d = b % 10;
                    if (d % 2 == 0)
                    {
                        b /= 10;
                        continue;
                    }
                    else
                        a = a * 10 + d;
                    b /= 10;
                }
                return a;
            }
            public static void sum_even_odd_prime(int num)
            {
                int sum_even = 0, sum_odd = 0, sum_prime = 0;
                while (num != 0)
                {
                    int d = num % 10;
                    if (is_even(d))
                        sum_even = sum_even + d;
                    if (!is_even(d))
                        sum_odd = sum_odd + d;
                    // if (prime(d))
                    sum_prime = sum_prime + d;
                    num /= 10;
                }
                Console.WriteLine("sum_even=" + sum_even + "sum_odd" + sum_odd + "sum_prime" + sum_prime);
            }
        }
        internal class Prime_numbers
        {
            StreamReader sr;
            List<int> list;
            public Prime_numbers()
            {

                list = new List<int>();
                sr = new StreamReader("13million_primes.txt");
                String op = sr.ReadLine();
                while (op != null)
                {
                    int num = int.Parse(op);
                    list.Add(num);
                    op = sr.ReadLine();
                }
                sr.Close();
            }
            public void oop()
            {
                int sum = 0;
                StreamWriter streamWriter = new StreamWriter("ppppp.txt");
                for (int i = 0; i < 10; i++)
                {
                    int val = list[i];
                    for (int j = 0; j < val; j++)
                        sum += list[j];
                    Console.WriteLine(val + "\t" + sum);
                    streamWriter.WriteLine(val + "\t" + sum);
                    sum = 0;
                }
                streamWriter.Close();
            }

            public void oooop()
            {
                for (int i = 1; i < 10; i++)
                {
                    int val = i;
                    val++;
                    val *= val;
                    for (int j = i * i; j < val; j++)
                        Console.Write(j + "\t");
                    Console.WriteLine();
                }
            }
            public int value(int index)
            {
                index--;
                if (index < 0 || index >= list.Count)
                    return -1;
                return list[index];
            }
            public int gap()
            {
                int max = 0;
                for (int i = 0; i < list.Count - 1; i++)
                    if (list[i + 1] - list[i] > max)
                        max = list[i + 1] - list[i];
                StreamWriter sw = new StreamWriter("text_2.txt");
                for (int i = 0; i < list.Count - 1; i++)
                    if (list[i + 1] - list[i] == 2)
                        sw.WriteLine(list[i].ToString() + "\t" + list[i + 1].ToString());
                sw.Close();
                return max;
            }
            public bool prime(int num)
            {
                return list.Contains(num);
            }
            public void write()
            {
                StreamWriter sw = new StreamWriter("prim.txt");
                for (int i = 0; i < 100000; i++)
                    sw.WriteLine((i + 1).ToString() + "\t" + list[i]);
            }
            public int next_prime(int x)
            {
                x++;
                while (!prime(x))
                    x++;
                return x;

            }
            public bool indecies(int index_)
            {
                int sum = 0;
                for (int i = 0; i < index_ - 1; i++)
                    sum += list[i];
                int ind = index(index_);
                return ind == sum;
            }
            public List<int> get()
            {
                return this.list;
            }
            public int index(int num)
            {
                if (list.Contains(num))
                    return list.IndexOf(num) + 1;
                return -1;
            }
            public int[] prime_numbers_range(int num)
            {
                for (int i = num; i > 1; i--)
                    if (prime(i))
                        num = i;
                num = index(num);
                int[] A = new int[num + 1];
                for (int i = 0; i <= num; i++)
                    A[i] = list[i];
                return A;
            }
            public int[] prime_with_n(int num)
            {
                int[] A = new int[num];
                int count = 0;
                int i = 1;
                while (count < num)
                {
                    if (prime(i))
                        A[count++] = i;
                    i++;
                }
                return A;
            }
            public int[] not_prime_numbers_range(int num)
            {
                int[] A;
                int c = 0;
                for (int i = 1; i < num; i++)
                    if (!prime(i))
                        c++;
                A = new int[c];
                c = 0;
                for (int i = 1; i < num; i++)
                    if (!prime(i))
                        A[c++] = i;
                return A;
            }
            public int sum_n(int num)
            {
                int sum = 0;
                for (int i = 0; i <= num; i++)
                    if (prime(i))
                        sum += i;
                return sum;
            }
            public int sum_numbers(int num)
            {
                int count = 0;
                int sum = 0;
                int i = 1;
                while (count <= num)
                {
                    if (prime(i))
                    {
                        sum += i;
                        count++;
                    }
                    i++;
                }
                return sum;
            }
            public int sum_n_value(int value)
            {
                int sum = 0;
                int count = 0;
                int i = 1;
                while (sum < value)
                {
                    if (prime(i))
                    {
                        sum += i;
                        count++;
                    }
                    i++;
                }
                return count;
            }
            public bool is_symmetric(int num)
            {
                if (!prime(num))
                    return false;
                string x = num.ToString();
                x = STring.reverse(x);
                int b = int.Parse(x);
                return b == num;
            }
            public bool is_mersen(int num)
            {
                if (!prime(num))
                    return false;
                num--;
                return NUmber.is_pow_2(num);
            }
            public bool is_twin(int x, int y)
            {
                if (prime(x) && prime(y))
                    return x - y == 2;
                return false;
            }
            public bool additive(int num)
            {
                if (!prime(num))
                    return false;
                int sum = NUmber.sum_of_digits(num);
                return prime(sum);
            }
            public bool pure(int num)
            {
                if (!additive(num)) return false;
                int index = NUmber.count_of_digits(num);
                return prime(index);
            }
            public bool is_Cousin(int x, int y)
            {
                if (prime(y) && prime(x))
                    return x - y == 4;
                return false;
            }
            public bool is_euclid(int num)
            {
                if (!prime(num))
                    return false;
                num--;
                while (num != 1)
                {
                    ;
                }
                return false;
            }
            public bool is_fact(int num)
            {
                if (!prime(num))
                    return false;
                num--;
                if (NUmber.is_fact(num))
                    return true;
                num += 2;
                if (NUmber.is_fact(num))
                    return true;
                return false;
            }
            public bool is_isolated(int num)
            {
                num -= 2;
                if (prime(num)) return false;
                num += 4;
                if (prime(num))
                    return false;
                return true;
            }
            public bool is_safe(int num)
            {
                if (!prime(num)) return false;
                num--;
                num /= 2;
                return prime(num);
            }
            public bool is_carol(int num)
            {
                if (!prime(num))
                    return false;
                num -= 2;
                num = NUmber.square_root(num);
                return false;

            }

            public bool is_super(int num)
            {
                if (!prime(num))
                    return false;
                int i = index(num);
                return prime(i);
            }

            public bool is_Sophie_germain(int num)
            {
                if (!prime(num))
                    return false;
                int i = 2 * num + 1;
                return prime(i);
            }

            public bool is_sexy(int num1, int num2)
            {
                if (prime(num1) && prime(num2))
                    if (num1 - num2 == 6)
                        return true;
                return false;
            }
        }
        class PI
        {
            string Pi = "";
            public PI()
            {
                StreamReader sw = new StreamReader("pi1.txt");
                Pi = sw.ReadLine();

            }

            public void print(int x)
            {
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine(Pi[i]);
                }
                int num = 0;
                int count = 0;
                Console.WriteLine("oop");
                while (count < x)
                {
                    char ch = Pi[count++];
                    num = (int)ch;
                    num -= 48;
                    Console.WriteLine(num);
                }
            }
            public int sum(int x)
            {
                int sum = 0;
                int count = 0;
                int num = 0;
                while (count < x)
                {
                    char ch = Pi[count++];
                    num = (int)ch;
                    num -= 48;
                    sum += num;
                    // Console.WriteLine(num);

                }

                return sum;
            }
        }
        public class BIt_Manipulation
        {
            public static bool is_even(int num)
            {
                return (num & 1) == 0;
            }

            public static void print_binary_num(int num)
            {
                while (num != 0)
                {
                    Console.Write((num & 1) + "\t");
                    num >>= 1;
                }
            }
            public static int from_dic_bin(int num)
            {
                int s = 0;
                int b = 1;
                while (num != 0)
                {
                    int d = num % 2;
                    d *= b;
                    s += d;
                    b *= 10;
                    num /= 2;
                }
                return s;
            }

            public static int from_dic_oct(int num)
            {
                int s = 0;
                int b = 1;
                while (num != 0)
                {
                    int d = num % 8;
                    d *= b;
                    s += d;
                    b *= 10;
                    num /= 8;
                }
                return s;
            }
            public static int from_dic_hex(int num)
            {
                int s = 0;
                int b = 1;
                while (num != 0)
                {
                    int d = num % 16;
                    if (d > 9)
                    {
                        ;
                    }
                    d *= b;
                    s += d;
                    b *= 10;
                    num /= 16;
                }
                return s;
            }

            public static void print_binary_num_2(int num)
            {
                while (num != 0)
                {
                    Console.Write((num % 2 + "\t"));
                    num /= 2;
                }
            }
            public static int from_bin_dic(int num)
            {
                int sum = 0;
                String x = num.ToString();
                x = STring.reverse(x);
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] == '0')
                        sum += 0;
                    else sum += (pow_2(i));
                }
                return sum;
            }

            public static int pow_2(int pow)
            {
                int sum = 1;
                for (int i = 1; i <= pow; i++)
                    sum *= 2;
                return sum;
            }
            public static int and(int x, int y)
            {
                return x & y;
            }
            public static int or(int x, int y)
            {
                return x | y;
            }
            public static int x_or(int x, int y)
            {
                return x ^ y;
            }
            public static int not(int x)
            {
                return ~x;
            }
            public static int first_complement(int num)
            {
                return num;
            }
            public static int second_complement(int num)
            {
                return num;
            }

        }

        public class NOde_1
        {

            public int value;
            public NOde_1 next;

            public NOde_1()
            {
                this.next = null;
                this.value = 0;
            }

            public NOde_1(int value, NOde_1 next)
            {
                this.value = value;
                this.next = next;
            }

        }

        public class SIngle_link_list_no_tail
        {

            public NOde_1 Header = null;

            public void push_front(int v)
            {
                NOde_1 n1 = new NOde_1();
                n1.value = v;
                if (Header == null)
                {
                    n1.next = null;
                    Header = n1;
                }
                else
                {
                    n1.next = Header;
                    Header = n1;
                }
            }

            public void push_back(int v)
            {
                NOde_1 n1 = new NOde_1();
                n1.value = v;
                if (Header == null)
                {
                    n1.next = null;
                    Header = n1;
                }
                else
                {
                    NOde_1 p = Header;
                    while (p.next != null)
                    {
                        p = p.next;
                    }
                    n1.next = null;
                    p.next = n1;
                }
            }

            public void push_middle(int v)
            {
                NOde_1 n1 = new NOde_1();
                if (is_empty())
                {
                    n1.value = v;
                    n1.next = null;
                    Header = n1;
                }
                else
                {
                    int c = count();
                    c = c / 2;
                    NOde_1 p = Header;
                    int i = 1;
                    while (i < c)
                    {
                        p = p.next;
                        i++;
                    }
                    n1.value = v;
                    n1.next = p.next;
                    p.next = n1;
                }
            }

            public void display()
            {
                NOde_1 p = Header;
                while (p != null)
                {
                    Console.WriteLine(p.value);
                    p = p.next;
                }
            }

            public void print_reverse()
            {

            }

            public int count()
            {
                int c = 0;
                NOde_1 p = Header;
                while (p != null)
                {
                    p = p.next;
                    c++;
                }
                return c;
            }

            public int top_front()
            {
                if (Header == null)
                    return 0;
                else return Header.value;
            }

            public int top_back()
            {
                if (Header == null)
                    return 0;
                if (Header.next == null)
                    return Header.value;
                if (Header.next.next == null)
                    return Header.next.value;
                else
                {
                    NOde_1 p = Header;
                    while (p.next.next != null)
                        p = p.next;
                    return p.next.value;
                }

            }

            public void pop_front()
            {
                if (is_empty())
                    return;
                Header = Header.next;
            }

            public void pop_back()
            {
                if (is_empty())
                    return;
                if (Header.next == null)
                    Header = null;
                else
                {
                    NOde_1 p = Header;
                    while (p.next.next != null)
                    {
                        p = p.next;
                    }
                    p.next = null;
                }
            }

            public void pop_value(int value)
            {
                if (is_empty())
                    return;
                if (!find(value))
                    return;
                if (Header.value == value)
                    Header = null;
                else if (Header.next.value == value)
                    Header.next = Header.next.next;
                else
                {
                    NOde_1 p = Header;
                    while (p != null && p.next.value != value)
                        p = p.next;
                    return;
                }

            }
            public void pop_middle()
            {

            }

            public bool find(int v)
            {
                if (is_empty())
                    return false;
                else
                {
                    NOde_1 p = Header;
                    while (p != null)
                    {
                        if (p.value == v)
                            return true;
                        p = p.next;
                    }
                }
                return false;
            }

            public bool is_empty()
            {
                return Header == null;
            }

            public void destroy()
            {
                Header = null;
            }

            public SIngle_link_list_no_tail copy()
            {
                SIngle_link_list_no_tail s1 = new SIngle_link_list_no_tail();
                s1.Header = Header;
                return s1;
            }

            public void sort(int value)
            {


            }
        }


        public class SIngle_link_list_with_tail
        {

            public NOde_1 Header = null;
            public NOde_1 tail = null;

            public void push_front(int v)
            {
                NOde_1 n1 = new NOde_1();
                n1.value = v;
                if (Header == null)
                {
                    n1.next = null;
                    tail = Header = n1;
                }
                else
                {
                    n1.next = Header;
                    Header = n1;
                }
            }

            public void push_back(int v)
            {
                NOde_1 n1 = new NOde_1();
                n1.value = v;
                if (Header == null)
                {
                    n1.next = null;
                    tail = Header = n1;
                }
                else
                {
                    n1.next = null;
                    tail.next = n1;
                    tail = n1;
                }
            }

            public void display()
            {
                NOde_1 p = Header;
                while (p != null)
                {
                    Console.WriteLine(p.value);
                    p = p.next;
                }
            }

            public int count()
            {
                int c = 0;
                NOde_1 p = Header;
                while (p != null)
                {
                    p = p.next;
                    c++;
                }
                return c;
            }

            public void pop_front()
            {
                if (is_empty())
                    return;
                if (Header.next == null)
                {
                    tail = Header = null;
                }
                else
                    Header = Header.next;
            }

            public void pop_back()
            {
                if (is_empty())
                    return;
                if (Header.next == null)
                {
                    tail = Header = null;
                }
                else if (Header.next.next == null)
                {
                    Header.next = null;
                    tail = Header;
                }
                else
                {
                    NOde_1 p = Header;
                    while (p.next.next != null)
                    {
                        p = p.next;
                    }
                    p.next = null;
                    tail = p;
                }
            }

            public bool find(int v)
            {
                if (is_empty())
                    return false;
                else
                {
                    NOde_1 p = Header;
                    while (p != null)
                    {
                        if (p.value == v)
                            return true;
                        p = p.next;
                    }
                }
                return false;
            }

            public bool is_empty()
            {
                return Header == null;
            }

            public void destroy()
            {
                tail = Header = null;
            }
        }
        public class STak
        {
            int caps = 0;
            int count = 0;
            int[] A;
            public STak(int capacity)
            {
                A = new int[capacity];
                this.caps = capacity;
            }
            public bool is_full()
            {
                return this.count >= this.caps;
            }
            public bool is_empty()
            {
                return this.count == 0;
            }
            public void push(int key)
            {
                if (!is_full())
                    A[count++] = key;
                else
                    Console.WriteLine("full");
            }
            public void pop()
            {
                if (!is_empty()) --this.count;
                else
                    Console.WriteLine("empty");
            }
            public int top()
            {
                if (!is_empty())
                    return --this.count;
                Console.WriteLine("empty");
                return -1;
            }


        }

        public class STring
        {
            public static void print(String[] a)
            {
                foreach (String x in a)
                    Console.WriteLine(x);
            }
            public static void print(string a)
            {
                for (int i = 0; i < a.Length; i++)
                    Console.WriteLine(a[i]);
            }

            public static String[] split(String x)
            {
                return x.Split(' ');
            }

            public static String from_arr_str(String[] a)
            {
                String x = "";
                for (int i = 0; i < a.Length; i++)
                    x += a[i];
                return x;
            }
            public static String to_lower(String x)
            {
                String y = "";
                for (int i = 0; i < x.Length; i++)
                {
                    char ch = Char.ToLower(x[i]);
                    y += ch;
                }
                return y;
            }

            public static String to_upper(String x)
            {
                String y = "";
                for (int i = 0; i < x.Length; i++)
                {
                    char ch = Char.ToUpper(x[i]);
                    y += ch;
                }
                return y;
            }
            public static String from_char_str(char[] x)
            {
                String y = "";
                for (int i = 0; i < x.Length; i++)
                    y += x[i];
                return y;
            }
            public static char[] to_char_array(String x)
            {
                char[] ch = new char[x.Length];
                for (int i = 0; i < x.Length; i++)
                    ch[i] = char_at(x, i);
                return ch;
            }

            public static char char_at(String x, int index)
            {
                return x[index];
            }

            public static bool is_empty(String x)
            {
                return x == "";
            }
            public static bool palindromes(String x)
            {
                String y = reverse(x);
                return x == y;
            }

            public static bool is_anagram(String x, String y)
            {
                x = sort_str(x);
                y = sort_str(y);
                return x == y;
            }
            public static String[] extract_palindromes(String x)
            {
                String[] y = x.Split(' ');
                int count = 0;
                for (int i = 0; i < y.Length; i++)
                    if (palindromes(y[i]))
                        count++;
                String[] a = new string[count];
                count = 0;
                for (int i = 0; i < y.Length; i++)
                    if (palindromes(y[i]))
                        a[count++] = y[i];

                return a;

            }
            public static int last_index(String x, char y)
            {
                int c = -1;
                for (int i = 0; i < x.Length; i++)
                    if (x[i] == y)
                        c = i;
                return c;
            }

            public static int n_index(String x, char y, int count)
            {
                int index = -1;
                int c = 0;
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] == y)
                    {
                        c++;
                    }
                    if (c == count)
                    {
                        return i;
                    }
                }
                return index;
            }

            public static int first_index(String x, char y)
            {
                int c = -1;
                for (int i = 0; i < x.Length; i++)
                    if (x[i] == y)
                    {
                        c = i;
                        break;
                    }
                return c;
            }

            public static String remove_first_space(String x)
            {
                String y = "";
                int c = -1;
                for (int i = 0; i < x.Length; i++)
                    if (x[i] == ' ')
                        c = i;
                    else
                        break;
                for (int i = c + 1; i < x.Length; i++)
                    y += x[i];
                return y;
            }

            public static String remove_last_space(String x)
            {
                String y = "";
                int c = x.Length;
                for (int i = x.Length - 1; i >= 0; i--)
                    if (x[i] == ' ')
                        c = i;
                    else
                        break;
                for (int i = 0; i < c; i++)
                    y += x[i];
                return y;
            }

            public static String reverse(String x)
            {
                String y = "";
                for (int i = x.Length - 1; i >= 0; i--)
                    y += x[i];
                return y;
            }

            public static String reverse_words(String x)
            {
                String y = "";
                String[] A = x.Split(" ");
                for (int i = A.Length - 1; i >= 0; i--)
                    y += A[i] + " ";
                return y;
            }

            public static bool contain(String x, char y)
            {
                for (int i = 0; i < x.Length; i++)
                    if (x[i] == y)
                        return true;
                return false;
            }

            public static void print_occure_char(String x)
            {
                String y = remove_duplicate_1(x);
                Console.WriteLine(y);
                for (int i = 0; i < y.Length; i++)
                {
                    Console.WriteLine(y[i].ToString() + "\t" + (occurence(x, y[i])).ToString());
                }
            }
            public static int count_substring_in_string(String x, String y)
            {
                int count = 0;
                for (int i = 0; i < x.Length - y.Length; i++)
                {
                    for (int j = i; j < x.Length - 1; j++)
                    {
                        ;
                    }
                }
                return count;
            }
            public static String sort_str(String x)
            {
                String y = "";
                while (x != "")
                {
                    char m = min_char(x);
                    y += m;
                    x = remove_first_char(x, m);
                }
                return y;
            }

            public static String sort_words(String x)
            {
                String[] y = x.Split(' ');
                return "";
            }
            public static String remove_all_char(String x, char y)
            {
                String a = "";
                for (int i = 0; i < x.Length; i++)
                    if (x[i] != y)
                        a += x[i];
                return a;
            }
            public static String remove_first_char(String x, char y)
            {
                int index = x.IndexOf(y);
                String a = x.Substring(0, index) + x.Substring(index + 1);
                return a;
            }

            public static String remove_last_char(String x, char y)
            {
                int index = x.LastIndexOf(y);
                String a = x.Substring(0, index) + x.Substring(index + 1);
                return a;
            }
            public static String remove_n_index_char(String x, char y)
            {
                String a;
                int index = STring.n_index(x, y, 3);
                a = x.Substring(0, index) + x.Substring(index + 1);
                return a;
            }
            public static String remove_duplicate(String x)
            {
                String y = "";
                for (int i = 0; i < x.Length; i++)
                    if (!STring.contain(y, x[i]))
                        y += x[i];
                return y;
            }
            public static String remove_duplicate_1(String x)
            {
                char[] a = x.Distinct().ToArray();
                String y = from_char_str(a);
                return y;

            }

            public static int occurence(String x, char y)
            {
                int count = 0;
                for (int i = 0; i < x.Length; i++)
                    if (x[i] == y)
                        count++;
                return count;
            }

            public static char most_common(String x)
            {
                int m = occurence(x, x[0]);
                int c = 0;
                char a = x[0];
                for (int i = 0; i < x.Length; i++)
                {
                    c = occurence(x, x[i]);
                    if (c > m)

                    {
                        m = c;
                        a = x[i];
                    }
                }
                return a;
            }

            public static void print_duplicate_characters(String x)
            {

                for (int i = 0; i < x.Length; i++)
                    if (occurence(x, x[i]) > 1)
                        Console.WriteLine(x[i]);
            }

            public static int count_unique_chars(String x)
            {
                int count = 0;
                x = remove_duplicate(x);
                count = x.Length;
                return count;
            }
            public static int count_unique_chars_1(String x)
            {
                int count = 0;
                count = x.Distinct().ToArray().Length;
                // count = x.Length;

                return count;
            }

            public static char first_non_repeating_char(String x)
            {
                char a = ' ';
                for (int i = 0; i < x.Length; i++)
                    if (occurence(x, x[i]) == 1)
                        return x[i];
                return a;
            }

            public static String swap(String x, char a, char b)
            {
                String y = "";
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] == a)
                    {
                        y += b;
                        y += x.Substring(i + 1);
                    }
                    else
                        y += x[i];
                }
                return y;
            }

            public static String insert(String x, int pos, String y)
            {
                y += x.Substring(pos, x.Length - 1);
                x = x.Substring(0, pos) + y;
                return x;
            }

            public static String concat(String x, String y)
            {
                return x + y;
            }

            public static char max_char(String x)
            {
                char y = x[0];
                for (int i = 1; i < x.Length; i++)
                    if (x[i] > y)
                        y = x[i];
                return y;
            }
            public static char min_char(String x)
            {
                char y = x[0];
                for (int i = 1; i < x.Length; i++)
                    if (x[i] < y)
                        y = x[i];
                return y;
            }

            public static int freq_seqence(String x, String y)
            {
                int count = 0;


                return count;
            }

        }
        public class TWo_die_men_Arr
        {
            public static void fill(int[,] A)
            {
                int count = 0;
                for (int i = 0; i < A.GetLength(0); i++)
                    for (int j = 0; j < A.Length / A.GetLength(0); j++)
                        A[i, j] = ++count;
            }
            public static void display(int[,] A)
            {
                for (int i = 0; i < A.GetLength(0); i++)
                    for (int j = 0; j < A.Length / A.GetLength(0); j++)
                        Console.WriteLine(A[i, j]);
            }

            public static void display(char[,] A)
            {
                for (int i = 0; i < A.GetLength(0); i++)
                    for (int j = 0; j < A.Length / A.GetLength(0); j++)
                        Console.WriteLine(A[i, j]);
            }

            public static int sum(int[,] A)
            {
                int sum = 0;
                for (int i = 0; i < A.GetLength(0); i++)
                    for (int j = 0; j < A.Length / A.GetLength(0); j++)
                        sum += A[i, j];
                return sum;
            }

            public static double avg(int[,] A)
            {
                int s = sum(A);
                double b = A.Length;
                double a = s / b;
                return a;
            }

            public static int min(int[,] A)
            {
                int m = A[0, 0];
                for (int i = 0; i < A.GetLength(0); i++)
                    for (int j = 0; j < A.Length / A.GetLength(0); j++)
                        if (A[i, j] < m)
                            m = A[i, j];
                return m;
            }

            public static int max(int[,] A)
            {
                int m = A[0, 0];
                for (int i = 0; i < A.GetLength(0); i++)
                    for (int j = 0; j < A.Length / A.GetLength(0); j++)
                        if (A[i, j] > m)
                            m = A[i, j];
                return m;
            }

            public static bool find(int[,] A, int x)
            {
                for (int i = 0; i < A.GetLength(0); i++)
                    for (int j = 0; j < A.Length / A.GetLength(0); j++)
                        if (A[i, j] == x)
                            return true;
                return false;
            }

            public static int occurence(int[,] A, int x)
            {

                int count = 0;
                for (int i = 0; i < A.GetLength(0); i++)
                    for (int j = 0; j < A.Length / A.GetLength(0); j++)
                        if (A[i, j] == x)
                            count++;
                return count;
            }

            public static int most_common(int[,] A)
            {
                int c = 0, m = 0, n = 0;
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < A.Length / A.GetLength(0); j++)
                    {
                        c = occurence(A, A[i, j]);
                        if (c > m)
                        {
                            m = c;
                            n = A[i, j];
                        }
                    }
                }
                return n;
            }

            public static String to_string(int[,] A)
            {
                String x = "";
                for (int i = 0; i < A.GetLength(0); i++)
                    for (int j = 0; j < A.Length / A.GetLength(0); j++)
                        x += A[i, j];
                return x;
            }


            public static int count_of_unique_numbers(int[,] A)
            {
                int count = 0, c = 0;
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < A.Length / A.GetLength(0); j++)
                    {
                        c = occurence(A, A[i, j]);
                        if (c == 1)
                            count++;
                    }
                }
                return count;
            }
            public static void print_origin_diagonal(int[,] A)
            {
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < A.Length / A.GetLength(0); j++)
                    {
                        if (i == j)
                            Console.WriteLine(A[i, j]);
                    }
                }
            }

            public static int sum_origin_diagonal(int[,] A)
            {
                int num = 0;
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < A.Length / A.GetLength(0); j++)
                    {
                        if (i == j)
                            num += A[i, j];
                    }
                }
                return num;
            }
            public static int sum_second_diagonal(int[,] A)
            {
                int num = 0;

                return num;
            }
            public static int[,] sum_two(int[,] A, int[,] B)
            {
                int[,] C = new int[A.GetLength(0), A.Length / A.GetLength(0)];
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < A.Length / A.GetLength(0); j++)
                    {
                        C[i, j] = A[i, j] + B[i, j];
                    }
                }
                return C;
            }
            public static int[,] mul_two(int[,] A, int[,] B)
            {
                int[,] C = new int[A.GetLength(0), A.Length / A.GetLength(0)];

                return C;
            }
        }

        /*public enum Gender
        {
            Unkown,
            Male,
            Female
            */
        /*
            other codes
                    Gender g1 = new Gender();
            g1 = Gender.Male;
            String[] A = (String[])Enum.GetNames(typeof(Gender));
            foreach (String i in A)
                Console.WriteLine(i);
            Console.WriteLine(Enum.GetName(typeof(Gender), 0));



             */
        /*
        }*/

        /*public enum Color
        {
            White,
            Red,
            Blue,
            Brown,
            Green
        }*/

        public class Informatio_security
        {
            public Informatio_security()
            {
            }

            public static String Caesar(String x, int key)
            {
                String y = "";
                int index = 0;
                for (int i = 0; i < x.Length; i++)
                {
                    index = Char_1.asci_1(x[i]);
                    index += key;
                    y += Char_1.asci_2(index);
                }
                return y;
            }

        }

        //DirectoryInfo
        /*
        DriveInfo d1 = new DriveInfo("E:");


        print(d1.Name);
        print(d1.TotalSize);
        print(d1.IsReady);
        print(d1.VolumeLabel);
        print(d1.AvailableFreeSpace);
        print(d1.DriveFormat);// NTF 
        print(d1.DriveType);
        print(d1.GetType());
        print(d1.RootDirectory + "oop");
        DriveInfo []D=    DriveInfo.GetDrives();
        foreach (DriveInfo d in D)
            Console.WriteLine(d.Name);
        DirectoryInfo d2 = new DirectoryInfo("E:\\Courses\\C#\\Courses\\c#2\\Lesson 72 - File Handling -Directory and DirectoryInfo");
        print("\n\n"+d2.Name);
        print(d2.FullName);
        print(d2.Parent);
        print(d2.Refresh);
        print(d2.Root);
        print(d2.Attributes);
        print(d2.CreationTime);

        print(d2.LastAccessTime);
        print(d2.LastWriteTime);
        print(d2.Name);
        print(d2.Extension);
        print(d2.CreationTimeUtc);
        print(d2.Exists);
        print(d2.LastWriteTimeUtc+"\n\n\n");
        print(d2.UnixFileMode);
        // d2.SetAccessControl(d2,)
        FileInfo []f = d2.GetFiles();
        foreach (FileInfo  b in f)
            Console.WriteLine(b);
        DirectoryInfo []d4 = d2.GetDirectories();
        foreach (DirectoryInfo d in d4) 
            Console.WriteLine(d);
        DirectoryInfo opo = new DirectoryInfo("E:\\Courses\\C#\\Courses\\c#2\\mmmm");
        opo.Create();
        print(opo.CreationTime);
        opo.Delete();
        */

        //  File 
        /*
        //File.Move("E:\\Ahmad_Ashraf.docx", "D:\\oop.docx");
        print(File.Exists("E:\\Ahmad_Ashraf.docx"));
        FileInfo f1 = new FileInfo("E:\\Courses\\C#\\Courses\\c#2\\Form1.cs");
        //f1.CopyTo("D:ppp.docx");
        print(f1.Extension);
        print(f1.FullName);
        // print(f1.Length);
        print(f1.CreationTime);
        print(f1.LastWriteTime);
        print(f1.LastAccessTime);
        print(f1.LastWriteTimeUtc);
        print(f1.Name);
        print(f1.LinkTarget);
        print(f1.Attributes);
        print(f1.UnixFileMode);
        print(f1.Refresh);
        print(f1.CreationTimeUtc);
        print(f1.IsReadOnly);
        print(f1.ToString());
        print(f1.OpenWrite);

        FileStream f2 = new FileStream("E:\\oop.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        f2.Position = 0;
        print(f2.ToString());
        print(f2.CanSeek);
        print(f2.CanWrite);
        print(f2.CanRead);


        StreamWriter sw = new StreamWriter(f2);
        sw.WriteLine("oop");
        sw.Close();
        */

        // DateTime
        /*
                 DateTime now = DateTime.Now;
                print(now);
                print(now.Date); print(now.Hour); print(now.Minute); print(now.Second); print(now.Millisecond);
                now = now.AddDays(10);
                now = now.AddYears(10);
                now = now.AddHours(10);
                now = now.AddMinutes(10);
                now = now.AddSeconds(10);
                now = now.AddMilliseconds(10);
                print(now.DayOfYear);
                print(now.DayOfWeek);
                print(now.Day);
                print(now.Year);
                print(DateTime.IsLeapYear(2020));
                print(DateAndTime.Today);
                print(DateAndTime.Today.Year); print(DateAndTime.Today.Month); print(DateAndTime.Today.DayOfYear);
                print(DateAndTime.Timer);
                print(DateAndTime.TimeString);
                print(DateAndTime.MonthName);
                //DateFormat.ShortDate=3;
                // TimeZoneInfo 
                Timer timer = new Timer();
                timer.Start();
                timer.Enabled = true;
                timer.Stop();
        */

        //  TYpe

        /*
                 String x = "oop";
                if (x is String)
                    Console.WriteLine(true);
                int y=90;

                Type p = y.GetType();
                Console.WriteLine(p.ToString());
                Console.WriteLine(p.Name);
                Console.WriteLine(p.FullName);
                Console.WriteLine(p.IsValueType );
                Console.WriteLine(p.IsEnum );
                Console.WriteLine(p.DeclaringType);
                Console.WriteLine(p.Assembly);
                Console.WriteLine(p.Module);
                Console.WriteLine(p.Namespace);
                Console.WriteLine(p.MetadataToken);
        */

        /*class Person
        {
            String f_name;
            String l_name;

            public Person(string f_name, string l_name)
            {
                this.f_name = f_name;
                this.l_name = l_name;
            }

        }*/

        /*        String x = "123";
                string p = null;
                double pp;
                int? y =null;
                y = 90;
                Console.WriteLine(y.HasValue.ToString() + "ppp");
                Console.WriteLine(y ?? 9000);
                Console.WriteLine(ll((int)y));
                int m = int.Parse(x);
                Console.WriteLine(m.GetType); */
        class Problem_Solving
        {
            public static void sum_even_odd(int[] A)
            {
                int sum_even = 0;
                int sum_odd = 0;
                for (int i = 0; i < A.Length; i += 2)
                    sum_odd += A[i];
                for (int i = 1; i < A.Length; i += 2)
                    sum_even += A[i];
                if (sum_even == sum_odd)
                    Console.WriteLine("yes" + sum_odd.ToString());
                else
                    Console.WriteLine("no\t" + (sum_odd - sum_even).ToString());
            }

            public static int sum_Vowels(String x)
            {
                /* Dictionary<Char, int> D = { 'a':1,'e':2,'i':3,'o':4,'u':5};
                 int count = 0;
                 for(int i=0;i<x.Length;i++)
                     if (Char_1.is_vowel(x[i]))
                     {

                     }

                 */
                return 0;
            }

            public static void Element_Equal_Sum_all(int[] A)
            {
                int max = Array_1.max(A);
                int sum = 0;
                for (int i = 0; i < A.Length; i++)
                    sum += A[i];
                sum = sum - max;
                if (sum == max)
                    Console.WriteLine("yes\tsum= = " + sum.ToString());
                else
                    Console.WriteLine("no\t diff= " + (sum - max).ToString());
            }

            public static void Even_Odd_Positions(int[] A)
            {
                int sum_odd = 0;
                int sum_even = 0;
                int max_odd = A[0];
                int max_even = A[1];
                int min_odd = A[0];
                int min_even = A[1];
                int j = 1;
                for (int i = 0; i < A.Length; i += 2)
                {
                    sum_odd += A[i];
                    sum_even += A[j];
                    if (A[i] > max_odd)
                        max_odd = A[i];
                    if (A[j] > max_even)
                        max_even = A[j];
                    if (A[j] < min_even)
                        min_even = A[j];
                    if (A[i] < min_odd)
                        min_odd = A[i];

                    j += 2;
                }
                Console.WriteLine(sum_odd + "\n" + min_odd + "\n" + max_odd + "\n");
                Console.WriteLine(sum_even + "\n" + min_even + "\n" + max_even);
            }

            public static void Division_without_Remainder(int[] A)
            {
                int[] p1_2, p2_3;
                int c2 = 0, c3 = 0, c4 = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] % 2 == 0)
                        c2++;
                    if (A[i] % 3 == 0)
                        c3++;
                    if (A[i] % 4 == 0) c4++;
                }
                p1_2 = new int[c2];
                p2_3 = new int[c3];

            }
            public static void valid_num_with_range(int range, int num)
            {
                if (num >= 1 && num <= range)
                    return;
                else
                {
                    Console.WriteLine("Enter again");
                    int x = int.Parse(Console.ReadLine());
                    valid_num_with_range(range, x);
                }
            }

            public static void valid_even_num(int num)
            {
                if (num % 2 == 0)
                    return;
                else
                {
                    Console.WriteLine("Enter again");
                    int x = int.Parse(Console.ReadLine());
                    valid_even_num(x);
                }
            }
            public static void print_pyramid_number(int num)
            {
                int c = 1;

                for (int i = 0; i < num * 10000; i++)
                {
                    {
                        for (int j = 0; j <= i; j++)
                            Console.Write(c++ + "\t");
                        if (c >= num)
                            break;
                    }
                    Console.WriteLine();
                }

            }
            public static long hms_to_secs(int hours, int min, int sec)
            {
                int secs = sec;
                min = min * 60;
                secs += min;
                hours = hours * 60;
                hours *= 60;
                secs += hours;
                return secs;
            }
            public static int[] sect_hourse(int sec)
            {
                int[] A = new int[3];
                int hour = sec / 3600;
                sec = sec % 3600;
                int min = sec / 60;
                sec %= 60;
                A[0] = hour;
                A[1] = min;
                A[2] = sec;
                return A;

            }
        }

        class Shape
        {
            public static void stop_sign(int x)
            {
                for (int i = 0; i < x; i++)
                {
                    for (int j = 3; j > i; j--)
                        Console.Write("*");

                    Console.WriteLine();
                }
            }

            public static void diamond(int num)
            {
                for (int i = 1; i <= num; i++)
                {
                    for (int j = num; j > i; j--)
                        Console.Write(' ');
                    for (int k = 1; k <= i; k++)
                        Console.Write("*");



                    Console.WriteLine();
                }
            }

            public static void pascal_triangle()
            {
                for (int i = 1; i <= 9; i++)
                {
                    for (int j = 9; j > i; j--)
                        Console.Write(" ");
                    for (int k = i; k > 0; k--)
                        Console.Write(k);
                    for (int l = 2; l > i; l--)
                        Console.Write(l);
                    Console.WriteLine();
                }
            }
        }
        class Sequences
        {
            public static void Triangular_Number_Sequence()
            {
                int s = 1;
                int c = 2;
                for (int i = 1; i <= 9; i++)
                {
                    Console.WriteLine(s);
                    s += c;
                    c++;


                }
            }
        }

        public class Fraction_Number
        {

            double num, denum;

            public Fraction_Number()
            {
                this.num = this.denum = 0;
            }

            public Fraction_Number(double num, double denum)
            {
                this.num = num;
                this.denum = denum;
            }

            public void setNum(double num)
            {
                this.num = num;
            }

            public void setDenum(double denum)
            {
                this.denum = denum;
            }

            public double getNum()
            {
                return num;
            }

            public double getDenum()
            {
                return denum;
            }

            public double sum(Fraction_Number f1, Fraction_Number f2)
            {

                double a = f1.num * f2.denum;
                double b = f1.denum * f2.num;
                a += b;
                b = f1.denum * f2.denum;
                Console.WriteLine(a + "/" + b + "\t");
                a = a / b;
                return a;
            }

            public double sub(Fraction_Number f1, Fraction_Number f2)
            {

                double a = f1.num * f2.denum;
                double b = f1.denum * f2.num;
                a -= b;
                b = f1.denum * f2.denum;
                Console.WriteLine(a + "/" + b + "\t");
                a = a / b;
                return a;
            }

            public double mul(Fraction_Number f1, Fraction_Number f2)
            {

                double a = f1.num * f2.num;
                double b = f1.denum * f2.denum;
                Console.WriteLine(a + "/" + b + "\t");
                a = a / b;
                return a;
            }

            public double div(Fraction_Number f1, Fraction_Number f2)
            {

                double a = f1.num * f2.denum;
                double b = f1.denum * f2.num;
                Console.WriteLine(a + "/" + b + "\t");
                a = a / b;
                return a;
            }

        }

        public class Complex_Number
        {

            private double real, img;

            public Complex_Number()
            {
                this.img = this.real = 0;
            }

            public Complex_Number(double x, double y)
            {
                this.real = x;
                this.img = y;
            }

            public void setReal(double real)
            {
                this.real = real;
            }
            public void setImg(double img)
            {
                this.img = img;
            }
            public double getReal()
            {
                return real;
            }

            public double getImg()
            {
                return img;
            }

            public Complex_Number add(Complex_Number c1, Complex_Number c2)
            {
                Complex_Number c3 = new Complex_Number();
                c3.real = c1.real + c2.real;
                c3.img = c1.img + c2.img;
                return c3;
            }

            public Complex_Number sub(Complex_Number c1, Complex_Number c2)
            {
                Complex_Number c3 = new Complex_Number();
                c3.real = c1.real - c2.real;
                c3.img = c1.img - c2.img;
                return c3;
            }

            public Complex_Number mul(Complex_Number c1, Complex_Number c2)
            {
                Complex_Number c3 = new Complex_Number();
                double x = c1.real * c2.real;
                double y = c1.img * c2.img;
                x = x - y;
                c3.real = x;
                x = c1.real * c2.img;
                y = c2.real * c1.img;
                x = x + y;
                c3.img = x;
                return c3;
            }

            public Complex_Number div(Complex_Number c1, Complex_Number c2)
            {
                Complex_Number c3 = new Complex_Number();
                double x = c1.real * c2.real;
                double y = c1.img * c2.img;
                c3.real = x + y;
                x = c1.real * c2.img;
                x *= -1;
                y = c1.img * c2.real;
                c3.img = x + y;
                x = c2.real * c2.real;
                y = c2.img * c2.img;
                x = x + y;
                c3.real /= x;
                c3.img /= y;

                return c3;
            }
            public double abs(Complex_Number c1, Complex_Number c2)
            {
                double s = 0;
                c1.real = c1.real - c2.real;
                c1.img = c1.img - c2.img;
                c1.real = Math.Abs(c1.real);
                c1.img = Math.Abs(c1.img);
                s = c1.real * c1.real + c2.img * c2.img;
                s = Math.Sqrt(s);

                return s;
            }
            public static Complex_Number operator +(Complex_Number c1, Complex_Number c2)
            {
                return new Complex_Number(c1.real + c2.real, c1.img + c2.img);
            }
            public static Complex_Number operator -(Complex_Number c1, Complex_Number c2)
            {
                return new Complex_Number(c1.real - c2.real, c1.img - c2.img);
            }

            public static Complex_Number operator ++(Complex_Number c1)
            {
                return new Complex_Number(c1.real + 1, c1.img);
            }
            public static bool operator >(Complex_Number c1, Complex_Number c2)
            {
                if (c1.real == c2.real)
                    return c1.img > c2.img;
                else
                    return c1.real > c2.real;
            }

            public static bool operator <(Complex_Number c1, Complex_Number c2)
            {
                if (c1.real == c2.real)
                    return c1.img < c2.img;
                else
                    return c1.real < c2.real;
            }
            public static bool operator ==(Complex_Number c1, Complex_Number c2)
            {
                if ((c1.real == c2.real) && (c1.img == c2.img))
                    return true;
                return false;
            }

            public static bool operator !=(Complex_Number c1, Complex_Number c2)
            {
                if ((c1.real != c2.real) && (c1.img != c2.img))
                    return true;
                return false;
            }

            public static explicit operator double(Complex_Number c1)
            {
                return c1.real;
            }
        }


        public class Triangle
        {
            private double x, y, z;
            public Triangle()
            {
                this.x = this.y = this.z = 0;
            }

            public Triangle(double x, double y, double z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }

            public void setX(double x)
            {
                this.x = x;
            }

            public void setY(double y)
            {
                this.y = y;
            }

            public void setZ(double z)
            {
                this.z = z;
            }

            public double getX()
            {
                return x;
            }

            public double getY()
            {
                return y;
            }

            public double getZ()
            {
                return z;
            }

            public bool is_triangle()
            {
                return (this.x + this.y > this.z) && (this.x + this.z > this.y) && (this.y + this.z > this.x);
            }

            public double premeter()
            {
                return this.x + this.y + this.z;
            }
            public String types_sides()
            {
                if ((this.x == this.y) && (this.y == this.z))
                    return "Equilateral Triangle";
                else if ((this.x == this.y) || (this.y == this.z) || (this.x == this.z))
                    return "Isosceles Triangle";
                return "Scalene Triangle";
            }

            public double area()
            {
                double s = this.x + this.y + this.z;
                double b = s / 2;
                double a = s * (s - this.x) * (s - this.y) * (s - this.z);
                a = Math.Sqrt(a);
                return a;
            }
        }
        public class Rectangle
        {
            double len;
            public Rectangle(double l)
            {
                this.len = l;
            }
            public void set_len(double len)
            {
                this.len = len;
            }
            public double premeter()
            {
                return 4 * this.len;
            }
            public double area()
            {
                return this.len * this.len;
            }
        }
        public class Circle
        {
            private double r;
            public Circle()
            {
                this.r = 0;
            }
            public Circle(double r)
            {
                this.r = r;
            }
            public void setR(double r)
            {
                this.r = r;
            }

            public double getR()
            {
                return r;
            }

            public double premeter()
            {
                return 2 * Math.PI * r;
            }

            public double area()
            {
                return 2 * Math.PI * r;
            }
        }

        public class POint
        {
            private double x, y;
            public POint()
            {
                this.x = this.y = 0;
            }
            public POint(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            public void setX(double x)
            {
                this.x = x;
            }
            public void setY(double y)
            {
                this.y = y;
            }
            public double getX()
            {
                return x;
            }
            public double getY()
            {
                return y;
            }
            public bool is_original()
            {
                return this.x == 0 && this.y == 0;
            }
            public double distance(POint p1, POint p2)
            {
                double x = p1.x - p2.x;
                x *= x;
                double y = p1.y - p2.y;
                y *= y;
                x += y;
                return Math.Sqrt(x);
            }
            public double Manhattan_distance(POint p1, POint p2)
            {
                double p = 0;
                p = p1.x - p2.x;
                p = Math.Abs(p);
                p1.x = p1.y - p2.y;
                p1.x = Math.Abs(p1.x);
                p += p1.x;
                return p;
            }
            public double cross_vector(POint p1, POint p2)
            {
                double v = p1.x * p2.y - p1.y * p2.x;
                return v;
            }
        }

        public class Quran
        {
            public int[] Verses = { 7, 286, 200, 176, 120, 165, 206, 75, 129, 109, 123, 111, 43, 52, 99, 128, 111, 110, 98, 135, 112, 78, 118, 64, 77, 227, 93, 88, 69, 60, 34, 30, 73, 54, 45, 83, 182, 88, 75, 85, 54, 53, 89, 59, 37, 35, 38, 29, 18, 45, 60, 49, 62, 55, 78, 96, 29, 22, 24, 13, 14, 11, 11, 18, 12, 12, 30, 52, 52, 44, 28, 28, 20, 56, 40, 31, 50, 40, 46, 42, 29, 19, 36, 25, 22, 17, 19, 26, 30, 20, 15, 21, 11, 8, 8, 19, 5, 8, 8, 11, 11, 8, 3, 9, 5, 4, 7, 3, 6, 3, 5, 4, 5, 6 };
            public int[] sum_v_i;
            public int count_even = 0, count_odd = 0;
            public int sum_even = 0, sum_odd = 0;
            public int sum_verses = 0, sum_digit = 0, count_digit = 0;
            int[] Dup, Uni;
            public Quran()
            {
                sum_v_i = new int[Verses.Length];
                for (int i = 0; i < Verses.Length; i++)
                    sum_v_i[i] = Verses[i] + (i + 1);
                sum_verses = Array_1.sum(Verses);
            }

            public void oop()
            {
                for (int i = 0; i < Verses.Length; i++)
                    if (sum_v_i[i] % 2 == 0)
                    {
                        count_even++;
                        sum_even += sum_v_i[i];
                    }
                    else
                    {
                        count_odd++;
                        sum_odd += sum_v_i[i];
                    }
                int count = 0;
                for (int i = 0; i < sum_v_i.Length; i++)
                    if (Array_1.Occurence(sum_v_i, sum_v_i[i]) > 1)
                        count++;
                Dup = new int[count];
                count = 0;
                for (int i = 0; i < sum_v_i.Length; i++)
                    if (Array_1.Occurence(sum_v_i, sum_v_i[i]) > 1)
                        Dup[count++] = sum_v_i[i];
            }
            public int under_114()
            {
                int count = 0;
                for (int i = 1; i <= 114; i++)
                    if (Verses.Contains(i) && i % 2 == 0)
                        count++;
                return count;
            }

            public int sum_Digit()
            {
                sum_digit = 0;
                for (int i = 0; i < Verses.Length; i++)
                    sum_digit += NUmber.sum_of_digits(Verses[i]);
                Console.WriteLine(sum_digit);
                return sum_digit;
            }

            public int count_Digit()
            {
                count_digit = 0;
                for (int i = 0; i < Verses.Length; i++)
                    count_digit += NUmber.count_of_digits(Verses[i]);
                Console.WriteLine(count_digit);
                return count_digit;
            }

            public int max_prime()
            {
                Prime_numbers p = new Prime_numbers();
                int max = 2;
                for (int i = 0; i < Verses.Length; i++)
                {
                    if (p.prime(Verses[i]))
                        if (Verses[i] > max)
                            max = Verses[i];
                }
                return max;
            }

            public int cummulative_sum()
            {
                int sum = 0;
                for (int i = 0; i < Verses.Length; i++)
                    for (int j = 1; j <= Verses[i]; j++)
                        sum += j;
                Console.WriteLine(sum);
                return sum;
            }
        }

        class OOp
        {
            string name;
            int age;
            double grade;
            char grade_;
            int[] A;
            static int num;

            public OOp()
            {
                Console.WriteLine(this.name);
                Console.WriteLine(this.age);
                Console.WriteLine(this.grade);
                Console.WriteLine(this.grade_);
                A = new int[7];
                foreach (int i in A)
                    Console.WriteLine(i);
                Console.WriteLine("pp" + num);
            }

            /* OOp(string name, int age, double grade)
             {
                 this.name = name;
                 this.age = age;
                 this.grade = grade;
             }
            */
        }

        class Equation
        {
            double x, y;
            double c;
            double slope;
            public Equation()
            {
                this.x = this.y = this.c = this.slope = 0;
            }
            public void set_x(int x)
            {
                this.x = x;
            }
            void set_y(double y)
            {
                this.y = y;
            }

            void set_c(double c)
            {
                this.c = c;
            }
            void set_slope(double slope)
            {
                this.slope = slope;
            }
            double get_x()
            {
                return this.x;
            }

            double get_y()
            {
                return this.y;
            }

            double get_slope()
            {
                this.slope = -x / y;
                return this.slope;
            }
            bool is_parallel_or_optimal(Equation e1, Equation e2)
            {
                POint p1 = new POint(x: e1.x, y: e1.y);
                POint p2 = new POint(x: e2.x, y: e2.y);
                double s1 = e1.slope;
                double s2 = e2.slope;
                if (s1 == s2)
                    return true;

                return false;
            }
            POint intersecion_point(Equation e1, Equation e2)
            {
                POint p1 = new POint(x: 0, y: 0);
                var l = is_parallel_or_optimal(e1, e2);
                if (l == false)
                {
                    double d = (-e2.c - e2.y) / e2.x;
                    d = e1.x * d;
                }
                return p1;
            }

        }

        /*void calcResult(var grade)
        {
            double grade = 0;
            String result = "";
            String degree = "";
            if (grade >= 90)
            {
                result = "Excellent";
                if (grade >= 95)
                    degree = "A+";
                else degree = "A-";
            }
            else if (grade >= 80)
            {
                result = "Very Good";
                if (grade >= 85)
                    degree = "B+";
                else degree = "B-";
            }
            else if (grade >= 70)
            {
                result = "Good";
                if (grade >= 75)
                    degree = "C+";
                else degree = "C-";
            }
            else if (grade >= 50)
            {
                result = "Accepted";
                if (grade >= 65)
                    degree = "D+";
                else degree = "D-";
            }
            else
            {
                result = "Fail";
                degree = "F";
            }
        }*/



        class Point3D : ICloneable, IComparable<Point3D>
        {
            private double x, y, z;
            public Point3D(double x)
            {
                this.x = x;
            }
            public Point3D(double x, double y) : this(x)
            {
                this.y = y;
            }
            public Point3D(double x, double y, double z) : this(x, y)
            {
                this.z = z;
            }
            // copy constructor
            public Point3D(Point3D point3D)
            {
                this.x = point3D.x;
                this.y = point3D.y;
                this.z = point3D.z;
            }

            public object Clone()
            {
                return new Point3D(this.x, this.y, this.z);
                return new Point3D(this);
            }

            public override string ToString()
            {
                return ($"point coordinates:({this.x}\t{this.y}\t {this.z}");
            }

           

            public static explicit operator Point3D(POint p)
            {
                return new Point3D(p.getX(), p.getY(), 9);
            }

            public static bool equal(Point3D point3D, Point3D other)
            {
                return ((point3D.x == other.x) && (point3D.y == other.y));
            }

            public override bool Equals(object? obj)
            {
                Point3D point3D = (Point3D)obj;
                return ((this.x == point3D.x) && (this.y == point3D.y));
            }
            public int CompareTo(object? obj)
            {
                //if (obj is Point3D point3D)
                Point3D point3D = obj as Point3D;
                {
                    if (obj == null) return 1;
                    if (this.x == point3D.x)
                        return (this.y.CompareTo(point3D.y));
                    else
                        return this.x.CompareTo(point3D.x);
                }
            }
            public int CompareTo(Point3D? other)
            {
                if (other == null) return 1;
                if (this.x == other.x)
                    return this.y.CompareTo(other.y);
                return this.x.CompareTo(other.x);
            }
        }
        class Phone_Book
        {
            string[] names;
            int[] nums;
            int size;
            public Phone_Book(int size)
            {
                this.size = size;
                names = new string[size];
                nums = new int[size];
            }

            public void add_person(int index, string name, int num)
            {
                if (index >= 0 && index < names.Length)
                {
                    names[index] = name;
                    nums[index] = num;
                }
            }
            public int this[string n, int op]
            {
                get
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == n)
                            return nums[i] * op;
                    }
                    return -1;
                }
                set
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == n)
                        {
                            nums[i] = value;
                        }
                    }
                }
            }

            public string this[int n]
            {
                get
                {
                    for (int i = 0; i < nums.Length; i++)
                        if (nums[i] == n)
                            return names[i];
                    return null;
                }
                set
                {
                    for (int i = 0; i < nums.Length; i++)
                        if (nums[i] == n)
                            names[i] = value;
                }
            }
            public int Size
            {
                get { return this.size; }
            }
        }
        internal class Employee
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public decimal Salary { get; set; }
            public int? Age { get; set; }

        }

        /*class Employee*//*:ICloneable,IComparable*//*
        {
            // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Key]
            public int Id;
            string f_name;
            int? age;
            double sal;

            //public Employee()
            //{

            //}
            ////public Employee() { } 
            //public Employee(int id, string fn, string ln, int g, double sal)
            //{
            //    this.Id = id;
            //    this.f_name = fn;
            //    this.age = g;
            //    this.sal = sal;
            //}
            //public Employee(int id)
            //{
            //    this.Id = id;
            //}
            //public void set_name(string op)
            //{
            //    this.f_name = op.Length < 5 ? op : op.Substring(0, 5);
            //}
            //public string F_name
            //{
            //    get { return this.f_name; }
            //    set { this.f_name = value; }
            //}
            //public int ID
            //{
            //    get { return this.Id; }
            //    set
            //    {
            //        this.ID = value;
            //    }
            //}
            //public virtual void oop()
            //{
            //    Console.WriteLine("hjhh");
            //}
            //public override string ToString()
            //{
            //    return $"id:  {this.Id}\n name: {this.f_name }";
            //}

            //public object Clone()
            //{
            //    return new Employee()
            //    {
            //        Id = this.Id,

            //    };
            //}

            //public int CompareTo(object? obj)
            //{
            //    Employee e1 = (Employee)obj;
            //    if (this.Id > e1.ID)
            //        return 1;
            //    else if (this.Id < e1.ID)
            //        return -1;
            //    return 0;
            //}
        }
    */
        //class Full_time_employee:Employee
        //{
        //    public Full_time_employee(int id, string m, string p, double s) /*: base(1, "ss", "saas", 4, 7)*/
        //    {

        //    }
        //    //public Full_time_employee():base(7)
        //    //{

        //    //}

        //    public new  void opp()
        //    {
        //        //  base.oop();
        //        Console.WriteLine("lllllllllll");
        //    }
        //    //public override void oop()
        //    //{
        //    //    base.oop();
        //    //}
        //    public override string ToString()
        //    {
        //        return "jjk";
        //    }
        //}


        /*  internal class Employee
          {
              public int Id { get; set; }
              public string? Name { get; set; }
              public decimal Salary { get; set; }
              public int? Age { get; set; }

          }*/

        /*class Employee*//*:ICloneable,IComparable*//*
        {
            // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Key]
            public int Id;
            string f_name;
            int? age;
            double sal;

            //public Employee()
            //{

            //}
            ////public Employee() { } 
            //public Employee(int id, string fn, string ln, int g, double sal)
            //{
            //    this.Id = id;
            //    this.f_name = fn;
            //    this.age = g;
            //    this.sal = sal;
            //}
            //public Employee(int id)
            //{
            //    this.Id = id;
            //}
            //public void set_name(string op)
            //{
            //    this.f_name = op.Length < 5 ? op : op.Substring(0, 5);
            //}
            //public string F_name
            //{
            //    get { return this.f_name; }
            //    set { this.f_name = value; }
            //}
            //public int ID
            //{
            //    get { return this.Id; }
            //    set
            //    {
            //        this.ID = value;
            //    }
            //}
            //public virtual void oop()
            //{
            //    Console.WriteLine("hjhh");
            //}
            //public override string ToString()
            //{
            //    return $"id:  {this.Id}\n name: {this.f_name }";
            //}

            //public object Clone()
            //{
            //    return new Employee()
            //    {
            //        Id = this.Id,

            //    };
            //}

            //public int CompareTo(object? obj)
            //{
            //    Employee e1 = (Employee)obj;
            //    if (this.Id > e1.ID)
            //        return 1;
            //    else if (this.Id < e1.ID)
            //        return -1;
            //    return 0;
            //}
        }
    */
        //class Full_time_employee:Employee
        //{
        //    public Full_time_employee(int id, string m, string p, double s) /*: base(1, "ss", "saas", 4, 7)*/
        //    {

        //    }
        //    //public Full_time_employee():base(7)
        //    //{

        //    //}

        //    public new  void opp()
        //    {
        //        //  base.oop();
        //        Console.WriteLine("lllllllllll");
        //    }
        //    //public override void oop()
        //    //{
        //    //    base.oop();
        //    //}
        //    public override string ToString()
        //    {
        //        return "jjk";
        //    }
        //}

        /* class Math
         {
             public Math(int x, int y)
             {
                 this.num_1 = x;
                 this.num_2 = y;
             }
             public int num_1
             {
                 get;
                 set;
             }
             public int num_2
             {
                 get;
                 set;
             }
             public static int add(int x, int y)
             {
                 return x + y;
             }

             public static int sub(int x, int y)
             {
                 return x - y;
             }
             public static int mul(int x, int y)
             {
                 return x * y;
             }

             public static int div(int x, int y)
             {
                 if (y != 0)
                     return x / y;
                 return 0;
             }

             public override string ToString()
             {
                 return string.Format("num1={0}\tnum2{1}", this.num_1, this.num_2);
                 //return $"{this.num_1} \t{this.num_2}";
             }
         }*/

        class Helper<T> where T : class, IComparable<T>, ICloneable
        {
            public static void swap(ref T x, ref T y)
            {
                T temp = x;
                x = y;
                y = temp;
            }
            public static void insertion_sort(T[] A)
            {
                int min = 0;
                for (int i = 0; i < A?.Length - 1; i++)
                {
                    min = i;
                    for (int j = i + 1; j < A.Length; j++)
                    {
                        if (A[j].CompareTo(A[min]) < 0)
                            min = j;
                    }
                    T swap = A[min];
                    A[min] = A[i];
                    A[i] = swap;
                }
            }
            public static int search(T[] A, T num)
            {
                if (A == null) return -1;
                for (int i = 0; i < A?.Length; i++)
                {
                    if (A[i].Equals(num)) return i;
                }
                return -1;
            }
        }



        //Console.WriteLine(json_call("https://jsonplaceholder.typicode.com/posts"));

        //Employee employee = new Employee() { Age = 20, Name = "ahsm", Salary = 9 };
        //Employee employee1 = new Employee();

        /*  EFcodedatabase dbcontext1 = new EFcodedatabase();
          Employee employee = new Employee() { Age = 1, Name = "poo", Salary = 9 };
          Employee employee1 = new Employee() { Age = 3, Name = "nbvv", Salary = 5 };
          dbcontext1.Employees.Add(employee);
          dbcontext1.Set<Employee>().Add(employee1);
          dbcontext1.Add(employee1);
         // WriteLine(dbcontext1.Entry(employee).State);

          dbcontext1.Entry(employee).State = EntityState.Added;

          dbcontext1.SaveChanges();
          //dbcontext1.Database.Migrate();
          var v = dbcontext1.Employees.FirstOrDefault((i) => i.Id > 9);
          Console.WriteLine(v);*/

        //Employee employee = new Employee();

        //Console.WriteLine(dbcontext1.Database.EnsureCreated());
        //SqlConnection sqlConnection = new SqlConnection("Data Source=Ahmed; Initial Catalog=Company; Integrated Security =true");
        //sqlConnection.Open();
        // Console.WriteLine(sqlConnection.State);
        //sqlConnection.Close();

        //status status1 = status.married;
        //status status2 = status.single;
        ////Console.WriteLine(status1.CompareTo(status2));
        //Car1 car = new Car1("jkjk", 99, "jj");
        //Console.WriteLine(car.Speed + " " + Car1.ll);

        // Car1 car = new Car1("jhjk", 33, "uiu");



        //double x = 1, y = 7;
        //swap(ref x, ref y);
        //WriteLine($"{x}\t{y}");

        /* asd a1 = new asd(2, 3);
         asd b1 = new asd(6, 7);
         a1.x = 3; a1.y = 2;
         b1.x = 3; b1.y = 2;

         WriteLine(a1.Equals(b1));
         WriteLine(a1 == b1);
         asd[] asds = { new asd(2, 7), new asd(7, 9) };

        //  Helper<asds>.insertion_sort(asds);
    */       /* Point3D[] point3D = { new Point3D(1, 2, 3), new Point3D(-2, 5, 7) };
            for (int i = 0; i < point3D.Length; i++)
                Console.WriteLine(point3D[i]);
            // Helper<Point3D>.insertion_sort(point3D);
            for (int i = 0; i < point3D.Length; i++)
                Console.WriteLine(point3D[i]);
            Point point = new Point(1, 2);
            Point point1 = new Point(1, 2);
            Console.WriteLine(point.x);
            Console.WriteLine(point1.x);
            //point = point1 ;
            point.x++;
            point1.x++;
            Console.WriteLine(point.x);
            Console.WriteLine(point1.x);
            Console.WriteLine(point.Equals(point1));
            Console.WriteLine(point);
            int a = 2;
            int b = 7;*/
        /* Phone_Book phone_Book = new Phone_Book(3);

         phone_Book.add_person(0, "dss", 4343);
         phone_Book.add_person(1, "sds", 34);
         phone_Book.add_person(2, "aa", 111);
         phone_Book["sds", 32] = 22222;
         phone_Book[111] = "mmm";
         WriteLine(phone_Book[111]);
         Console.WriteLine(phone_Book["sds", 1]);*/
        /* Full_time_employee full_Time_Employee = new Full_time_employee();
         full_Time_Employee.oop();
         fun_1 fun = new fun_1(STring.count_unique_chars_1);
         fun.Invoke("hjh");
         List<int> list = Enumerable.Range(1, 100).ToList();
         bool l = (b % 2 == 0);
         string aa = "12k";
         int.TryParse(aa, out int num);
         WriteLine(num);

         var t = new Tuple<int, string, long>(1, "jj", 9);
         List<object> llll = new List<object>()
         {
             new Point(),
             new Point3D(0, 0, 0),
         };

         int oop(int x,int y)
         {
             return x + y;
         }
         WriteLine(oop(2, 34));
         int? p = 89;
         int o =(int) p;
         point3D.Clone();

         Car[] cars = { new Car(2, "oop"), new Car(1, "pp") };
         foreach(Car car in cars)
         {
             Console.WriteLine(car);
         }
         swap<Car>(ref cars[0], ref cars[1]);

         foreach (Car car in cars)
         {
             Console.WriteLine(car);
         }

         WriteLine(Helper<Car>.search(cars, new Car(1, "pp")));

         var mm = Console.ReadLine();
         WriteLine(mm.GetType());

         dynamic dynamic_ = "jjj";
         WriteLine(dynamic_.GetType());
         dynamic_ = 756;
         WriteLine(dynamic_.GetType());

         int num_ = 987;
         Console.WriteLine(Extension_method.mun(9));
         WriteLine(num_.mun());
         WriteLine("mnb".iop());
         #region anynomus object
         var ob = new { id = 1, pl = "oop", bb = 9.7 };

         WriteLine(ob.id);
         var aqw = new { ob.id, ob.pl, bb = 1.8 };
         WriteLine(aqw.GetType().Name);
         var ag = aqw with { bb = 4.5 };
         WriteLine(ag.id);
         #endregion
         int am = 9;
         int[] A = { 2, 3, 7, 5, 9, 1 };
         Sort_1.insertion_sort(A);
         foreach (int i in A)
             Console.WriteLine(i);
        */

        /*  List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

          List<int> li = list.Where((n) => n * n % 2 == 1).ToList();
          li = Enumerable.Where(list, (n) => n % 2 == 1).ToList();
          foreach (int n in li)
              WriteLine(n);
          var lli = from lis in list where lis % 2 == 1 select lis;
     */
        // WriteLine(Listgenerator.productlist[0]);
        //var list = Listgenerator.productlist.Where((p) => p.UnitPrice == 0);
        //List<int> list2 = new List<int>();
        //  Action<string> action = (pp);
        //Func<string,int ,double > kl = pp;
        //Predicate<string> predicate = pp;
        //Action<int> action = (a) =>
        //{
        //    Console.WriteLine("ppp");
        //    Console.WriteLine("jnmmmmmmmmm");
        //    Console.WriteLine(a);
        //};
        //action(90);
        //action = delegate (qq)
        //{
        //    Console.WriteLine("ppppppp");
        //    Console.WriteLine("bnnnnnnnnnn");
        //};
        // action(9);
        /*Func<string> func = () => "ppppp";
       // WriteLine(func.Invoke());
        List<int> list = new List<int>();
        for (int i = 0; i < 10; i++)
            list.Add(i);
        List<int> listt = (from li in list
                           where (li % 2 == 0 && li < 5)
                           select li * li).ToList();
        foreach (int i in listt)
            Console.WriteLine(i);
        string[] strings = { "asd", "fdd", "dddd" };
        var a = from li in strings
                where (li.Length > 1)
                select li;
        foreach (string i in a)
            Console.WriteLine(i);
        var pp = strings.Where((str) => str.Length > 3);
        var v = strings.FirstOrDefault((str) => str.Length > 3);
        var l = strings.Where((i) => i.Length > 3).Select((i) => i);
        Country[] countries =
        {
            new Country( countryName:"hjj",countryCode:"56",year:"jhh", value:"6"),
            new Country (countryName:"hh",countryCode:"978",year:"uu",value:"6"),
  new Country  (countryName: "Arab World", countryCode: "ARB",year: "1960",  value: "96388069")
        };
        foreach (Country country in countries)
            Console.WriteLine(country);
        */
        /*        Action<string> action1 = Act;
                action1.Invoke("jhgh");
                Func<int, int, string> func = func_1;
                string p = func.Invoke(1, 2);
                Func<string> func11 = m;
                Console.WriteLine(func11.Invoke());
                Predicate<string> pred = rt;
                Console.WriteLine(rt("jk"));
                Action<string> action11 = (str) =>
                  {
                      Console.WriteLine("kk");
                      Console.WriteLine("jjjjjjjjjjjjj");
                  };
                Func<string, int> func111 = (op) =>
                {
                    Console.WriteLine(op);
                    return 1;
                };
                Console.WriteLine(func111.Invoke("aqwe"));
                Predicate<int> pred11 = (val) =>
                {
                    Console.WriteLine(val);
                    return val % 2 == 0;
                };

                Console.WriteLine(pred11(9));
                List<string> list_1 = new List<string> { "ahmed", "mohmed", "hassan", "ali", "kareem" };
                *//*        IEnumerable<string> iop = from li in list_1
                                                  where li.StartsWith('a') && li.EndsWith('d')
                                                  select  "jjj" ;
                        foreach(var i in iop )
                            Console.WriteLine(i);*//*
                var name = list_1.Where((str) =>
                {
                    string op = str.ToLower();
                    if (op == "vdsf") return false;
                    return true;
                }).Select((im) => im.ToLower() );

                foreach (var str in name)
                    Console.WriteLine(str);

                list_1.ForEach((ui) => {
                    Console.WriteLine(ui);
                    Console.WriteLine(ui.ToLower());
                }
                );
                WriteLine(productlist[0]);
                Console.WriteLine(customerlist[0]);
                var aasd = productlist.Where((op) => {
                    Console.WriteLine("jjjjjjj");
                    return op.UnitsInStock == 0;
                }); ;

                foreach (var i in aasd)
                    Console.WriteLine(i);
                var aasdd = from i in productlist
                            where (i.UnitsInStock == 0)
                            select new
                            {
                                id = i.ProductID,
                                sal = i.UnitPrice,
                            }; //i.ProductID;
                foreach(var i in aasdd)
                    Console.WriteLine(i);
                var maasdd = productlist.Where((op, i) =>
                {
                    return op.UnitsInStock == 0 && i < 10;
                }
                   );
                //foreach(var i in maasdd)
                  //  Console.WriteLine(i);
                var t = productlist.Select((op) => op);
                var tt = from i in productlist select i.ProductID;
               // foreach (var i in t)
                 //   Console.WriteLine(i);
                var pp = customerlist.SelectMany(p => p.Orders);
                pp = from i in customerlist
                     from op in i.Orders
                     select op;

               // foreach (var i in pp)
                 //   Console.WriteLine(i);
                var ppp=productlist.Select ((i)=> { return i.ProductID + " " + i.ProductName; });
                var yu = productlist.Where((i) => i.UnitsInStock > 0)
                     .Select((i) => new
                     {
                         id = i.ProductID,
                         name = i.ProductName,
                         new_price = i.UnitPrice - i.UnitPrice * .1m
                     });

                var ppppn=productlist.OrderByDescending((p)=> p.UnitPrice).ThenBy((i)=>i.UnitsInStock).ToList();

                var ui = from i in productlist
                         orderby i.UnitPrice, i.UnitsInStock descending
                         select i;
                var ds = productlist.Where((i) => i.UnitsInStock == 0).Reverse().ToList();
                int[] A = { 1, 2, 3, 4, 5, 6, 7, 89, 9 };
                int[] v = A.Where((i) =>
                {
                    Console.WriteLine("jhk");
                    return i % 2 == 0;
                }).Select((i,p) => {
                    int po = i;
                    po = po * p;
                    i = po;
                    return  po;
                }).ToArray();
                v = A.Select((i) =>
               {

                   return i;
               }).ToArray();
                A.Any();
               var l= A.OrderByDescending((i)=>i);
              //  var l = (from k in A
                //         select A).ToArray();
                foreach (var i in l)
                    Console.WriteLine(i);
                Console.WriteLine(A.Max());
              //  Dictionary<long, Product> dic = ProductList.Where((i) => i.UnitsInStock == 0).ToDictionary((i) => i.ProductID);
                var ar=productlist.Where((i)=> i.UnitsInStock == 0 && i.UnitPrice>300);
                Console.WriteLine(productlist.Where((i)=> i.UnitsInStock>0).FirstOrDefault());*/
        // Predicate predicate=new Predicate() 
        //Employee[] employees =
        //{
        //    new Employee(-1),
        //    new Employee(2),
        //    new Employee(-4),
        //    new Employee(3),
        //};
        //Array.Sort(employees);
        //foreach( Employee employee in employees )
        //    Console.WriteLine(employee);

        /*        Point3D point_1 = new Point3D(10, 10, 10);
                Point3D point_2 = new Point3D(1, 2, 3);
                for (int i = 0; i < 3; i++)
                {
                    double x = 0;
                    bool flag = double.TryParse(Console.ReadLine(), out x);
                    if(flag)
                    {
                        ;
                    }
                    x = Convert.ToDouble(ReadLine());
                }
                if (point_1.CompareTo(point_2) == 0)
                    Console.WriteLine("equal");
                else if (point_1.CompareTo(point_2) == 1)
                    Console.WriteLine("point_1 > point_2");
                else
                    Console.WriteLine("point_1 < point_2");

                if (point_1 == point_2)
                    WriteLine(true);*/
        /* Point point = new Point(4, 7);
         Console.WriteLine(point.x.ToString());
         WriteLine(point.ToString());
         Console.WriteLine();
         var x = 4;
         var y = "kk";
         var p = true;
         WriteLine(x.GetType());
         WriteLine(y.GetType());
         WriteLine(p.GetType());
        */

        /*Class1 class1 = new Class1();
        Prime_numbers prime_Numbers = new Prime_numbers();
        Console.WriteLine((sizeof(long)).GetType());
        Type type = typeof(Program);
        Console.WriteLine(type);
        Console.WriteLine(nameof(class1));
*/
        /* int? x;
         x=null;
         int y = x ?? 0;
         x = 9;
         Console.WriteLine(x.HasValue);
         x = null;
        // x = int.Parse(ReadLine());
         //Console.WriteLine(x.HasValue);
         int[] A = default;
        // y = (int)(A?.Length);
        */

        /*        Array.Sort(A);
                Array.Copy();
                Array.ConstrainedCopy();
                A = (int[])Array.CreateInstance(typeof(int), 7);
                int[,] C = (int[,])Array.CreateInstance(typeof(int), 7, 4);
                int[][] B = new int[3][];
                A.
                B[0] = new int[3];
                B[1] = new int[7];
                B[2] = new int[5];
                int[,] A = new int[3, 4];
                WriteLine(A.GetLength(1));
                WriteLine(A.Rank);*/
        /*WriteLine("Enter number");
        int num;
    Label: bool flag = int.TryParse(ReadLine(), out num);
        if (!flag)
            goto Label;*/

        //print<int>(0,8,66);
        /* WriteLine("hjd");
         int x = 3, y = 5;
         string m = string.Format("Equation : {0} + {1} = {2}", x, y, x + y);
         WriteLine(m);
         m = $"Equation : {x} + {y} = {x + y}";
         WriteLine(m);*/
        /*  int x = 5, y = 7;
          WriteLine(x > 3 | y++ > 7);
          WriteLine(y);*/
        //Console.WriteLine(quran.under_114());

        // Prime_numbers p = new Prime_numbers();
        //WriteLine(p.gap());

        #region Types
        /* double x=9.0;
       Type a=x.GetType();
       WriteLine(a.ToString());
        */
        #endregion


        #region MyRegion
        /*DateTime dateTime = DateTime.Now;
        WriteLine(dateTime);
        WriteLine(DateTime.UtcNow);
        WriteLine(dateTime.Date);
        WriteLine(dateTime.Minute);
        WriteLine(dateTime.Year);
        WriteLine(dateTime.Month.ToString());
        WriteLine(dateTime.Ticks);
        WriteLine(dateTime.Day);
        WriteLine(dateTime.DayOfWeek);
        WriteLine(dateTime.DayOfYear);
        WriteLine(dateTime.Hour);
        WriteLine(dateTime.Kind);
        dateTime.AddDays(10);

        WriteLine(dateTime + "pppppp");
        string[] op = dateTime.GetDateTimeFormats();
        foreach (var format in op)
        {
            WriteLine(format);
        }
        WriteLine(dateTime + "pppppp");
        WriteLine(dateTime.GetType());
        int x = 9;
        WriteLine(dateTime.ToBinary());
        WriteLine(dateTime.ToFileTime());
        WriteLine(dateTime.ToFileTimeUtc());
        dateTime = dateTime.ToUniversalTime();

        WriteLine(dateTime.ToString());
        */
        #endregion
        //OOp op = new OOp();
        /* StreamWriter sw = new StreamWriter("data.txt");
         for (int i = 1; i <= 10; i++)
         {
             sw.WriteLine("لا اله الا الله");
             sw.WriteLine("لا اله الا انت");
             sw.WriteLine("لا اله الا انت سبحانك");
             sw.WriteLine("لا اله الا انت سبحانك انى كنت من الظالمين");
             sw.WriteLine("لا اله الا الله من كل سوء و مكروه");
             sw.WriteLine("لنا الله");
         }
        sw.Close();*/
        //double p = 4776913288248855555558656789888888888319;
        /* int count = 1;
        int num = 1;
        while (count < 40) 
        {
           // Console.WriteLine(num);
            count = NUmber.sum_of_digits(num++);
        }
        WriteLine(num.ToString());
        */
        //Quran q = new Quran();
        //q.sum_Digit();
        //q.count_Digit();
        //Console.WriteLine(q.max_prime());

        //Console.WriteLine("oop");
        /*
                int count = 0;
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 10; j >= i; j--)
                        Console.Write(" ");
                    for (int k = 1; k <= i; k++)
                        Console.Write(p.value(count++) + " ");
                    Console.WriteLine();
                }*/
        //for (int i = 1; i <= 114; i++) 
        //   Console.WriteLine(114 - i + "\t" + i.ToString());
        // for (int i = 1; i < 100; i++)
        //{
        //  Console.WriteLine(p.value(123) + "\t" + p.value(NUmber.reverse_num(123)));
        //}
        //  for (int i = 0; i < 36; i++) ;            // Console.WriteLine(p.value(i) - i);


        //  Shape.pascal_triangle();
        //NUmber.count_of_divisor(1122);

        // Console.WriteLine(p.next_prime(1000)); 
        /* for (int i = 1; i < 10; i++) 
         {
             int v = p.value(i);
             string s = i.ToString();
             string b = s;
             s += v.ToString();
             b += " " + v.ToString();
             v = int.Parse(s);
             //    if (p.prime(v))
             Console.WriteLine(v);
             List<int> A = NUmber.count_of_divisor(v);
             foreach (var m in A)
                 Console.Write(m + "\t");

         }
         */


        //public delegate int fun_1(string x);
        //public delegate List<int> fun_2(List<int> x);
        //class asd:IComparable
        //{
        //    public asd(int x, int y)
        //    {
        //        this.x = x;
        //        this.y = y;
        //    }

        //    public int x { get; set; }
        //    public int y { get; set; }
        //    public int CompareTo(object? obj)
        //    {
        //        asd asd=obj as asd;
        //        if (this.x > asd.x)
        //            return 1;
        //        else if (this.x < asd.x) return -1;
        //        else return 0;
        //    }
        //}

        /*public static class Extension_method
        //{
        //    public static int mun(this int x)
        //    {
        //        return x + 4;
        //    }

        //    public static string iop(this  string m)
        //    {
        //        return m.Reverse().ToString();
        //    }
        }*/

        /*class Product
    {
        public int ProductID
        {
            get;
            set;
        }
        public string ProductName
        {
            get;
            set;
        }
        public string Category
        {
            get; set;
        }
        public double UnitPrice
        {
            get; set;
        }
        public double UnitsInStock
        {
            get;
            set;
        }
    }*/

        /*internal class Employee_
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public int? Age { get; set; }

    }
    */
        //struct Point
        //{
        //    public int x, y;
        //    public Point(int x, int y)
        //    {
        //        this.x = x;
        //        this.y = y;
        //    }
        //    public Point()
        //    {
        //        x = default;
        //        y = default;
        //    }

        //    public int X
        //    {
        //        get { return x; }
        //        set { x = value; }
        //    }
        //    public static bool operator ==(Point a, Point b)
        //    {
        //        return ((a.x == b.x) && (a.y == b.y));
        //    }

        //    public static bool operator !=(Point a, Point b)
        //    {
        //        return ((a.x != b.x) && (a.y != b.y));
        //    }

        //}

        /* public static List<int> numbers_(List<int> numbers)
         {
             List<int> numbers__ = new List<int>();
             return null;
         }*/

   
}
