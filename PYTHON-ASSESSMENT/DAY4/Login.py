class NameNotFound1(Exception):
    def __init__(self,msg="name not found"):
        Exception.__init__(self,msg)

class NameNotFound2(Exception):
    def __init__(self,msg="Credential is wrong"):
        Exception.__init__(self,msg)

try:
  obj={"sachin":"123","saurav":"456","rahul":"789"}
  name=input("enter the name:")
  sha=input("Enter the password")
  for n in obj:
      if n==name:
          if obj[n]==sha:
              print("welcome")
              exit()
          else:
              raise NameNotFound2
      else:
          raise NameNotFound1

except NameNotFound2 as q:
    print(q)


except NameNotFound1 as e:
    print(e)
except NameNotFound1 as e:
    print(e)
except Exception as e:
    print("This is name Right:", e)
except Exception as e:
    print("This is name Right:", e)




    