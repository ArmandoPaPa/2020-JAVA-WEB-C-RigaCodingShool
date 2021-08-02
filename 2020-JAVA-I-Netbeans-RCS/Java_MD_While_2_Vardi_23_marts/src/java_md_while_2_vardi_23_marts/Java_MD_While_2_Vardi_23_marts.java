/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_md_while_2_vardi_23_marts;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class Java_MD_While_2_Vardi_23_marts {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here

        Vardi();

    }

    static void Vardi() {

        Scanner sc = new Scanner(System.in);

        System.out.println("Tev vajadzes uzminet pirma speletaja vardu un vari minet 5 reizes!");

        System.out.println("Pirmais speletajs ievada VARDU!");
        String ONE = sc.nextLine();

        ONE = ONE.toLowerCase();
        ONE = ONE.toUpperCase();

        int Skaititajs = 0;

        while (true) {

            System.out.println("Uzmini pirma speletaja vardu!");

            Skaititajs = Skaititajs + 1;

            String MINI = sc.nextLine();

            MINI = MINI.toLowerCase();
            MINI = MINI.toUpperCase();

            if (ONE.equals(MINI) && Skaititajs <= 5) {

                System.out.println("TU UZMINEJI, APSVEICU!");
                break;

            } else if (Skaititajs >= 5) {

                System.out.println("TU NEUZMINEJI! Uzvar 1.speletajs!");
                break;

            }
        }

    }

}
