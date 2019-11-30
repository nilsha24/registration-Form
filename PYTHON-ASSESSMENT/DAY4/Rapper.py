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
def sayhi(str1, str2, str3):
    print(str1, str2, str3)


@demo
def sayhello(a, b, c):
    print(a, b, c)


@demo
def sayBye(name1, name2):
    print(name1, name2)

sayhi(str1="Alpha", str2="Beta", str3="Zeta")
sayhello(1, "William", "harry")
sayBye("Alpha", name2="Beta")