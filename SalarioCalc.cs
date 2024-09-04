using System.Reflection.Metadata;

namespace Ex_C__Natal_04_09_24;

public class SalarioCalc
{
    public double salario =0;

    public SalarioCalc()
    {
    }

    public void LerDados(){
        Console.WriteLine("Digite seu salário bruto: ");
        this.salario=Convert.ToDouble(Console.ReadLine());
        this.calcular();
    }

    public void calcular(){
        double resultado=0, ir, inss;
        ir = this.salario*0.10;
        inss = this.salario*0.05;
        resultado=this.salario-inss-ir;
        Console.WriteLine("Valor de INSS: "+inss);
        Console.WriteLine("Valor de IR: "+ir);
        Console.WriteLine("Salário líquido: "+resultado);
        
    }

}
