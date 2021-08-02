/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_day2_io_if_majasdarbs1;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class Java_day2_IO_If_Majasdarbs1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here

        // 1) Cilvēks ievada 3 skaitļus un šos skaitļus sasummēt un izvadīt
        // 2) Cilvēks ievada savu vārdu(String), vecumu (int). 
        // Izvadīt tekstu pēc piemēra - "<vārds> ir <vecums> gadus vecs"
        // 3) Cilvēks ievada divus skaitļus (int) un izvadām lielāko.
        // 4) Cilvēks ievada divus skaitļus, pārbaudām vai tie ir vienādi. 
        Scanner sc = new Scanner(System.in);

        System.out.println("Labdien, tagad Tev bus jaizpilda 4 uzdevumi");

        System.out.println("Uzdevums 1 - ievadi 3 skaitlus un tie tiks sasummeti");
        System.out.println("Ievadi 1.skaitli");
        double a = sc.nextDouble();
        System.out.println("Ievadi 2.skaitli");
        double b = sc.nextDouble();
        System.out.println("Ievadi 3.skaitli");
        double c = sc.nextDouble();

        System.out.println("Tavu ievadito tris skaitlu summa ir" + " " + (a + b + c));

        System.out.println("Malacis! Ar pirmo uzdevumu tikam gala. "
                + "Tagad Uzdevums 2 - ievadi savu vardu un vecumu");

        Scanner sc2 = new Scanner(System.in);
        System.out.println("Ka Tevi sauc? Ievadi savu vardu");
        String vards = sc2.nextLine();
        System.out.println("Cik Tev pilnu gadu? Ievadi gadus skaitlos");
        int vecums = sc.nextInt();
        System.out.println("Patikami iepazities! " + vards + " ir "
                + vecums + " gadus vecs");

        System.out.println("Tagad pariesim pie 3.uzdevuma - divu skaitlu salidzinasanas");
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
        System.out.println("Tagad atlicis ir pedejais uzdevums "
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
