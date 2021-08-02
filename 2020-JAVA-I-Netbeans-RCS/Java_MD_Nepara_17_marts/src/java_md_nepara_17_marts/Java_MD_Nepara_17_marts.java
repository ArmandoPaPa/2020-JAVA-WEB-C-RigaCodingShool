/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_md_nepara_17_marts;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class Java_MD_Nepara_17_marts {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic 

        System.out.println("Ievadi jebkuru skaitli un tiks izvadits lielakais tuvakais nepara skaitlis");

        Scanner sc = new Scanner(System.in);
        int a = sc.nextInt();

        Nepara(a);

    }

    static int Nepara(int a) {

        if (a % 2 == 0) {
            System.out.println("Tuvakais nepara skaitlis ir " + (a + 1));
        } else {
            System.out.println("Tuvakais nepara skaitlis ir " + (a + 2));
        }

        return a;
    }

}
