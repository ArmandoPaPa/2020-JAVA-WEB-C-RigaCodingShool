/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_day2_io_if;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class Java_day2_IO_If {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Ievadiet 1.skaitli");
        int skaitlis = sc.nextInt();
        // >
        // <
        // <=
        // >=
        // ==
        // != nozime nav vienads
        if (skaitlis < 10) {
            System.out.println("Pareizi!");
        } else {
            System.out.println("Nepareizi!");
        }

        //Cilveks ievada skaitli
        //ja ir mazaks, vienads par 5 izvadam #
        //ja ir lielaks par 5 izvadam ##
        System.out.println("Uzdevums 1 ar if else");
        int z = sc.nextInt();
        if (z <= 5) {
            System.out.println(" # ");
        } else {
            System.out.println(" ## ");
        }

        //Cilveks ievada skaitli
        //ja ir mazaks par 6 izvadam slikts vertejums
        //ja ir vienads ar 6 izvadam videji
        //ja ir lielaks par 6 labi
        //ja ir lielaks par 10, nemulkojies
        System.out.println("Uzdevums Extra ar if else if");
        int w = sc.nextInt();
        if (w < 6) {
            System.out.println(" Slikts vertejums");
        } else if (w == 6) {
            System.out.println("Videji");
        } else if (w > 6 && w <= 10) {
            System.out.println("Labi");
        } else if (w > 10) {
            System.out.println("Nemulkojies");
        }

        //Uzdevums If Else 2
        //cilveks ievada 1 skaitli
        //cilveks ievada 2 skaitli
        //cilveks iavada 3 skaitli
        //ja 3.skaitlis it negativs vai 0, tad atnemam sk1 - sk 2
        //ja 3.skaitlis ir pozitivs, tad saskaitam sk1 + sk 2
        System.out.println("Uzdevums 2 ar if else");

        System.out.println("Ievadi skaitli - sk - 1");
        int sk1 = sc.nextInt();

        System.out.println("Ievadi skaitli - sk - 2");
        int sk2 = sc.nextInt();

        System.out.println("Ievadi skaitli - sk - 3");
        int sk3 = sc.nextInt();

        if (sk3 <= 0) {
            System.out.println("Skaitlis 3 bija 0 vai negativs, tapec" + " " + (sk1 - sk2));

        } else {
            System.out.println("Skaitlis 3 bija pozitivs, tapec" + " " + (sk1 + sk2));
        }

        // Parbaudit vai skaitlis ir ranga no 0 lidz 5?
        
        System.out.println("Ievadi skaitli, mes parbaudisim, vai tas ir 0-5 ranga");
        int q = sc.nextInt();

        if (q >= 0 && q <= 5) {
            System.out.println("Skaitlis ir 0-5 rami, APSVEICU");

        } else {
            System.out.println("Skaitlis nav RAMI, BRRRRR");
        }
        
    }

    // TODO code application logic here
    static void Piemers1arAplus3() {

        // Pirmais uzdevums - a+3!
        Scanner sc = new Scanner(System.in);
        System.out.println("Pirmais klases uzdevums, atkartojums!");
        System.out.println("Ievadiet skaitli!");
        int a = sc.nextInt();

        System.out.println(a + 3);
    }

    static void PiemersArKomatu() {

        Scanner sc = new Scanner(System.in);

        // Pirmais uzdevums - a+3!
        System.out.println("Pirmais klases uzdevums, atkartojums!");
        System.out.println("Ievadiet skaitli!");
        int a = sc.nextInt();

        System.out.println(a + 3);

        // Otrais uzdevums!
        // cilveks ievada skaitli 1 - x - double
        // cilveks ievada skaitli 2 - x - double
        // Izvadam skaitlu summu
        System.out.println("Sakas otrais uzdevums - divu skaitlu (double) ievade!");

        System.out.println("Ievadi skaitli 1 - x");
        double x = sc.nextDouble();
        System.out.println("Ievadi skaitli 2 - y");
        double y = sc.nextDouble();
        System.out.println("Rezultats ir" + " " + (x + y)); //summai jabut iekavas!

    }

}
