/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_md_reizinasana_16marts;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class Java_MD_Reizinasana_16marts {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        System.out.println("Majasdarbs - ievadit a * b un tiks izvadits reizinajums."
                + "Neviens skaitlis nedriks but 0");
        
        Scanner sc = new Scanner(System.in);
        
        System.out.println("Ievadi skaitli a");
        double a = sc.nextDouble ();
        
        System.out.println("Ievadi skaitli b");
        double b = sc.nextDouble ();
        
        if (a==0 || b ==0) {
            System.out.println("Kads no tevis ievaditajiem skaitliem vai abi ir 0. KLUDA!");
        } else {
            Reizinasana (a, b);
        }
          
    }
    
    static void Reizinasana (double a, double b){
        System.out.println("Tevis ievaditie skaitli a un b nav 0. Un reizinajums ir ");
        System.out.println(a*b);
    }
    
}
