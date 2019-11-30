def demo(a):
    def inner(*args, **kwargs):
        for arg in args:
            if not isinstance(arg, str):
                print("Not all arguments are string")
                return
        for kwarg in kwargs.values():
            if not isinstance(kwarg, str):
                print("Not all arguments are string")
                return
        else:
            a(*args, **kwargs)
    return inner

@demo
def sayhi(name1):
    print("Hi "+name1)
@demo
def sayhello(name1,name2):
    print("Hello "+name1+" "+name2)

sayhi(1)
sayhello("Thomas","JOhn")
sayhello(name1="Bill",name2=34)
sayhello(name2="Bill",name1="William")