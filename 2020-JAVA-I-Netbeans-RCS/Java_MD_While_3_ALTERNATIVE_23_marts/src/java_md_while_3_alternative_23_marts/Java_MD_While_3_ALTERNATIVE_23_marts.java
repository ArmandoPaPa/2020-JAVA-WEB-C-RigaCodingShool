/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_md_while_3_alternative_23_marts;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class Java_MD_While_3_ALTERNATIVE_23_marts {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here

        SkaitluSALIDZINASANA();

    }

    static void SkaitluSALIDZINASANA() {

        System.out.println("Tagad Tev bus jaievada 6 skaitlus un beigas mes Tev izvadisim LIELAKO!");

        Scanner sc = new Scanner(System.in);

        int skaititajs = 0;

        Double rez = 0.0;

        int k = 0;

        while (skaititajs != 6) {

            System.out.println("Ievadi jebkuru skaitli!");

            Double x = sc.nextDouble();

            if (x >= rez) {

                rez = x;

            }

            if (rez == 0 && x == 0) {

                k = 1;

            }

            if (x < rez && rez == 0 && k != 1) {

                rez = x;

            }

            skaititajs++;

        }

        System.out.println("Tevis ievaditais lielakais skaitlis ir   " + rez);

    }

}
