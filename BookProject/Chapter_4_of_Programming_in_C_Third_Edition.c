#include<stdio.h>
int main(void)
{
    //Exercies 4
    printf("Exercies 4\n");
    int F=27;
    float C=(float)((F-32)/1.8);
    printf("Converts %i from degrees Fabrenheit(F) to degrees Celsius(C): %.2f \n",F,C);
    //Exercies 6
    printf("Exercies 6\n");
    double x=2.55;
    double y=(double)(3*x*x*x-5*x*x+6);
    printf("when x=%.2f 3x^3-5x^2+6 is %.2f\n",x,y);
    //Exercies 7
    printf("Exercies 7\n");
    double a=3.31e-8;
    double b=2.01e-7;
    double c=7.16e-6;
    double d=2.01e-8;
    double f=(a*b)/(c+d);
    printf("(%g * %g)/(%g + %g)=%g\n",a,b,c,d,f);

    //Exercies 8
    printf("Exercies 8\n");
    int i=365;
    int j=7;
    printf("i\t\tj\tNext_multiple\n");
    printf("%d\t\t%d\t%d\n",i,j,i+j-i%j);
    i=12258;
    j=23;
    printf("%d\t%d\t%d\n",i,j,i+j-i%j);
    i=996;
    j=4;
    printf("%d\t\t%d\t%d\n",i,j,i+j-i%j);
    


    return 0;
}