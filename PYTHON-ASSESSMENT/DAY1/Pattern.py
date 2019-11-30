b=int(input("Enter the number: "))
c=int(input("Enter the number: "))
d=int(input("Enter the number: "))
e=int(input("Enter the number: "))

fact=int(input("Enter a number to find factorial "))
fib=int(input("Enter length of fibonacci series"))
result=1
fb=[0, 1]
for i in range(1,b+1):
    print("*"*i)

for j in range(c,0,-1):
    print("*"*j)

for k in range(0,d):
    print(" "*k + "*"*(d-k))
    
for l in range(0,e):
    print(" "*(e-l) + "*"*(l+1))

    
for i in range(1, fact+1):
    result=result*i

print("Factorial = ", result)
for i in range(2, fib):
    fb.append(fb[i-1]+fb[i-2])
    
print("Fibbonaci Series ", fb)



s="PYTHON"
l=len(s)
for u in range(l):
    print(" "*(l-u) + s[0:(u+1)])

def add(a,b):
    return a+b