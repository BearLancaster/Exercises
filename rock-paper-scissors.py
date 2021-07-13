import sys

import random
User=input("Rock(R),Paper(P),Scissors(S):")
CheckChar="RPS"
for i in User:
  if CheckChar.find(i)==-1:
    print("Enter information is Wrong!")
    sys.exit(0)
    

long=len(User)
a=10**(long-1)
b=(10**long)-1
#print(a)
#print(b)
Computer=random.randint(a,b)
#print(Computer)
i=0
Computer_Data=[]
while i<long:#Get the compuetr's result
  #print(i)
  data=Computer//(10**(long-1-i))
  #print(10**(long-1-i))
  #print(data)
  if(data%3==0):
    Computer_Data.append("R")
  elif (data%3==1):
    Computer_Data.append("P")
  else:
    Computer_Data.append("S")  
  Computer=Computer-data*(10**(long-1-i))
  i+=1
print(Computer_Data)
Win=0
Lose=0
Draw=0
for i in range(long):#compare the result
  #print(User[i])
  #print(Computer_Data[i])
  if(User[i]==Computer_Data[i]):
    Draw+=1
    print(User[i]+" VS "+Computer_Data[i]+" :Draw")
  elif(User[i]=='R' and Computer_Data[i]=='S')or(User[i]=='S' and Computer_Data[i]=='P') or (User[i]=='P' and Computer_Data[i]=='R'):
    print(User[i]+" VS "+Computer_Data[i]+" :Win")
    Win+=1
  else:
    print(User[i]+" VS "+Computer_Data[i]+" :Lose")
    Lose+=1
if Win==Lose:# Make sure who is winner
  print("draw")
elif Win>Lose:
  print("You win!")
else:
  print("You lose!")

  

