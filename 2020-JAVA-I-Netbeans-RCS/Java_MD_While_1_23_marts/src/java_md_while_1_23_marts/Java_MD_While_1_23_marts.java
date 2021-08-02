/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_md_while_1_23_marts;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class Java_MD_While_1_23_marts {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here

        While1();

    }

    static void While1() {

        System.out.println("Tu tagad varesi ievadit dazadus skaitlus tik ilgi lidz nepateiksi - ne. "
                + "Ja ievadisi - ne - tad tiks izvadita visu tavu ievadito skaitlu summa.");

        Scanner sc = new Scanner(System.in);

        double sum = 0;
        String stop = "";

        while (!stop.equals("ne")) {

            System.out.println("Ievadi skaitli");
            double a = sc.nextDouble();

            sum = sum + a;

            System.out.println("Vai velies turpinat?");
            stop = sc.next();

        }

        System.out.println("Tevis ievadito skaitlu summa ir  " + sum);

    }

}
