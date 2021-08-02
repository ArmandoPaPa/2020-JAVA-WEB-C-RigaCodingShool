/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_md_1_10_marts;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class Java_MD_1_10_marts {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here

        Scanner sc = new Scanner(System.in);

        System.out.println("Labdien, tagad Tev būs jāizpilda 4 uzdevumi");
        System.out.println("Uzdevums 1 - 3 skaitlu summa");
        System.out.println("Uzdevums 2 - vards un vecums");
        System.out.println("Uzdevums 3 - 2 skaitlu salidzinasana");
        System.out.println("Uzdevums 4 - vienadibas parbaude");

        System.out.println("Izvelies, kuru uzdevumu velies pildit - ievadi uzdevuma Nr");
        int x = sc.nextInt();
        switch (x) {
            case 1:
                Uzdevums1();
                break;
            case 2:
                Uzdevums2();
                break;
            case 3:
                Uzdevums3();
                break;
            case 4:
                Uzdevums4();
                break;
            default:
                System.out.println("Tu neizvelejies nevienu no uzdevumiem. OK.");
                break;

        }
    
    }
    
    static void Uzdevums1() {

        Scanner sc = new Scanner(System.in);

        System.out.println("Uzdevums 1 - ievadi 3 skaitlus un tie tiks sasummeti");
        System.out.println("Ievadi 1.skaitli");
        double a = sc.nextDouble();
        System.out.println("Ievadi 2.skaitli");
        double b = sc.nextDouble();
        System.out.println("Ievadi 3.skaitli");
        double c = sc.nextDouble();

        System.out.println("Tavu ievadito tris skaitlu summa ir" + " " + (a + b + c));
    }

    static void Uzdevums2() {

        Scanner sc = new Scanner(System.in);

        System.out.println("Uzdevums 2 - ievadi savu vardu un vecumu");

        Scanner sc2 = new Scanner(System.in);
        System.out.println("Ka Tevi sauc? Ievadi savu vardu");
        String vards = sc2.nextLine();
        System.out.println("Cik Tev pilnu gadu? Ievadi gadus skaitlos");
        int vecums = sc.nextInt();
        System.out.println("Patikami iepazities! " + vards + " ir "
                + vecums + " gadus vecs");

    }

    static void Uzdevums3() {

        Scanner sc = new Scanner(System.in);

        System.out.println("Uzdevums 3 - divu skaitlu salidzinasanas");
        System.out.println("Ievadi pirmo veselo skaitli");
        int d = sc.nextInt();
        System.out.println("Ievadi otro veselo skaitli");
        int e = sc.nextInt();
        System.out.println("Lielakais no Tevis ievaditajiem skaitliem ir");
        if (d > e) {
            System.out.println(d);
        } else if (e > d) {
            System.out.println(e);
        } else {
            System.out.println("Abi Tevis ievaditie skaitli ir vienadi");
        }

    }

    static void Uzdevums4() {

        Scanner sc = new Scanner(System.in);

        System.out.println("Uzdevums 4 "
                + "- divu skaitlu vienadibas parbaude");
        System.out.println("Ievadi pirmo skaitli");
        double f = sc.nextDouble();
        System.out.println("Ievadi otro skaitli");
        double g = sc.nextDouble();
        if (f == g) {
            System.out.println("Abi Tevis ievaditie skaitli ir VIENADI!");
        } else {
            System.out.println("Abi Tevis ievaditie skaitli ir DAZADI!");
        }
    }

}
