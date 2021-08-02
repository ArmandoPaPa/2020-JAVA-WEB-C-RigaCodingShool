/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_day3_if_methods;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class Java_day3_If_Methods {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here

        String a = "abc";
        int stringGarums = a.length();

        System.out.println(stringGarums);

        Scanner sc = new Scanner(System.in);

        System.out.println("Ievadi String 1");
        String x = sc.nextLine();
        System.out.println("Ievadi String 2");
        String y = sc.nextLine();
        System.out.println("Ievadi String 3");
        String z = sc.nextLine();
        
        Task5 (x,y,z);

    }

    static void Task1() {

        // 1.Cilveks ievada simbolu virkni
        // 2. Ja String garums lielaks par 8, tad izvadam "Nepareizi"
        // 3. Ja String zem 8, tad izvadam String vertibu
        Scanner sc = new Scanner(System.in);

        System.out.println("Ievadi simbolu virkni");
        String b = sc.nextLine();
        int c = b.length();
        //  && and
        // || or
        // var likt ari kopa

        if (c > 8) {
            System.out.println("Nepareizi");
        } else {
            System.out.println(b);
        }
    }

    static void Task2() {

        // 1.Papildus
        // Cilveks ievada divus skaitlus
        // +,-,*,/
        Scanner sc = new Scanner(System.in);

        System.out.println("Ievadi 1.skaitli");
        double d = sc.nextDouble();
        System.out.println("Ievadi 2.skaitli");
        double e = sc.nextDouble();
        System.out.println("Skaitlu summa ir " + (d + e) + "," + "Skaitlu starpiba ir "
                + (d - e) + "," + "Skaitlu reizinajums ir " + (d * e) + "," + "Skaitlu dalijums ir "
                + (d / e));
    }

    static void Task3() {

        // Uztaisit metodi - static void
        // cilveks ievada string vertibu
        // parbauda vai garums nav lielaks par 8
        // un mazaks par 3
        // 3-8 = Viss OK
        // citadi, nav OK
        Scanner sc = new Scanner(System.in);

        System.out.println("Ievadi simbolu virkni");
        String a = sc.nextLine();
        if (a.length() < 8 && a.length() > 3 || a.length() == 3 || a.length() == 8) {
            System.out.println("Viss OK");
            // vareja ari likt <= un >=
        } else {
            System.out.println("Nav OK");
        }
    }

    static void StringCompare() {

        Scanner sc = new Scanner(System.in);

        String a = "aa";
        a = a.toUpperCase();
        a = a.toLowerCase();
        String b = "aa";

        if (a.equals(b)) {
            System.out.println("Viss OK");
        } else {
            System.out.println("Nav OK");
        }

    }

    static void StringCompareUZD() {

        //1.speletajs ievada vardu
        //cits censas uzminet
        //izvadam, uzmineja vai ne
        Scanner sc = new Scanner(System.in);

        System.out.println("Ievadi savu vardu");
        String a = sc.nextLine();
        System.out.println("Uzmini sava drauga vardu");
        String b = sc.nextLine();
        a = a.toUpperCase();
        a = a.toLowerCase();
        b = b.toUpperCase();
        b = b.toLowerCase();

        if (a.equals(b)) {
            System.out.println("Tu uzmineji vardu, APSVEICU");
        } else {
            System.out.println("Megini velreiz, neuzmineji!");

            //SHIFT+ALT+F  - sakarto kodu!!!
        }
    }

    static void exampleWithPar(int a, int b) {

        System.out.println("Demo txt");

        System.out.println(a + b);
        //
        Scanner sc = new Scanner(System.in);

    }

    static void Task5(String x, String y, String z) {
        //uztaisit metodi, kurai parametri ir string vertibas
        //izvadit sasummetu vertibu abc, cde utml.

        System.out.println(x + y + z);

    }

}
