internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Задание №1");

        double R1, t1, l1;

        Console.WriteLine("Введите значение переменной t1");
        t1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной l1");
        l1 = Convert.ToDouble(Console.ReadLine());

        R1 = 3 * Math.Pow(t1, 2) + 3 * Math.Pow(l1, 5) + 4.9;

        Console.WriteLine($"Значение R1 = {R1}");



        Console.WriteLine("Задание №2");

        double K2, p2, y2, e2;

        Console.WriteLine("Введите значение перременной p");
        p2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e2 = Convert.ToDouble(Console.ReadLine());

        K2 = Math.Log(Math.Pow(p2, 2) + Math.Pow(y2, 3)) + Math.Pow(e2, p2);

        Console.WriteLine($"Результат задания №2 = {K2}");


        Console.WriteLine("Задание №3");

        double G3, n3, y3;

        Console.WriteLine("Введите значение перременной n");
        n3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y3 = Convert.ToDouble(Console.ReadLine());


        G3 = n3 * (y3 + 3.5) + Math.Sqrt(y3);

        Console.WriteLine($"Результат задания №3 = {G3}");




        Console.WriteLine("Задание №4");

        double D4, a4, t4;

        Console.WriteLine("Введите значение перременной a");
        a4 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной t");
        t4 = Convert.ToDouble(Console.ReadLine());

        D4 = 9.8 * Math.Pow(a4, 2) + 5.52 * Math.Cos(Math.Pow(t4, 5));

        Console.WriteLine($"Результат задания №4 = {D4}");



        Console.WriteLine("Задание №5");

        double L5, x5;

        Console.WriteLine("Введите значение перременной x");
        x5 = Convert.ToDouble(Console.ReadLine());


        L5 = 1.51 * Math.Cos(Math.Pow(x5, 2)) + 2 * Math.Pow(x5, 3);

        Console.WriteLine($"Результат задания №5 = {L5}");




        Console.WriteLine("Задание №6");

        double M6, x6, y6, e6;

        Console.WriteLine("Введите значение перременной x");
        x6 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y6 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e6 = Convert.ToDouble(Console.ReadLine());

        M6 = Math.Cos(2 * y6) + 3.6 * Math.Pow(e6, x6);

        Console.WriteLine($"Результат задания №6 = {M6}");



        Console.WriteLine("Задание №7");

        double N7, m7;

        Console.WriteLine("Введите значение перременной m");
        m7 = Convert.ToDouble(Console.ReadLine());


        N7 = Math.Pow(m7, 2) + 2.8 * Math.Abs(m7) + 0.55;

        Console.WriteLine($"Результат задания №7 = {N7}");




        Console.WriteLine("Задание №8");

        double T8, y8;


        Console.WriteLine("Введите значение перременной y");
        y8 = Convert.ToDouble(Console.ReadLine());


        T8 = Math.Sqrt(Math.Abs(6 * Math.Pow(y8, 2) - 0.1 * y8 + 4));
        Console.WriteLine($"Результат задания №8 = {T8}");




        Console.WriteLine("Задание №9");

        double V9, x9, y9;

        Console.WriteLine("Введите значение перременной x");
        x9 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y9 = Convert.ToDouble(Console.ReadLine());

        V9 = Math.Log(y9 + 0.95) + Math.Sin(Math.Pow(x9, 4));

        Console.WriteLine($"Результат задания №9 = {V9}");




        Console.WriteLine("Задание №10");

        double U10, x10, y10, e10, k10;

        Console.WriteLine("Введите значение перременной x");
        x10 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y10 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e10 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной k");
        k10 = Convert.ToDouble(Console.ReadLine());

        U10 = Math.Pow(e10, y10) + 7.355 * Math.Pow(k10, 2) + Math.Pow(Math.Sin(x10), 2);

        Console.WriteLine($"Результат задания №10 = {U10}");




        Console.WriteLine("Задание №11");

        double S11, x11, y11;

        Console.WriteLine("Введите значение перременной x");
        x11 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y11 = Convert.ToDouble(Console.ReadLine());


        S11 = 9.756 * Math.Pow(y11, 7) + 2 * Math.Tan(11);

        Console.WriteLine($"Результат задания №11 = {S11}");




        Console.WriteLine("Задание №12");

        double K12, t12, x12;

        Console.WriteLine("Введите значение перременной x");
        x12 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной t");
        t12 = Convert.ToDouble(Console.ReadLine());



        K12 = 7 * Math.Pow(t12, 2) + 3 * Math.Sin(Math.Pow(x12, 3)) + 9.2;

        Console.WriteLine($"Результат задания №12 = {K12}");


        Console.WriteLine("Задание №13");

        double E13, y13;

        Console.WriteLine("Введите значение перременной y");
        y13 = Convert.ToDouble(Console.ReadLine());


        E13 = Math.Sqrt(Math.Abs(3 * Math.Pow(y13, 2) + 0.5 * y13 + 4));

        Console.WriteLine($"Результат задания №13 = {E13}");




        Console.WriteLine("Задание №14");

        double R14, x14, y14, e14;

        Console.WriteLine("Введите значение перременной x");
        x14 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y14 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e14 = Convert.ToDouble(Console.ReadLine());

        R14 = Math.Abs(Math.Sqrt(Math.Pow(Math.Sin(y14), 2) + 6.835) + Math.Pow(e14, y14));

        Console.WriteLine($"Результат задания №14 = {R14}");




        Console.WriteLine("Задание №15");

        double H15, y15;


        Console.WriteLine("Введите значение перременной y");
        y15 = Convert.ToDouble(Console.ReadLine());


        H15 = Math.Sin(Math.Pow(y15, 2)) - 2.8 * y15 + Math.Sqrt(Math.Abs(y15));

        Console.WriteLine($"Результат задания №15 = {H15}");



        Console.WriteLine("Задание №16");

        double S16, y16;

        Console.WriteLine("Введите значение перременной y");
        y16 = Convert.ToDouble(Console.ReadLine());


        S16 = Math.Sqrt(Math.Cos(4 * Math.Pow(y16, 2)) + 7.151);

        Console.WriteLine($"Результат задания №16 = {S16}");





        Console.WriteLine("Задание №17");

        double N17, y17;


        Console.WriteLine("Введите значение перременной y");
        y17 = Convert.ToDouble(Console.ReadLine());


        N17 = 3 * Math.Pow(y17, 2) + Math.Sqrt(y17 + 1);

        Console.WriteLine($"Результат задания №17 = {N17}");





        Console.WriteLine("Задание №18");

        double Z18, y18;


        Console.WriteLine("Введите значение перременной y");
        y18 = Convert.ToDouble(Console.ReadLine());


        Z18 = 3 * Math.Pow(y18, 2) + Math.Sqrt(Math.Pow(y18, 3) + 1);

        Console.WriteLine($"Результат задания №18 = {Z18}");




        Console.WriteLine("Задание №19");

        double P19, g19, y19, n19;

        Console.WriteLine("Введите значение перременной g");
        g19 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y19 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной n");
        n19 = Convert.ToDouble(Console.ReadLine());


        P19 = n19 * Math.Sqrt(Math.Pow(y19, 3) + 1.09 * g19);

        Console.WriteLine($"Результат задания №19 = {P19}");




        Console.WriteLine("Задание №20");

        double U20, x20, y20, e20, k20;

        Console.WriteLine("Введите значение перременной x");
        x20 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y20 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e20 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной k");
        k20 = Convert.ToDouble(Console.ReadLine());

        U20 = Math.Pow(e20, k20 + y20) + Math.Tan(x20) * Math.Sqrt(x20);

        Console.WriteLine($"Результат задания №20 = {U20}");




        Console.WriteLine("Задание №21");

        double P21, e21, y21, h21;

        Console.WriteLine("Введите значение перременной e");
        e21 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y21 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной h");
        h21 = Convert.ToDouble(Console.ReadLine());


        P21 = Math.Pow(e21, y21 + 3.3) + 9.1 * Math.Pow(h21, 3);

        Console.WriteLine($"Результат задания №21 = {P21}");


        Console.WriteLine("Задание №22");

        double T22, x22, y22, u22;

        Console.WriteLine("Введите значение перременной x");
        x22 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y22 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной u");
        u22 = Convert.ToDouble(Console.ReadLine());

        T22 = Math.Sin(2 * u22) * Math.Log(2 * Math.Pow(y22, 2) + Math.Sqrt(x22));

        Console.WriteLine($"Результат задания №22 = {T22}");




        Console.WriteLine("Задание №23");

        double G23, f23, y23, e23;

        Console.WriteLine("Введите значение перременной f");
        f23 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y23 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e23 = Convert.ToDouble(Console.ReadLine());


        G23 = Math.Pow(e23, 2 * y23) + Math.Sin(f23);

        Console.WriteLine($"Результат задания №23 = {G23}");




        Console.WriteLine("Задание №24");

        double F24, y24;

        Console.WriteLine("Введите значение перременной y");
        y24 = Convert.ToDouble(Console.ReadLine());



        F24 = 2 * Math.Sin(0.214 * Math.Pow(y24, 5) + 1);

        Console.WriteLine($"Результат задания №24 = {F24}");




        Console.WriteLine("Задание №25");

        double G25, y25, f25, e25;

        Console.WriteLine("Введите значение перременной y");
        y25 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной f");
        f25 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e25 = Convert.ToDouble(Console.ReadLine());

        G25 = Math.Pow(e25, 2 * y25) + Math.Sin(Math.Pow(f25, 2));

        Console.WriteLine($"Результат задания №25 = {G25}");




        Console.WriteLine("Задание №26");

        double Z26, p26;

        Console.WriteLine("Введите значение перременной p");
        p26 = Convert.ToDouble(Console.ReadLine());


        Z26 = Math.Sin(Math.Pow(Math.Pow(p26, 2) + 0.4, 3));

        Console.WriteLine($"Результат задания №26 = {Z26}");




        Console.WriteLine("Задание №27");

        double W27, x27, y27, e27, v27;

        Console.WriteLine("Введите значение перременной x");
        x27 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y27 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e27 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной v");
        v27 = Convert.ToDouble(Console.ReadLine());

        W27 = 1.03 * v27 + Math.Pow(e27, 2 * y27) + Math.Tan(Math.Abs(x27));


        Console.WriteLine($"Результат задания №27 = {W27}");




        Console.WriteLine("Задание №28");

        double T28, e28, y28, h28;

        Console.WriteLine("Введите значение перременной y");
        y28 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e28 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной h");
        h28 = Convert.ToDouble(Console.ReadLine());

        T28 = Math.Pow(e28, y28 * h28) + Math.Sqrt(Math.Abs(6.4 * y28));

        Console.WriteLine($"Результат задания №28 = {T28}");



        Console.WriteLine("Задание №29");

        double N29, y29;

        Console.WriteLine("Введите значение перременной y");
        y29 = Convert.ToDouble(Console.ReadLine());


        N29 = 3 * Math.Pow(y29, 2) + Math.Sqrt(Math.Abs(y29 + 1));

        Console.WriteLine($"Результат задания №29 = {N29}");



        Console.WriteLine("Задание №30");

        double W30, r30, y30, e30;

        Console.WriteLine("Введите значение перременной r");
        r30 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y30 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e30 = Convert.ToDouble(Console.ReadLine());


        W30 = Math.Pow(e30, y30 * r30) + 7.2 * Math.Sin(r30);

        Console.WriteLine($"Результат задания №30 = {W30}");


        Console.WriteLine("Задание №31");

        double G31, f31, y31, e31;

        Console.WriteLine("Введите значение перременной f");
        f31 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y31 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e31 = Convert.ToDouble(Console.ReadLine());

        G31 = Math.Exp(2 * y31) + Math.Sin(f31) / Math.Log10(3.8 * y31 + f31);

        Console.WriteLine($"Результат задания №31 = {G31}");



        Console.WriteLine("Задание №32");

        double G1, f1, y1, e1;

        Console.WriteLine("Введите значение перременной f");
        f32 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y32 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e32 = Convert.ToDouble(Console.ReadLine());

        G32 = (Math.Pow(e32, 2 * y32) + Math.Sin(f32)) / (Math.Log(3.8 * y32 + f32);

        Console.WriteLine($"Результат задания №32 = {G32}");


        Console.WriteLine("Задание №33");

        double F33, d33, y33;

        Console.WriteLine("Введите значение перременной d");
        d33 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y33 = Convert.ToDouble(Console.ReadLine());


        F33 = Math.Log(d33) * ((3.5 * Math.Pow(d33, 2) + 1) / (Math.Cos(2) * y33));

        Console.WriteLine($"Результат задания №33 = {F33}");


        Console.WriteLine("Задание №34");

        double U34, y34, e34, k34;

        Console.WriteLine("Введите значение перременной y");
        y34 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e34 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной k");
        k34 = Convert.ToDouble(Console.ReadLine());

        U34 = (Math.Log(k34 - y34) + Math.Pow(y34, 4)) / (Math.Pow(e34, y34) + 2.355 * Math.Pow(k34, 2));

        Console.WriteLine($"Результат задания №34 = {U34}");


        Console.WriteLine("Задание №35");

        double G35, w35, y35;

        Console.WriteLine("Введите значение перременной w");
        w35 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y35 = Convert.ToDouble(Console.ReadLine());

        G35 = (9.33 * Math.Pow(w35, 3) + Math.Sqrt(w35)) / (Math.Log(y35 + 3.5) + Math.Sqrt(y35));

        Console.WriteLine($"Результат задания №35 = {G35}");


        Console.WriteLine("Задание №36");

        double D36, t36, y36, e36, a36;

        Console.WriteLine("Введите значение перременной t");
        t36 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y36 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e36 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной a");
        a36 = Convert.ToDouble(Console.ReadLine());

        D36 = (7.8 * Math.Pow(a36, 2) + 3.52 * t36) / (Math.Log(a36 + 2 * y5) + Math.Pow(e5, y36));

        Console.WriteLine($"Результат задания №36 = {D36}");


        Console.WriteLine("Задание №37");

        double L37, i37, y37;

        Console.WriteLine("Введите значение перременной i");
        i37 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y37 = Convert.ToDouble(Console.ReadLine());



        L37 = 0.81 * Math.Cos(i37) / (Math.Log(y37) + 2 * Math.Pow(i37, 3));

        Console.WriteLine($"Результат задания №37 = {L37}");


        Console.WriteLine("Задание №38");

        double N38, m38, y38;

        Console.WriteLine("Введите значение перременной m");
        m38 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y38 = Convert.ToDouble(Console.ReadLine());


        N38 = (Math.Pow(m38, 2) + 2.8 * m38 + 0.355) / (Math.Cos(2) * y38 + 3.6);

        Console.WriteLine($"Результат задания №38 = {N38}");


        Console.WriteLine("Задание №39");

        double T39, r39, y39;

        Console.WriteLine("Введите значение перременной r");
        r39 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y39 = Convert.ToDouble(Console.ReadLine());


        T39 = 2.37 * Math.Sin(r39 + 1) / Math.Sqrt(4 * Math.Pow(y39, 2) - 0.1 * y39 + 5);

        Console.WriteLine($"Результат задания №39 = {T39}");


        Console.WriteLine("Задание №40");

        double V40, w40, y40;

        Console.WriteLine("Введите значение перременной w");
        w40 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y40 = Convert.ToDouble(Console.ReadLine());


        V40 = Math.Pow(y40 + 2 * w40, 3) / Math.Log(y40 + 0.75);

        Console.WriteLine($"Результат задания №40 = {V40}");


        Console.WriteLine("Задание №41");

        double Z41, t41, y41;

        Console.WriteLine("Введите значение перременной t");
        t41 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y41 = Convert.ToDouble(Console.ReadLine());


        Z41 = (2 * y41 + y41 * Math.Cos(t41)) / Math.Sqrt(y41 + 4.831);

        Console.WriteLine($"Результат задания №41 = {Z41}");


        Console.WriteLine("Задание №42");

        double D42, n42, y42;

        Console.WriteLine("Введите значение перременной n");
        n42 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y42 = Convert.ToDouble(Console.ReadLine());


        D42 = Math.Pow(y42, 2) * ((0.5 * n42 + 4.8) / Math.Sin(y42));

        Console.WriteLine($"Результат задания №42 = {D42}");


        Console.WriteLine("Задание №43");

        double R43, r43, y43;

        Console.WriteLine("Введите значение перременной r");
        r43 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y43 = Convert.ToDouble(Console.ReadLine());


        R43 = (Math.Pow(Math.Sin(2 * r43 + 1), 2) + 0.3) / Math.Log(r43 + y43);

        Console.WriteLine($"Результат задания №43 = {R43}");


        Console.WriteLine("Задание №44");

        double A44, h44, y44, e44, k44;

        Console.WriteLine("Введите значение перременной h");
        h44 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y44 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e44 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной k");
        k44 = Convert.ToDouble(Console.ReadLine());

        A44 = (Math.Sin(2 * y44 + h44) + Math.Pow(h44, 2)) / (Math.Pow(e44, k44) + y44);

        Console.WriteLine($"Результат задания №44 = {A44}");


        Console.WriteLine("Задание №45");

        double P45, h45, y45, e45;

        Console.WriteLine("Введите значение перременной h");
        h45 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y45 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e45 = Convert.ToDouble(Console.ReadLine());


        P45 = (Math.Pow(e45, y45 + 2.3) + 7.1 * Math.Pow(h45, 2)) / Math.Log(Math.Sqrt(y45 + 0.04 * h45));

        Console.WriteLine($"Результат задания №45 = {P45}");


        Console.WriteLine("Задание №46");

        double F46, j46, y46;

        Console.WriteLine("Введите значение перременной j");
        j46 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y46 = Convert.ToDouble(Console.ReadLine());

        F46 = 2 * Math.Sin(0.354 * y46 + 1) / Math.Log(y46 + 2 * j46);

        Console.WriteLine($"Результат задания №46 = {F46}");


        Console.WriteLine("Задание №47");

        double W47, t47, y47, e47, r47;

        Console.WriteLine("Введите значение перременной t");
        t47 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y47 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e47 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной r");
        r47 = Convert.ToDouble(Console.ReadLine());

        W47 = (4 * Math.Pow(r47, 3) + Math.Log(r47)) / (Math.Pow(e47, y47 + r47) + 7.2 * Math.Sin(r47));

        Console.WriteLine($"Результат задания №47 = {W47}");


        Console.WriteLine("Задание №48");

        double H48, n48, y48;

        Console.WriteLine("Введите значение перременной n");
        n48 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y48 = Convert.ToDouble(Console.ReadLine());


        H48 = (Math.Pow(y48, 2) - 0.8 * y48 + Math.Sqrt(y48)) / (23.1 * Math.Pow(n48, 2) + Math.Cos(n48));

        Console.WriteLine($"Результат задания №48 = {H48}");


        Console.WriteLine("Задание №49");

        double R49, k49, y49;

        Console.WriteLine("Введите значение перременной k");
        k49 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y49 = Convert.ToDouble(Console.ReadLine());


        R49 = (Math.Sqrt(Math.Pow((Math.Sin(y49)), 2)) + 6.835) / (Math.Log(y49 + k49) + 3 * Math.Pow(y49, 2));

        Console.WriteLine($"Результат задания №49 = {R49}");



        Console.WriteLine("Задание №50");

        double E50, q50, y50;

        Console.WriteLine("Введите значение перременной ");
        q50 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y50 = Convert.ToDouble(Console.ReadLine());


        E50 = Math.Log(0.7 * y50 + 2 * q50) / Math.Sqrt(3 * Math.Pow(y50, 2) + 0.5 * y50 + 4);

        Console.WriteLine($"Результат задания №50 = {E50}");


        Console.WriteLine("Задание №51");

        double K51, t51, y51, e51, l51;

        Console.WriteLine("Введите значение перременной t");
        t51 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y51 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e51 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной l");
        l51 = Convert.ToDouble(Console.ReadLine());

        K51 = (2 * Math.Pow(t51, 2) + 3 * l51 + 7.2) / (Math.Log(y51) + Math.Pow(e51, 2 * t51));

        Console.WriteLine($"Результат задания №51 = {K51}");


        Console.WriteLine("Задание №52");

        double Q52, k52, p52, x52, d52;

        Console.WriteLine("Введите значение перременной k");
        k52 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной p");
        p52 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной x");
        x52 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной l");
        d52 = Convert.ToDouble(Console.ReadLine());

        Q52 = Math.Sqrt(k52 + 2.6 * p52 * Math.Sin(k52)) / (x52 - Math.Pow(d52, 3));

        Console.WriteLine($"Результат задания №52= {Q52}");


        Console.WriteLine("Задание №53");

        double S53, t53, y53;

        Console.WriteLine("Введите значение перременной t");
        t53 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y53 = Convert.ToDouble(Console.ReadLine());

        S53 = (4.351 * Math.Pow(y53, 3) + 2) * t53 * Math.Log(t53) / Math.Sqrt(Math.Cos(2) * y53 + 4.351);

        Console.WriteLine($"Результат задания №53 = {S53}");


        Console.WriteLine("Задание №54");

        double R54, d54, y54, e54;

        Console.WriteLine("Введите значение перременной d");
        d54 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y54 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e54 = Convert.ToDouble(Console.ReadLine());


        R54 = (Math.Pow(Math.Sin(y54), 2) + 0.3 * d54) / (Math.Pow(e54, y54) + Math.Log(d54));

        Console.WriteLine($"Результат задания №54 = {R54}");


        Console.WriteLine("Задание №55");

        double U55, k55, y55, e55;

        Console.WriteLine("Введите значение перременной k");
        k55 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y55 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e55 = Convert.ToDouble(Console.ReadLine());


        U55 = Math.Log(2 * k55 + 4.3) / (Math.Pow(e55, k55 + y55) + Math.Sqrt(y55));

        Console.WriteLine($"Результат задания №55 = {U55}");


        Console.WriteLine("Задание №56");

        double L56, t56, c56;

        Console.WriteLine("Введите значение перременной t");
        t56 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной c");
        c56 = Convert.ToDouble(Console.ReadLine());


        L56 = Math.Pow(Math.Cos(c56), 2) * ((3 * Math.Pow(t56, 2) + 4) / Math.Sqrt(c56 + t56));

        Console.WriteLine($"Результат задания №56 = {L56}");


        Console.WriteLine("Задание №57");

        double T57, u57, y57;

        Console.WriteLine("Введите значение перременной u");
        u57 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y57 = Convert.ToDouble(Console.ReadLine());



        T57 = Math.Sin(2) * u57 / Math.Log(2 * y57 + u57);

        Console.WriteLine($"Результат задания №57 = {T57}");


        Console.WriteLine("Задание №58");

        double Z58, p58, y58;

        Console.WriteLine("Введите значение перременной P");
        p58 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y58 = Convert.ToDouble(Console.ReadLine());

        Z58 = Math.Sin(Math.Pow(p58 + 0.4, 2)) / (Math.Pow(y58, 2) + 7.325 * p58);

        Console.WriteLine($"Результат задания №58 = {Z58}");



        Console.WriteLine("Задание №59");

        double W59, v59, y59, e59;

        Console.WriteLine("Введите значение перременной v");
        v59 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y59 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e59 = Convert.ToDouble(Console.ReadLine());


        W59 = (0.004 * v59 + Math.Pow(e59, 2 * y59)) / Math.Pow(e59, y59 / 2);

        Console.WriteLine($"Результат задания №59 = {W59}");



        Console.WriteLine("Задание №60");

        double T60, h60, y60, e60;

        Console.WriteLine("Введите значение перременной h");
        h60 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y60 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e60 = Convert.ToDouble(Console.ReadLine());

        T60 = (0.355 * Math.Pow(h60, 2) - 4.355) / (Math.Pow(e60, y60 + h60) + Math.Sqrt(2.7 * y60));

        Console.WriteLine($"Результат задания №60 = {T60}");



        Console.WriteLine("Задание №61");

        double N61, p61, y61, e61;

        Console.WriteLine("Введите значение перременной p");
        p61 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y61 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e61 = Convert.ToDouble(Console.ReadLine());


        N61 = (3 * Math.Pow(y61, 2) + Math.Sqrt(y61 + 1)) / (Math.Log(p61 + y61) + Math.Pow(e61, p61));

        Console.WriteLine($"Результат задания №61 = {N61}");



        Console.WriteLine("Задание №62");

        double L62, e62, x62, a62, c62;

        Console.WriteLine("Введите значение переменной e");
        e62 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной x");
        x62 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной a");
        a62 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение переменной c");
        c62= Convert.ToDouble(Console.ReadLine());

        L62 = (Math.Sqrt(Math.Pow(e62, x62) - Math.Pow((Math.Cos(Math.Pow(x62, 2) * Math.Pow(a62 5))), 4))) + Math.Pow((Math.Atanh(a62 - Math.Pow(x62, 5))), 4) / (Math.Pow((Math.Abs(a62 + x62 * Math.Pow(c62, 4))), e62 / 2));

        Console.WriteLine($"Результат задания №62 = {L62}");


        Console.WriteLine("Задание №63");

        double L63, c63, x63, t63;

        Console.WriteLine("Введите значение переменной c");
        c63 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной x");
        x63 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной t");
        t63 = Convert.ToDouble(Console.ReadLine());


        L63 = Math.Pow((Math.Tanh(c63)), 2) * ((2 * Math.Pow(x63, 2) + 5)) / (Math.Sqrt(c63 + t63));

        Console.WriteLine($"Результат задания №63 = {L63}");


        Console.WriteLine("Задание №64");

        double A64, y64, h64;

        Console.WriteLine("Введите значение переменной y");
        y64 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной h");
        h64 = Convert.ToDouble(Console.ReadLine());

        A64 = (Math.Tan(Math.Pow(y64, 3) - Math.Pow(h64, 4)) + Math.Pow(h64, 2)) / (Math.Pow((Math.Sin(h64)), 3) + y64);

        Console.WriteLine($"Результат задания №64 = {A64}");


        Console.WriteLine("Задание №65");

        double F65, y65, x65;

        Console.WriteLine("Введите значение переменной e");
        y65 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной x");
        x65= Convert.ToDouble(Console.ReadLine());
        F65 = (Math.Sqrt(Math.Pow((2 + y65), 2) + Math.Pow((Math.Sin(y65 + 5)), 7 / 2))) / (Math.Log(x65 + 1) - Math.Pow(y65, 3));

        Console.WriteLine($"Результат задания №65 = {F65}");


        Console.WriteLine("Задание 66");

        double G66, x66, z66, y66, c66;

        Console.WriteLine("Введите значение переменной z");
        z66 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной x");
        x66 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной y");
        y66 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной c");
        c66 = Convert.ToDouble(Console.ReadLine());


        G66 = (Math.Tan(Math.Pow(x66, 4) - 6) - Math.Pow((Math.Cos(z66 + x66 * y66)), 3)) / (Math.Pow((Math.Cos(Math.Pow(x66, 3) * Math.Pow(c66, 2))), 4));

        Console.WriteLine($"Результат задания №66 = {G66}");


        Console.WriteLine("Задание №67");

        double K67, x67, b67, a67, y67;

        Console.WriteLine("Введите значение переменной x");
        x67 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной b");
        b67 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной a");
        a67 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной y");
        y67 = Convert.ToDouble(Console.ReadLine());


        K67 = (Math.Sqrt(x67 + b67 - a67) + Math.Log(y67)) / (Math.Atan(b67 + a67));

        Console.WriteLine($"Результат задания №67 = {K67}");


        Console.WriteLine("Задание №68");

        double D68, y68, x68, a68;

        Console.WriteLine("Введите значение переменной y");
        y68 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной x");
        x68 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной a");
        a68 = Convert.ToDouble(Console.ReadLine());


        D68 = (Math.Cos(Math.Pow(x68, 3) + 6) - Math.Sin(y68 - a68)) / (Math.Log(Math.Pow(x68, 4)) - 2 * Math.Pow(Math.Sin(x68), 5));


        Console.WriteLine($"Результат задания №68 = {D68}");


        Console.WriteLine("Задание №69");

        double P69, y69, x69, c69, a69;

        Console.WriteLine("Введите значение переменной y");
        y69 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной x");
        x69 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной c");
        c69 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной a");
        a69 = Convert.ToDouble(Console.ReadLine());


        P69 = (Math.Pow(a69, 5) + Math.Pow((Math.Sin(y69 - c69)), 4)) / (Math.Pow((Math.Sin(x69 + y8)), 3) + Math.Abs(x69 - y69));

        Console.WriteLine($"Результат задания №69 = {P69}");


        Console.WriteLine("Задание №70");

        double R70, y70, x70, d70, e70;

        Console.WriteLine("Введите значение переменной e");
        e70 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной x");
        x70 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной y");
        y70 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной d");
        d70 = Convert.ToDouble(Console.ReadLine());


        R70 = (Math.Pow((Math.Cos(y70)), 3) + Math.Pow(2, x70) * d70) / (Math.Pow(e70, x70) + Math.Log(Math.Pow((Math.Sin(x70)), 2) + 7.4));


        Console.WriteLine($"Результат задания №70 = {70}");


        Console.WriteLine("Задание №71");

        double U71, e71, x71, y71;

        Console.WriteLine("Введите значение переменной e");
        e71 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной x");
        x71 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной y");
        y71 = Convert.ToDouble(Console.ReadLine());


        U71 = (Math.Pow(e71, Math.Pow(x71, 3)) + Math.Pow((Math.Cos(x71 - 4)), 2)) / (Math.Atan(10) + 5.2 * y);


        Console.WriteLine($"Результат задания №71 = {U71}");


        Console.WriteLine("Задание №72");

        double I72, y72, x72, e72;

        Console.WriteLine("Введите значение переменной e");
        e72 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной x");
        x72 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной y");
        y72 = Convert.ToDouble(Console.ReadLine());

        I72 = (2.33 * Math.Log(Math.Sqrt(1 + Math.Pow((Math.Cos(y72)), 2)))) / (Math.Pow(e72, y72) + Math.Pow((Math.Sin(x72)), 2));


        Console.WriteLine($"Результат задания №72 = {I72}");


        Console.WriteLine("Задание №73");

        double G73, y73, x73, a73;

        Console.WriteLine("Введите значение переменной y");
        y73 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной x");
        x73 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной a");
        a73 = Convert.ToDouble(Console.ReadLine());


        G73 = (Math.Pow((Math.Cos(Math.Abs(y12 + x73))), 3) - (x73 + y73)) / (Math.Pow((Math.Atan(x73 + a73)), 4) * Math.Pow(x73, 3));


        Console.WriteLine($"Результат задания №73 = {G73}");


        Console.WriteLine("Задание №74");

        double R74, b74, x74, a74;

        Console.WriteLine("Введите значение переменной b");
        b74 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной x");
        x74 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной a");
        a74 = Convert.ToDouble(Console.ReadLine());

        R74 = ((a74) / (x74 - a74)) + ((Math.Pow(b74, x74) + Math.Pow((Math.Cos(x74)), 3)) / (Math.Pow((Math.Log(a74)), 3) + 4.5));


        Console.WriteLine($"Результат задания №74 = {R74}");


        Console.WriteLine("Задание №75");

        double R75, x75;


        Console.WriteLine("Введите значение переменной x");
        x75 = Convert.ToDouble(Console.ReadLine());

        R75 = (Math.Sin(Math.Pow(((Math.Pow(x75, 2)) + 4), 3)) + 4.3) / (Math.Pow((Math.Cos(Math.Pow(x75, 4))), 3));


        Console.WriteLine($"Результат задания №75 = {R75}");


        Console.WriteLine("Задание №76");

        double N76, y76, m76;

        Console.WriteLine("Введите значение переменной y");
        y76 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной m");
        m76 = Convert.ToDouble(Console.ReadLine());

        N76 = (Math.Pow(m76, 2) + 2.8 * m76 + 0.355) / (Math.Cos(2) * y76 + 3.6);


        Console.WriteLine($"Результат задания №76 = {N76}");


        Console.WriteLine("Задание №77");
        double P77, t77, x77, y77, e77;
        Console.WriteLine("Введите значение переменной t");
        t77 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной x");
        x77 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной y");
        y77 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной e");
        e77 = Convert.ToDouble(Console.ReadLine());
        P77 = (Math.Pow((Math.Sin(x77)), 3) + Math.Log10(2 * y77 + 3 * x77)) / (Math.Pow(t77, e77) + Math.Sqrt(x77));


        Console.WriteLine($"Результат задания №77 = {P77}");


        Console.WriteLine("Задание №78");
        double T78, a78, b78, x78, y78;
        Console.WriteLine("Введите значение переменной a");
        a78 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной b");
        b78 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной x");
        x78 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной y");
        y78 = Convert.ToDouble(Console.ReadLine());
        T78 = (Math.Sqrt(x78 + b78 - a78) + Math.Log10(y78)) / (Math.Atan(b78 + a78));


        Console.WriteLine($"Результат задания №78 = {T78}");


        Console.WriteLine("Задание №79");
        double S79, t79, y79;
        Console.WriteLine("Введите значение переменной t");
        t79 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной y");
        y79 = Convert.ToDouble(Console.ReadLine());
        S79 = (4.351 * Math.Pow(y79, 3) + 2 * t79 * Math.Log10(t79)) / (Math.Sqrt(Math.Cos(2 * y79) + 4.351));


        Console.WriteLine($"Результат задания №79 = {S79}");


        Console.WriteLine("Задание №80");
        double D80, K80, a80, b80, x80, y80, arx;

        Console.WriteLine("Введите значение переменной K");
        K80 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной arx");
        arx = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной a");
        a80 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной b");
        b80 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной x");
        x80 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной y");
        y80 = Convert.ToDouble(Console.ReadLine());
        D80 = (Math.Pow(K80, arx) - a80 * Math.Sqrt(6) - Math.Cos(3 * a80 * b80)) / (Math.Pow(Math.Sin(a80 * Math.Asin(x80) + Math.Log10(y80)), 2));


        Console.WriteLine($"Результат задания №80 = {D80}");


        Console.WriteLine("Задание №81");
        double U81, a81, b81, c81, x81, y81;
        Console.WriteLine("Введите значение переменной a");
        a81 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной b");
        b81 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной c");
        c81 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной x");
        x81 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной y");
        y81 = Convert.ToDouble(Console.ReadLine());
        U81 = (Math.Pow(Math.Tan(y81), 3) + Math.Pow(Math.Sin(x81 * Math.Sqrt(b81 - c81)), 3)) / (Math.Sqrt(a81 - b81 + c81));


        Console.WriteLine($"Результат задания №81 = {U81}");


        Console.WriteLine("Задание №82");
        double N82, z82, x82, e82, a82;
        Console.WriteLine("Введите значение переменной a");
        a21 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной e");
        e21 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной x");
        x21 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной z");
        z21 = Convert.ToDouble(Console.ReadLine());
        N21 = (Math.Pow((z21 * Math.Sqrt(z21 * x21)), 3 / 2)) / (Math.Pow(e21, x21) + Math.Pow(a21, 3) * Math.Atanh(x21));


        Console.WriteLine($"Результат задания №82 = {N82}");


        Console.WriteLine("Задание №83");
        double F83, x83, y83;
        Console.WriteLine("Введите значение переменной x");
        x83 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной y");
        y83 = Convert.ToDouble(Console.ReadLine());
        F83 = (Math.Cos(Math.Pow(x83, 2) + 2) + ((3.5 * Math.Pow(x83, 2) + 1) / (Math.Pow(Math.Cos(y83), 2))));


        Console.WriteLine($"Результат задания №83 = {F83}");


        Console.WriteLine("Задание №84");
        double F84, x84, z84, b84, a84;
        Console.WriteLine("Введите значение переменной a");
        a84 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной b");
        b84 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной x");
        x84 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной z");
        z84 = Convert.ToDouble(Console.ReadLine());
        F84 = (Math.Sqrt(Math.Abs(x84) + Math.Pow(Math.Cos(x84), 3) + Math.Pow(z84, 4))) / (Math.Log10(x84) - Math.Asin(b84 * x84 - a84));


        Console.WriteLine($"Результат задания №84 = {F84}");


        Console.WriteLine("Задание №85");
        double f85, b85, a85, x85, z85;
        Console.WriteLine("Введите значение переменной a");
        a85 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной b");
        b85 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной x");
        x85 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной z");
        z85 = Convert.ToDouble(Console.ReadLine());
        f85 = (Math.Pow(Math.Cos(b85 * Math.Pow(x85, 5)), 7) - (Math.Sin(Math.Pow(a85, 2)) - Math.Cos(Math.Pow(x85, 3) + Math.Pow(z85, 5) - Math.Pow(a85, 2)))) / (Math.Asin(Math.Pow(a85, 2)) + Math.Acos(Math.Pow(x85, 7) - Math.Pow(a85, 2)));


        Console.WriteLine($"Результат задания №85 = {f85}");


        Console.WriteLine("Задание №86");
        double J86, a86, x86, y86;
        Console.WriteLine("Введите значение переменной a");
        a86 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной y");
        y86 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной x");
        x86 = Convert.ToDouble(Console.ReadLine());
        J86 = (Math.Pow(Math.Tan(Math.Pow(a25, 3)), 3) + Math.Pow(Math.Atan(a86), 2)) / (Math.Sqrt(Math.Pow(y86, Math.Tan(x86))));


        Console.WriteLine($"Результат задания №86 = {J86}");


        Console.WriteLine("Задание №87");
        double U87, x87, y87, e87, k87;
        Console.WriteLine("Введите значение переменной k");
        k87 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной e");
        e87 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной x");
        x87 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной y");
        y87 = Convert.ToDouble(Console.ReadLine());
        U26 = (Math.Log10(Math.Pow(x87, 3) + y87) - Math.Pow(y87, 4)) / (Math.Pow(e87, y87) + 5.4 * Math.Pow(k87, 3));


        Console.WriteLine($"Результат задания №87 = {U87}");


        Console.WriteLine("Задание №88");
        double P88, a88, c88, x88, y88;
        Console.WriteLine("Введите значение переменной a");
        a88 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной c");
        c88 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной x");
        x88 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной y");
        y88 = Convert.ToDouble(Console.ReadLine());
        P88 = (Math.Pow(a88, 5) + Math.Acos(a88 + Math.Pow(x88, 3)) - Math.Pow(Math.Sin(y88 - c27), 4)) / (Math.Pow(Math.Sin(x88 - y88), 3) + Math.Abs(x88 - y88));


        Console.WriteLine($"Результат задания №88 = {P88}");


        Console.WriteLine("Задание №89");
        double G89, c89, x89, y89, z89;
        Console.WriteLine("Введите значение переменной c");
        c89 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной x");
        x89 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной y");
        y89 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной z");
        z89 = Convert.ToDouble(Console.ReadLine());
        G89 = (Math.Tan(Math.Pow(x89, 4) - 6) - Math.Pow(Math.Cos(z89 + Math.Pow(x89, 3) * y89), 3 * x89)) / (Math.Pow(Math.Cos(Math.Pow(x89, 3) * Math.Pow(c89, 2)), 2));


        Console.WriteLine($"Результат задания №89 = {G89}");


        Console.WriteLine("Задание №90");
        double R90, x90, y90, d90, e90;
        Console.WriteLine("Введите значение переменной x:");
        x90 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной y:");
        y90 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной d:");
        d90 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной e:");
        e90 = Convert.ToDouble(Console.ReadLine());
        R90 = (Math.Pow(Math.Cos(y90), 2) + 2.4 * d90) / (Math.Pow(e90, y90) + Math.Log10(Math.Pow(Math.Sin(x90 + 6), 2)));


        Console.WriteLine($"Результат задания №90 = {R90}");


        Console.WriteLine("Задание №91");
        double K91, x91, e91;
        Console.WriteLine("Введите значение переменной x:");
        x91 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной e:");
        e91 = Convert.ToDouble(Console.ReadLine());
        K91 = (Math.Sqrt(Math.Pow((3 + x91), 6) - Math.Log10(x91))) / (Math.Pow(e91, 0) + Math.Asin(6 * Math.Pow(x91, 2)));


        Console.WriteLine($"Результат задания №91 = {K91}");
    }
}