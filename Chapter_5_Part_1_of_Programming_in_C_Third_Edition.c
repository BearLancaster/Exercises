#include<stdio.h>
int main(void)
{
//Exercies 2

printf("n\tn^2\n");
for(int i=1;i<=10;i++)
{
    printf("%i\t%i\n",i,i*i);
}
//Exercies 3
for(int i=5;i<=50;i=i+5)
{
    printf("1");
    int a=1;
    for(int j=2;j<=i;j++)
    {
        printf("+%i",j);
    }
    printf("=%i\n",(i+1)*i/2);
}
//Exercies 4
for(int i=1;i<=10;i++)
{
    printf("%i!=",i);
    if(i==1)
    {
        printf("1\n");
    }
    else
    {
        int z=1;
        int t=i;
        do
        {
            if(t==1)
            {
                printf("1=%i\n",z);
            }
            else
            {
                printf("%i*",t);
                z=z*t;
            }
            t=t-1;
        }while(t!=0);
    }
}
// Exercies 11
int l=0;
int q=0;
printf("Enter the Number:");
scanf("%i",&l);
do
{
    int Tb=l%10;
    l=l/10;
    if(l==0)
    {
        printf("%i=",Tb);
    }
    else
    {
        printf("%i+",Tb);
    }
    q=q+Tb;
}
while(l!=0);
printf("%i\n",q);



return 0;
}